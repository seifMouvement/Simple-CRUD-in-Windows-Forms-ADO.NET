namespace Simple_CRUD_in_Windows_Form_ADO
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
            this.tbcCategorie = new System.Windows.Forms.TabControl();
            this.tbgRecherche = new System.Windows.Forms.TabPage();
            this.tbgMiseAjour = new System.Windows.Forms.TabPage();
            this.pnlRecherche = new System.Windows.Forms.Panel();
            this.pnlAffichage = new System.Windows.Forms.Panel();
            this.pnrBoutton = new System.Windows.Forms.Panel();
            this.dgvCATEGORIE = new System.Windows.Forms.DataGridView();
            this.txrNUMCAT = new System.Windows.Forms.TextBox();
            this.txrNOMCAT = new System.Windows.Forms.TextBox();
            this.lbrNUMCAT = new System.Windows.Forms.Label();
            this.lbrNOMCAT = new System.Windows.Forms.Label();
            this.btrNouveau = new System.Windows.Forms.Button();
            this.btrModifier = new System.Windows.Forms.Button();
            this.btrSupprimer = new System.Windows.Forms.Button();
            this.btrQuitter = new System.Windows.Forms.Button();
            this.tbcCategorie.SuspendLayout();
            this.tbgRecherche.SuspendLayout();
            this.pnlRecherche.SuspendLayout();
            this.pnlAffichage.SuspendLayout();
            this.pnrBoutton.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCATEGORIE)).BeginInit();
            this.SuspendLayout();
            // 
            // tbcCategorie
            // 
            this.tbcCategorie.Controls.Add(this.tbgRecherche);
            this.tbcCategorie.Controls.Add(this.tbgMiseAjour);
            this.tbcCategorie.Location = new System.Drawing.Point(26, 27);
            this.tbcCategorie.Name = "tbcCategorie";
            this.tbcCategorie.SelectedIndex = 0;
            this.tbcCategorie.Size = new System.Drawing.Size(749, 411);
            this.tbcCategorie.TabIndex = 0;
            // 
            // tbgRecherche
            // 
            this.tbgRecherche.Controls.Add(this.pnrBoutton);
            this.tbgRecherche.Controls.Add(this.pnlAffichage);
            this.tbgRecherche.Controls.Add(this.pnlRecherche);
            this.tbgRecherche.Location = new System.Drawing.Point(4, 22);
            this.tbgRecherche.Name = "tbgRecherche";
            this.tbgRecherche.Padding = new System.Windows.Forms.Padding(3);
            this.tbgRecherche.Size = new System.Drawing.Size(741, 385);
            this.tbgRecherche.TabIndex = 0;
            this.tbgRecherche.Text = "Recherche";
            this.tbgRecherche.UseVisualStyleBackColor = true;
            // 
            // tbgMiseAjour
            // 
            this.tbgMiseAjour.Location = new System.Drawing.Point(4, 22);
            this.tbgMiseAjour.Name = "tbgMiseAjour";
            this.tbgMiseAjour.Padding = new System.Windows.Forms.Padding(3);
            this.tbgMiseAjour.Size = new System.Drawing.Size(741, 385);
            this.tbgMiseAjour.TabIndex = 1;
            this.tbgMiseAjour.Text = "Mise à jour";
            this.tbgMiseAjour.UseVisualStyleBackColor = true;
            // 
            // pnlRecherche
            // 
            this.pnlRecherche.Controls.Add(this.lbrNOMCAT);
            this.pnlRecherche.Controls.Add(this.lbrNUMCAT);
            this.pnlRecherche.Controls.Add(this.txrNOMCAT);
            this.pnlRecherche.Controls.Add(this.txrNUMCAT);
            this.pnlRecherche.Location = new System.Drawing.Point(26, 25);
            this.pnlRecherche.Name = "pnlRecherche";
            this.pnlRecherche.Size = new System.Drawing.Size(675, 100);
            this.pnlRecherche.TabIndex = 1;
            // 
            // pnlAffichage
            // 
            this.pnlAffichage.Controls.Add(this.dgvCATEGORIE);
            this.pnlAffichage.Location = new System.Drawing.Point(26, 131);
            this.pnlAffichage.Name = "pnlAffichage";
            this.pnlAffichage.Size = new System.Drawing.Size(675, 177);
            this.pnlAffichage.TabIndex = 2;
            // 
            // pnrBoutton
            // 
            this.pnrBoutton.Controls.Add(this.btrQuitter);
            this.pnrBoutton.Controls.Add(this.btrSupprimer);
            this.pnrBoutton.Controls.Add(this.btrModifier);
            this.pnrBoutton.Controls.Add(this.btrNouveau);
            this.pnrBoutton.Location = new System.Drawing.Point(26, 314);
            this.pnrBoutton.Name = "pnrBoutton";
            this.pnrBoutton.Size = new System.Drawing.Size(675, 55);
            this.pnrBoutton.TabIndex = 3;
            // 
            // dgvCATEGORIE
            // 
            this.dgvCATEGORIE.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCATEGORIE.Location = new System.Drawing.Point(15, 12);
            this.dgvCATEGORIE.Name = "dgvCATEGORIE";
            this.dgvCATEGORIE.Size = new System.Drawing.Size(647, 150);
            this.dgvCATEGORIE.TabIndex = 0;
            // 
            // txrNUMCAT
            // 
            this.txrNUMCAT.Location = new System.Drawing.Point(201, 15);
            this.txrNUMCAT.Name = "txrNUMCAT";
            this.txrNUMCAT.Size = new System.Drawing.Size(215, 20);
            this.txrNUMCAT.TabIndex = 0;
            // 
            // txrNOMCAT
            // 
            this.txrNOMCAT.Location = new System.Drawing.Point(201, 62);
            this.txrNOMCAT.Name = "txrNOMCAT";
            this.txrNOMCAT.Size = new System.Drawing.Size(215, 20);
            this.txrNOMCAT.TabIndex = 1;
            // 
            // lbrNUMCAT
            // 
            this.lbrNUMCAT.AutoSize = true;
            this.lbrNUMCAT.Location = new System.Drawing.Point(36, 22);
            this.lbrNUMCAT.Name = "lbrNUMCAT";
            this.lbrNUMCAT.Size = new System.Drawing.Size(50, 13);
            this.lbrNUMCAT.TabIndex = 2;
            this.lbrNUMCAT.Text = "Numéro :";
            // 
            // lbrNOMCAT
            // 
            this.lbrNOMCAT.AutoSize = true;
            this.lbrNOMCAT.Location = new System.Drawing.Point(36, 70);
            this.lbrNOMCAT.Name = "lbrNOMCAT";
            this.lbrNOMCAT.Size = new System.Drawing.Size(82, 13);
            this.lbrNOMCAT.TabIndex = 3;
            this.lbrNOMCAT.Text = "Nom catégorie :";
            // 
            // btrNouveau
            // 
            this.btrNouveau.BackColor = System.Drawing.Color.Transparent;
            this.btrNouveau.Location = new System.Drawing.Point(39, 17);
            this.btrNouveau.Name = "btrNouveau";
            this.btrNouveau.Size = new System.Drawing.Size(75, 23);
            this.btrNouveau.TabIndex = 0;
            this.btrNouveau.Text = "Nouveau";
            this.btrNouveau.UseVisualStyleBackColor = false;
            // 
            // btrModifier
            // 
            this.btrModifier.Location = new System.Drawing.Point(186, 17);
            this.btrModifier.Name = "btrModifier";
            this.btrModifier.Size = new System.Drawing.Size(75, 23);
            this.btrModifier.TabIndex = 1;
            this.btrModifier.Text = "Modifier";
            this.btrModifier.UseVisualStyleBackColor = true;
            // 
            // btrSupprimer
            // 
            this.btrSupprimer.Location = new System.Drawing.Point(341, 17);
            this.btrSupprimer.Name = "btrSupprimer";
            this.btrSupprimer.Size = new System.Drawing.Size(75, 23);
            this.btrSupprimer.TabIndex = 2;
            this.btrSupprimer.Text = "Supprimer";
            this.btrSupprimer.UseVisualStyleBackColor = true;
            // 
            // btrQuitter
            // 
            this.btrQuitter.Location = new System.Drawing.Point(484, 17);
            this.btrQuitter.Name = "btrQuitter";
            this.btrQuitter.Size = new System.Drawing.Size(75, 23);
            this.btrQuitter.TabIndex = 3;
            this.btrQuitter.Text = "Quitter";
            this.btrQuitter.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tbcCategorie);
            this.Name = "Form1";
            this.Text = "Catégorie";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tbcCategorie.ResumeLayout(false);
            this.tbgRecherche.ResumeLayout(false);
            this.pnlRecherche.ResumeLayout(false);
            this.pnlRecherche.PerformLayout();
            this.pnlAffichage.ResumeLayout(false);
            this.pnrBoutton.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCATEGORIE)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tbcCategorie;
        private System.Windows.Forms.TabPage tbgRecherche;
        private System.Windows.Forms.TabPage tbgMiseAjour;
        private System.Windows.Forms.Panel pnrBoutton;
        private System.Windows.Forms.Panel pnlAffichage;
        private System.Windows.Forms.DataGridView dgvCATEGORIE;
        private System.Windows.Forms.Panel pnlRecherche;
        private System.Windows.Forms.Label lbrNOMCAT;
        private System.Windows.Forms.Label lbrNUMCAT;
        private System.Windows.Forms.TextBox txrNOMCAT;
        private System.Windows.Forms.TextBox txrNUMCAT;
        private System.Windows.Forms.Button btrQuitter;
        private System.Windows.Forms.Button btrSupprimer;
        private System.Windows.Forms.Button btrModifier;
        private System.Windows.Forms.Button btrNouveau;
    }
}

