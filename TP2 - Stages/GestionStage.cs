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
        }

        private void BTN_AjoutStage_Click(object sender, EventArgs e)
        {




        }






































































        private void DGV_GestionStage_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            LB_NumStage.Text = DGV_GestionStage.SelectedRows[0].Cells[0].Value.ToString();
            TB_Plateforme.Text = DGV_GestionStage.SelectedRows[0].Cells[1].Value.ToString();
            TB_Logiciel.Text = DGV_GestionStage.SelectedRows[0].Cells[2].Value.ToString();
            TB_Type.Text = DGV_GestionStage.SelectedRows[0].Cells[3].Value.ToString();
            TB_NumEnt.Text = DGV_GestionStage.SelectedRows[0].Cells[4].Value.ToString();
            DTP_DebutStage.Value = DateTime.Parse( DGV_GestionStage.SelectedRows[0].Cells[6].Value.ToString());
            DTP_FinStage.Value = DateTime.Parse(DGV_GestionStage.SelectedRows[0].Cells[7].Value.ToString());
            RTB_Description.Text = DGV_GestionStage.SelectedRows[0].Cells[5].Value.ToString();
        }
    }
}
