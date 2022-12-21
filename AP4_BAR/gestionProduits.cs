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
    public enum EtatGestion
    {
        Create,
        Create2,
        Update
    }
    public partial class gestionProduits : Form
    {
        private EtatGestion etat;
        private int idBar;
        public gestionProduits(EtatGestion etat, int idBar)
        {
            InitializeComponent();
            this.etat = etat;
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

        private void gestionProduits_Load(object sender, EventArgs e)
        {
            RemplirListeBar();
            if (etat == EtatGestion.Create) // cas etat create
            {
                label1.Text = "Ajout d'un produit global";
                btn_ajout.Text = "AJOUTER";
                cbListeBar.Visible = false;
                tbPrix.Visible = false;
                tbProduit.Visible = false;
                cbListeBar.Enabled = false;
                cbListeBar.SelectedValue = idBar;
            }
            else if (etat == EtatGestion.Create2) // cas etat create
            {
                label1.Text = "Ajout d'un produit dans votre bar";
                btn_ajout.Text = "AJOUTER";
                cbListeBar.Visible = true;
                cbListeBar.Enabled = false;
                cbListeBar.SelectedValue = idBar;
            }
            else // cas etat update
            {
                label1.Text = "Modification d'un produit";
                btn_ajout.Text = "MODIFIER";
                cbListeBar.Visible = true;
                cbListeBar.SelectedValue = idBar;
                cbListeBar.Enabled = true;
                RemplirListeBar();
            }
        }

        private void Annuler()
        {
            tbProduit.Clear();
            tbQte.Clear();
            tbPrix.Clear();
        }

        private void Button_Click(object sender, EventArgs e)
        {
            int idproduit, qte, prix;
            string nomProd;
            nomProd = tbProduit.Text;
            qte = Convert.ToInt32(tbQte.Text);
            prix = Convert.ToInt32(tbPrix.Text);



            if (etat == EtatGestion.Create) // cas de l'ajout
            {

                idproduit = Modele.RetourneDernierProduitSaisi() + 1;

                // ajouter produit dans produit

                if (Modele.Ajoutproduit(idproduit, nomProd))
                {
                    MessageBox.Show("Produit ajouté " + Modele.RetourneDernierProduitSaisi());
                    Annuler();
                }

                if (Modele.AjoutPRODUIT(idproduit, idBar, qte, prix))
                {
                    MessageBox.Show("Produit ajouté " + Modele.RetourneDernierProduitSaisi());
                    Annuler();
                }
            }
            if (etat == EtatGestion.Update) // cas de la mise à jour
            {
                STOCKER P = (STOCKER)bsBar.Current;
                if (Modele.ModificationProduit(P.ID_PRODUIT, P.ID_BAR, Convert.ToInt32(P.QUANTITESTOCK), Convert.ToInt32(P.PRIX)))
                {
                    MessageBox.Show("Produit modifié");
                    cbListeBar.SelectedIndex = -1;
                    // Annuler();
                }
            }
        }
    }
}
