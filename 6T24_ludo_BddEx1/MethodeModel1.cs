using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;
using System.Diagnostics;
using Org.BouncyCastle.Asn1.Tsp;
using System.Collections;
using Org.BouncyCastle.Crypto.Digests;

namespace _6T24_ludo_BddEx1
{
    internal class MethodeModel1
    {
        public void CD()
        {
            MySqlConnection conn = null;
            MySqlDataAdapter adapter = null;
            
        }
        static string  CheminBDD()
        {
            return "server=10.10.51.98; database=immo; port=3306; UserId=root; password=root";
        }
        public bool ChercheUtilisateurs (out DataSet infos)
        {
            bool ok =false;
            MySqlConnection maConnexion = new MySqlConnection(CheminBDD());
            string query = "";
            try
            {
                maConnexion.Open();

                query = "SELECT * FROM utilisateurs;";

                MySqlDataAdapter da = new MySqlDataAdapter(query, maConnexion);
                infos = new DataSet();
                da.Fill(infos,"infoUtilisateurs");
                maConnexion.Close();

                if (infos.Tables[0].Rows.Count >= 1)
                {
                    ok = true;
                }
               
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
                throw;
            }

            return ok;

        }
        public bool UpdateBiens (int bienId, string info, string nom)
        {
            bool ok = false;
            MySqlConnection maConnexion = new MySqlConnection(CheminBDD());
            
            

            try
            {
                string query = "UPDATE table SET nomDuChampAMettreAJour=@parametre WHERE champPourCritere =" + bienId + ";";
                maConnexion.Open();
                MySqlCommand upDateCommand = new MySqlCommand(query, maConnexion);
                upDateCommand.Parameters.AddWithValue("@nom", nom);


                if (upDateCommand.ExecuteNonQuery() > 0)
                {
                    ok = true;
                }
                maConnexion.Open ();
                return ok;
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
                throw;
            }


            return ok;

        }
        public bool DeleteBiens (int bienId)
        {
            bool ok = false;
            MySqlConnection maConnexion = new MySqlConnection(CheminBDD());

            try
            {
                string query = "DELETE table SET nomDuChampAMettreAJour=@parametre WHERE champPourCritere =" + bienId + ";";
                maConnexion.Open();
                MySqlCommand upDateCommand = new MySqlCommand(query, maConnexion);
                upDateCommand.Parameters.AddWithValue("@nom", nom);

            }
            catch
            {

            }

            return ok;
        }

    }
}
