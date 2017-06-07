using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace vente_credit.Models
{
    public class LivraisonCarte
    {
        private int id;
        private DistributionCarte distributionCarte;
        private Employe employe;
        private int quantite;
        private int resteNonVendu;
        private DateTime date;
        private PointDeVente pointDeVente;

        public LivraisonCarte(int id, DistributionCarte distributionCarte, Employe employe, int quantite,
            int resteNonVendu, DateTime date, PointDeVente pointDeVente)
        {
            this.Id = id;
            this.DistributionCarte = distributionCarte;
            this.Employe = employe;
            this.Quantite = quantite;
            this.ResteNonVendu = resteNonVendu;
            this.Date = date;
            this.PointDeVente = pointDeVente;
        }

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public DistributionCarte DistributionCarte
        {
            get { return distributionCarte; }
            set { distributionCarte = value; }
        }

        public Employe Employe
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

        public PointDeVente PointDeVente
        {
            get { return pointDeVente; }
            set { pointDeVente = value; }
        }
    }
}