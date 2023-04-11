using mission2.DAL;
using mission2.Modele;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mission2.Controleur
{
    public class Secliaison
    {
        SecteurDAO SecDAO = new SecteurDAO();
        List<Secteur> listeSecteur;
        LiaisonDAO liaDAO = new LiaisonDAO();
        List<Liaison> listeLaison;
       // Secteur s;

        public Secliaison()
        {
            listeSecteur = new List<Secteur>();
            listeLaison = new List<Liaison>();

        }

        public List<Secteur> chargementSecteur()
        {
            listeSecteur = SecteurDAO.GetSecteur();
            return listeSecteur;
        }

        public List<Liaison> chargementLiaison(int id, string name)
        {
            
            listeLaison = LiaisonDAO.GetLiaison(id);
            return listeLaison;
        }
    }
}
   
