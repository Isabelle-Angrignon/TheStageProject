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
        private OracleConnection conn = new OracleConnection();
        private DataSet mainDataSet = new DataSet();
        int NumStageDefaut = 0;
        public GestionStage()
        {
            InitializeComponent();
        }

        private void GestionStage_Load(object sender, EventArgs e)
        {
            this.BackColor = Properties.Settings.Default.CouleurFond;
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
    }
}
