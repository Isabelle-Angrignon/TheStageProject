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
    public partial class GestionEntreprisecs : Form
    {
        public OracleConnection conn = new OracleConnection();
        private DataSet mainDataSet = new DataSet();
        string PackageEnt = "GESTIONENTREPRISES";
        public GestionEntreprisecs()
        {
            InitializeComponent();
        }

        private void BTN_Ok_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void GestionEntreprisecs_Load(object sender, EventArgs e)
        {
            MiseAjour();
        }
        private void MiseAjour()
        {
            RemplirDGV();
            DonnerCouleur();
        }
        private void RemplirDGV()
        {
            OracleCommand oraliste = new OracleCommand(PackageEnt, conn);
            oraliste.CommandText = PackageEnt + ".LISTER";
            oraliste.CommandType = CommandType.StoredProcedure;

            OracleParameter OrapameResultat = new OracleParameter("LISTE",
            OracleDbType.RefCursor);
            OrapameResultat.Direction = ParameterDirection.ReturnValue;
            oraliste.Parameters.Add(OrapameResultat);

            OracleDataAdapter Oraliste = new OracleDataAdapter(oraliste);

            if (mainDataSet.Tables.Contains("Liste_stage"))
            {
                mainDataSet.Tables["Liste_stage"].Clear();
            }
            Oraliste.Fill(mainDataSet, "Liste_stage");
            Oraliste.Dispose();

            BindingSource maSource = new BindingSource(mainDataSet, "Liste_stage");
            DGV_GestionEnt.DataSource = maSource;
            RemplirTB();
        }
        private void DonnerCouleur()
        {
            for (int i = 0; i < DGV_GestionEnt.RowCount; i++)
            {
                if (int.Parse(DGV_GestionEnt.Rows[i].Cells[7].Value.ToString()) >= 5)
                {
                    DGV_GestionEnt.Rows[i].DefaultCellStyle.BackColor = Color.LimeGreen;
                }
                else
                {
                    DGV_GestionEnt.Rows[i].DefaultCellStyle.BackColor = Color.Red;
                }
            }
        }

        private void DGV_GestionEnt_Paint(object sender, PaintEventArgs e)
        {
            DonnerCouleur();
        }


        private void RemplirTB()
        {
            LB_NumEnt.Text = DGV_GestionEnt.SelectedRows[0].Cells[0].Value.ToString();
            TB_Nom.Text = DGV_GestionEnt.SelectedRows[0].Cells[1].Value.ToString();
            TB_Contact.Text = DGV_GestionEnt.SelectedRows[0].Cells[2].Value.ToString();
            TB_Taille.Text = DGV_GestionEnt.SelectedRows[0].Cells[3].Value.ToString();
            TB_Adresse.Text = DGV_GestionEnt.SelectedRows[0].Cells[4].Value.ToString();
            TB_Courriel.Text = DGV_GestionEnt.SelectedRows[0].Cells[5].Value.ToString();
            TB_Tel.Text = DGV_GestionEnt.SelectedRows[0].Cells[6].Value.ToString();
            TB_Cote.Text = DGV_GestionEnt.SelectedRows[0].Cells[7].Value.ToString();
            
        }

        private void DGV_GestionEnt_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            RemplirTB();
        }

        private void BTN_ClearStage_Click(object sender, EventArgs e)
        {
            Clear();
        }
        private void Clear()
        {
            LB_NumEnt.Text = "";
            TB_Nom.Text = "";
            TB_Contact.Text = "";
            TB_Taille.Text = "";
            TB_Adresse.Text = "";
            TB_Courriel.Text = "";
            TB_Tel.Text = "";
            TB_Cote.Text = "";
        }

        private void BTN_AjoutStage_Click(object sender, EventArgs e)
        {
            try
            {
                OracleParameter oParamNom = new OracleParameter("PNOMENT", OracleDbType.Varchar2, 20);
                OracleParameter oParamCont = new OracleParameter("PNOMCONTACT", OracleDbType.Varchar2, 20);
                OracleParameter oParamTaille = new OracleParameter("PTAILLEENT", OracleDbType.Varchar2, 8);
                OracleParameter oParamAdresse = new OracleParameter("PADRESSEENT", OracleDbType.Varchar2, 50);
                OracleParameter oParamCour = new OracleParameter("PCOURIELENT", OracleDbType.Varchar2,30);
                OracleParameter oParamTel = new OracleParameter("PTELEPHONEENT", OracleDbType.Varchar2,20);
                OracleParameter oParamCote = new OracleParameter("PCOTEENT", OracleDbType.Int32, 2);
                

                //ajout
                oParamNom.Direction = ParameterDirection.Input;
                oParamCont.Direction = ParameterDirection.Input;
                oParamTaille.Direction = ParameterDirection.Input;
                oParamAdresse.Direction = ParameterDirection.Input;
                oParamCour.Direction = ParameterDirection.Input;
                oParamTel.Direction = ParameterDirection.Input;
                oParamCote.Direction = ParameterDirection.Input;


                oParamNom.Value = TB_Nom.Text;
                oParamCont.Value = TB_Contact.Text;
                oParamTaille.Value = TB_Taille.Text;
                oParamAdresse.Value = TB_Adresse.Text;
                oParamCour.Value = TB_Courriel.Text;
                oParamTel.Value = TB_Tel.Text;
                oParamCote.Value = TB_Cote.Text;

                //modif/////
                OracleCommand orComm = new OracleCommand(PackageEnt, conn);
                orComm.CommandText = PackageEnt + ".INSERER";
                orComm.CommandType = CommandType.StoredProcedure;

                orComm.Parameters.Add(oParamNom);
                orComm.Parameters.Add(oParamCont);
                orComm.Parameters.Add(oParamTaille);
                orComm.Parameters.Add(oParamAdresse);
                orComm.Parameters.Add(oParamCour);
                orComm.Parameters.Add(oParamTel);
                orComm.Parameters.Add(oParamCote);
                orComm.ExecuteNonQuery();

                RemplirDGV();
            }
            catch (OracleException ex) { MessageBox.Show(ex.Message); } 
        }

        private void BTN_EditStage_Click(object sender, EventArgs e)
        {
            try
            {
                OracleParameter oParamNum = new OracleParameter("PNUMENT", OracleDbType.Int32, 3);
                OracleParameter oParamNom = new OracleParameter("PNOMENT", OracleDbType.Varchar2, 20);
                OracleParameter oParamCont = new OracleParameter("PNOMCONTACT", OracleDbType.Varchar2, 20);
                OracleParameter oParamTaille = new OracleParameter("PTAILLEENT", OracleDbType.Varchar2, 8);
                OracleParameter oParamAdresse = new OracleParameter("PADRESSEENT", OracleDbType.Varchar2, 50);
                OracleParameter oParamCour = new OracleParameter("PCOURIELENT", OracleDbType.Varchar2, 30);
                OracleParameter oParamTel = new OracleParameter("PTELEPHONEENT", OracleDbType.Varchar2, 20);
                OracleParameter oParamCote = new OracleParameter("PCOTEENT", OracleDbType.Int32, 2);


                //ajout
                oParamNum.Direction = ParameterDirection.Input;
                oParamNom.Direction = ParameterDirection.Input;
                oParamCont.Direction = ParameterDirection.Input;
                oParamTaille.Direction = ParameterDirection.Input;
                oParamAdresse.Direction = ParameterDirection.Input;
                oParamCour.Direction = ParameterDirection.Input;
                oParamTel.Direction = ParameterDirection.Input;
                oParamCote.Direction = ParameterDirection.Input;


                oParamNum.Value = LB_NumEnt.Text;
                oParamNom.Value = TB_Nom.Text;
                oParamCont.Value = TB_Contact.Text;
                oParamTaille.Value = TB_Taille.Text;
                oParamAdresse.Value = TB_Adresse.Text;
                oParamCour.Value = TB_Courriel.Text;
                oParamTel.Value = TB_Tel.Text;
                oParamCote.Value = TB_Cote.Text;

                //modif/////
                OracleCommand orComm = new OracleCommand(PackageEnt, conn);
                orComm.CommandText = PackageEnt + ".MODIFIER";
                orComm.CommandType = CommandType.StoredProcedure;

                orComm.Parameters.Add(oParamNum);
                orComm.Parameters.Add(oParamNom);
                orComm.Parameters.Add(oParamCont);
                orComm.Parameters.Add(oParamTaille);
                orComm.Parameters.Add(oParamAdresse);
                orComm.Parameters.Add(oParamCour);
                orComm.Parameters.Add(oParamTel);
                orComm.Parameters.Add(oParamCote);
                orComm.ExecuteNonQuery();

                RemplirDGV();
            }
            catch (OracleException ex) { MessageBox.Show(ex.Message); } 
        }

        private void BTN_DeleteStage_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Voulez-vous vraiment supprimer cet enregistrement?", "Attention", MessageBoxButtons.YesNo) ==
                    System.Windows.Forms.DialogResult.Yes)
                {
                    OracleParameter oParamNum = new OracleParameter("PNUMENT", OracleDbType.Int32, 3);
                    oParamNum.Direction = ParameterDirection.Input;
                    oParamNum.Value = LB_NumEnt.Text;

                    OracleCommand orComm = new OracleCommand(PackageEnt, conn);
                    orComm.CommandText = PackageEnt + ".SUPPRIMER";
                    orComm.CommandType = CommandType.StoredProcedure;
                    orComm.Parameters.Add(oParamNum);
                    orComm.ExecuteNonQuery();

                    RemplirDGV();
                }
            }
            catch (OracleException ex) { MessageBox.Show(ex.Message); }
        }
    }
}
