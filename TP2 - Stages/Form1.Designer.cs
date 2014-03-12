namespace TP2___Stages
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.gestionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.àProposToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.étudiantsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stagesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.entreprisesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DGV_Places = new System.Windows.Forms.DataGridView();
            this.BN_Assigner = new System.Windows.Forms.Button();
            this.DGV_Etudiants = new System.Windows.Forms.DataGridView();
            this.DGV_Stages = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.BN_TypeInfo = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Places)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Etudiants)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Stages)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gestionToolStripMenuItem,
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(561, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // gestionToolStripMenuItem
            // 
            this.gestionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.étudiantsToolStripMenuItem,
            this.stagesToolStripMenuItem,
            this.entreprisesToolStripMenuItem});
            this.gestionToolStripMenuItem.Name = "gestionToolStripMenuItem";
            this.gestionToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.gestionToolStripMenuItem.Text = "Gestion";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.àProposToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(24, 20);
            this.toolStripMenuItem1.Text = "?";
            // 
            // àProposToolStripMenuItem
            // 
            this.àProposToolStripMenuItem.Name = "àProposToolStripMenuItem";
            this.àProposToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F1;
            this.àProposToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.àProposToolStripMenuItem.Text = "À propos...";
            // 
            // étudiantsToolStripMenuItem
            // 
            this.étudiantsToolStripMenuItem.Name = "étudiantsToolStripMenuItem";
            this.étudiantsToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.étudiantsToolStripMenuItem.Text = "Étudiants";
            // 
            // stagesToolStripMenuItem
            // 
            this.stagesToolStripMenuItem.Name = "stagesToolStripMenuItem";
            this.stagesToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.stagesToolStripMenuItem.Text = "Stages";
            // 
            // entreprisesToolStripMenuItem
            // 
            this.entreprisesToolStripMenuItem.Name = "entreprisesToolStripMenuItem";
            this.entreprisesToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.entreprisesToolStripMenuItem.Text = "Entreprises";
            // 
            // DGV_Places
            // 
            this.DGV_Places.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Places.Location = new System.Drawing.Point(35, 323);
            this.DGV_Places.Name = "DGV_Places";
            this.DGV_Places.Size = new System.Drawing.Size(505, 251);
            this.DGV_Places.TabIndex = 1;
            // 
            // BN_Assigner
            // 
            this.BN_Assigner.Location = new System.Drawing.Point(449, 275);
            this.BN_Assigner.Name = "BN_Assigner";
            this.BN_Assigner.Size = new System.Drawing.Size(91, 23);
            this.BN_Assigner.TabIndex = 5;
            this.BN_Assigner.Text = "Assigner";
            this.BN_Assigner.UseVisualStyleBackColor = true;
            // 
            // DGV_Etudiants
            // 
            this.DGV_Etudiants.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Etudiants.Location = new System.Drawing.Point(35, 94);
            this.DGV_Etudiants.Name = "DGV_Etudiants";
            this.DGV_Etudiants.Size = new System.Drawing.Size(196, 175);
            this.DGV_Etudiants.TabIndex = 6;
            // 
            // DGV_Stages
            // 
            this.DGV_Stages.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Stages.Location = new System.Drawing.Point(241, 94);
            this.DGV_Stages.Name = "DGV_Stages";
            this.DGV_Stages.Size = new System.Drawing.Size(299, 175);
            this.DGV_Stages.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 303);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Placés :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Étudiants";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(253, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Stages";
            // 
            // BN_TypeInfo
            // 
            this.BN_TypeInfo.Location = new System.Drawing.Point(35, 39);
            this.BN_TypeInfo.Name = "BN_TypeInfo";
            this.BN_TypeInfo.Size = new System.Drawing.Size(75, 23);
            this.BN_TypeInfo.TabIndex = 11;
            this.BN_TypeInfo.Text = "Gest/Indu";
            this.BN_TypeInfo.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(561, 595);
            this.Controls.Add(this.BN_TypeInfo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DGV_Stages);
            this.Controls.Add(this.DGV_Etudiants);
            this.Controls.Add(this.BN_Assigner);
            this.Controls.Add(this.DGV_Places);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Places)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Etudiants)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Stages)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem gestionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem étudiantsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stagesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem entreprisesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem àProposToolStripMenuItem;
        private System.Windows.Forms.DataGridView DGV_Places;
        private System.Windows.Forms.Button BN_Assigner;
        private System.Windows.Forms.DataGridView DGV_Etudiants;
        private System.Windows.Forms.DataGridView DGV_Stages;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BN_TypeInfo;
    }
}

