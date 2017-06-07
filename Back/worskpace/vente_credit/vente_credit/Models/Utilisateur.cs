using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace vente_credit.Models
{
    public class Utilisateur
    {
        private int id;
        private TypeUtilisateur typeUtilisateur;
        private string login;
        private string password;

        public Utilisateur(int id, TypeUtilisateur typeUtilisateur, string login, string password)
        {

        }

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public TypeUtilisateur TypeUtilisateur
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