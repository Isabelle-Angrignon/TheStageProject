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

        private void BTN_Ajouter_Click(object sender, EventArgs e)
        {
            try  
            {
                OracleParameter oParamNumad = new OracleParameter("PNUMAD", OracleDbType.Int32, 9);
                OracleParameter oParamNom = new OracleParameter("PNOMETUDIANT", OracleDbType.Varchar2, 20);
                OracleParameter oParamPrenom = new OracleParameter("PPRENOMETUDIANT", OracleDbType.Varchar2, 20);
                OracleParameter oParamSpec = new OracleParameter("PSPECIALISATION", OracleDbType.Varchar2, 20);
                OracleParameter oParamCourriel = new OracleParameter("PCOURRIELETUDIANT", OracleDbType.Varchar2, 20);
                
                //ajout
                oParamNumad.Direction = ParameterDirection.Input;
                oParamNom.Direction = ParameterDirection.Input;
                oParamPrenom.Direction = ParameterDirection.Input;
                oParamSpec.Direction = ParameterDirection.Input;
                oParamCourriel.Direction = ParameterDirection.Input;               
                
                oParamNumad.Value = TB_Numad.Text;
                oParamNom.Value = TB_Nom.Text;
                oParamPrenom.Value = TB_Prenom.Text;
                oParamSpec.Value = TB_Special.Text;
                oParamCourriel.Value = TB_Courriel.Text;
                
                //modif/////
                OracleCommand orComm = new OracleCommand(Package, conn);
                orComm.CommandText = Package + ".INSERER";
                orComm.CommandType = CommandType.StoredProcedure;

                orComm.Parameters.Add(oParamNumad);
                orComm.Parameters.Add(oParamNom);
                orComm.Parameters.Add(oParamPrenom);
                orComm.Parameters.Add(oParamSpec);
                orComm.Parameters.Add(oParamCourriel);
                orComm.ExecuteNonQuery();

                RemplirDGV();
            }
            catch (OracleException ex) { ErrorMessage(ex);      }
            catch (Exception ex) { MessageBox.Show(ex.Message); } 
        }

        private void BTN_Edit_Click(object sender, EventArgs e)
        {
            try
            {
                OracleParameter oParamNumad = new OracleParameter("PNUMAD", OracleDbType.Int32, 9);
                OracleParameter oParamNom = new OracleParameter("PNOMETUDIANT", OracleDbType.Varchar2, 20);
                OracleParameter oParamPrenom = new OracleParameter("PPRENOMETUDIANT", OracleDbType.Varchar2, 20);
                OracleParameter oParamSpec = new OracleParameter("PSPECIALISATION", OracleDbType.Varchar2, 20);
                OracleParameter oParamCourriel = new OracleParameter("PCOURRIELETUDIANT", OracleDbType.Varchar2, 20);
               
                //ajout
                oParamNumad.Direction = ParameterDirection.Input;
                oParamNom.Direction = ParameterDirection.Input;
                oParamPrenom.Direction = ParameterDirection.Input;
                oParamSpec.Direction = ParameterDirection.Input;
                oParamCourriel.Direction = ParameterDirection.Input;
                
                oParamNumad.Value = TB_Numad.Text;
                oParamNom.Value = TB_Nom.Text;
                oParamPrenom.Value = TB_Prenom.Text;
                oParamSpec.Value = TB_Special.Text;
                oParamCourriel.Value = TB_Courriel.Text;
                
                //modif/////
                OracleCommand orComm = new OracleCommand(Package, conn);
                orComm.CommandText = Package + ".MODIFIER";
                orComm.CommandType = CommandType.StoredProcedure;

                orComm.Parameters.Add(oParamNumad);
                orComm.Parameters.Add(oParamNom);
                orComm.Parameters.Add(oParamPrenom);
                orComm.Parameters.Add(oParamSpec);
                orComm.Parameters.Add(oParamCourriel);
                orComm.ExecuteNonQuery();

                RemplirDGV();
            }
            catch (OracleException ex) { ErrorMessage(ex); }
            catch (Exception ex) { MessageBox.Show(ex.Message); } 
        }

        private void BTN_Delete_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Voulez-vous vraiment supprimer cet enregistrement?", "Attention", MessageBoxButtons.YesNo) ==
                    System.Windows.Forms.DialogResult.Yes)
                {
                    OracleParameter oParamNumStage = new OracleParameter("PNUMAD", OracleDbType.Int32, 5);
                    oParamNumStage.Direction = ParameterDirection.Input;
                    oParamNumStage.Value = TB_Numad.Text;

                    OracleCommand orComm = new OracleCommand(Package, conn);
                    orComm.CommandText = Package + ".SUPPRIMER";
                    orComm.CommandType = CommandType.StoredProcedure;
                    orComm.Parameters.Add(oParamNumStage);
                    orComm.ExecuteNonQuery();

                    RemplirDGV();
                }
            }
            catch (OracleException ex) { ErrorMessage(ex); }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void BTN_Clear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void Clear()
        {
            TB_Numad.Text = "";
            TB_Nom.Text = "";
            TB_Prenom.Text = "";
            TB_Special.Text = "";
            TB_Courriel.Text = "";          
        }

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
