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
    public partial class GestionStage : Form
    {
        public OracleConnection conn = new OracleConnection();
        private DataSet mainDataSet = new DataSet();
        int NumStageDefaut = 0;
        string PackageStage = "GESTIONSTAGES";
        public GestionStage()
        {
            InitializeComponent();
        }

        private void GestionStage_Load(object sender, EventArgs e)
        {
            this.BackColor = Properties.Settings.Default.CouleurFond;
            MiseAJour();
        }

        private void BTN_Ok_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void BTN_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MiseAJour()
        {
            RemplirDGVStage();
        }

        private void RemplirDGVStage()
        {
            try
            {
                OracleCommand oraliste = new OracleCommand(PackageStage, conn);
                oraliste.CommandText = PackageStage + ".LISTER";
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
                DGV_GestionStage.DataSource = maSource;
                RemplirTB();
            }

            catch (OracleException ex)
            {
                ErrorMessage(ex);
            }

            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void BTN_AjoutStage_Click(object sender, EventArgs e)
        { 
            try
            {
                OracleParameter oParamDescr = new OracleParameter("PDESCR", OracleDbType.Varchar2, 200);
                OracleParameter oParamPlate = new OracleParameter("PPLATEFORME", OracleDbType.Varchar2, 20);
                OracleParameter oParamLogi = new OracleParameter("PLOGICIEL", OracleDbType.Varchar2, 20);
                OracleParameter oParamType = new OracleParameter("PTYPE", OracleDbType.Varchar2, 20);
                OracleParameter oParamDebut = new OracleParameter("PDEBUT", OracleDbType.Date);
                OracleParameter oParamFin = new OracleParameter("PFIN", OracleDbType.Date);
                OracleParameter oParamEnt = new OracleParameter("PENT", OracleDbType.Int32, 3);

                //ajout
                oParamDescr.Direction = ParameterDirection.Input;
                oParamPlate.Direction = ParameterDirection.Input;
                oParamLogi.Direction = ParameterDirection.Input;
                oParamType.Direction = ParameterDirection.Input;
                oParamDebut.Direction = ParameterDirection.Input;
                oParamFin.Direction = ParameterDirection.Input;
                oParamEnt.Direction = ParameterDirection.Input;

                oParamDescr.Value = RTB_Description.Text;
                oParamPlate.Value = TB_Plateforme.Text;
                oParamLogi.Value = TB_Logiciel.Text;
                oParamType.Value = TB_Type.Text;
                //Pour ne garderque la date, sans l'heure
                string DateDebut = DTP_DebutStage.Value.ToShortDateString();
                string DateFin = DTP_FinStage.Value.ToShortDateString();
                oParamDebut.Value = DateTime.Parse(DateDebut);
                oParamFin.Value = DateTime.Parse(DateFin);
                oParamEnt.Value = TB_NumEnt.Text;

                //modif/////
                OracleCommand orComm = new OracleCommand(PackageStage, conn);
                orComm.CommandText = PackageStage + ".INSERER";
                orComm.CommandType = CommandType.StoredProcedure;

                orComm.Parameters.Add(oParamDescr);
                orComm.Parameters.Add(oParamPlate);
                orComm.Parameters.Add(oParamLogi);
                orComm.Parameters.Add(oParamType);
                orComm.Parameters.Add(oParamDebut);
                orComm.Parameters.Add(oParamFin);
                orComm.Parameters.Add(oParamEnt);
                orComm.ExecuteNonQuery();

                RemplirDGVStage();
            }
            catch (OracleException ex)
            {
                ErrorMessage(ex);
            }

            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void BTN_EditStage_Click(object sender, EventArgs e)
        {  
            try
            {
                OracleParameter oParamNum = new OracleParameter("PNUM", OracleDbType.Int32, 5);
                OracleParameter oParamDescr = new OracleParameter("PDESCR", OracleDbType.Varchar2, 200);
                OracleParameter oParamPlate = new OracleParameter("PPLATEFORME", OracleDbType.Varchar2, 20);
                OracleParameter oParamLogi = new OracleParameter("PLOGICIEL", OracleDbType.Varchar2, 20);
                OracleParameter oParamType = new OracleParameter("PTYPE", OracleDbType.Varchar2, 20);
                OracleParameter oParamDebut = new OracleParameter("PDEBUT", OracleDbType.Date);
                OracleParameter oParamFin = new OracleParameter("PFIN", OracleDbType.Date);
                OracleParameter oParamEnt = new OracleParameter("PENT", OracleDbType.Int32, 3);

                //ajout
                oParamNum.Direction = ParameterDirection.Input;
                oParamDescr.Direction = ParameterDirection.Input;
                oParamPlate.Direction = ParameterDirection.Input;
                oParamLogi.Direction = ParameterDirection.Input;
                oParamType.Direction = ParameterDirection.Input;
                oParamDebut.Direction = ParameterDirection.Input;
                oParamFin.Direction = ParameterDirection.Input;
                oParamEnt.Direction = ParameterDirection.Input;

                oParamNum.Value = LB_NumStage.Text;
                oParamDescr.Value = RTB_Description.Text;
                oParamPlate.Value = TB_Plateforme.Text;
                oParamLogi.Value = TB_Logiciel.Text;
                oParamType.Value = TB_Type.Text;
                //Pour ne garderque la date, sans l'heure
                string DateDebut = DTP_DebutStage.Value.ToShortDateString();
                string DateFin = DTP_FinStage.Value.ToShortDateString();
                oParamDebut.Value = DateTime.Parse(DateDebut);
                oParamFin.Value = DateTime.Parse(DateFin);
                oParamEnt.Value = TB_NumEnt.Text;

                //modif/////
                OracleCommand orComm = new OracleCommand(PackageStage, conn);
                orComm.CommandText = PackageStage + ".MODIFIER";
                orComm.CommandType = CommandType.StoredProcedure;

                orComm.Parameters.Add(oParamNum); 
                orComm.Parameters.Add(oParamDescr);
                orComm.Parameters.Add(oParamPlate);
                orComm.Parameters.Add(oParamLogi);
                orComm.Parameters.Add(oParamType);
                orComm.Parameters.Add(oParamDebut);
                orComm.Parameters.Add(oParamFin);
                orComm.Parameters.Add(oParamEnt);
                orComm.ExecuteNonQuery();

                RemplirDGVStage();
            }
            catch (OracleException ex)
            {
                ErrorMessage(ex);
            }

            catch (Exception ex) { MessageBox.Show(ex.Message); }         
        }

        private void BTN_DeleteStage_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Voulez-vous vraiment supprimer cet enregistrement?", "Attention", MessageBoxButtons.YesNo) ==
                    System.Windows.Forms.DialogResult.Yes)
                {
                    OracleParameter oParamNumStage = new OracleParameter("PNUM", OracleDbType.Int32, 5);
                    oParamNumStage.Direction = ParameterDirection.Input;
                    oParamNumStage.Value = LB_NumStage.Text;

                    OracleCommand orComm = new OracleCommand(PackageStage, conn);
                    orComm.CommandText = PackageStage + ".SUPPRIMER";
                    orComm.CommandType = CommandType.StoredProcedure;
                    orComm.Parameters.Add(oParamNumStage);
                    orComm.ExecuteNonQuery();

                    RemplirDGVStage();
                }
            }

            catch (OracleException ex)
            {
                ErrorMessage(ex);
            }

            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void DGV_GestionStage_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            RemplirTB();
        }
        private void RemplirTB()
        {
            LB_NumStage.Text = DGV_GestionStage.SelectedRows[0].Cells[0].Value.ToString();
            TB_Plateforme.Text = DGV_GestionStage.SelectedRows[0].Cells[1].Value.ToString();
            TB_Logiciel.Text = DGV_GestionStage.SelectedRows[0].Cells[2].Value.ToString();
            TB_Type.Text = DGV_GestionStage.SelectedRows[0].Cells[3].Value.ToString();
            TB_NumEnt.Text = DGV_GestionStage.SelectedRows[0].Cells[4].Value.ToString();
            DTP_DebutStage.Value = DateTime.Parse(DGV_GestionStage.SelectedRows[0].Cells[7].Value.ToString());
            DTP_FinStage.Value = DateTime.Parse(DGV_GestionStage.SelectedRows[0].Cells[8].Value.ToString());
            RTB_Description.Text = DGV_GestionStage.SelectedRows[0].Cells[6].Value.ToString();
        }

        private void BTN_ClearStage_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void Clear()
        {
            LB_NumStage.Text = "";
            TB_Plateforme.Text = "";
            TB_Logiciel.Text = "";
            TB_Type.Text = "";
            TB_NumEnt.Text = "";
            DTP_DebutStage.Value = DateTime.Now;
            DTP_FinStage.Value = DateTime.Now;
            RTB_Description.Text = "";
        }

        private void ErrorMessage(OracleException Ex)
        {
            switch (Ex.Number)
            {
                case 02290:
                    MessageBox.Show("Entrée invalide");
                    break;
                case 02292:
                    MessageBox.Show("Impossible de supprimer le stage; un étudiant lui est assigné");
                    break;
                case 01400:
                    MessageBox.Show("Il y a des champs vides");
                    break;
                case 01438:
                    MessageBox.Show("Le nombre est trop long");
                    break;
                case 02291:
                    MessageBox.Show("Impossible d'ajouter le stage; le numéro d'entreprise spécifié n'existe pas");
                    break;
                default: MessageBox.Show(Ex.Message.ToString());
                    break;
            }
        }
    }
}
