
namespace AP4_BAR
{
    partial class Accueil
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Accueil));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.pRODUITSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lISTEDESPRODUITSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aJOUTPRODUITToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificationDunProduitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rÉAPPROVISIONNEMENTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statistiquesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.déconnexionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelPrincipal = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelPrincipal.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pRODUITSToolStripMenuItem,
            this.rÉAPPROVISIONNEMENTToolStripMenuItem,
            this.statistiquesToolStripMenuItem,
            this.déconnexionToolStripMenuItem,
            this.quitterToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(703, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // pRODUITSToolStripMenuItem
            // 
            this.pRODUITSToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lISTEDESPRODUITSToolStripMenuItem,
            this.aJOUTPRODUITToolStripMenuItem,
            this.modificationDunProduitToolStripMenuItem});
            this.pRODUITSToolStripMenuItem.Name = "pRODUITSToolStripMenuItem";
            this.pRODUITSToolStripMenuItem.Size = new System.Drawing.Size(73, 20);
            this.pRODUITSToolStripMenuItem.Text = "PRODUITS";
            // 
            // lISTEDESPRODUITSToolStripMenuItem
            // 
            this.lISTEDESPRODUITSToolStripMenuItem.Name = "lISTEDESPRODUITSToolStripMenuItem";
            this.lISTEDESPRODUITSToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.lISTEDESPRODUITSToolStripMenuItem.Text = "Liste";
            this.lISTEDESPRODUITSToolStripMenuItem.Click += new System.EventHandler(this.lISTEDESPRODUITSToolStripMenuItem_Click);
            // 
            // aJOUTPRODUITToolStripMenuItem
            // 
            this.aJOUTPRODUITToolStripMenuItem.Name = "aJOUTPRODUITToolStripMenuItem";
            this.aJOUTPRODUITToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.aJOUTPRODUITToolStripMenuItem.Text = "Ajout";
            this.aJOUTPRODUITToolStripMenuItem.Click += new System.EventHandler(this.aJOUTPRODUITToolStripMenuItem_Click);
            // 
            // modificationDunProduitToolStripMenuItem
            // 
            this.modificationDunProduitToolStripMenuItem.Name = "modificationDunProduitToolStripMenuItem";
            this.modificationDunProduitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.modificationDunProduitToolStripMenuItem.Text = "Modification";
            this.modificationDunProduitToolStripMenuItem.Click += new System.EventHandler(this.modificationDunProduitToolStripMenuItem_Click);
            // 
            // rÉAPPROVISIONNEMENTToolStripMenuItem
            // 
            this.rÉAPPROVISIONNEMENTToolStripMenuItem.Name = "rÉAPPROVISIONNEMENTToolStripMenuItem";
            this.rÉAPPROVISIONNEMENTToolStripMenuItem.Size = new System.Drawing.Size(154, 20);
            this.rÉAPPROVISIONNEMENTToolStripMenuItem.Text = "RÉAPPROVISIONNEMENT";
            // 
            // statistiquesToolStripMenuItem
            // 
            this.statistiquesToolStripMenuItem.Name = "statistiquesToolStripMenuItem";
            this.statistiquesToolStripMenuItem.Size = new System.Drawing.Size(90, 20);
            this.statistiquesToolStripMenuItem.Text = "STATISTIQUES";
            // 
            // déconnexionToolStripMenuItem
            // 
            this.déconnexionToolStripMenuItem.Name = "déconnexionToolStripMenuItem";
            this.déconnexionToolStripMenuItem.Size = new System.Drawing.Size(102, 20);
            this.déconnexionToolStripMenuItem.Text = "DÉCONNEXION";
            this.déconnexionToolStripMenuItem.Click += new System.EventHandler(this.déconnexionToolStripMenuItem_Click);
            // 
            // quitterToolStripMenuItem
            // 
            this.quitterToolStripMenuItem.Name = "quitterToolStripMenuItem";
            this.quitterToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.quitterToolStripMenuItem.Text = "QUITTER";
            this.quitterToolStripMenuItem.Click += new System.EventHandler(this.quitterToolStripMenuItem_Click);
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(700, 409);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // panelPrincipal
            // 
            this.panelPrincipal.Controls.Add(this.pictureBox1);
            this.panelPrincipal.Location = new System.Drawing.Point(0, 27);
            this.panelPrincipal.Name = "panelPrincipal";
            this.panelPrincipal.Size = new System.Drawing.Size(703, 412);
            this.panelPrincipal.TabIndex = 2;
            // 
            // Accueil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(703, 441);
            this.ControlBox = false;
            this.Controls.Add(this.panelPrincipal);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Accueil";
            this.Text = "Accueil";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelPrincipal.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem statistiquesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem déconnexionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitterToolStripMenuItem;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripMenuItem rÉAPPROVISIONNEMENTToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pRODUITSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lISTEDESPRODUITSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aJOUTPRODUITToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificationDunProduitToolStripMenuItem;
        private System.Windows.Forms.Panel panelPrincipal;
    }
}

