using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace vente_credit.Models
{
    public class PointDeVenteVue
    {
        private int id;
        private string zoneDeTravail;
        private string libelle;
        private string latitude;
        private string longitude;

        public PointDeVenteVue(int id, string zoneDeTravail, string libelle, string latitude, string longitude)
        {
            this.Id = id;
            this.ZoneDeTravail = zoneDeTravail;
            this.Libelle = libelle;
            this.Latitude = latitude;
            this.Longitude = longitude;
        }

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public string ZoneDeTravail
        {
            get { return zoneDeTravail; }
            set { zoneDeTravail = value; }
        }

        public string Libelle
        {
            get { return libelle; }
            set { libelle = value; }
        }

        public string Latitude
        {
            get { return latitude; }
            set { latitude = value; }
        }

        public string Longitude
        {
            get { return longitude; }
            set { longitude = value; }
        }
    }
}