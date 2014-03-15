namespace TP2___Stages
{
    partial class GestionStagiaires
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
            this.label2 = new System.Windows.Forms.Label();
            this.BTN_Clear = new System.Windows.Forms.Button();
            this.BTN_Edit = new System.Windows.Forms.Button();
            this.BTN_Delete = new System.Windows.Forms.Button();
            this.BTN_Ajouter = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TB_Prenom = new System.Windows.Forms.TextBox();
            this.TB_Nom = new System.Windows.Forms.TextBox();
            this.DGV_Stagiaires = new System.Windows.Forms.DataGridView();
            this.BTN_Ok = new System.Windows.Forms.Button();
            this.TB_Special = new System.Windows.Forms.TextBox();
            this.TB_Courriel = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TB_Numad = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Stagiaires)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "* Profil :";
            // 
            // BTN_Clear
            // 
            this.BTN_Clear.Image = global::TP2___Stages.Properties.Resources.Clear_Neutral;
            this.BTN_Clear.Location = new System.Drawing.Point(242, 162);
            this.BTN_Clear.Name = "BTN_Clear";
            this.BTN_Clear.Size = new System.Drawing.Size(45, 41);
            this.BTN_Clear.TabIndex = 13;
            this.BTN_Clear.UseVisualStyleBackColor = true;
            this.BTN_Clear.Click += new System.EventHandler(this.BTN_Clear_Click);
            // 
            // BTN_Edit
            // 
            this.BTN_Edit.Image = global::TP2___Stages.Properties.Resources.Edit_Neutral;
            this.BTN_Edit.Location = new System.Drawing.Point(242, 115);
            this.BTN_Edit.Name = "BTN_Edit";
            this.BTN_Edit.Size = new System.Drawing.Size(45, 41);
            this.BTN_Edit.TabIndex = 12;
            this.BTN_Edit.UseVisualStyleBackColor = true;
            this.BTN_Edit.Click += new System.EventHandler(this.BTN_Edit_Click);
            // 
            // BTN_Delete
            // 
            this.BTN_Delete.Image = global::TP2___Stages.Properties.Resources.Delete_Neutral;
            this.BTN_Delete.Location = new System.Drawing.Point(242, 68);
            this.BTN_Delete.Name = "BTN_Delete";
            this.BTN_Delete.Size = new System.Drawing.Size(45, 41);
            this.BTN_Delete.TabIndex = 11;
            this.BTN_Delete.UseVisualStyleBackColor = true;
            this.BTN_Delete.Click += new System.EventHandler(this.BTN_Delete_Click);
            // 
            // BTN_Ajouter
            // 
            this.BTN_Ajouter.Image = global::TP2___Stages.Properties.Resources.Add_Neutral;
            this.BTN_Ajouter.Location = new System.Drawing.Point(242, 21);
            this.BTN_Ajouter.Name = "BTN_Ajouter";
            this.BTN_Ajouter.Size = new System.Drawing.Size(45, 41);
            this.BTN_Ajouter.TabIndex = 10;
            this.BTN_Ajouter.UseVisualStyleBackColor = true;
            this.BTN_Ajouter.Click += new System.EventHandler(this.BTN_Ajouter_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "* Prénom :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "* Nom :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "* #DA";
            // 
            // TB_Prenom
            // 
            this.TB_Prenom.Location = new System.Drawing.Point(90, 60);
            this.TB_Prenom.Name = "TB_Prenom";
            this.TB_Prenom.Size = new System.Drawing.Size(140, 20);
            this.TB_Prenom.TabIndex = 7;
            // 
            // TB_Nom
            // 
            this.TB_Nom.Location = new System.Drawing.Point(90, 34);
            this.TB_Nom.Name = "TB_Nom";
            this.TB_Nom.Size = new System.Drawing.Size(140, 20);
            this.TB_Nom.TabIndex = 6;
            // 
            // DGV_Stagiaires
            // 
            this.DGV_Stagiaires.AllowUserToAddRows = false;
            this.DGV_Stagiaires.AllowUserToDeleteRows = false;
            this.DGV_Stagiaires.AllowUserToResizeRows = false;
            this.DGV_Stagiaires.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.DGV_Stagiaires.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DGV_Stagiaires.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Stagiaires.Location = new System.Drawing.Point(293, 9);
            this.DGV_Stagiaires.MultiSelect = false;
            this.DGV_Stagiaires.Name = "DGV_Stagiaires";
            this.DGV_Stagiaires.ReadOnly = true;
            this.DGV_Stagiaires.RowHeadersWidth = 20;
            this.DGV_Stagiaires.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGV_Stagiaires.Size = new System.Drawing.Size(531, 262);
            this.DGV_Stagiaires.TabIndex = 14;
            this.DGV_Stagiaires.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_Stagiaires_CellClick);
            // 
            // BTN_Ok
            // 
            this.BTN_Ok.Location = new System.Drawing.Point(787, 277);
            this.BTN_Ok.Name = "BTN_Ok";
            this.BTN_Ok.Size = new System.Drawing.Size(37, 23);
            this.BTN_Ok.TabIndex = 15;
            this.BTN_Ok.Text = "Ok";
            this.BTN_Ok.UseVisualStyleBackColor = true;
            this.BTN_Ok.Click += new System.EventHandler(this.BTN_Ok_Click);
            // 
            // TB_Special
            // 
            this.TB_Special.Location = new System.Drawing.Point(90, 113);
            this.TB_Special.Name = "TB_Special";
            this.TB_Special.Size = new System.Drawing.Size(140, 20);
            this.TB_Special.TabIndex = 9;
            // 
            // TB_Courriel
            // 
            this.TB_Courriel.Location = new System.Drawing.Point(90, 86);
            this.TB_Courriel.Name = "TB_Courriel";
            this.TB_Courriel.Size = new System.Drawing.Size(140, 20);
            this.TB_Courriel.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 89);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Courriel :";
            // 
            // TB_Numad
            // 
            this.TB_Numad.Location = new System.Drawing.Point(90, 8);
            this.TB_Numad.Name = "TB_Numad";
            this.TB_Numad.Size = new System.Drawing.Size(140, 20);
            this.TB_Numad.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 221);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(257, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "No de stage : modifiable dans assignation seulement.";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 143);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(117, 13);
            this.label9.TabIndex = 23;
            this.label9.Text = "* = Champs obligatoires";
            // 
            // GestionStagiaires
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(836, 310);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.TB_Numad);
            this.Controls.Add(this.TB_Special);
            this.Controls.Add(this.BTN_Ok);
            this.Controls.Add(this.DGV_Stagiaires);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BTN_Clear);
            this.Controls.Add(this.BTN_Edit);
            this.Controls.Add(this.BTN_Delete);
            this.Controls.Add(this.BTN_Ajouter);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TB_Courriel);
            this.Controls.Add(this.TB_Prenom);
            this.Controls.Add(this.TB_Nom);
            this.Name = "GestionStagiaires";
            this.Text = "Gestion des stagiaires";
            this.Load += new System.EventHandler(this.GestionStagiaires_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Stagiaires)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BTN_Clear;
        private System.Windows.Forms.Button BTN_Edit;
        private System.Windows.Forms.Button BTN_Delete;
        private System.Windows.Forms.Button BTN_Ajouter;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TB_Prenom;
        private System.Windows.Forms.TextBox TB_Nom;
        private System.Windows.Forms.DataGridView DGV_Stagiaires;
        private System.Windows.Forms.Button BTN_Ok;
        private System.Windows.Forms.TextBox TB_Special;
        private System.Windows.Forms.TextBox TB_Courriel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TB_Numad;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;

    }
}