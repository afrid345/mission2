using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using mission2.Controleur;
using mission2.DAL;
using MySql.Data.MySqlClient;

namespace mission2.Modele
{
    public class Secteur
    {
        private int id;
        private String libelle;

      
        public Secteur(int id, string libelle)
        {
            this.id = id;
            this.libelle = libelle;
        }

        public String afficheSecteur
        {
            get => this.libelle;
        }
        public String getlibelle()
        {
            return this.libelle;
        }

        public int getID()
        {
            return this.id;
        }

        public void setlibelle(String uneLibelle)
        {
            this.libelle = uneLibelle;
        }

        public override String ToString()
        {
            return (this.id + "  " + this.libelle);
        }
        

    }
}
