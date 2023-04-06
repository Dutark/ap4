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
    public partial class listeBarman : Form
    {
        private int idBar;
        public listeBarman(int idBar)
        {
            InitializeComponent();
            this.idBar = idBar;
        }

        private void listeBarman_Load(object sender, EventArgs e)
        {
            bsBarman.DataSource = Modele.listeBarman().Select(x => new
            {
                x.ID_BAR,
                x.NOM,
                x.PRENOM,
                x.MAIL
            }).Where(x => x.ID_BAR == idBar);

            //ici j'ajoute des infos dans l'header
            dgvBarman.DataSource = bsBarman;
            dgvBarman.Columns[0].HeaderText = "Id du bar"; //Yo
            dgvBarman.Columns[1].HeaderText = "Nom du barman"; //Yo
            dgvBarman.Columns[2].HeaderText = "Prénom du barman"; //Yo
            dgvBarman.Columns[3].HeaderText = "Mail du barman"; //Mr brosseau le POAT
        }

        private void btn_suppr_Click(object sender, EventArgs e)
        {
            System.Type type = bsBarman.Current.GetType();
            int idBarman = (int)type.GetProperty("ID_USER").GetValue(bsBarman.Current, null);

            if (MessageBox.Show("Etes vous sur de vouloir supprimer la tesla : " + idBarman, "Suppression", MessageBoxButtons.YesNoCancel) == DialogResult.Yes)
            {
                Modele.SupprProduit(idBarman);
                string message2 = "Le barman a bien été supprimé !";
                MessageBox.Show(message2);
            }
        }

        private void dgvBarman_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
