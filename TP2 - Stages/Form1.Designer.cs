namespace TP2___Stages
{
    partial class FormPrincipale
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.gestionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.étudiantsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stagesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.entreprisesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.àProposToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DGV_Places = new System.Windows.Forms.DataGridView();
            this.BN_Assigner = new System.Windows.Forms.Button();
            this.DGV_Etudiants = new System.Windows.Forms.DataGridView();
            this.DGV_Stages = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.BN_TypeInfo = new System.Windows.Forms.Button();
            this.TTIP_profil = new System.Windows.Forms.ToolTip(this.components);
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
            this.menuStrip1.Size = new System.Drawing.Size(802, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // gestionToolStripMenuItem
            // 
            this.gestionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.étudiantsToolStripMenuItem,
            this.stagesToolStripMenuItem,
            this.entreprisesToolStripMenuItem});
            this.gestionToolStripMenuItem.Name = "gestionToolStripMenuItem";
            this.gestionToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.gestionToolStripMenuItem.Text = "Gérer";
            // 
            // étudiantsToolStripMenuItem
            // 
            this.étudiantsToolStripMenuItem.Name = "étudiantsToolStripMenuItem";
            this.étudiantsToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.étudiantsToolStripMenuItem.Text = "Stagiaires";
            this.étudiantsToolStripMenuItem.Click += new System.EventHandler(this.étudiantsToolStripMenuItem_Click);
            // 
            // stagesToolStripMenuItem
            // 
            this.stagesToolStripMenuItem.Name = "stagesToolStripMenuItem";
            this.stagesToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.stagesToolStripMenuItem.Text = "Stages";
            this.stagesToolStripMenuItem.Click += new System.EventHandler(this.stagesToolStripMenuItem_Click);
            // 
            // entreprisesToolStripMenuItem
            // 
            this.entreprisesToolStripMenuItem.Name = "entreprisesToolStripMenuItem";
            this.entreprisesToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.entreprisesToolStripMenuItem.Text = "Entreprises";
            this.entreprisesToolStripMenuItem.Click += new System.EventHandler(this.entreprisesToolStripMenuItem_Click);
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
            this.àProposToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.àProposToolStripMenuItem.Text = "À propos...";
            this.àProposToolStripMenuItem.Click += new System.EventHandler(this.àProposToolStripMenuItem_Click);
            // 
            // DGV_Places
            // 
            this.DGV_Places.AllowUserToAddRows = false;
            this.DGV_Places.AllowUserToDeleteRows = false;
            this.DGV_Places.AllowUserToResizeColumns = false;
            this.DGV_Places.AllowUserToResizeRows = false;
            this.DGV_Places.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.DGV_Places.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DGV_Places.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Places.Location = new System.Drawing.Point(30, 323);
            this.DGV_Places.MultiSelect = false;
            this.DGV_Places.Name = "DGV_Places";
            this.DGV_Places.ReadOnly = true;
            this.DGV_Places.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGV_Places.Size = new System.Drawing.Size(762, 251);
            this.DGV_Places.TabIndex = 4;
            this.DGV_Places.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DGV_Places_CellMouseDown);
            // 
            // BN_Assigner
            // 
            this.BN_Assigner.Location = new System.Drawing.Point(701, 275);
            this.BN_Assigner.Name = "BN_Assigner";
            this.BN_Assigner.Size = new System.Drawing.Size(91, 23);
            this.BN_Assigner.TabIndex = 3;
            this.BN_Assigner.Text = "Assigner";
            this.BN_Assigner.UseVisualStyleBackColor = true;
            this.BN_Assigner.Click += new System.EventHandler(this.BN_Assigner_Click);
            // 
            // DGV_Etudiants
            // 
            this.DGV_Etudiants.AllowUserToAddRows = false;
            this.DGV_Etudiants.AllowUserToDeleteRows = false;
            this.DGV_Etudiants.AllowUserToResizeColumns = false;
            this.DGV_Etudiants.AllowUserToResizeRows = false;
            this.DGV_Etudiants.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.DGV_Etudiants.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DGV_Etudiants.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Etudiants.Location = new System.Drawing.Point(30, 94);
            this.DGV_Etudiants.MultiSelect = false;
            this.DGV_Etudiants.Name = "DGV_Etudiants";
            this.DGV_Etudiants.ReadOnly = true;
            this.DGV_Etudiants.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGV_Etudiants.Size = new System.Drawing.Size(315, 175);
            this.DGV_Etudiants.TabIndex = 1;
            // 
            // DGV_Stages
            // 
            this.DGV_Stages.AllowUserToAddRows = false;
            this.DGV_Stages.AllowUserToDeleteRows = false;
            this.DGV_Stages.AllowUserToResizeColumns = false;
            this.DGV_Stages.AllowUserToResizeRows = false;
            this.DGV_Stages.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.DGV_Stages.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DGV_Stages.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Stages.Location = new System.Drawing.Point(351, 94);
            this.DGV_Stages.MultiSelect = false;
            this.DGV_Stages.Name = "DGV_Stages";
            this.DGV_Stages.ReadOnly = true;
            this.DGV_Stages.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGV_Stages.Size = new System.Drawing.Size(441, 175);
            this.DGV_Stages.TabIndex = 2;
            this.DGV_Stages.Paint += new System.Windows.Forms.PaintEventHandler(this.DGV_Stages_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 303);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Placés :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Stagiaires";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(361, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Stages";
            // 
            // BN_TypeInfo
            // 
            this.BN_TypeInfo.Location = new System.Drawing.Point(30, 39);
            this.BN_TypeInfo.Name = "BN_TypeInfo";
            this.BN_TypeInfo.Size = new System.Drawing.Size(75, 23);
            this.BN_TypeInfo.TabIndex = 0;
            this.BN_TypeInfo.Text = "Gestion";
            this.BN_TypeInfo.UseVisualStyleBackColor = true;
            this.BN_TypeInfo.Click += new System.EventHandler(this.BN_TypeInfo_Click);
            this.BN_TypeInfo.MouseHover += new System.EventHandler(this.BN_TypeInfo_MouseHover);
            // 
            // FormPrincipale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(802, 595);
            this.Controls.Add(this.BN_TypeInfo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DGV_Stages);
            this.Controls.Add(this.DGV_Etudiants);
            this.Controls.Add(this.BN_Assigner);
            this.Controls.Add(this.DGV_Places);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormPrincipale";
            this.Text = "Affectation des stages";
            this.Activated += new System.EventHandler(this.FormPrincipale_Activated);
            this.Load += new System.EventHandler(this.FormPrincipale_Load);
            this.Enter += new System.EventHandler(this.FormPrincipale_Enter);
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
        private System.Windows.Forms.ToolTip TTIP_profil;
    }
}

