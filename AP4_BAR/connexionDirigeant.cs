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
    public partial class connexionDirigeant : Form
    {
        public connexionDirigeant()
        {
            InitializeComponent();
        }

        private void btn_connect_Click(object sender, EventArgs e)
        {

            

            if (txt_login.Text == "" || txt_mdp.Text == "")
            {
                string message = "Erreur, vous n'avez pas rempli correctement les champs !";
                MessageBox.Show(message);
            }
            else
            {
                int idBar = Modele.verifDirigeant(txt_login.Text, txt_mdp.Text);
                if (idBar != -1)
                {
                    string message2 = "Connexion réussie !";
                    MessageBox.Show(message2);
                    Accueil accueil = new Accueil(idBar);
                    accueil.ShowDialog();
                    this.Hide();
                }
                else
                {
                    string message3 = "Connexion échouée !";
                    MessageBox.Show(message3);
                }

            }
        }

        private void connexionDirigeant_Load(object sender, EventArgs e)
        {

        }
    }
}
