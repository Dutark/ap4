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
    public partial class listeProduits : Form
    {

        private int idBar;
        public listeProduits(int idBar)
        {
            InitializeComponent();
            this.idBar = idBar;
        }

        private void ajoutProduit_Load(object sender, EventArgs e)
        {
            bsProduits.DataSource = Modele.listeProduit().Select(x => new
            {
                x.ID_BAR,
                x.BARS.NOMBAR,
                x.PRODUIT.NOM_PRODUIT,
                //x.PRODUIT.BOISSON.ESTALCOOLISE,
                x.QUANTITESTOCK,
                x.PRIX

            }).Where(x => x.ID_BAR == idBar);

            //ici j'ajoute des infos dans l'header
            dgvProduits.DataSource = bsProduits;
            dgvProduits.Columns[0].HeaderText = "Id du bar"; //Yo
            dgvProduits.Columns[1].HeaderText = "Nom du bar"; //Yo
            dgvProduits.Columns[2].HeaderText = "Nom du produit"; //Yo
            //dgvProduits.Columns[2].HeaderText = "Est alcoolisé"; //Yo
            dgvProduits.Columns[3].HeaderText = "Quantité du produit"; //Mr brosseau le POAT
            dgvProduits.Columns[4].HeaderText = "Prix du produit"; //le prix de la tesla model S
        }

        private void btn_suppr_Click_1(object sender, EventArgs e)
        {
            System.Type type = bsProduits.Current.GetType();
            int idProduit = (int)type.GetProperty("ID_PRODUIT").GetValue(bsProduits.Current, null);

            if (MessageBox.Show("Etes vous sur de vouloir supprimer la tesla : " + idProduit, "Suppression", MessageBoxButtons.YesNoCancel) == DialogResult.Yes)
            {
                Modele.SupprProduit(idProduit);
                string message2 = "Le produit a bien été supprimé !";
                MessageBox.Show(message2);
            }
        }

        private void BtnFermer_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvProduits_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dgvProduits.Visible = false;
        }

        private void dgvProduits_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            dgvProduits.Visible = false;
        }

        private void dgvProduits_Click(object sender, EventArgs e)
        {
            dgvProduits.Visible = false;
        }

        private void BtnFermer_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvProduits_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
