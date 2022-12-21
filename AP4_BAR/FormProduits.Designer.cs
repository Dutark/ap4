
namespace AP4_BAR
{
    partial class FormProduits
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
            this.dgvProduits = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_suppr = new System.Windows.Forms.Button();
            this.BtnFermer = new System.Windows.Forms.Button();
            this.bsProduits = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduits)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsProduits)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvProduits
            // 
            this.dgvProduits.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProduits.Location = new System.Drawing.Point(16, 45);
            this.dgvProduits.Name = "dgvProduits";
            this.dgvProduits.Size = new System.Drawing.Size(673, 297);
            this.dgvProduits.TabIndex = 0;
            this.dgvProduits.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProduits_CellContentClick_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(187, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "Liste des Produits :";
            // 
            // btn_suppr
            // 
            this.btn_suppr.BackColor = System.Drawing.Color.Black;
            this.btn_suppr.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_suppr.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_suppr.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_suppr.Location = new System.Drawing.Point(465, 348);
            this.btn_suppr.Name = "btn_suppr";
            this.btn_suppr.Size = new System.Drawing.Size(123, 51);
            this.btn_suppr.TabIndex = 7;
            this.btn_suppr.Text = "SUPPRIMER";
            this.btn_suppr.UseVisualStyleBackColor = false;
            this.btn_suppr.Click += new System.EventHandler(this.btn_suppr_Click_1);
            // 
            // BtnFermer
            // 
            this.BtnFermer.BackColor = System.Drawing.Color.Black;
            this.BtnFermer.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnFermer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnFermer.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BtnFermer.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnFermer.Location = new System.Drawing.Point(594, 348);
            this.BtnFermer.Name = "BtnFermer";
            this.BtnFermer.Size = new System.Drawing.Size(95, 51);
            this.BtnFermer.TabIndex = 8;
            this.BtnFermer.Text = "FERMER";
            this.BtnFermer.UseVisualStyleBackColor = false;
            this.BtnFermer.Click += new System.EventHandler(this.BtnFermer_Click_1);
            // 
            // FormProduits
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(719, 409);
            this.Controls.Add(this.BtnFermer);
            this.Controls.Add(this.btn_suppr);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvProduits);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormProduits";
            this.Text = "AjoutProduit";
            this.Load += new System.EventHandler(this.ajoutProduit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduits)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsProduits)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvProduits;
        private System.Windows.Forms.BindingSource bsProduits;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_suppr;
        private System.Windows.Forms.Button BtnFermer;
    }
}