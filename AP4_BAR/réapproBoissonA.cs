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
    public partial class réapproBoissonA : Form
    {
        private int idBar;
        public réapproBoissonA(int idBar)
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

        public void RemplirListeProduitsA()
        {
            cbProd.ValueMember = "ID_PRODUIT";
            cbProd.DisplayMember = "NOM_PRODUIT";
         
            List<view_boisson_alcool> lesP = new List<view_boisson_alcool>();
            List<view_boisson_alcool> lesPAffiche = new List<view_boisson_alcool>();
            lesP = Modele.listeProduitAl();
            // REFAIRE LES VUES
            foreach (view_boisson_alcool s in lesP)
            {
                if (s.ID_BAR == idBar) 
                {
                   lesPAffiche.Add(s);
                }
            }

            bsProduits.DataSource = lesPAffiche;
            cbProd.DataSource = bsProduits;
            cbProd.SelectedIndex = -1;
        }

        private void Annuler()
        {
            tbQte.Clear();
            tbPrix.Clear();
            tbVolume.Clear();
            tbDegA.Clear();
        }

        private void btn_ajout_Click(object sender, EventArgs e)
        {
            int idproduit, prix, qte;
            int degA, volume;

            idproduit = Convert.ToInt32(cbProd.SelectedValue);

            STOCKER p = Modele.RecupererProduit(idproduit);
            qte = Convert.ToInt32(tbQte.Text) + Convert.ToInt32(p.QUANTITESTOCK);
            prix = Convert.ToInt32(tbPrix.Text);
            degA = Convert.ToInt32(tbDegA.Text);
            volume = Convert.ToInt32(tbVolume.Text);
            if (Modele.ModificationProduit(idproduit, idBar, qte, prix))
            {
                if (Modele.ModificationPRODUITALCOOL(idproduit, degA, volume))
                {
                    MessageBox.Show("Produit dans votre bar modifié ");
                    Annuler();
                } 
            }

        }

        private void réapproBoissonA_Load(object sender, EventArgs e)
        {
            RemplirListeBar();
            RemplirListeProduitsA();
            cbListeBar.SelectedValue = idBar;
            cbListeBar.Enabled = false;

        }
    }
}
