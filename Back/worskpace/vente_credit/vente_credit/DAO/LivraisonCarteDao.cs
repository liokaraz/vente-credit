using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Npgsql;
using vente_credit.Models;
using vente_credit.utilities;

namespace vente_credit.DAO
{
    public class LivraisonCarteDAO
    {
        private NpgsqlConnection conn;
        private NpgsqlCommand cmd;
        private NpgsqlDataReader reader;

        public List<LivraisonCarteVue> search(LivraisonCarteVue carte)
        {
            conn = new DB().getConn();
            List<LivraisonCarteVue> listAll = new List<LivraisonCarteVue>();
            try
            {
                string query = "select * from livraison_carte_vue when ";
                if (carte.DistributionCarte != null)
                    query += "distributeur_carte =" + carte.DistributionCarte;
                if (carte.Employe != null)
                    query += " and valeur =" + carte.Employe;
                if (carte.Quantite != null)
                    query += " and quantite =" + carte.Quantite;
                if (carte.ResteNonVendu != null)
                    query += " and reste_non_vendu =" + carte.ResteNonVendu;
                if (carte.Date != null)
                    query += " and date =" + carte.Date;
                if (carte.PointDeVente != null)
                    query += " and point_de_vente =" + carte.PointDeVente;

                cmd = new NpgsqlCommand(query, conn);
                reader = cmd.ExecuteReader();
                while (reader.Read() == true)
                {
                    LivraisonCarteVue c = new LivraisonCarteVue(reader.GetInt16(0), reader.GetInt32(1),
                        reader.GetString(3), reader.GetInt32(4), reader.GetInt32(5), reader.GetDateTime(6),
                        reader.GetString(7));
                    listAll.Add(c);
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

        public void remove(LivraisonCarteVue carte)
        {
            conn = new DB().getConn();
            try
            {
                string query = "delete * from livraison_carte where id = " + carte.Id;
                cmd = new NpgsqlCommand(query, conn);
                cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                throw new Exception("Erreur dans LivraisonCarteDao=>remove " + e.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        public LivraisonCarteVue findById(int id)
        {
            conn = new DB().getConn();
            LivraisonCarteVue carte = null;
            try
            {
                string query = "select * from livraison_carte_vue where id=" + id;
                cmd = new NpgsqlCommand(query, conn);
                reader = cmd.ExecuteReader();
                if (reader.Read() == true)
                {
                    carte = new LivraisonCarteVue(reader.GetInt16(0), reader.GetInt32(1),
                        reader.GetString(3), reader.GetInt32(4), reader.GetInt32(5), reader.GetDateTime(6),
                        reader.GetString(7));
                }
            }
            catch (Exception e)
            {
                throw new Exception("Erreur dans LivraisonCarteDao=>findBydId " + e.Message);
            }
            finally
            {
                conn.Close();
                reader.Close();
            }
            return carte;
        }

        public void insert(LivraisonCarte carte)
        {
            conn = new DB().getConn();
            try
            {
                string query = "insert into livraison_carte (id,distribution_carte,employe,quantite,"
                +"resteNonVendu,date,point_de_vente) values (nextval('seq_livraison_carte)," + carte.Employe + ","
                + carte.Quantite + "," + carte.ResteNonVendu + "," + carte.Date + "," + carte.PointDeVente +")";
                cmd = new NpgsqlCommand(query, conn);
                cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                throw new Exception("Erreur dans LivraisonCarteDao=>insert" + e.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        public List<LivraisonCarteVue> getAll()
        {
            List<LivraisonCarteVue> listAll = new List<LivraisonCarteVue>();
            conn = new DB().getConn();
            try
            {
                string query = "select * from livraison_carte_vue";
                cmd = new NpgsqlCommand(query, conn);
                reader = cmd.ExecuteReader();
                while (reader.Read() == true)
                {
                    LivraisonCarteVue carte = new LivraisonCarteVue(reader.GetInt16(0), reader.GetInt32(1),
                        reader.GetString(3), reader.GetInt32(4), reader.GetInt32(5), reader.GetDateTime(6),
                        reader.GetString(7));
                    listAll.Add(carte);
                }
            }
            catch (Exception e)
            {
                throw new Exception("Erreur dans LivraisonCarteDao->getAll" + e.Message);
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