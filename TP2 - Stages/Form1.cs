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

        //Gestion du bouton qui change le profil de gestion à industriel ou vice-versa
        //On change le texte du bouton, les propriétés des couleurs met a jour les dgv.
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
            DonnerCouleur();
        }
        //Met a jour la couleur du fond 
        //On peut y ajouter toute autre fonction éventuelle de formatage
        // est appelé chaque fois qu'on fait un changement qui affecte le Form1.
        private void MettreAJour()
        {
            this.BackColor = Properties.Settings.Default.CouleurFond;
            UpdateDGV();
        }

        private void àProposToolStripMenuItem_Click(object sender, EventArgs e)
        {
            APropos form = new APropos();
            form.ShowDialog();
            MettreAJour();
        }
        //Si la souris est sur le bouton de choix de profil, un tool tip s'affiche
        //cetool tip dit de cliquer pour changer le profil.
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

        // Utilise la fontion listestagiaires du package gestionaffectation
        // qui retourne un refcursor
        //Liste tous les étudiants du profil (type) choisi qui n'ontpas de numstage
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
        // Utilise la fontion listestagesdispo du package gestionaffectation
        // qui retourne un refcursor
        // Liste tous les stages qui n'apparaissent pas dans la listes des stagiaires placés
        // selon le profil (type) choisi
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

        // Utilise la fontion listeplaces du package gestionaffectation
        // qui retourne un refcursor
        // Liste tous les étudiants dans le profil choisi qui ont une valeur de numstage.
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
        //Update l'employé sélectionné dans le dgv des stagiaires (par numad)
        //en lui donnant le numstage sélection dans l'autre dgv stages dispo.
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
        //Sur le dgv des stagiaires placés:
        // affiche un tool strip menu qui donne l'option de désassigner un stage.
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
        //Update l'employé sélectionné dans le dgv des stagiaires (par numad)
        //en lui donnant le numstage sélection dans l'autre dgv stages dispo.
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
            GestionEntreprises f = new GestionEntreprises();
            f.conn = conn;
            f.ShowDialog();
            MettreAJour();
        } 

        private void étudiantsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GestionStagiaires f = new GestionStagiaires();
            f.conn = conn;
            f.ShowDialog();
            MettreAJour();
        }     

        //S'assure de remettre a jour les dgv si on a ajouté supprimé ou modifié une liste via
        //un autre form.
        private void FormPrincipale_Activated(object sender, EventArgs e)
        {
            MettreAJour();
        }
        //Affecte la couleur au dgv des stages disponibles selon la valeur de la
        //cote de l'entreprise
        private void DonnerCouleur()
        {
            for (int i = 0; i < DGV_Stages.RowCount; i++)
            {
                if (int.Parse(DGV_Stages.Rows[i].Cells[4].Value.ToString()) >= 5)
                {
                    DGV_Stages.Rows[i].DefaultCellStyle.BackColor = Color.LimeGreen;
                }
                else
                {
                    DGV_Stages.Rows[i].DefaultCellStyle.BackColor = Color.Tomato;
                }
            }
        }

        private void DGV_Stages_Paint(object sender, PaintEventArgs e)
        {
            DonnerCouleur();
        }
    }
}
