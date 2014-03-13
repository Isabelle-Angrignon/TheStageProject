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
        public FormPrincipale()
        {
            InitializeComponent();
        }

        private void stagesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GestionStage GestionS = new GestionStage();
            GestionS.conn = conn;
            if (GestionS.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                MettreAJour();
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
        }

        private void FormPrincipale_Load(object sender, EventArgs e)
        {
            Connect();
            Properties.Settings.Default.CouleurFond = Color.LightBlue;
            MettreAJour();
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
                MessageBox.Show(conn.State.ToString());
            }
            catch (Exception ex) { MessageBox.Show(ex.Message.ToString()); }
        }
    }
}
