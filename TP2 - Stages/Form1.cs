using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.DataAccess.Client;

namespace TP2___Stages
{
    public partial class FormPrincipale : Form
    {
        private OracleConnection conn = new OracleConnection();
        private DataSet mainDataSet = new DataSet();
        private string Package = "GESTIONAFFECTATION";

        public FormPrincipale()
        {
            InitializeComponent();
        }

        private void Connect()
        {
            try
            {
                string Dsource = "(DESCRIPTION="
                + "(ADDRESS_LIST=(ADDRESS=(PROTOCOL=TCP)"
                + "(HOST=205.237.244.251)(PORT=1521)))"
                + "(CONNECT_DATA=(SERVICE_NAME=ORCL)))";

                String ChaineConnexion = "Data Source=" + Dsource
                + ";User Id = angrigno; Password =  oracle2";
                conn.ConnectionString = ChaineConnexion;
                conn.Open();
                MessageBox.Show("Vous êtes connecté");
            }
            catch (Exception ex) { MessageBox.Show(ex.Message.ToString()); }
        }

        private void stagesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GestionStage GestionS = new GestionStage();
            GestionS.conn = conn;
            if (GestionS.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                MettreAJour();
                UpdateDGV();
            }
        }

        private void BN_TypeInfo_Click(object sender, EventArgs e)
        {
            string Nom = BN_TypeInfo.Text;
            if (BN_TypeInfo.Text == "Gestion")
            {
                Nom = "Industriel";
                Properties.Settings.Default.CouleurFond = Color.LightGreen;
            }
            if (BN_TypeInfo.Text == "Industriel")
            {
                Nom = "Gestion";
                Properties.Settings.Default.CouleurFond = Color.LightBlue;
            }
            BN_TypeInfo.Text = Nom;
            MettreAJour();
            UpdateDGV();
        }

        private void FormPrincipale_Load(object sender, EventArgs e)
        {
            Connect();
            Properties.Settings.Default.CouleurFond = Color.LightBlue;
            MettreAJour();
            UpdateDGV();
            TTIP_profil.SetToolTip(BN_TypeInfo, "Changer de profil");
        }

        private void MettreAJour()
        {
            this.BackColor = Properties.Settings.Default.CouleurFond;
        }

        private void àProposToolStripMenuItem_Click(object sender, EventArgs e)
        {
            APropos form = new APropos();
            form.ShowDialog();
        }

        private void BN_TypeInfo_MouseHover(object sender, EventArgs e)
        {
            TTIP_profil.Active = true;
        }

        private void UpdateDGV()
        {
            RemplirDGVEtudiants();
            RemplirDGVStages();
            RemplirDGVPlaces();
        }

        private void RemplirDGVEtudiants()
        {
            try
            {
                OracleCommand oraliste = new OracleCommand(Package, conn);
                oraliste.CommandText = Package + ".LISTESTAGIAIRES";
                oraliste.CommandType = CommandType.StoredProcedure;

                OracleParameter OrapameResultat = new OracleParameter("ENREG",
                OracleDbType.RefCursor);
                OrapameResultat.Direction = ParameterDirection.ReturnValue;
                oraliste.Parameters.Add(OrapameResultat);

                OracleParameter OrapamTypeInfo = new
                OracleParameter("PTYPE", OracleDbType.Varchar2);
                OrapamTypeInfo.Value = BN_TypeInfo.Text;
                OrapamTypeInfo.Direction = ParameterDirection.Input;
                oraliste.Parameters.Add(OrapamTypeInfo);

                OracleDataAdapter Oraliste = new OracleDataAdapter(oraliste);

                if (mainDataSet.Tables.Contains("Liste_Etudiants"))
                {
                    mainDataSet.Tables["Liste_Etudiants"].Clear();
                }
                Oraliste.Fill(mainDataSet, "Liste_Etudiants");
                Oraliste.Dispose();

                BindingSource maSource = new BindingSource(mainDataSet, "Liste_Etudiants");
                DGV_Etudiants.DataSource = maSource;
            }
            catch (OracleException ex) { MessageBox.Show(ex.Message); } 

        }

