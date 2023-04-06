using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AP4_BAR
{
    public partial class gestionBarman : Form
    {

        private int idBar;
        public gestionBarman(int idBar)
        {
            InitializeComponent();
            this.idBar = idBar;
        }


        private void Annuler()
        {
            tbNom.Clear();
            tbPrenom.Clear();
            tbMail.Clear();
            tbMdp.Clear();
            dtArriver.Value = DateTime.Now;
        }

        private void btn_ajout_Click(object sender, EventArgs e)
        {
            string nom, prenom, mail, passwordHash;
            bool estDirigeant = false;
            DateTime dateA;
            nom = tbNom.Text;
            prenom = tbPrenom.Text;
            mail = tbMail.Text;
            passwordHash = BCrypt.Net.BCrypt.HashPassword(tbMdp.Text);
            dateA = dtArriver.Value;

            estDirigeant = cbOui.Checked;


            if (Modele.Ajoutbarman(idBar, estDirigeant ,nom, prenom, mail, passwordHash, dateA))
            {
                MessageBox.Show("Barman ajouté " + Modele.RetourneDernierBarmanSaisi());
                Annuler();
            }
        }

        private void tbNom_TextChanged(object sender, EventArgs e)
        {

        }

        private void cbOui_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void gestionBarman_Load(object sender, EventArgs e)
        {

        }
    }
}
