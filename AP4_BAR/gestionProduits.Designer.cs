
namespace AP4_BAR
{
    partial class gestionProduits
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_ajout = new System.Windows.Forms.Button();
            this.lbNomProd = new System.Windows.Forms.Label();
            this.tbProduit = new System.Windows.Forms.TextBox();
            this.lbQte = new System.Windows.Forms.Label();
            this.tbQte = new System.Windows.Forms.TextBox();
            this.lbNomBar = new System.Windows.Forms.Label();
            this.cbListeBar = new System.Windows.Forms.ComboBox();
            this.lbPrix = new System.Windows.Forms.Label();
            this.tbPrix = new System.Windows.Forms.TextBox();
            this.cbTypeP = new System.Windows.Forms.ComboBox();
            this.lbType = new System.Windows.Forms.Label();
            this.bsBar = new System.Windows.Forms.BindingSource(this.components);
            this.bsTypeP = new System.Windows.Forms.BindingSource(this.components);
            this.tbVol = new System.Windows.Forms.TextBox();
            this.lbVol = new System.Windows.Forms.Label();
            this.tbDeg = new System.Windows.Forms.TextBox();
            this.lbDegA = new System.Windows.Forms.Label();
            this.tbPoids = new System.Windows.Forms.TextBox();
            this.lbPoids = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bsBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsTypeP)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(252, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 24);
            this.label1.TabIndex = 4;
            this.label1.Text = "Ajout d\'un Produit :";
            // 
            // btn_ajout
            // 
            this.btn_ajout.BackColor = System.Drawing.Color.Black;
            this.btn_ajout.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_ajout.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ajout.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_ajout.Location = new System.Drawing.Point(290, 346);
            this.btn_ajout.Name = "btn_ajout";
            this.btn_ajout.Size = new System.Drawing.Size(123, 51);
            this.btn_ajout.TabIndex = 8;
            this.btn_ajout.Text = "AJOUTER";
            this.btn_ajout.UseVisualStyleBackColor = false;
            this.btn_ajout.Click += new System.EventHandler(this.Button_Click);
            // 
            // lbNomProd
            // 
            this.lbNomProd.AutoSize = true;
            this.lbNomProd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNomProd.Location = new System.Drawing.Point(130, 88);
            this.lbNomProd.Name = "lbNomProd";
            this.lbNomProd.Size = new System.Drawing.Size(105, 16);
            this.lbNomProd.TabIndex = 14;
            this.lbNomProd.Text = "Nom du produit :";
            // 
            // tbProduit
            // 
            this.tbProduit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbProduit.Location = new System.Drawing.Point(256, 85);
            this.tbProduit.Name = "tbProduit";
            this.tbProduit.Size = new System.Drawing.Size(185, 22);
            this.tbProduit.TabIndex = 17;
            // 
            // lbQte
            // 
            this.lbQte.AutoSize = true;
            this.lbQte.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbQte.Location = new System.Drawing.Point(110, 168);
            this.lbQte.Name = "lbQte";
            this.lbQte.Size = new System.Drawing.Size(125, 16);
            this.lbQte.TabIndex = 18;
            this.lbQte.Text = "Quantité du produit :";
            // 
            // tbQte
            // 
            this.tbQte.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbQte.Location = new System.Drawing.Point(256, 165);
            this.tbQte.Name = "tbQte";
            this.tbQte.Size = new System.Drawing.Size(185, 22);
            this.tbQte.TabIndex = 19;
            // 
            // lbNomBar
            // 
            this.lbNomBar.AutoSize = true;
            this.lbNomBar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNomBar.Location = new System.Drawing.Point(151, 126);
            this.lbNomBar.Name = "lbNomBar";
            this.lbNomBar.Size = new System.Drawing.Size(84, 16);
            this.lbNomBar.TabIndex = 20;
            this.lbNomBar.Text = "Nom du bar :";
            // 
            // cbListeBar
            // 
            this.cbListeBar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbListeBar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbListeBar.FormattingEnabled = true;
            this.cbListeBar.Location = new System.Drawing.Point(256, 123);
            this.cbListeBar.Name = "cbListeBar";
            this.cbListeBar.Size = new System.Drawing.Size(185, 24);
            this.cbListeBar.TabIndex = 22;
            // 
            // lbPrix
            // 
            this.lbPrix.AutoSize = true;
            this.lbPrix.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPrix.Location = new System.Drawing.Point(137, 208);
            this.lbPrix.Name = "lbPrix";
            this.lbPrix.Size = new System.Drawing.Size(98, 16);
            this.lbPrix.TabIndex = 23;
            this.lbPrix.Text = "Prix du produit :";
            // 
            // tbPrix
            // 
            this.tbPrix.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPrix.Location = new System.Drawing.Point(256, 205);
            this.tbPrix.Name = "tbPrix";
            this.tbPrix.Size = new System.Drawing.Size(185, 22);
            this.tbPrix.TabIndex = 24;
            // 
            // cbTypeP
            // 
            this.cbTypeP.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTypeP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTypeP.FormattingEnabled = true;
            this.cbTypeP.Items.AddRange(new object[] {
            "Boisson alcoolisé",
            "Boisson soft",
            "Nourriture"});
            this.cbTypeP.Location = new System.Drawing.Point(256, 49);
            this.cbTypeP.Name = "cbTypeP";
            this.cbTypeP.Size = new System.Drawing.Size(185, 24);
            this.cbTypeP.TabIndex = 25;
            this.cbTypeP.SelectedIndexChanged += new System.EventHandler(this.cbTypeP_SelectedIndexChanged);
            // 
            // lbType
            // 
            this.lbType.AutoSize = true;
            this.lbType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbType.Location = new System.Drawing.Point(127, 52);
            this.lbType.Name = "lbType";
            this.lbType.Size = new System.Drawing.Size(108, 16);
            this.lbType.TabIndex = 26;
            this.lbType.Text = "Type du produit :";
            // 
            // tbVol
            // 
            this.tbVol.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbVol.Location = new System.Drawing.Point(256, 283);
            this.tbVol.Name = "tbVol";
            this.tbVol.Size = new System.Drawing.Size(185, 22);
            this.tbVol.TabIndex = 30;
            // 
            // lbVol
            // 
            this.lbVol.AutoSize = true;
            this.lbVol.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbVol.Location = new System.Drawing.Point(113, 286);
            this.lbVol.Name = "lbVol";
            this.lbVol.Size = new System.Drawing.Size(122, 16);
            this.lbVol.TabIndex = 29;
            this.lbVol.Text = "Volume du produit :";
            // 
            // tbDeg
            // 
            this.tbDeg.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDeg.Location = new System.Drawing.Point(256, 243);
            this.tbDeg.Name = "tbDeg";
            this.tbDeg.Size = new System.Drawing.Size(185, 22);
            this.tbDeg.TabIndex = 28;
            // 
            // lbDegA
            // 
            this.lbDegA.AutoSize = true;
            this.lbDegA.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDegA.Location = new System.Drawing.Point(80, 246);
            this.lbDegA.Name = "lbDegA";
            this.lbDegA.Size = new System.Drawing.Size(155, 16);
            this.lbDegA.TabIndex = 27;
            this.lbDegA.Text = "Degré Alcool du produit :";
            // 
            // tbPoids
            // 
            this.tbPoids.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPoids.Location = new System.Drawing.Point(256, 318);
            this.tbPoids.Name = "tbPoids";
            this.tbPoids.Size = new System.Drawing.Size(185, 22);
            this.tbPoids.TabIndex = 32;
            // 
            // lbPoids
            // 
            this.lbPoids.AutoSize = true;
            this.lbPoids.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPoids.Location = new System.Drawing.Point(124, 321);
            this.lbPoids.Name = "lbPoids";
            this.lbPoids.Size = new System.Drawing.Size(111, 16);
            this.lbPoids.TabIndex = 31;
            this.lbPoids.Text = "Poids du produit :";
            // 
            // gestionProduits
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(719, 409);
            this.Controls.Add(this.tbPoids);
            this.Controls.Add(this.lbPoids);
            this.Controls.Add(this.tbVol);
            this.Controls.Add(this.lbVol);
            this.Controls.Add(this.tbDeg);
            this.Controls.Add(this.lbDegA);
            this.Controls.Add(this.lbType);
            this.Controls.Add(this.cbTypeP);
            this.Controls.Add(this.tbPrix);
            this.Controls.Add(this.lbPrix);
            this.Controls.Add(this.cbListeBar);
            this.Controls.Add(this.lbNomBar);
            this.Controls.Add(this.tbQte);
            this.Controls.Add(this.lbQte);
            this.Controls.Add(this.tbProduit);
            this.Controls.Add(this.lbNomProd);
            this.Controls.Add(this.btn_ajout);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "gestionProduits";
            this.Text = "gestionProduits";
            this.Load += new System.EventHandler(this.gestionProduits_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bsBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsTypeP)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_ajout;
        private System.Windows.Forms.Label lbNomProd;
        private System.Windows.Forms.TextBox tbProduit;
        private System.Windows.Forms.Label lbQte;
        private System.Windows.Forms.TextBox tbQte;
        private System.Windows.Forms.Label lbNomBar;
        private System.Windows.Forms.ComboBox cbListeBar;
        private System.Windows.Forms.Label lbPrix;
        private System.Windows.Forms.TextBox tbPrix;
        private System.Windows.Forms.BindingSource bsBar;
        private System.Windows.Forms.ComboBox cbTypeP;
        private System.Windows.Forms.Label lbType;
        private System.Windows.Forms.BindingSource bsTypeP;
        private System.Windows.Forms.TextBox tbVol;
        private System.Windows.Forms.Label lbVol;
        private System.Windows.Forms.TextBox tbDeg;
        private System.Windows.Forms.TextBox tbPoids;
        private System.Windows.Forms.Label lbPoids;
        private System.Windows.Forms.Label lbDegA;
    }
}