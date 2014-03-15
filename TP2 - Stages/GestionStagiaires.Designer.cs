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
            this.LB_NumAd = new System.Windows.Forms.Label();
            this.BTN_ClearStage = new System.Windows.Forms.Button();
            this.BTN_EditStage = new System.Windows.Forms.Button();
            this.BTN_DeleteStage = new System.Windows.Forms.Button();
            this.BTN_AjoutStage = new System.Windows.Forms.Button();
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
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Stagiaires)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 38;
            this.label2.Text = "Spécialisation";
            // 
            // LB_NumAd
            // 
            this.LB_NumAd.AutoSize = true;
            this.LB_NumAd.Location = new System.Drawing.Point(94, 9);
            this.LB_NumAd.Name = "LB_NumAd";
            this.LB_NumAd.Size = new System.Drawing.Size(35, 13);
            this.LB_NumAd.TabIndex = 37;
            this.LB_NumAd.Text = "label7";
            // 
            // BTN_ClearStage
            // 
            this.BTN_ClearStage.Image = global::TP2___Stages.Properties.Resources.Clear_Neutral;
            this.BTN_ClearStage.Location = new System.Drawing.Point(242, 162);
            this.BTN_ClearStage.Name = "BTN_ClearStage";
            this.BTN_ClearStage.Size = new System.Drawing.Size(45, 41);
            this.BTN_ClearStage.TabIndex = 36;
            this.BTN_ClearStage.UseVisualStyleBackColor = true;
            // 
            // BTN_EditStage
            // 
            this.BTN_EditStage.Image = global::TP2___Stages.Properties.Resources.Edit_Neutral;
            this.BTN_EditStage.Location = new System.Drawing.Point(242, 115);
            this.BTN_EditStage.Name = "BTN_EditStage";
            this.BTN_EditStage.Size = new System.Drawing.Size(45, 41);
            this.BTN_EditStage.TabIndex = 35;
            this.BTN_EditStage.UseVisualStyleBackColor = true;
            // 
            // BTN_DeleteStage
            // 
            this.BTN_DeleteStage.Image = global::TP2___Stages.Properties.Resources.Delete_Neutral;
            this.BTN_DeleteStage.Location = new System.Drawing.Point(242, 68);
            this.BTN_DeleteStage.Name = "BTN_DeleteStage";
            this.BTN_DeleteStage.Size = new System.Drawing.Size(45, 41);
            this.BTN_DeleteStage.TabIndex = 34;
            this.BTN_DeleteStage.UseVisualStyleBackColor = true;
            // 
            // BTN_AjoutStage
            // 
            this.BTN_AjoutStage.Image = global::TP2___Stages.Properties.Resources.Add_Neutral;
            this.BTN_AjoutStage.Location = new System.Drawing.Point(242, 21);
            this.BTN_AjoutStage.Name = "BTN_AjoutStage";
            this.BTN_AjoutStage.Size = new System.Drawing.Size(45, 41);
            this.BTN_AjoutStage.TabIndex = 33;
            this.BTN_AjoutStage.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 30;
            this.label4.Text = "Prénom :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 29;
            this.label3.Text = "Nom :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 28;
            this.label1.Text = "#DA";
            // 
            // TB_Prenom
            // 
            this.TB_Prenom.Location = new System.Drawing.Point(90, 60);
            this.TB_Prenom.Name = "TB_Prenom";
            this.TB_Prenom.Size = new System.Drawing.Size(140, 20);
            this.TB_Prenom.TabIndex = 25;
            // 
            // TB_Nom
            // 
            this.TB_Nom.Location = new System.Drawing.Point(90, 34);
            this.TB_Nom.Name = "TB_Nom";
            this.TB_Nom.Size = new System.Drawing.Size(140, 20);
            this.TB_Nom.TabIndex = 24;
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
            this.DGV_Stagiaires.Size = new System.Drawing.Size(427, 262);
            this.DGV_Stagiaires.TabIndex = 42;
            // 
            // BTN_Ok
            // 
            this.BTN_Ok.Location = new System.Drawing.Point(683, 280);
            this.BTN_Ok.Name = "BTN_Ok";
            this.BTN_Ok.Size = new System.Drawing.Size(37, 23);
            this.BTN_Ok.TabIndex = 43;
            this.BTN_Ok.Text = "Ok";
            this.BTN_Ok.UseVisualStyleBackColor = true;
            this.BTN_Ok.Click += new System.EventHandler(this.BTN_Ok_Click);
            // 
            // TB_Special
            // 
            this.TB_Special.Location = new System.Drawing.Point(90, 113);
            this.TB_Special.Name = "TB_Special";
            this.TB_Special.Size = new System.Drawing.Size(140, 20);
            this.TB_Special.TabIndex = 44;
            // 
            // TB_Courriel
            // 
            this.TB_Courriel.Location = new System.Drawing.Point(90, 86);
            this.TB_Courriel.Name = "TB_Courriel";
            this.TB_Courriel.Size = new System.Drawing.Size(140, 20);
            this.TB_Courriel.TabIndex = 26;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 89);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 13);
            this.label5.TabIndex = 31;
            this.label5.Text = "Courriel :";
            // 
            // GestionStagiaires
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 315);
            this.Controls.Add(this.TB_Special);
            this.Controls.Add(this.BTN_Ok);
            this.Controls.Add(this.DGV_Stagiaires);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.LB_NumAd);
            this.Controls.Add(this.BTN_ClearStage);
            this.Controls.Add(this.BTN_EditStage);
            this.Controls.Add(this.BTN_DeleteStage);
            this.Controls.Add(this.BTN_AjoutStage);
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
        private System.Windows.Forms.Label LB_NumAd;
        private System.Windows.Forms.Button BTN_ClearStage;
        private System.Windows.Forms.Button BTN_EditStage;
        private System.Windows.Forms.Button BTN_DeleteStage;
        private System.Windows.Forms.Button BTN_AjoutStage;
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

    }
}