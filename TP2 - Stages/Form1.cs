using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP2___Stages
{
    public partial class FormPrincipale : Form
    {
        public FormPrincipale()
        {
            InitializeComponent();
        }

        private void stagesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GestionStage GestionS = new GestionStage();
            if (GestionS.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                Refresh();
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
            Refresh();
        }

        private void FormPrincipale_Load(object sender, EventArgs e)
        {
            Properties.Settings.Default.CouleurFond = Color.LightBlue;
            Refresh();
        }
        private void Refresh()
        {
            this.BackColor = Properties.Settings.Default.CouleurFond;
        }

        private void àProposToolStripMenuItem_Click(object sender, EventArgs e)
        {
            APropos form = new APropos();
            form.ShowDialog();
        }
    }
}
