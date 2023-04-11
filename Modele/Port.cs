using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mission2.Modele
{
    public class Port
    {
        private int id;
        private String nom;


        public Port(int id, string nom)
        {
            this.id = id;
            this.nom = nom;
        }

        public String afficheSecteur
        {
            get => this.nom;
        }
        public String getNom()
        {
            return this.nom;
        }

        public int getID()
        {
            return this.id;
        }

        public void setlibelle(String unNom)
        {
            this.nom = unNom;
        }

        public override String ToString()
        {
            return (this.id + "  " + this.nom);
        }


    }
}
