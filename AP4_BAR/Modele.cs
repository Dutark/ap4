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
        public static List<PRODUIT> listeProduitProd()
        {
            return maConnexion.PRODUIT.ToList();
        }
        public static List<view_boisson_alcool> listeProduitAl()
        {
            return maConnexion.view_boisson_alcool.ToList();
        }
        public static List<view_boisson_sans_alcool> listeProduitSo()
        {
            return maConnexion.view_boisson_sans_alcool.ToList();
        }
        public static List<view_nourriture> listeProduitFo()
        {
            return maConnexion.view_nourriture.ToList();
        }
        public static List<BARS> listeBar()
        {
            return maConnexion.BARS.ToList();
        }
        

        public static int verifDirigeant(string mail, string password)
        {

            string passwordHash = BCrypt.Net.BCrypt.HashPassword(password);
            bool verified = BCrypt.Net.BCrypt.Verify(password, passwordHash);

            foreach (BARMAN barman in listeBarman())
            {
                if (barman.ESTDIRIGEANT == true)
                {
                    if (barman.MAIL == mail && barman.MDP == passwordHash)
                    {
                        return barman.ID_BAR;
                    }
                }  
            }
            return -1;
        }

        public static int RetourneDernierProduitSaisi()
        {
            return maConnexion.PRODUIT.Max(x => x.ID_PRODUIT);
        }

        public static int RetourneDernierBarmanSaisi()
        {
            return maConnexion.BARMAN.Max(x => x.ID_USER);
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

        public static BOISSON RecupererProduitBoisson(int idproduit)
        {
            BOISSON boisson = new BOISSON();
            try
            {
                boisson = maConnexion.BOISSON.First(x => x.ID_PRODUIT == idproduit);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
            return boisson;
        }

        public static NOURRITURE RecupererProduitFOOD(int idproduit)
        {
            NOURRITURE food = new NOURRITURE();
            try
            {
                food = maConnexion.NOURRITURE.First(x => x.ID_PRODUIT == idproduit);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
            return food;
        }

        public static BARMAN RecupererBARMAN(int idbarman)
        {
            BARMAN barman = new BARMAN();
            try
            {
                barman = maConnexion.BARMAN.First(x => x.ID_USER == idbarman);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
            return barman;
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
                maConnexion.STOCKER.Add(stocker);
                maConnexion.SaveChanges();
            }
            catch (Exception ex)
            {
                vretour = false;
                MessageBox.Show(ex.Message.ToString());
            }
            return vretour;
        }

        public static bool Ajoutproduit(string nomproduit)
        {
            PRODUIT produit;
            bool vretour = true;
            try
            {
                produit = new PRODUIT();
                produit.NOM_PRODUIT = nomproduit;
                maConnexion.PRODUIT.Add(produit);
                maConnexion.SaveChanges();
            }
            catch (Exception ex)
            {
                vretour = false;
                MessageBox.Show(ex.Message.ToString());
            }
            return vretour;
        }

        public static bool AjoutproduitNourriture(int idproduit, int poids)
        {
            NOURRITURE nourriture;
            bool vretour = true;
            try
            {
                nourriture = new NOURRITURE();
                nourriture.POIDS = poids;
                nourriture.ID_PRODUIT = idproduit;
                maConnexion.NOURRITURE.Add(nourriture);
                maConnexion.SaveChanges();
            }
            catch (Exception ex)
            {
                vretour = false;
                MessageBox.Show(ex.Message.ToString());
            }
            return vretour;
        }

        public static bool AjoutproduitAlcoolise(int idproduit, bool estAlcooolise, int degreeAlcool, int volume)
        {
            BOISSON boisson;
            bool vretour = true;
            try
            {
                boisson = new BOISSON();
                boisson.DEGREALCOOL = degreeAlcool;
                boisson.VOLUME = volume;
                boisson.ESTALCOOLISE = estAlcooolise;
                boisson.ID_PRODUIT = idproduit;
                maConnexion.BOISSON.Add(boisson);
                maConnexion.SaveChanges();
            }
            catch (Exception ex)
            {
                vretour = false;
                MessageBox.Show(ex.Message.ToString());
            }
            return vretour;
        }

        public static bool AjoutproduitSoft(int idproduit, bool estAlcooolise, int volume)
        {
            BOISSON boisson;
            bool vretour = true;
            try
            {
                boisson = new BOISSON();
                boisson.VOLUME = volume;
                boisson.ESTALCOOLISE = estAlcooolise;
                boisson.ID_PRODUIT = idproduit;
                maConnexion.BOISSON.Add(boisson);
                maConnexion.SaveChanges();
            }
            catch (Exception ex)
            {
                vretour = false;
                MessageBox.Show(ex.Message.ToString());
            }
            return vretour;
        }

        public static bool Ajoutbarman(int idBar, bool estDirigeant, string nom, string prenom, string mail, string mdp, DateTime dtarriver)
        {
            BARMAN barman;
            bool vretour = true;
            try
            {
                barman = new BARMAN();
                barman.ID_BAR = idBar;
                barman.ESTDIRIGEANT = estDirigeant;
                barman.ESTBARMAN= true;
                barman.NOM = nom;
                barman.PRENOM = prenom;
                barman.MAIL = mail;
                barman.MDP = mdp;
                barman.DATE_ARRIVER = dtarriver;    
                maConnexion.BARMAN.Add(barman);
                maConnexion.SaveChanges();
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

        public static bool ModificationPRODUITALCOOL(int idproduit, int degA, int volume)
        {
            BOISSON unproduit;
            bool vretour = true;
            try
            {
                // récupération de l'hackathon à modifier
                unproduit = RecupererProduitBoisson(idproduit);

                // mise à jour des champs de l'hackathon
                unproduit.ID_PRODUIT = idproduit;
                unproduit.DEGREALCOOL = degA;
                unproduit.VOLUME = volume;

                maConnexion.SaveChanges();
            }
            catch (Exception ex)
            {
                vretour = false;
                MessageBox.Show(ex.Message.ToString());
            }
            return vretour;
        }

        public static bool ModificationPRODUITSOFT(int idproduit, int volume)
        {
            BOISSON unproduit;
            bool vretour = true;
            try
            {
                // récupération de l'hackathon à modifier
                unproduit = RecupererProduitBoisson(idproduit);

                // mise à jour des champs de l'hackathon
                unproduit.ID_PRODUIT = idproduit;
                unproduit.VOLUME = volume;

                maConnexion.SaveChanges();
            }
            catch (Exception ex)
            {
                vretour = false;
                MessageBox.Show(ex.Message.ToString());
            }
            return vretour;
        }

        public static bool ModificationPRODUITFOOD(int idproduit, int poids)
        {
            NOURRITURE unproduit;
            bool vretour = true;
            try
            {
                // récupération de l'hackathon à modifier
                unproduit = RecupererProduitFOOD(idproduit);
                // mise à jour des champs de l'hackathon
                unproduit.ID_PRODUIT = idproduit;
                unproduit.POIDS = poids;
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

        public static BARMAN barman;
        public static bool SupprBarman(int idbarman)
        {
            bool vretour = true;
            try
            {
                barman = RecupererBARMAN(idbarman);
                maConnexion.BARMAN.Remove(barman);
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
