using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Npgsql;
using vente_credit.Models;
using vente_credit.utilities;

namespace vente_credit.DAO
{
    public class PointDeVenteDAO
    {
        private NpgsqlConnection conn;
        private NpgsqlCommand cmd;
        private NpgsqlDataReader reader;

        public List<PointDeVenteVue> search(PointDeVente pVente)
        {
            conn = new DB().getConn();
            List<PointDeVenteVue> listAll = new List<PointDeVenteVue>();
            try
            {
                string query = "select * from livraison_carte_vue when ";
                if (pVente.ZoneDeTravail != null)
                    query += "zone_de_travail =" + pVente.ZoneDeTravail;
                if (pVente.Libelle != null)
                    query += " and libelle =" + pVente.Libelle;
                if (pVente.Latitude != null)
                    query += " and latitude =" + pVente.Latitude;
                if (pVente.Longitude != null)
                    query += " and longitude =" + pVente.Longitude;

                cmd = new NpgsqlCommand(query, conn);
                reader = cmd.ExecuteReader();
                while (reader.Read() == true)
                {
                    PointDeVenteVue pv = new PointDeVenteVue(reader.GetInt16(0), reader.GetString(1),
                        reader.GetString(3), reader.GetString(4), reader.GetString(5));
                    listAll.Add(pv);
                }
            }
            catch (Exception e)
            {
                throw new Exception("Erreur dans LivraisonCarteDao=>search " + e.Message);
            }
            finally
            {
                conn.Close();
                reader.Close();
            }
            return listAll;
        }

        public void remove(PointDeVenteVue carte)
        {
            conn = new DB().getConn();
            try
            {
                string query = "delete * from point_de_vente where id = " + carte.Id;
                cmd = new NpgsqlCommand(query, conn);
                cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                throw new Exception("Erreur dans PointDeVenteDao=>remove " + e.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        public PointDeVenteVue findById(int id)
        {
            conn = new DB().getConn();
            PointDeVenteVue pVente = null;
            try
            {
                string query = "select * from point_de_vente_vue where id=" + id;
                cmd = new NpgsqlCommand(query, conn);
                reader = cmd.ExecuteReader();
                if (reader.Read() == true)
                {
                    pVente = new PointDeVenteVue(reader.GetInt16(0), reader.GetString(1),
                        reader.GetString(3), reader.GetString(4), reader.GetString(5));
                }
            }
            catch (Exception e)
            {
                throw new Exception("Erreur dans PointDeVenteDao=>findBydId " + e.Message);
            }
            finally
            {
                conn.Close();
                reader.Close();
            }
            return pVente;
        }

        public void insert(PointDeVente pvente)
        {
            conn = new DB().getConn();
            try
            {
                string query = "insert into point_de_vente (id,zone_de_travail,libelle,latitude,"
                + "longitude) values (nextval('seq_point_de_vente)," + pvente.ZoneDeTravail.Id + ","
                + pvente.Libelle + "," + pvente.Latitude + "," + pvente.Longitude + ")";
                cmd = new NpgsqlCommand(query, conn);
                cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                throw new Exception("Erreur dans PointDeVenteDao=>insert" + e.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        public List<PointDeVenteVue> getAll()
        {
            List<PointDeVenteVue> listAll = new List<PointDeVenteVue>();
            conn = new DB().getConn();
            try
            {
                string query = "select * from point_de_vente_vue";
                cmd = new NpgsqlCommand(query, conn);
                reader = cmd.ExecuteReader();
                while (reader.Read() == true)
                {
                    PointDeVenteVue pvente = new PointDeVenteVue(reader.GetInt16(0), reader.GetString(1),
                        reader.GetString(3), reader.GetString(4), reader.GetString(5));
                    listAll.Add(pvente);
                }
            }
            catch (Exception e)
            {
                throw new Exception("Erreur dans PointDeVenteDao->getAll" + e.Message);
            }
            finally
            {
                conn.Close();
                reader.Close();
            }
            return listAll;
        }
    }
}