        private void RemplirDGVStages()
        {
            OracleCommand oraliste = new OracleCommand(Package, conn);
            oraliste.CommandText = Package + ".LISTESTAGESDISPO";
            oraliste.CommandType = CommandType.StoredProcedure;

            OracleParameter OrapameResultat = new OracleParameter("ENREG",
            OracleDbType.RefCursor);
            OrapameResultat.Direction = ParameterDirection.ReturnValue;
            oraliste.Parameters.Add(OrapameResultat);

            OracleParameter OrapamTypeInfo = new
            OracleParameter("PTYPE", OracleDbType.Varchar2);
            OrapamTypeInfo.Value = BN_TypeInfo.Text;
            OrapamTypeInfo.Direction = ParameterDirection.Input;
            oraliste.Parameters.Add(OrapamTypeInfo);

            OracleDataAdapter Oraliste = new OracleDataAdapter(oraliste);

            if (mainDataSet.Tables.Contains("Liste_Stages"))
            {
                mainDataSet.Tables["Liste_Stages"].Clear();
            }

            Oraliste.Fill(mainDataSet, "Liste_Stages");
            Oraliste.Dispose();

            BindingSource maSource = new BindingSource(mainDataSet, "Liste_Stages");
            DGV_Stages.DataSource = maSource;
        }

        private void RemplirDGVPlaces()
        {
            OracleCommand oraliste = new OracleCommand(Package, conn);
            oraliste.CommandText = Package + ".LISTEPLACES";
            oraliste.CommandType = CommandType.StoredProcedure;

            OracleParameter OrapameResultat = new OracleParameter("ENREG",
            OracleDbType.RefCursor);
            OrapameResultat.Direction = ParameterDirection.ReturnValue;
            oraliste.Parameters.Add(OrapameResultat);

            OracleParameter OrapamTypeInfo = new
            OracleParameter("PTYPE", OracleDbType.Varchar2);
            OrapamTypeInfo.Value = BN_TypeInfo.Text;
            OrapamTypeInfo.Direction = ParameterDirection.Input;
            oraliste.Parameters.Add(OrapamTypeInfo);

            OracleDataAdapter Oraliste = new OracleDataAdapter(oraliste);

            if (mainDataSet.Tables.Contains("Liste_Places"))
            {
                mainDataSet.Tables["Liste_Places"].Clear();
            }
            Oraliste.Fill(mainDataSet, "Liste_Places");
            Oraliste.Dispose();

            BindingSource maSource = new BindingSource(mainDataSet, "Liste_Places");
            DGV_Places.DataSource = maSource;
        }

        private void BN_Assigner_Click(object sender, EventArgs e)
        {
            Assigner();
        }

        private void Assigner()
        {
            try
            {
                OracleCommand oraliste = new OracleCommand(Package, conn);
                oraliste.CommandText = Package + ".ASSIGNER";
                oraliste.CommandType = CommandType.StoredProcedure;

                OracleParameter OrapamNumAd = new OracleParameter("PSTAGIAIRE", OracleDbType.Int32);
                OracleParameter OrapamNumStage = new OracleParameter("PSTAGE", OracleDbType.Int32);

                OrapamNumAd.Value = DGV_Etudiants.SelectedRows[0].Cells[0].Value.ToString();
                OrapamNumStage.Value = DGV_Stages.SelectedRows[0].Cells[0].Value.ToString();

                OrapamNumAd.Direction = ParameterDirection.Input;
                OrapamNumStage.Direction = ParameterDirection.Input;

                oraliste.Parameters.Add(OrapamNumAd);
                oraliste.Parameters.Add(OrapamNumStage);

                oraliste.ExecuteNonQuery();

                UpdateDGV();
            }

            catch (Exception ex) { MessageBox.Show("Il n'y a plus d'étudiant à assigner"); }
        }

        private void DGV_Places_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                ContextMenuStrip DGV_ContextMenu = new ContextMenuStrip();

                ToolStripMenuItem TSMI = new ToolStripMenuItem("Désassigner");
                TSMI.Click += TSMI_Desassigner_Click;
                DGV_ContextMenu.Items.Add(TSMI);

                DGV_ContextMenu.Show(DGV_Places, DGV_Places.PointToClient(Cursor.Position));
            }
        }

        private void TSMI_Desassigner_Click(object sender, EventArgs e)
        {
            if (DGV_Places.SelectedRows.Count > 0)
            {
                Desassigner();
            }
        }

        private void Desassigner()
        {
            OracleCommand oraliste = new OracleCommand(Package, conn);
            oraliste.CommandText = Package + ".DESASSIGNER";
            oraliste.CommandType = CommandType.StoredProcedure;

            OracleParameter OrapamNumAd = new
            OracleParameter("PSTAGIAIRE", OracleDbType.Int32);
            OrapamNumAd.Value = DGV_Places.SelectedRows[0].Cells[0].Value.ToString();
            OrapamNumAd.Direction = ParameterDirection.Input;
            oraliste.Parameters.Add(OrapamNumAd);

            oraliste.ExecuteNonQuery();

            UpdateDGV();
        }

        private void entreprisesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GestionEntreprisecs f = new GestionEntreprisecs();
            f.conn = conn;
            f.ShowDialog();
        }

        private void étudiantsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GestionStagiaires f = new GestionStagiaires();
            f.conn = conn;
            f.ShowDialog();
        }
    }
}
