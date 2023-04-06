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
    public partial class réapproBoissonS : Form
    {
        private int idBar;
        public réapproBoissonS(int idBar)
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


        public void RemplirListeProduitsS()
        {
            cbProd.ValueMember = "ID_PRODUIT";
            cbProd.DisplayMember = "NOM_PRODUIT";

            List<view_boisson_sans_alcool> lesP = new List<view_boisson_sans_alcool>();
            List<view_boisson_sans_alcool> lesPAffiche = new List<view_boisson_sans_alcool>();
            lesP = Modele.listeProduitSo();
            // REFAIRE LES VUES
            foreach (view_boisson_sans_alcool s in lesP)
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

        private void réapproBoissonS_Load(object sender, EventArgs e)
        {
            RemplirListeBar();
            RemplirListeProduitsS();
            cbListeBar.SelectedValue = idBar;
            cbListeBar.Enabled = false;
        }

        private void Annuler()
        {
            tbQte.Clear();
            tbPrix.Clear();
            tbVolume.Clear();
        }

        private void btn_ajout_Click(object sender, EventArgs e)
        {
            int idproduit, prix, qte;
            int volume;
            idproduit = Convert.ToInt32(cbProd.SelectedValue);

            STOCKER p = Modele.RecupererProduit(idproduit);
            qte = Convert.ToInt32(tbQte.Text) + Convert.ToInt32(p.QUANTITESTOCK);
            prix = Convert.ToInt32(tbPrix.Text);
            volume = Convert.ToInt32(tbVolume.Text);
            if (Modele.ModificationProduit(idproduit, idBar, qte, prix))
            {
                if (Modele.ModificationPRODUITSOFT(idproduit, volume))
                {
                    MessageBox.Show("Produit dans votre bar modifié ");
                    Annuler();
                }
            }
        }

        private void cbProd_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
