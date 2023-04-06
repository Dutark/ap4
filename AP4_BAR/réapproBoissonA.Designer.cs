
namespace AP4_BAR
{
    partial class réapproBoissonA
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
            this.tbPrix = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbListeBar = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbQte = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_ajout = new System.Windows.Forms.Button();
            this.cbProd = new System.Windows.Forms.ComboBox();
            this.bsBar = new System.Windows.Forms.BindingSource(this.components);
            this.bsProduits = new System.Windows.Forms.BindingSource(this.components);
            this.tbDegA = new System.Windows.Forms.TextBox();
            this.tbVolume = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bsBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsProduits)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(126, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(465, 24);
            this.label1.TabIndex = 5;
            this.label1.Text = "Réapprovisionnement d\'une boisson alcoolisée :";
            // 
            // tbPrix
            // 
            this.tbPrix.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPrix.Location = new System.Drawing.Point(256, 281);
            this.tbPrix.Name = "tbPrix";
            this.tbPrix.Size = new System.Drawing.Size(185, 22);
            this.tbPrix.TabIndex = 33;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(130, 284);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 16);
            this.label4.TabIndex = 32;
            this.label4.Text = "Prix du produit :";
            // 
            // cbListeBar
            // 
            this.cbListeBar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbListeBar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbListeBar.FormattingEnabled = true;
            this.cbListeBar.Location = new System.Drawing.Point(256, 128);
            this.cbListeBar.Name = "cbListeBar";
            this.cbListeBar.Size = new System.Drawing.Size(185, 24);
            this.cbListeBar.TabIndex = 31;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(144, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 16);
            this.label3.TabIndex = 30;
            this.label3.Text = "Nom du bar :";
            // 
            // tbQte
            // 
            this.tbQte.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbQte.Location = new System.Drawing.Point(256, 206);
            this.tbQte.Name = "tbQte";
            this.tbQte.Size = new System.Drawing.Size(185, 22);
            this.tbQte.TabIndex = 29;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(103, 209);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 16);
            this.label2.TabIndex = 28;
            this.label2.Text = "Quantité du produit :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(123, 90);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(105, 16);
            this.label6.TabIndex = 26;
            this.label6.Text = "Nom du produit :";
            // 
            // btn_ajout
            // 
            this.btn_ajout.BackColor = System.Drawing.Color.Black;
            this.btn_ajout.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_ajout.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ajout.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_ajout.Location = new System.Drawing.Point(256, 346);
            this.btn_ajout.Name = "btn_ajout";
            this.btn_ajout.Size = new System.Drawing.Size(185, 51);
            this.btn_ajout.TabIndex = 25;
            this.btn_ajout.Text = "RÉAPPROVISIONNER";
            this.btn_ajout.UseVisualStyleBackColor = false;
            this.btn_ajout.Click += new System.EventHandler(this.btn_ajout_Click);
            // 
            // cbProd
            // 
            this.cbProd.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbProd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbProd.FormattingEnabled = true;
            this.cbProd.Location = new System.Drawing.Point(256, 87);
            this.cbProd.Name = "cbProd";
            this.cbProd.Size = new System.Drawing.Size(185, 24);
            this.cbProd.TabIndex = 34;
            // 
            // tbDegA
            // 
            this.tbDegA.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDegA.Location = new System.Drawing.Point(256, 244);
            this.tbDegA.Name = "tbDegA";
            this.tbDegA.Size = new System.Drawing.Size(185, 22);
            this.tbDegA.TabIndex = 35;
            // 
            // tbVolume
            // 
            this.tbVolume.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbVolume.Location = new System.Drawing.Point(256, 168);
            this.tbVolume.Name = "tbVolume";
            this.tbVolume.Size = new System.Drawing.Size(185, 22);
            this.tbVolume.TabIndex = 36;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(168, 171);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 16);
            this.label5.TabIndex = 37;
            this.label5.Text = "Volume :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(135, 247);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(93, 16);
            this.label7.TabIndex = 38;
            this.label7.Text = "Degré Alcool :";
            // 
            // réapproBoissonA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(719, 409);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbVolume);
            this.Controls.Add(this.tbDegA);
            this.Controls.Add(this.cbProd);
            this.Controls.Add(this.tbPrix);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbListeBar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbQte);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btn_ajout);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "réapproBoissonA";
            this.Text = "réapproProduits";
            this.Load += new System.EventHandler(this.réapproBoissonA_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bsBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsProduits)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbPrix;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbListeBar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbQte;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_ajout;
        private System.Windows.Forms.BindingSource bsBar;
        private System.Windows.Forms.ComboBox cbProd;
        private System.Windows.Forms.BindingSource bsProduits;
        private System.Windows.Forms.TextBox tbDegA;
        private System.Windows.Forms.TextBox tbVolume;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
    }
}