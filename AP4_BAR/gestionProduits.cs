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
    public enum TypeProduit
    {
        BoissonAlcoolisé,
        BoissonSoft,
        Nourriture
    }

    public partial class gestionProduits : Form
    {
        private EtatGestion etat;
        private TypeProduit type;
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
                btn_ajout.Text = "AJOUTER";
                
                lbType.Visible = true; 
                lbNomProd.Visible = false; 
                lbNomBar.Visible = false; 
                lbQte.Visible = false; 
                lbPrix.Visible = false; 
                lbDegA.Visible = false; 
                lbVol.Visible = false;
                lbPoids.Visible = false;


                tbProduit.Visible = false;
                cbListeBar.Visible = false;
                cbListeBar.Enabled = false;
                cbTypeP.Visible = true;
                tbQte.Visible = false;
                tbPrix.Visible = false;
                tbDeg.Visible = false;
                tbVol.Visible = false;
                tbPoids.Visible = false;
                cbListeBar.SelectedValue = idBar;
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
            int idproduit, qte, prix, degreAlcool, volume, poids;
            string nomProd;
            bool estAlcoolise;

            nomProd = tbProduit.Text;
            qte = Convert.ToInt32(tbQte.Text);
            prix = Convert.ToInt32(tbPrix.Text);
            
            
            estAlcoolise = true;


            if (cbTypeP.SelectedItem.ToString() == "Boisson Alcoolisé")
            {
                type = TypeProduit.BoissonAlcoolisé;
            }

            if (cbTypeP.SelectedItem.ToString() == "Boisson Soft")
            {
                type = TypeProduit.BoissonSoft;
                volume = Convert.ToInt32(tbVol.Text);
            }

            if (cbTypeP.SelectedItem.ToString() == "Nourriture")
            {
                type = TypeProduit.Nourriture;
            }

            if (etat == EtatGestion.Create) // cas de l'ajout
            {

                if (Modele.Ajoutproduit(nomProd))
                {
                    MessageBox.Show("Produit global ajouté " + Modele.RetourneDernierProduitSaisi());
                    idproduit = Modele.RetourneDernierProduitSaisi();

                    if (Modele.AjoutPRODUIT(idproduit, idBar, qte, prix))
                    {
                        MessageBox.Show("Produit dans votre bar ajouté en stock " + idproduit);

                        if (type == TypeProduit.BoissonAlcoolisé)
                        {
                            degreAlcool = Convert.ToInt32(tbDeg.Text);
                            volume = Convert.ToInt32(tbVol.Text);
                            if (Modele.AjoutproduitAlcoolise(idproduit, true, degreAlcool, volume))
                            {
                                MessageBox.Show("Produit alcoolisé ajouté " + idproduit);
                            }
                        }

                        if (type == TypeProduit.BoissonSoft)
                        {
                            volume = Convert.ToInt32(tbVol.Text);
                            if (Modele.AjoutproduitSoft(idproduit, false, volume))
                            {
                                MessageBox.Show("Produit soft ajouté " + idproduit);
                            }
                        }

                        if (type == TypeProduit.Nourriture)
                        {
                            poids = Convert.ToInt32(tbPoids.Text);
                            if (Modele.AjoutproduitNourriture(idproduit, poids))
                            {
                                MessageBox.Show("Produit nourriture ajouté " + idproduit);
                            }

                        }
                    }
                }

            }
        }

        private void cbTypeP_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbTypeP.SelectedIndex == 0)
            {
                type = TypeProduit.BoissonAlcoolisé;
            }

            if (cbTypeP.SelectedIndex == 1)
            {
                type = TypeProduit.BoissonSoft;
            }

            if (cbTypeP.SelectedIndex == 2)
            {
                type = TypeProduit.Nourriture;
            }

            if (type == TypeProduit.BoissonAlcoolisé)
            {
                btn_ajout.Text = "AJOUTER";
                lbType.Visible = true;
                lbNomProd.Visible = true;
                lbNomBar.Visible = true;
                lbQte.Visible = true;
                lbPrix.Visible = true;
                lbDegA.Visible = true;
                lbVol.Visible = true;
                lbPoids.Visible = false;


                tbProduit.Visible = true;
                cbListeBar.Visible = true;
                cbListeBar.Enabled = false;
                cbTypeP.Visible = true;
                tbQte.Visible = true;
                tbPrix.Visible = true;
                tbDeg.Visible = true;
                tbVol.Visible = true;
                tbPoids.Visible = false;
                cbListeBar.SelectedValue = idBar;
            }

            if (type == TypeProduit.BoissonSoft)
            {
                btn_ajout.Text = "AJOUTER";
                lbType.Visible = true;
                lbNomProd.Visible = true;
                lbNomBar.Visible = true;
                lbQte.Visible = true;
                lbPrix.Visible = true;
                lbDegA.Visible = false;
                lbVol.Visible = true;
                lbPoids.Visible = false;


                tbProduit.Visible = true;
                cbListeBar.Visible = true;
                cbListeBar.Enabled = false;
                cbTypeP.Visible = true;
                tbQte.Visible = true;
                tbPrix.Visible = true;
                tbDeg.Visible = false;
                tbVol.Visible = true;
                tbPoids.Visible = false;
                cbListeBar.SelectedValue = idBar;
            }

            if (type == TypeProduit.Nourriture)
            {
                btn_ajout.Text = "AJOUTER";
                lbType.Visible = true;
                lbNomProd.Visible = true;
                lbNomBar.Visible = true;
                lbQte.Visible = true;
                lbPrix.Visible = true;
                lbDegA.Visible = false;
                lbVol.Visible = false;
                lbPoids.Visible = true;


                tbProduit.Visible = true;
                cbListeBar.Visible = true;
                cbListeBar.Enabled = false;
                cbTypeP.Visible = true;
                tbQte.Visible = true;
                tbPrix.Visible = true;
                tbDeg.Visible = false;
                tbVol.Visible = false;
                tbPoids.Visible = true;
                cbListeBar.SelectedValue = idBar;
            }

        }
    }
}
