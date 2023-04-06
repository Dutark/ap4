
namespace AP4_BAR
{
    partial class listeBarman
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
            this.dgvBarman = new System.Windows.Forms.DataGridView();
            this.btn_suppr = new System.Windows.Forms.Button();
            this.BtnFermer = new System.Windows.Forms.Button();
            this.bsBarman = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBarman)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsBarman)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 24);
            this.label1.TabIndex = 4;
            this.label1.Text = "Liste des Barmans:";
            // 
            // dgvBarman
            // 
            this.dgvBarman.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBarman.Location = new System.Drawing.Point(16, 45);
            this.dgvBarman.Name = "dgvBarman";
            this.dgvBarman.Size = new System.Drawing.Size(673, 297);
            this.dgvBarman.TabIndex = 5;
            this.dgvBarman.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBarman_CellContentClick);
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
            this.btn_suppr.TabIndex = 8;
            this.btn_suppr.Text = "SUPPRIMER";
            this.btn_suppr.UseVisualStyleBackColor = false;
            this.btn_suppr.Click += new System.EventHandler(this.btn_suppr_Click);
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
            this.BtnFermer.TabIndex = 9;
            this.BtnFermer.Text = "FERMER";
            this.BtnFermer.UseVisualStyleBackColor = false;
            // 
            // listeBarman
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(719, 409);
            this.Controls.Add(this.BtnFermer);
            this.Controls.Add(this.btn_suppr);
            this.Controls.Add(this.dgvBarman);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "listeBarman";
            this.Text = "gestionBarman";
            this.Load += new System.EventHandler(this.listeBarman_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBarman)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsBarman)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvBarman;
        private System.Windows.Forms.Button btn_suppr;
        private System.Windows.Forms.Button BtnFermer;
        private System.Windows.Forms.BindingSource bsBarman;
    }
}