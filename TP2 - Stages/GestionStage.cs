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
                oParamDebut.Value = DTP_DebutStage.Value.ToShortDateString();
                oParamFin.Value = DTP_FinStage.Value.ToShortDateString();
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
            catch (OracleException ex) { MessageBox.Show(ex.Message); } 



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
            DTP_DebutStage.Value = DateTime.Parse(DGV_GestionStage.SelectedRows[0].Cells[6].Value.ToString());
            DTP_FinStage.Value = DateTime.Parse(DGV_GestionStage.SelectedRows[0].Cells[7].Value.ToString());
            RTB_Description.Text = DGV_GestionStage.SelectedRows[0].Cells[5].Value.ToString();
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
    }
}
