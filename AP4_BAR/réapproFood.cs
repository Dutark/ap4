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
    public partial class réapproFood : Form
    {
        private int idBar;
        public réapproFood(int idBar)
        {
            InitializeComponent();
            this.idBar = idBar;
        }

        public void RemplirListeBar()
        {
            cbListeBar.ValueMember = "ID_BAR";
            cbListeBar.DisplayMember = "NOMBAR";
            bsBar.DataSource = Modele.listeBar();
            cbListeBar.DataSource = bsBar;
            cbListeBar.SelectedIndex = -1;
        }

        public void RemplirListeProduitsF()
        {
            cbProd.ValueMember = "ID_PRODUIT";
            cbProd.DisplayMember = "NOM_PRODUIT";

            List<view_nourriture> lesP = new List<view_nourriture>();
            List<view_nourriture> lesPAffiche = new List<view_nourriture>();
            lesP = Modele.listeProduitFo();
            // REFAIRE LES VUES
            foreach (view_nourriture s in lesP)
            {
                lesPAffiche.Add(s);
            }

            bsProduits.DataSource = lesPAffiche;
            cbProd.DataSource = bsProduits;
            cbProd.SelectedIndex = -1;
        }

        private void réapproFood_Load(object sender, EventArgs e)
        {
            RemplirListeBar();
            RemplirListeProduitsF();
            cbListeBar.SelectedValue = idBar;
            cbListeBar.Enabled = false;
        }

        private void Annuler()
        {
            tbQte.Clear();
            tbPrix.Clear();
            tbPoids.Clear();
        }

        private void btn_ajout_Click(object sender, EventArgs e)
        {
            int idproduit, prix, qte;
            int poids;
            idproduit = Convert.ToInt32(cbProd.SelectedValue);

            STOCKER p = Modele.RecupererProduit(idproduit);
            qte = Convert.ToInt32(tbQte.Text) + Convert.ToInt32(p.QUANTITESTOCK);
            prix = Convert.ToInt32(tbPrix.Text);
            poids = Convert.ToInt32(tbPoids.Text);
            if (Modele.ModificationProduit(idproduit, idBar, qte, prix))
            {
                if (Modele.ModificationPRODUITSOFT(idproduit, poids))
                {
                    MessageBox.Show("Produit dans votre bar modifié ");
                    Annuler();
                }
            }
        }
    }
}
