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
            this.pnrBoutton = new System.Windows.Forms.Panel();
            this.btrQuitter = new System.Windows.Forms.Button();
            this.btrSupprimer = new System.Windows.Forms.Button();
            this.btrModifier = new System.Windows.Forms.Button();
            this.btrNouveau = new System.Windows.Forms.Button();
            this.pnlAffichage = new System.Windows.Forms.Panel();
            this.dgvCATEGORIE = new System.Windows.Forms.DataGridView();
            this.pnlRecherche = new System.Windows.Forms.Panel();
            this.lbrNOMCAT = new System.Windows.Forms.Label();
            this.lbrNUMCAT = new System.Windows.Forms.Label();
            this.txrNOMCAT = new System.Windows.Forms.TextBox();
            this.txrNUMCAT = new System.Windows.Forms.TextBox();
            this.tbgMiseAjour = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnajouter = new System.Windows.Forms.Button();
            this.btnquitter = new System.Windows.Forms.Button();
            this.btnsupprimer = new System.Windows.Forms.Button();
            this.btnmodifier = new System.Windows.Forms.Button();
            this.btnnouveau = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblNOMCAT = new System.Windows.Forms.Label();
            this.lblNUMCAT = new System.Windows.Forms.Label();
            this.txtNOMCAT = new System.Windows.Forms.TextBox();
            this.txtNUMCAT = new System.Windows.Forms.TextBox();
            this.tbcCategorie.SuspendLayout();
            this.tbgRecherche.SuspendLayout();
            this.pnrBoutton.SuspendLayout();
            this.pnlAffichage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCATEGORIE)).BeginInit();
            this.pnlRecherche.SuspendLayout();
            this.tbgMiseAjour.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
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
            // btrQuitter
            // 
            this.btrQuitter.Location = new System.Drawing.Point(484, 17);
            this.btrQuitter.Name = "btrQuitter";
            this.btrQuitter.Size = new System.Drawing.Size(75, 23);
            this.btrQuitter.TabIndex = 3;
            this.btrQuitter.Text = "Quitter";
            this.btrQuitter.UseVisualStyleBackColor = true;
            // 
            // btrSupprimer
            // 
            this.btrSupprimer.Location = new System.Drawing.Point(341, 17);
            this.btrSupprimer.Name = "btrSupprimer";
            this.btrSupprimer.Size = new System.Drawing.Size(75, 23);
            this.btrSupprimer.TabIndex = 2;
            this.btrSupprimer.Text = "Supprimer";
            this.btrSupprimer.UseVisualStyleBackColor = true;
            this.btrSupprimer.Click += new System.EventHandler(this.btrSupprimer_Click);
            // 
            // btrModifier
            // 
            this.btrModifier.Location = new System.Drawing.Point(186, 17);
            this.btrModifier.Name = "btrModifier";
            this.btrModifier.Size = new System.Drawing.Size(75, 23);
            this.btrModifier.TabIndex = 1;
            this.btrModifier.Text = "Modifier";
            this.btrModifier.UseVisualStyleBackColor = true;
            this.btrModifier.Click += new System.EventHandler(this.btrModifier_Click);
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
            this.btrNouveau.Click += new System.EventHandler(this.btrNouveau_Click);
            // 
            // pnlAffichage
            // 
            this.pnlAffichage.Controls.Add(this.dgvCATEGORIE);
            this.pnlAffichage.Location = new System.Drawing.Point(26, 131);
            this.pnlAffichage.Name = "pnlAffichage";
            this.pnlAffichage.Size = new System.Drawing.Size(675, 177);
            this.pnlAffichage.TabIndex = 2;
            // 
            // dgvCATEGORIE
            // 
            this.dgvCATEGORIE.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCATEGORIE.Location = new System.Drawing.Point(15, 12);
            this.dgvCATEGORIE.Name = "dgvCATEGORIE";
            this.dgvCATEGORIE.Size = new System.Drawing.Size(647, 150);
            this.dgvCATEGORIE.TabIndex = 0;
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
            // lbrNOMCAT
            // 
            this.lbrNOMCAT.AutoSize = true;
            this.lbrNOMCAT.Location = new System.Drawing.Point(36, 70);
            this.lbrNOMCAT.Name = "lbrNOMCAT";
            this.lbrNOMCAT.Size = new System.Drawing.Size(82, 13);
            this.lbrNOMCAT.TabIndex = 3;
            this.lbrNOMCAT.Text = "Nom catégorie :";
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
            // txrNOMCAT
            // 
            this.txrNOMCAT.Location = new System.Drawing.Point(201, 62);
            this.txrNOMCAT.Name = "txrNOMCAT";
            this.txrNOMCAT.Size = new System.Drawing.Size(215, 20);
            this.txrNOMCAT.TabIndex = 1;
            // 
            // txrNUMCAT
            // 
            this.txrNUMCAT.Location = new System.Drawing.Point(201, 15);
            this.txrNUMCAT.Name = "txrNUMCAT";
            this.txrNUMCAT.Size = new System.Drawing.Size(215, 20);
            this.txrNUMCAT.TabIndex = 0;
            // 
            // tbgMiseAjour
            // 
            this.tbgMiseAjour.Controls.Add(this.panel2);
            this.tbgMiseAjour.Controls.Add(this.panel1);
            this.tbgMiseAjour.Location = new System.Drawing.Point(4, 22);
            this.tbgMiseAjour.Name = "tbgMiseAjour";
            this.tbgMiseAjour.Padding = new System.Windows.Forms.Padding(3);
            this.tbgMiseAjour.Size = new System.Drawing.Size(741, 385);
            this.tbgMiseAjour.TabIndex = 1;
            this.tbgMiseAjour.Text = "Mise à jour";
            this.tbgMiseAjour.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnajouter);
            this.panel2.Controls.Add(this.btnquitter);
            this.panel2.Controls.Add(this.btnsupprimer);
            this.panel2.Controls.Add(this.btnmodifier);
            this.panel2.Controls.Add(this.btnnouveau);
            this.panel2.Location = new System.Drawing.Point(23, 218);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(675, 55);
            this.panel2.TabIndex = 4;
            // 
            // btnajouter
            // 
            this.btnajouter.Location = new System.Drawing.Point(443, 17);
            this.btnajouter.Name = "btnajouter";
            this.btnajouter.Size = new System.Drawing.Size(75, 23);
            this.btnajouter.TabIndex = 4;
            this.btnajouter.Text = "Ajouter";
            this.btnajouter.UseVisualStyleBackColor = true;
            this.btnajouter.Click += new System.EventHandler(this.btnajouter_Click);
            // 
            // btnquitter
            // 
            this.btnquitter.Location = new System.Drawing.Point(552, 16);
            this.btnquitter.Name = "btnquitter";
            this.btnquitter.Size = new System.Drawing.Size(75, 23);
            this.btnquitter.TabIndex = 3;
            this.btnquitter.Text = "Quitter";
            this.btnquitter.UseVisualStyleBackColor = true;
            // 
            // btnsupprimer
            // 
            this.btnsupprimer.Location = new System.Drawing.Point(341, 17);
            this.btnsupprimer.Name = "btnsupprimer";
            this.btnsupprimer.Size = new System.Drawing.Size(75, 23);
            this.btnsupprimer.TabIndex = 2;
            this.btnsupprimer.Text = "Supprimer";
            this.btnsupprimer.UseVisualStyleBackColor = true;
            this.btnsupprimer.Click += new System.EventHandler(this.btnsupprimer_Click);
            // 
            // btnmodifier
            // 
            this.btnmodifier.Location = new System.Drawing.Point(186, 17);
            this.btnmodifier.Name = "btnmodifier";
            this.btnmodifier.Size = new System.Drawing.Size(75, 23);
            this.btnmodifier.TabIndex = 1;
            this.btnmodifier.Text = "Modifier";
            this.btnmodifier.UseVisualStyleBackColor = true;
            this.btnmodifier.Click += new System.EventHandler(this.btnmodifier_Click);
            // 
            // btnnouveau
            // 
            this.btnnouveau.BackColor = System.Drawing.Color.Transparent;
            this.btnnouveau.Location = new System.Drawing.Point(39, 17);
            this.btnnouveau.Name = "btnnouveau";
            this.btnnouveau.Size = new System.Drawing.Size(75, 23);
            this.btnnouveau.TabIndex = 0;
            this.btnnouveau.Text = "Nouveau";
            this.btnnouveau.UseVisualStyleBackColor = false;
            this.btnnouveau.Click += new System.EventHandler(this.btnnouveau_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblNOMCAT);
            this.panel1.Controls.Add(this.lblNUMCAT);
            this.panel1.Controls.Add(this.txtNOMCAT);
            this.panel1.Controls.Add(this.txtNUMCAT);
            this.panel1.Location = new System.Drawing.Point(23, 23);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(675, 100);
            this.panel1.TabIndex = 2;
            // 
            // lblNOMCAT
            // 
            this.lblNOMCAT.AutoSize = true;
            this.lblNOMCAT.Location = new System.Drawing.Point(36, 70);
            this.lblNOMCAT.Name = "lblNOMCAT";
            this.lblNOMCAT.Size = new System.Drawing.Size(82, 13);
            this.lblNOMCAT.TabIndex = 3;
            this.lblNOMCAT.Text = "Nom catégorie :";
            // 
            // lblNUMCAT
            // 
            this.lblNUMCAT.AutoSize = true;
            this.lblNUMCAT.Location = new System.Drawing.Point(36, 22);
            this.lblNUMCAT.Name = "lblNUMCAT";
            this.lblNUMCAT.Size = new System.Drawing.Size(50, 13);
            this.lblNUMCAT.TabIndex = 2;
            this.lblNUMCAT.Text = "Numéro :";
            // 
            // txtNOMCAT
            // 
            this.txtNOMCAT.Location = new System.Drawing.Point(201, 62);
            this.txtNOMCAT.Name = "txtNOMCAT";
            this.txtNOMCAT.Size = new System.Drawing.Size(215, 20);
            this.txtNOMCAT.TabIndex = 1;
            // 
            // txtNUMCAT
            // 
            this.txtNUMCAT.Location = new System.Drawing.Point(201, 15);
            this.txtNUMCAT.Name = "txtNUMCAT";
            this.txtNUMCAT.Size = new System.Drawing.Size(215, 20);
            this.txtNUMCAT.TabIndex = 0;
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
            this.pnrBoutton.ResumeLayout(false);
            this.pnlAffichage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCATEGORIE)).EndInit();
            this.pnlRecherche.ResumeLayout(false);
            this.pnlRecherche.PerformLayout();
            this.tbgMiseAjour.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
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
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnquitter;
        private System.Windows.Forms.Button btnsupprimer;
        private System.Windows.Forms.Button btnmodifier;
        private System.Windows.Forms.Button btnnouveau;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblNOMCAT;
        private System.Windows.Forms.Label lblNUMCAT;
        private System.Windows.Forms.TextBox txtNOMCAT;
        private System.Windows.Forms.TextBox txtNUMCAT;
        private System.Windows.Forms.Button btnajouter;
    }
}

