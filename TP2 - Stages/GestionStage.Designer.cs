namespace TP2___Stages
{
    partial class GestionStage
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
            this.DGV_GestionStage = new System.Windows.Forms.DataGridView();
            this.RTB_Description = new System.Windows.Forms.RichTextBox();
            this.TB_Plateforme = new System.Windows.Forms.TextBox();
            this.TB_Logiciel = new System.Windows.Forms.TextBox();
            this.TB_Type = new System.Windows.Forms.TextBox();
            this.TB_NomEnt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.BTN_Ok = new System.Windows.Forms.Button();
            this.BTN_Cancel = new System.Windows.Forms.Button();
            this.BTN_AjoutStage = new System.Windows.Forms.Button();
            this.BTN_DeleteStage = new System.Windows.Forms.Button();
            this.BTN_EditStage = new System.Windows.Forms.Button();
            this.BTN_ClearStage = new System.Windows.Forms.Button();
            this.LB_NumStage = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.DTP_DebutStage = new System.Windows.Forms.DateTimePicker();
            this.DTP_FinStage = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_GestionStage)).BeginInit();
            this.SuspendLayout();
            // 
            // DGV_GestionStage
            // 
            this.DGV_GestionStage.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_GestionStage.Location = new System.Drawing.Point(463, 12);
            this.DGV_GestionStage.Name = "DGV_GestionStage";
            this.DGV_GestionStage.Size = new System.Drawing.Size(708, 418);
            this.DGV_GestionStage.TabIndex = 0;
            // 
            // RTB_Description
            // 
            this.RTB_Description.Location = new System.Drawing.Point(27, 320);
            this.RTB_Description.Name = "RTB_Description";
            this.RTB_Description.Size = new System.Drawing.Size(417, 110);
            this.RTB_Description.TabIndex = 1;
            this.RTB_Description.Text = "";
            // 
            // TB_Plateforme
            // 
            this.TB_Plateforme.Location = new System.Drawing.Point(136, 81);
            this.TB_Plateforme.Name = "TB_Plateforme";
            this.TB_Plateforme.Size = new System.Drawing.Size(100, 20);
            this.TB_Plateforme.TabIndex = 3;
            // 
            // TB_Logiciel
            // 
            this.TB_Logiciel.Location = new System.Drawing.Point(136, 107);
            this.TB_Logiciel.Name = "TB_Logiciel";
            this.TB_Logiciel.Size = new System.Drawing.Size(100, 20);
            this.TB_Logiciel.TabIndex = 4;
            // 
            // TB_Type
            // 
            this.TB_Type.Location = new System.Drawing.Point(136, 133);
            this.TB_Type.Name = "TB_Type";
            this.TB_Type.Size = new System.Drawing.Size(100, 20);
            this.TB_Type.TabIndex = 5;
            // 
            // TB_NomEnt
            // 
            this.TB_NomEnt.Location = new System.Drawing.Point(136, 159);
            this.TB_NomEnt.Name = "TB_NomEnt";
            this.TB_NomEnt.Size = new System.Drawing.Size(100, 20);
            this.TB_NomEnt.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Numero de stage :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Plateforme :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Logiciel :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(31, 136);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Type :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(31, 162);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Nom de l\'entreprise :";
            // 
            // BTN_Ok
            // 
            this.BTN_Ok.Location = new System.Drawing.Point(1096, 436);
            this.BTN_Ok.Name = "BTN_Ok";
            this.BTN_Ok.Size = new System.Drawing.Size(75, 23);
            this.BTN_Ok.TabIndex = 13;
            this.BTN_Ok.Text = "Accepter";
            this.BTN_Ok.UseVisualStyleBackColor = true;
            // 
            // BTN_Cancel
            // 
            this.BTN_Cancel.Location = new System.Drawing.Point(1015, 436);
            this.BTN_Cancel.Name = "BTN_Cancel";
            this.BTN_Cancel.Size = new System.Drawing.Size(75, 23);
            this.BTN_Cancel.TabIndex = 14;
            this.BTN_Cancel.Text = "Annuler";
            this.BTN_Cancel.UseVisualStyleBackColor = true;
            // 
            // BTN_AjoutStage
            // 
            this.BTN_AjoutStage.Image = global::TP2___Stages.Properties.Resources.Add_Neutral;
            this.BTN_AjoutStage.Location = new System.Drawing.Point(388, 65);
            this.BTN_AjoutStage.Name = "BTN_AjoutStage";
            this.BTN_AjoutStage.Size = new System.Drawing.Size(45, 41);
            this.BTN_AjoutStage.TabIndex = 15;
            this.BTN_AjoutStage.UseVisualStyleBackColor = true;
            // 
            // BTN_DeleteStage
            // 
            this.BTN_DeleteStage.Image = global::TP2___Stages.Properties.Resources.Delete_Neutral;
            this.BTN_DeleteStage.Location = new System.Drawing.Point(388, 112);
            this.BTN_DeleteStage.Name = "BTN_DeleteStage";
            this.BTN_DeleteStage.Size = new System.Drawing.Size(45, 41);
            this.BTN_DeleteStage.TabIndex = 16;
            this.BTN_DeleteStage.UseVisualStyleBackColor = true;
            // 
            // BTN_EditStage
            // 
            this.BTN_EditStage.Image = global::TP2___Stages.Properties.Resources.Edit_Neutral;
            this.BTN_EditStage.Location = new System.Drawing.Point(388, 159);
            this.BTN_EditStage.Name = "BTN_EditStage";
            this.BTN_EditStage.Size = new System.Drawing.Size(45, 41);
            this.BTN_EditStage.TabIndex = 17;
            this.BTN_EditStage.UseVisualStyleBackColor = true;
            // 
            // BTN_ClearStage
            // 
            this.BTN_ClearStage.Image = global::TP2___Stages.Properties.Resources.Clear_Neutral;
            this.BTN_ClearStage.Location = new System.Drawing.Point(388, 206);
            this.BTN_ClearStage.Name = "BTN_ClearStage";
            this.BTN_ClearStage.Size = new System.Drawing.Size(45, 41);
            this.BTN_ClearStage.TabIndex = 18;
            this.BTN_ClearStage.UseVisualStyleBackColor = true;
            // 
            // LB_NumStage
            // 
            this.LB_NumStage.AutoSize = true;
            this.LB_NumStage.Location = new System.Drawing.Point(133, 56);
            this.LB_NumStage.Name = "LB_NumStage";
            this.LB_NumStage.Size = new System.Drawing.Size(35, 13);
            this.LB_NumStage.TabIndex = 19;
            this.LB_NumStage.Text = "label7";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 196);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "Début du stage :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(31, 224);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 13);
            this.label7.TabIndex = 21;
            this.label7.Text = "Fin du stage :";
            // 
            // DTP_DebutStage
            // 
            this.DTP_DebutStage.Location = new System.Drawing.Point(140, 190);
            this.DTP_DebutStage.Name = "DTP_DebutStage";
            this.DTP_DebutStage.Size = new System.Drawing.Size(200, 20);
            this.DTP_DebutStage.TabIndex = 22;
            // 
            // DTP_FinStage
            // 
            this.DTP_FinStage.Location = new System.Drawing.Point(140, 218);
            this.DTP_FinStage.Name = "DTP_FinStage";
            this.DTP_FinStage.Size = new System.Drawing.Size(200, 20);
            this.DTP_FinStage.TabIndex = 23;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(24, 304);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 13);
            this.label8.TabIndex = 24;
            this.label8.Text = "Description";
            // 
            // GestionStage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1205, 471);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.DTP_FinStage);
            this.Controls.Add(this.DTP_DebutStage);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.LB_NumStage);
            this.Controls.Add(this.BTN_ClearStage);
            this.Controls.Add(this.BTN_EditStage);
            this.Controls.Add(this.BTN_DeleteStage);
            this.Controls.Add(this.BTN_AjoutStage);
            this.Controls.Add(this.BTN_Cancel);
            this.Controls.Add(this.BTN_Ok);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TB_NomEnt);
            this.Controls.Add(this.TB_Type);
            this.Controls.Add(this.TB_Logiciel);
            this.Controls.Add(this.TB_Plateforme);
            this.Controls.Add(this.RTB_Description);
            this.Controls.Add(this.DGV_GestionStage);
            this.Name = "GestionStage";
            this.Text = "Gestion des stages";
            this.Load += new System.EventHandler(this.GestionStage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_GestionStage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DGV_GestionStage;
        private System.Windows.Forms.RichTextBox RTB_Description;
        private System.Windows.Forms.TextBox TB_Plateforme;
        private System.Windows.Forms.TextBox TB_Logiciel;
        private System.Windows.Forms.TextBox TB_Type;
        private System.Windows.Forms.TextBox TB_NomEnt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button BTN_Ok;
        private System.Windows.Forms.Button BTN_Cancel;
        private System.Windows.Forms.Button BTN_AjoutStage;
        private System.Windows.Forms.Button BTN_DeleteStage;
        private System.Windows.Forms.Button BTN_EditStage;
        private System.Windows.Forms.Button BTN_ClearStage;
        private System.Windows.Forms.Label LB_NumStage;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker DTP_DebutStage;
        private System.Windows.Forms.DateTimePicker DTP_FinStage;
        private System.Windows.Forms.Label label8;
    }
}