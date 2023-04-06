
namespace AP4_BAR
{
    partial class gestionBarman
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
            this.label1 = new System.Windows.Forms.Label();
            this.dtArriver = new System.Windows.Forms.DateTimePicker();
            this.tbMdp = new System.Windows.Forms.TextBox();
            this.tbMail = new System.Windows.Forms.TextBox();
            this.tbPrenom = new System.Windows.Forms.TextBox();
            this.tbNom = new System.Windows.Forms.TextBox();
            this.btn_ajout = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cbOui = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(252, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(194, 24);
            this.label1.TabIndex = 5;
            this.label1.Text = "Ajout d\'un Barman :";
            // 
            // dtArriver
            // 
            this.dtArriver.Location = new System.Drawing.Point(256, 275);
            this.dtArriver.Name = "dtArriver";
            this.dtArriver.Size = new System.Drawing.Size(200, 20);
            this.dtArriver.TabIndex = 6;
            // 
            // tbMdp
            // 
            this.tbMdp.Location = new System.Drawing.Point(256, 238);
            this.tbMdp.Name = "tbMdp";
            this.tbMdp.Size = new System.Drawing.Size(200, 20);
            this.tbMdp.TabIndex = 10;
            // 
            // tbMail
            // 
            this.tbMail.Location = new System.Drawing.Point(256, 201);
            this.tbMail.Name = "tbMail";
            this.tbMail.Size = new System.Drawing.Size(200, 20);
            this.tbMail.TabIndex = 11;
            // 
            // tbPrenom
            // 
            this.tbPrenom.Location = new System.Drawing.Point(256, 163);
            this.tbPrenom.Name = "tbPrenom";
            this.tbPrenom.Size = new System.Drawing.Size(200, 20);
            this.tbPrenom.TabIndex = 12;
            // 
            // tbNom
            // 
            this.tbNom.Location = new System.Drawing.Point(256, 126);
            this.tbNom.Name = "tbNom";
            this.tbNom.Size = new System.Drawing.Size(200, 20);
            this.tbNom.TabIndex = 13;
            this.tbNom.TextChanged += new System.EventHandler(this.tbNom_TextChanged);
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
            this.btn_ajout.TabIndex = 14;
            this.btn_ajout.Text = "AJOUTER";
            this.btn_ajout.UseVisualStyleBackColor = false;
            this.btn_ajout.Click += new System.EventHandler(this.btn_ajout_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(125, 127);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(110, 16);
            this.label6.TabIndex = 15;
            this.label6.Text = "Nom du barman :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(107, 164);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 16);
            this.label2.TabIndex = 16;
            this.label2.Text = "Prénom du barman :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(129, 202);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 16);
            this.label3.TabIndex = 17;
            this.label3.Text = "Mail du barman :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(72, 239);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(163, 16);
            this.label4.TabIndex = 18;
            this.label4.Text = "Mot de passe du barman :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(69, 275);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(166, 16);
            this.label5.TabIndex = 19;
            this.label5.Text = "Date d\'arrivée du barman :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(147, 89);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 16);
            this.label7.TabIndex = 22;
            this.label7.Text = "Est dirigeant :";
            // 
            // cbOui
            // 
            this.cbOui.AutoSize = true;
            this.cbOui.Location = new System.Drawing.Point(330, 90);
            this.cbOui.Name = "cbOui";
            this.cbOui.Size = new System.Drawing.Size(42, 17);
            this.cbOui.TabIndex = 20;
            this.cbOui.Text = "Oui";
            this.cbOui.UseVisualStyleBackColor = true;
            this.cbOui.CheckedChanged += new System.EventHandler(this.cbOui_CheckedChanged);
            // 
            // gestionBarman
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(719, 409);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cbOui);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btn_ajout);
            this.Controls.Add(this.tbNom);
            this.Controls.Add(this.tbPrenom);
            this.Controls.Add(this.tbMail);
            this.Controls.Add(this.tbMdp);
            this.Controls.Add(this.dtArriver);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "gestionBarman";
            this.Text = "gestionBarman";
            this.Load += new System.EventHandler(this.gestionBarman_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtArriver;
        private System.Windows.Forms.TextBox tbMdp;
        private System.Windows.Forms.TextBox tbMail;
        private System.Windows.Forms.TextBox tbPrenom;
        private System.Windows.Forms.TextBox tbNom;
        private System.Windows.Forms.Button btn_ajout;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox cbOui;
    }
}