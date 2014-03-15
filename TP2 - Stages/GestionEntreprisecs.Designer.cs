namespace TP2___Stages
{
    partial class GestionEntreprises
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.DGV_GestionEnt = new System.Windows.Forms.DataGridView();
            this.BTN_ClearStage = new System.Windows.Forms.Button();
            this.BTN_EditStage = new System.Windows.Forms.Button();
            this.BTN_DeleteStage = new System.Windows.Forms.Button();
            this.BTN_AjoutStage = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.TB_Nom = new System.Windows.Forms.TextBox();
            this.TB_Taille = new System.Windows.Forms.TextBox();
            this.TB_Adresse = new System.Windows.Forms.TextBox();
            this.TB_Contact = new System.Windows.Forms.TextBox();
            this.TB_Courriel = new System.Windows.Forms.TextBox();
            this.TB_Tel = new System.Windows.Forms.TextBox();
            this.TB_Cote = new System.Windows.Forms.TextBox();
            this.LB_NumEnt = new System.Windows.Forms.Label();
            this.BTN_Ok = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_GestionEnt)).BeginInit();
            this.SuspendLayout();
            // 
            // DGV_GestionEnt
            // 
            this.DGV_GestionEnt.AllowUserToAddRows = false;
            this.DGV_GestionEnt.AllowUserToDeleteRows = false;
            this.DGV_GestionEnt.AllowUserToResizeRows = false;
            this.DGV_GestionEnt.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.DGV_GestionEnt.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DGV_GestionEnt.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_GestionEnt.Location = new System.Drawing.Point(490, 28);
            this.DGV_GestionEnt.MultiSelect = false;
            this.DGV_GestionEnt.Name = "DGV_GestionEnt";
            this.DGV_GestionEnt.ReadOnly = true;
            this.DGV_GestionEnt.RowHeadersWidth = 20;
            this.DGV_GestionEnt.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGV_GestionEnt.Size = new System.Drawing.Size(757, 442);
            this.DGV_GestionEnt.TabIndex = 11;
            this.DGV_GestionEnt.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_GestionEnt_CellClick);
            this.DGV_GestionEnt.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DGV_GestionEnt_CellMouseDown);
            this.DGV_GestionEnt.Paint += new System.Windows.Forms.PaintEventHandler(this.DGV_GestionEnt_Paint);
            // 
            // BTN_ClearStage
            // 
            this.BTN_ClearStage.Image = global::TP2___Stages.Properties.Resources.Clear_Neutral;
            this.BTN_ClearStage.Location = new System.Drawing.Point(409, 238);
            this.BTN_ClearStage.Name = "BTN_ClearStage";
            this.BTN_ClearStage.Size = new System.Drawing.Size(45, 41);
            this.BTN_ClearStage.TabIndex = 10;
            this.BTN_ClearStage.UseVisualStyleBackColor = true;
            this.BTN_ClearStage.Click += new System.EventHandler(this.BTN_ClearStage_Click);
            // 
            // BTN_EditStage
            // 
            this.BTN_EditStage.Image = global::TP2___Stages.Properties.Resources.Edit_Neutral;
            this.BTN_EditStage.Location = new System.Drawing.Point(409, 191);
            this.BTN_EditStage.Name = "BTN_EditStage";
            this.BTN_EditStage.Size = new System.Drawing.Size(45, 41);
            this.BTN_EditStage.TabIndex = 9;
            this.BTN_EditStage.UseVisualStyleBackColor = true;
            this.BTN_EditStage.Click += new System.EventHandler(this.BTN_EditStage_Click);
            // 
            // BTN_DeleteStage
            // 
            this.BTN_DeleteStage.Image = global::TP2___Stages.Properties.Resources.Delete_Neutral;
            this.BTN_DeleteStage.Location = new System.Drawing.Point(409, 144);
            this.BTN_DeleteStage.Name = "BTN_DeleteStage";
            this.BTN_DeleteStage.Size = new System.Drawing.Size(45, 41);
            this.BTN_DeleteStage.TabIndex = 8;
            this.BTN_DeleteStage.UseVisualStyleBackColor = true;
            this.BTN_DeleteStage.Click += new System.EventHandler(this.BTN_DeleteStage_Click);
            // 
            // BTN_AjoutStage
            // 
            this.BTN_AjoutStage.Image = global::TP2___Stages.Properties.Resources.Add_Neutral;
            this.BTN_AjoutStage.Location = new System.Drawing.Point(409, 97);
            this.BTN_AjoutStage.Name = "BTN_AjoutStage";
            this.BTN_AjoutStage.Size = new System.Drawing.Size(45, 41);
            this.BTN_AjoutStage.TabIndex = 7;
            this.BTN_AjoutStage.UseVisualStyleBackColor = true;
            this.BTN_AjoutStage.Click += new System.EventHandler(this.BTN_AjoutStage_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 13);
            this.label1.TabIndex = 23;
            this.label1.Text = "Numero de l\'entreprise:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 24;
            this.label2.Text = "Nom :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 25;
            this.label3.Text = "Taille :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 158);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 26;
            this.label4.Text = "Adresse :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 205);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 13);
            this.label5.TabIndex = 27;
            this.label5.Text = "Nom du contact :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 252);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(116, 13);
            this.label6.TabIndex = 28;
            this.label6.Text = "Courriel de l\'entreprise :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 299);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(132, 13);
            this.label7.TabIndex = 29;
            this.label7.Text = "Téléphone de l\'entreprise :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 345);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 13);
            this.label8.TabIndex = 30;
            this.label8.Text = "Cote sur 10 :";
            // 
            // TB_Nom
            // 
            this.TB_Nom.Location = new System.Drawing.Point(150, 65);
            this.TB_Nom.Name = "TB_Nom";
            this.TB_Nom.Size = new System.Drawing.Size(100, 20);
            this.TB_Nom.TabIndex = 0;
            // 
            // TB_Taille
            // 
            this.TB_Taille.Location = new System.Drawing.Point(150, 110);
            this.TB_Taille.Name = "TB_Taille";
            this.TB_Taille.Size = new System.Drawing.Size(100, 20);
            this.TB_Taille.TabIndex = 1;
            // 
            // TB_Adresse
            // 
            this.TB_Adresse.Location = new System.Drawing.Point(150, 155);
            this.TB_Adresse.Name = "TB_Adresse";
            this.TB_Adresse.Size = new System.Drawing.Size(100, 20);
            this.TB_Adresse.TabIndex = 2;
            // 
            // TB_Contact
            // 
            this.TB_Contact.Location = new System.Drawing.Point(150, 205);
            this.TB_Contact.Name = "TB_Contact";
            this.TB_Contact.Size = new System.Drawing.Size(100, 20);
            this.TB_Contact.TabIndex = 3;
            // 
            // TB_Courriel
            // 
            this.TB_Courriel.Location = new System.Drawing.Point(150, 249);
            this.TB_Courriel.Name = "TB_Courriel";
            this.TB_Courriel.Size = new System.Drawing.Size(220, 20);
            this.TB_Courriel.TabIndex = 4;
            // 
            // TB_Tel
            // 
            this.TB_Tel.Location = new System.Drawing.Point(150, 296);
            this.TB_Tel.Name = "TB_Tel";
            this.TB_Tel.Size = new System.Drawing.Size(100, 20);
            this.TB_Tel.TabIndex = 5;
            // 
            // TB_Cote
            // 
            this.TB_Cote.Location = new System.Drawing.Point(150, 342);
            this.TB_Cote.Name = "TB_Cote";
            this.TB_Cote.Size = new System.Drawing.Size(100, 20);
            this.TB_Cote.TabIndex = 6;
            // 
            // LB_NumEnt
            // 
            this.LB_NumEnt.AutoSize = true;
            this.LB_NumEnt.Location = new System.Drawing.Point(147, 28);
            this.LB_NumEnt.Name = "LB_NumEnt";
            this.LB_NumEnt.Size = new System.Drawing.Size(35, 13);
            this.LB_NumEnt.TabIndex = 38;
            this.LB_NumEnt.Text = "label7";
            // 
            // BTN_Ok
            // 
            this.BTN_Ok.Location = new System.Drawing.Point(1172, 488);
            this.BTN_Ok.Name = "BTN_Ok";
            this.BTN_Ok.Size = new System.Drawing.Size(75, 23);
            this.BTN_Ok.TabIndex = 12;
            this.BTN_Ok.Text = "Okay";
            this.BTN_Ok.UseVisualStyleBackColor = true;
            this.BTN_Ok.Click += new System.EventHandler(this.BTN_Ok_Click);
            // 
            // GestionEntreprises
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1262, 523);
            this.Controls.Add(this.BTN_Ok);
            this.Controls.Add(this.LB_NumEnt);
            this.Controls.Add(this.TB_Cote);
            this.Controls.Add(this.TB_Tel);
            this.Controls.Add(this.TB_Courriel);
            this.Controls.Add(this.TB_Contact);
            this.Controls.Add(this.TB_Adresse);
            this.Controls.Add(this.TB_Taille);
            this.Controls.Add(this.TB_Nom);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BTN_ClearStage);
            this.Controls.Add(this.BTN_EditStage);
            this.Controls.Add(this.BTN_DeleteStage);
            this.Controls.Add(this.BTN_AjoutStage);
            this.Controls.Add(this.DGV_GestionEnt);
            this.Name = "GestionEntreprises";
            this.Text = "Gestion Entreprises";
            this.Load += new System.EventHandler(this.GestionEntreprisecs_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_GestionEnt)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DGV_GestionEnt;
        private System.Windows.Forms.Button BTN_ClearStage;
        private System.Windows.Forms.Button BTN_EditStage;
        private System.Windows.Forms.Button BTN_DeleteStage;
        private System.Windows.Forms.Button BTN_AjoutStage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox TB_Nom;
        private System.Windows.Forms.TextBox TB_Taille;
        private System.Windows.Forms.TextBox TB_Adresse;
        private System.Windows.Forms.TextBox TB_Contact;
        private System.Windows.Forms.TextBox TB_Courriel;
        private System.Windows.Forms.TextBox TB_Tel;
        private System.Windows.Forms.TextBox TB_Cote;
        private System.Windows.Forms.Label LB_NumEnt;
        private System.Windows.Forms.Button BTN_Ok;
    }
}