using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace vente_credit.Models
{
    public class LivraisonCarteVue
    {
        private int id;
        private int distributionCarte;
        private string employe;
        private int quantite;
        private int resteNonVendu;
        private DateTime date;
        private string pointDeVente;

        public LivraisonCarteVue(int id, int distributionCarte, string employe, int quantite, int resteNonVendu,
            DateTime date, string pointDeVente)
        {
            this.Id = id;
            this.DistributionCarte = distributionCarte;
            this.Employe = employe;
            this.Quantite = quantite;
            this.ResteNonVendu = resteNonVendu;
            this.Date = date;
            this.PointDeVente = PointDeVente;
        }

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public int DistributionCarte
        {
            get { return distributionCarte; }
            set { distributionCarte = value; }
        }

        public string Employe
        {
            get { return employe; }
            set { employe = value; }
        }

        public int Quantite
        {
            get { return quantite; }
            set { quantite = value; }
        }

        public int ResteNonVendu
        {
            get { return resteNonVendu; }
            set { resteNonVendu = value; }
        }

        public DateTime Date
        {
            get { return date; }
            set { date = value; }
        }

        public string PointDeVente
        {
            get { return pointDeVente; }
            set { pointDeVente = value; }
        }
    }
}