﻿using System;
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
    public partial class GestionStagiaires : Form
    {
        public OracleConnection conn = new OracleConnection();
        private DataSet mainDataSet = new DataSet();
        string Package = "GESTIONSTAGIAIRES";

        public GestionStagiaires()
        {
            InitializeComponent();
        }
        private void BTN_Ok_Click(object sender, EventArgs e)
        {
            this.Close();
		}        

        private void GestionStagiaires_Load(object sender, EventArgs e)
        {
            this.BackColor = Properties.Settings.Default.CouleurFond;
            MiseAJour();
        }
        private void MiseAJour()
        {
            RemplirDGV();
        }
        private void RemplirDGV()
        {
            OracleCommand oraliste = new OracleCommand(Package, conn);
            oraliste.CommandText = Package + ".LISTER";
            oraliste.CommandType = CommandType.StoredProcedure;

            OracleParameter OrapameResultat = new OracleParameter("LISTE",
            OracleDbType.RefCursor);
            OrapameResultat.Direction = ParameterDirection.ReturnValue;
            oraliste.Parameters.Add(OrapameResultat);

            OracleDataAdapter Oraliste = new OracleDataAdapter(oraliste);

            if (mainDataSet.Tables.Contains("Liste"))
            {
                mainDataSet.Tables["Liste"].Clear();
            }
            Oraliste.Fill(mainDataSet, "Liste");
            Oraliste.Dispose();

            BindingSource maSource = new BindingSource(mainDataSet, "Liste");
            DGV_Stagiaires.DataSource = maSource;
            RemplirTB();
        }
        private void RemplirTB()
        {
            TB_Numad.Text = DGV_Stagiaires.SelectedRows[0].Cells[0].Value.ToString();
            TB_Nom.Text = DGV_Stagiaires.SelectedRows[0].Cells[1].Value.ToString();
            TB_Prenom.Text = DGV_Stagiaires.SelectedRows[0].Cells[2].Value.ToString();
            TB_Special.Text = DGV_Stagiaires.SelectedRows[0].Cells[3].Value.ToString();
            TB_Courriel.Text = DGV_Stagiaires.SelectedRows[0].Cells[4].Value.ToString();            
        }

        private void DGV_Stagiaires_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            RemplirTB();
        }

        /* 
         * a ajouter avant le catch regulier des try pour add - sup - mod
         * catch (OracleException ex)
            {
                ErrorMessage(ex);
            } */

        


        private void ErrorMessage(OracleException Ex)
        {
            switch (Ex.Number)
            {
                case 02290:
                    // au lieu d'afficher violation de clé étrangère , on affiche ceci:
                    MessageBox.Show("Entrée invalide");
                    break;
                case 02292:
                    MessageBox.Show("Le joueur choisi est inscrit dans au moins un match: " +
                        "on ne peut le suprimer.");
                    break;
                case 01400:
                    MessageBox.Show("Il y a des champs vides");
                    break;
                default: MessageBox.Show(Ex.Message.ToString());
                    break;
            }
        }
    }
}
