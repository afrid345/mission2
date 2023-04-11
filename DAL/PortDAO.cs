using mission2.Modele;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mission2.DAL
{
    internal class PortDAO
    {



        private static string provider = "localhost";

        private static string dataBase = "bd_sicilylines";

        private static string uid = "Afrid";

        private static string mdp = "Afrid77";



        private static Connexion maConnexionSql;


        private static MySqlCommand com;

        // methode pour recupere la liste des ports
        public static List<Port> GetPort()
        {
            // creation d'une liste de port vide
            List<Port> lc = new List<Port>();

            try
            {

                maConnexionSql = Connexion.getInstance(provider, dataBase, uid, mdp);

                // on ouvre la connexion a la bdd
                maConnexionSql.openConnection();

                // on fait notre requete pour recuperer les ports
                com = maConnexionSql.reqExec("Select * from port");


                // on execute la requete
                MySqlDataReader reader = com.ExecuteReader();

                // creation d'un varaiable p de la class port
                Port p;

                //parcourir l'execution de la requete avec une boucle pour prendre nos donnée necessaire
                while (reader.Read())
                {

                    // affectation des valeur par l'indice de la table port nom -> indice 1 et id -> indice 0
                    string nom = (string)reader.GetValue(1);
                    int id = (int)reader.GetValue(0);

                    // instancier le port avec l'id et le nom qu'on a recuperer de la bdd
                    p = new Port(id, nom);


                    // ajout des ports dans la list qu'on a creer
                    lc.Add(p);


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
            // retourner la liste des ports creer
            return (lc);

        }
    }
}