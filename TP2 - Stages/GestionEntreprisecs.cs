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
            
        }
        private void MiseAjour()
        {
            RemplirDGV();
        }
        private void RemplirDGV()
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
    }
}
