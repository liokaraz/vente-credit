using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace vente_credit.Models
{
    public class UtilisateurVue
    {
        private int id;
        private string typeUtilisateur;
        private string login;
        private string password;

        public UtilisateurVue(int id, string typeUtilisateur,string login, string password) {
            this.id = id;
            this.typeUtilisateur = typeUtilisateur;
            this.login = login;
            this.password = password;
        }

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public string TypeUtilisateur
        {
            get { return typeUtilisateur; }
            set { typeUtilisateur = value; }
        }

        public string Login
        {
            get { return login; }
            set { login = value; }
        }

        public string Password
        {
            get { return password; }
            set { password = value; }
        }
    }
}