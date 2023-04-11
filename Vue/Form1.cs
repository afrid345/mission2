using mission2.DAL;
using mission2.Modele;
using mission2.Controleur;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mission2
{

    public partial class Form1 : Form
    {

        //pour rentrer un objet dans une listbox on peux faire :
        //- listbox.Items.Add(objet) // Ajoute un objet
        //- listox.Datasource = listeObjet // Ajoute toute la liste 


        // creation d'une list de secteur 
        List<Secteur> ls = new List<Secteur>() ;

        //instancier un controlleur
        Controleurs UnControlleur;
        public Form1()
        {
            InitializeComponent();
            //Creation d'un crontrolleur
            UnControlleur = new Controleurs();
        }

        // data source = null au debu pour eviter les bugs ,il prend dans la listbox du secteur les donnée de la liste des secteur crée
        // (datasource) et lorsqu'il va afficher on a mis un .to string c'est une méthode qui affiche notre objet sous forme de chaînes
        // de caractères (pour le décrire par exemple).
        public void afficher()
        {
            listboxSecteur.DataSource = null;

            listboxSecteur.DataSource = ls;
            // affiche ce qui a dans la methode .toString
            listboxSecteur.DisplayMember = ".Tostring";
        }


        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void secteur_TextChanged(object sender, EventArgs e)
        {


        }


       
        private void Form1_Load_1(object sender, EventArgs e)
        {
            //Affichage des secteur dans la listbox avec la methode GetSecteur() cree dans SecteurDAO.cs
            //(dans premier box)
            listboxSecteur.DataSource = SecteurDAO.GetSecteur();

        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
            
        }

        private void liaison_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void secteur_SelectedIndexChanged(object sender, EventArgs e)
        {
            // il met dans la variable secteur l'objet seclection dans la list box des secteur et le renomme en Secteur
            var secteur = listboxSecteur.SelectedItem as Secteur;

            //data source = null au debu pour eviter les bugs
            listboxLiaison.DataSource = null;

            // Recuperation du liaison pour un secteur precis d'ou l'importance de passer l'id du secteur en parametre 
            // (dans le deuxieme box)
            listboxLiaison.DataSource = LiaisonDAO.GetLiaison(secteur.getID());
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }


        //l'ajout
        private void ajouter_Click(object sender, EventArgs e)
        {
            Secteur secteur = listboxSecteur.SelectedItem as Secteur;
            Liaison add_liaison = listboxLiaison.SelectedItem as Liaison;

            // initier les valeur pour la creation de l'objet

            int add_id = LiaisonDAO.GetAllLiaison().Count+1;
            //string add_duree = duree.Text;
            Secteur add_secteur = secteur;
            // Port add_depart = textDepart.SelectedItem as Port;
              //Port add_arrivee = textArrivee.SelectedItem as Port;

           // LiaisonDAO.ajoutLiaison(add_id, add_duree, add_depart, add_arrivee,secteur.getID()) ;

            listboxLiaison.DataSource = null;
            listboxLiaison.DataSource = LiaisonDAO.GetLiaison(secteur.getID());



        }

        //la supresseion
        private void supprimer_Click(object sender, EventArgs e)
        {
            try
            {
                // creation d'une liaison de type liaison qu'on assigne a l'objet selectionne dans la listbox
                // de la liaison et on le caste pour dire que c'est bien un liaion qu'on recupere
                Liaison uneLiaison = (Liaison)listboxLiaison.SelectedItem;

                // appele a la fonction de deleteLiaison passant en parametre l'id de la liaion q'on souhaite supprimer (utilisitaion 
                // de la class liaionDAO.cs
                LiaisonDAO.deleteLiaison(uneLiaison.IdLiaison);

                // il met dans la variable secteur l'objet seclection dans la list box des secteur et le renomme en Secteur
                var secteur = listboxSecteur.SelectedItem as Secteur;


                // Recuperation du liaison pour un secteur precis d'ou l'importance de passer l'id du secteur en parametre
                listboxLiaison.DataSource = LiaisonDAO.GetLiaison(secteur.getID());


                //on a mis un .to string qui est la method qui va afficher(pour afficher comme on desire)
                listboxLiaison.DisplayMember = ".Tostring";

            }

            catch (Exception ex)
            {
                // attrape les erreurs et l'affiche dans le messageBox
                MessageBox.Show(ex.Message);

            }
        }

        
        //la modification
        private void modifier_Click(object sender, EventArgs e)
        {
            // creation d'une liaison de type liaison qu'on assigne a l'objet selectionne dans la listbox
            // de la liaison et on le caste pour dire que c'est bien un liaion qu'on recupere
            Liaison uneLiaison = (Liaison)listboxLiaison.SelectedItem;

            // appele a la fonction de modifLiaison passant en parametre l'id de la liaion q'on souhaite modifer (utilisitaion 
            // de la class liaionDAO.cs
            LiaisonDAO.modifLiaison(uneLiaison.IdLiaison, modifbox.Text);



            // il met dans la variable secteur l'objet seclection dans la list box des secteur et le renomme en Secteur
            var secteur = listboxSecteur.SelectedItem as Secteur;


            // Recuperation du liaison pour un secteur precis d'ou l'importance de passer l'id du secteur en parametre
            listboxLiaison.DataSource = LiaisonDAO.GetLiaison(secteur.getID());


            //on a mis un .to string qui est la method qui va afficher(pour afficher comme on desire)
            listboxLiaison.DisplayMember = ".Tostring";
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged_2(object sender, EventArgs e)
        {

        }

        private void textDepart_TextChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            var secteur = listboxSecteur.SelectedItem as Secteur;
            listBoxSecteurs.DataSource = LiaisonDAO.GetLiaison(secteur.getID());
        }
    }
}
