using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AP4_BAR
{


    public static class Modele
    {


        private static riledhouEntities maConnexion;

        public static void init()
        {
            maConnexion = new riledhouEntities();
        }

        public static List<BARMAN> listeBarman()
        {
            return maConnexion.BARMAN.ToList();
        }

        public static List<STOCKER> listeProduit()
        {
            return maConnexion.STOCKER.ToList();
        }

        public static List<BARS> listeBar()
        {
            return maConnexion.BARS.ToList();
        }
        

        public static int verifDirigeant(string mail, string password)
        {

            //string passwordHash = BCrypt.Net.BCrypt.HashPassword(password);

            foreach (BARMAN barman in listeBarman())
            {
                if (barman.ESTDIRIGEANT == true)
                {
                    if (barman.MAIL == mail && barman.MDP == password)
                    {
                        return barman.ID_BAR;
                    }
                }  
            }
            return -1;
        }

        public static int RetourneDernierProduitSaisi()
        {
            return maConnexion.STOCKER.Max(x => x.ID_PRODUIT);
        }

        public static STOCKER RecupererProduit(int idP)
        {
            STOCKER unProduit = new STOCKER();
            try
            {
                unProduit = maConnexion.STOCKER.First(x => x.ID_PRODUIT == idP);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
            return unProduit;
        }

        public static PRODUIT RecupererPRODUIT(int idproduit)
        {
            PRODUIT produit = new PRODUIT();
            try
            {
                produit = maConnexion.PRODUIT.First(x => x.ID_PRODUIT == idproduit);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
            return produit;
        }

        public static bool AjoutPRODUIT(int idproduit, int idbar, long quantite, long prix)
        {
            STOCKER stocker;
            bool vretour = true;
            try
            {
                stocker = new STOCKER();
                stocker.ID_BAR = idbar;
                stocker.ID_PRODUIT = idproduit;
                stocker.QUANTITESTOCK = quantite;
                stocker.PRIX = prix;
            }
            catch (Exception ex)
            {
                vretour = false;
                MessageBox.Show(ex.Message.ToString());
            }
            return vretour;
        }

        public static bool Ajoutproduit(int idproduit, string nomproduit)
        {
            PRODUIT produit;
            bool vretour = true;
            try
            {
                produit = new PRODUIT();
                produit.ID_PRODUIT = idproduit;
                produit.NOM_PRODUIT = nomproduit;
            }
            catch (Exception ex)
            {
                vretour = false;
                MessageBox.Show(ex.Message.ToString());
            }
            return vretour;
        }

        public static bool ModificationProduit(int idproduit, int idbar, long quantite, long prix)
        {
            STOCKER unproduit;
            bool vretour = true;
            try
            {
                // récupération de l'hackathon à modifier
                unproduit = RecupererProduit(idproduit);

                // mise à jour des champs de l'hackathon
                unproduit.ID_BAR = idbar;
                unproduit.ID_PRODUIT = idproduit;
                unproduit.QUANTITESTOCK = quantite;
                unproduit.PRIX = prix;

                maConnexion.SaveChanges();
            }
            catch (Exception ex)
            {
                vretour = false;
                MessageBox.Show(ex.Message.ToString());
            }
            return vretour;
        }

        public static PRODUIT produit;
        public static bool SupprProduit(int idproduit)
        {
            bool vretour = true;
            try
            {
                produit = RecupererPRODUIT(idproduit);
                maConnexion.PRODUIT.Remove(produit);    
                maConnexion.SaveChanges();
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message + " " + ex.InnerException.InnerException.Message);
                vretour = false;
            }
            return vretour;
        }


    }
}
