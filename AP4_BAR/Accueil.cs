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
    public partial class Accueil : Form
    {

        private int idBar;
        public Accueil(int idBar)
        {
            InitializeComponent();
            this.idBar = idBar;
        }

        public Form activeForm = null;
        public void openChildForm(Form formEnfant)
        {
            if (activeForm != null)
                activeForm.Close();

            activeForm = formEnfant;
            formEnfant.TopLevel = false;
            formEnfant.FormBorderStyle = FormBorderStyle.None;
            formEnfant.Dock = DockStyle.Fill;
            panelPrincipal.Controls.Add(formEnfant);
            panelPrincipal.Tag = formEnfant;
            formEnfant.BringToFront();
            formEnfant.Show();
        }

        private void quitterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void déconnexionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            connexionDirigeant conn = new connexionDirigeant();
            conn.Show();
            this.Hide();
        }

        private void lISTEDESPRODUITSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openChildForm(new FormProduits(idBar));
        }

        private void aJOUTPRODUITToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openChildForm(new gestionProduits(EtatGestion.Create2, idBar));
        }


        private void modificationDunProduitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openChildForm(new gestionProduits(EtatGestion.Update, idBar));
        }
    }
}
