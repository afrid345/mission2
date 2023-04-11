using mission2.DAL;
using mission2.Modele;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mission2.Modele
    {
     
    
    public class Liaison
        {


            public int idLiaisons;
            private int portDepart;
            private string duree;
            private int portArrivee;
            public int secteur;
            

            public Liaison(int idLiaisons, int portArrivee, int portDepart, string duree, int secteur)
            {
                this.idLiaisons = idLiaisons;
                this.portDepart = portDepart;
                this.PortArrivee = portArrivee;
                this.secteur = secteur;
                this.duree = duree;

            }

            public Liaison()
            {
                

            }

            
           // les get et les set
            public int IdLiaison { get => idLiaisons; set => idLiaisons = value; }

            public int Secteur { get => secteur; set => secteur = value; }
            public int PortDepart { get => portDepart; set => portDepart = value; }
            public int PortArrivee { get => portArrivee; set => portArrivee = value; }
            public string Duree { get => duree; set => duree = value; }

            public override string ToString()
            {
                // il commence son indice à 1 donc comme on informatique les indice commence à 0 on fait -1
                string nomDepart = PortDAO.GetPort()[this.portDepart-1].getNom();
            // il commence son indice à 1 donc comme on informatique les indice commence à 0 on fait -1
            string nomArrive = PortDAO.GetPort()[this.portArrivee-1].getNom();

            // retourner le nom d'arrive,la duree et le nom depart
                return nomArrive + ";" + this.duree + ";" + nomDepart;
            }
        }



    
}
