using mission2.DAL;
using mission2.Modele;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mission2.DAL
{
    internal class SecteurDAO
    {

        private static string provider = "localhost";

        private static string dataBase = "bd_sicilylines";

        private static string uid = "Afrid";

        private static string mdp = "Afrid77";



        private static Connexion maConnexionSql;


        private static MySqlCommand com;

        // methode pour recupere la liste des secteurs
        public static List<Secteur> GetSecteur()
        {
            // creation d'une liste de secteur vide
            List<Secteur> lc = new List<Secteur>();

            try
            {

                maConnexionSql = Connexion.getInstance(provider, dataBase, uid, mdp);

                // on ouvre la connexion a la bdd
                maConnexionSql.openConnection();

                // on fait notre requete pour recuperer les secteurs
                com = maConnexionSql.reqExec("Select * from secteur");

                // on execute la requete
                MySqlDataReader reader = com.ExecuteReader();

                // creation d'un varaiable s de la class secteur
                Secteur s;

                //parcourir l'execution de la requete avec une boucle pour prendre nos donnée necessaire
                while (reader.Read())
                {

                    // affectation des valeur par l'indice de la table secteur nom -> indice 1 et id -> indice 0
                    string nom = (string)reader.GetValue(1);
                    int id = (int)reader.GetValue(0);

                    // instancier le Secteur avec l'id et le nom qu'on a recuperer de la bdd
                    s = new Secteur(id, nom);

                    // ajout des secteurs dans la list qu'on a creer
                    lc.Add(s);


                }
                // fermeture du reader 
                reader.Close();

                // fermeture de la connexion
                maConnexionSql.closeConnection();


                



            }

            catch (Exception emp)
            {

                throw (emp); 

            }
            // retourner la liste des secteurs creer
            return (lc);

        }
    }
}