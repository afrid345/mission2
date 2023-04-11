using mission2.DAL;
using mission2.Modele;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace mission2.DAL
{
    internal class LiaisonDAO
    {
        private static string provider = "localhost";

        private static string dataBase = "bd_sicilylines";

        private static string uid = "Afrid";

        private static string mdp = "Afrid77";




        private static Connexion maConnexionSql;

        
        private static MySqlCommand com;

        // methode pour recupere la liste des liaisons avec l'id du secteur paser en parametre
        public static List<Liaison> GetLiaison(int idSecteur)
        {
            // creation d'une liste de liaison vide
            List<Liaison> lc = new List<Liaison>();



            try
            {

                maConnexionSql = Connexion.getInstance(provider, dataBase, uid, mdp);

                // on ouvre la connexion a la bdd
                maConnexionSql.openConnection();

                // on fait notre requete pour recuperer les liaisons avec l'id du secteur
                com = maConnexionSql.reqExec("Select * From liaison where idSecteur ="+ idSecteur);


                // on execute la requete
                MySqlDataReader reader = com.ExecuteReader();

                // creation d'un varaiable l de la class liaison
                Liaison l;

                //parcourir l'execution de la requete avec une boucle pour prendre nos donnée necessaire
                while (reader.Read())
                {
                    // affectation des valeur par l'indice de la table liaison id -> indice 0 et duree -> indice 1 
                    int id = (int)reader.GetValue(0);
                    int arrivee = (int)reader.GetValue(3);
                    int depart = (int)reader.GetValue(2);
                    string duree = (string)reader.GetValue(1);
                    int secteur = (int)reader.GetValue(4);



                    // instancier la liaison avec l'id,l'arrivee , le depart , la duree et le secteur qu'on a recuperer de la bdd
                    l = new Liaison(id, arrivee,depart, duree, secteur);

                    // ajout des liaisons dans la list qu'on a creer
                    lc.Add(l);


                }





                // fermeture du reader 
                reader.Close();

                // fermeture de la connexion
                maConnexionSql.closeConnection();

                // retourner la liste creer
                return (lc);


            }

            catch (Exception emp)
            {

                throw (emp);
            }

        }















        // methode pour recupere tous les liaisons 
        public static List<Liaison> GetAllLiaison()
        {
            // creation d'une liste de liaison vide
            List<Liaison> lc = new List<Liaison>();



            try
            {

                maConnexionSql = Connexion.getInstance(provider, dataBase, uid, mdp);

                // on ouvre la connexion a la bdd
                maConnexionSql.openConnection();

                // on fait notre requete pour recuperer les liaisons avec l'id du secteur
                com = maConnexionSql.reqExec("Select * From liaison");


                // on execute la requete
                MySqlDataReader reader = com.ExecuteReader();

                // creation d'un varaiable l de la class liaison
                Liaison l;

                //parcourir l'execution de la requete avec une boucle pour prendre nos donnée necessaire
                while (reader.Read())
                {
                    // affectation des valeur par l'indice de la table liaison id -> indice 0 et duree -> indice 1 
                    int id = (int)reader.GetValue(0);
                    int arrivee = (int)reader.GetValue(3);
                    int depart = (int)reader.GetValue(2);
                    string duree = (string)reader.GetValue(1);
                    int secteur = (int)reader.GetValue(4);



                    // instancier la liaison avec l'id,l'arrivee , le depart , la duree et le secteur qu'on a recuperer de la bdd
                    l = new Liaison(id, arrivee, depart, duree, secteur);

                    // ajout des liaisons dans la list qu'on a creer
                    lc.Add(l);


                }





                // fermeture du reader 
                reader.Close();

                // fermeture de la connexion
                maConnexionSql.closeConnection();

                // retourner la liste creer
                return (lc);


            }

            catch (Exception emp)
            {

                throw (emp);
            }

        }

















        // fonction pour supprimer une liaion avec l'id passer en parametre
        public static void deleteLiaison(int idLiaison)
        {
            try
            {

                maConnexionSql = Connexion.getInstance(provider, dataBase, uid, mdp);

                // on ouvre la connexion a la bdd
                maConnexionSql.openConnection();

                // on fait notre requete qui supprimera la liaion ou l'id sera l'id passer en parametre
                com = maConnexionSql.reqExec("DELETE from liaison where id=" + idLiaison);

                // execution de la requete por les deletes et les modifs
                int i = com.ExecuteNonQuery();

                // fermeture de la connexion
                maConnexionSql.closeConnection();

            }

            catch (Exception emp)
            {

                throw (emp);
            }
        }


        // fonction pour modifier  une liaion avec l'id de la liaion et la duree passer en parametre
        public static void modifLiaison(int idLiaison,string duree)
        {
            try
            {

                maConnexionSql = Connexion.getInstance(provider, dataBase, uid, mdp);

                // on ouvre la connexion a la bdd
                maConnexionSql.openConnection();

                // on fait notre requete pour modifier la durée de la liaisons avec l'id du liaions  passer en parametre
                com = maConnexionSql.reqExec("update liaison set duree = '"+duree+"' where id = "+idLiaison);

                // execution de la requete por les deletes et les modifs
                int i = com.ExecuteNonQuery();

                // fermeture de la connexion
                maConnexionSql.closeConnection();

            }

            catch (Exception emp)
            {

                throw (emp);
            }
        }









        // fonction pour ajouter  une liaion 
        public static void ajoutLiaison(int idLiaison, string duree,Port port_depart,Port port_arrivee, int idSecteur)
        {
            try
            {

                maConnexionSql = Connexion.getInstance(provider, dataBase, uid, mdp);

                // on ouvre la connexion a la bdd
                maConnexionSql.openConnection();

                // on fait notre requete pour modifier la durée de la liaisons avec l'id du liaions 
                com = maConnexionSql.reqExec("insert into liaison(id,duree,port-depart,port-arrivee,idSecteur) values("+idLiaison+","+duree+ ","+ port_depart + ","+ port_arrivee+"," + idSecteur+"+");

                // execution de la requete por les deletes et les modifs
                int i = com.ExecuteNonQuery();

                // fermeture de la connexion
                maConnexionSql.closeConnection();

            }

            catch (Exception emp)
            {

                throw (emp);
            }
        }


































        // fonction pour mettre à jour la duree avec l'id du liaison
        public static void updateDuree(Liaison le, string id)
        {

            try
            {


                maConnexionSql = Connexion.getInstance(provider, dataBase, uid, mdp);


                // on ouvre la connexion a la bdd
                maConnexionSql.openConnection();


                // mise à jour de la duree de la liaison avec l'id de la liaion 
                com = maConnexionSql.reqExec(" update liaison   set duree=" + le.Duree + "  where id="+ le.IdLiaison);

                // execution de la requete por les deletes et les modifs
                int i = com.ExecuteNonQuery();


                // fermeture de la connexion
                maConnexionSql.closeConnection();



            }

            catch (Exception emp)
            {

                throw (emp);
            }


        }

        
    }
}
