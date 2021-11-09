using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Jarmuvek_adatbazis_gyakorlas
{
   
    class AdatKapcsolat
    {
        static MySqlConnection connection;
        static MySqlCommand command;

        const string server = "localhost";
        const string user = "root";
        const uint port = 3306;
        const string password = "";
        const string database = "jarmuvek";
        const MySqlSslMode sslMode = MySqlSslMode.None;
        public static void Csatlakozas()
        {
            MySqlConnectionStringBuilder stringBuilder = new MySqlConnectionStringBuilder();

            stringBuilder.Server = server;
            stringBuilder.UserID = user;
            stringBuilder.Port = port;
            stringBuilder.Password = password;
            stringBuilder.Database = database;
            stringBuilder.SslMode = sslMode;

            string connectionString = stringBuilder.ToString();

            try
            {
                connection = new MySqlConnection(connectionString);
                connection.Open();

                command = new MySqlCommand();
                command.Connection = connection;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hiba az adatbázis csatlakozás közben: ", ex.Message);
            }
        }
        public static void KapcsolatBontasa()
        {
            try
            {
                connection.Close();
                command.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hiba az adatbázis kapcsolat bontása közben: ", ex.Message);
            }

        }
        public static List<AutoOsztaly> AutokkListazasa()
        {
            try
            {
                command.Parameters.Clear();
                command.CommandText = "SELECT * FROM auto";
                List<AutoOsztaly> autok = new List<AutoOsztaly>();
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    string marka = reader["márka"].ToString();
                    int km = reader.IsDBNull(2) ? 0 : reader.GetInt32("KM óra állás");
                    DateTime gyartasido = (DateTime)reader["Gyártási idő"];
                    string szin = reader["Szín"].ToString();
                    Autotipus tipus = (Autotipus)Enum.Parse(typeof(Autotipus), reader["Típus"].ToString());

                    /* 
                    autok.Add(new AutoOsztaly
                        (reader["marka"].ToString(),
                        (int)reader["km"],
                        (DateTime)reader["gyartasido"],
                        (reader["szin"].ToString(),
                        (Autotipus)Enum.Parse(typeof(Autotipus), reader["tipus"].ToString()))));
                    */
                        

                }
                reader.Close();
                return autok;
            }
            catch (Exception ex)
            {

                throw new Exception("Sikertelen listázás!", ex);
            }

        }
        public static void AutoFelvitel ( AutoOsztaly auto)
        {
            try
            {
                command.Parameters.Clear();
                command.CommandText = "INSERT INTO auto VALUES (@marka,@km,@gyartasido,@szin,@autoTipus)";
                command.Parameters.AddWithValue("@marka", auto.Marka);
                command.Parameters.AddWithValue("@km", auto.Km);
                command.Parameters.AddWithValue("@gyartasido", auto.Gyartasido);
                command.Parameters.AddWithValue("@szin", auto.Szin);
                command.Parameters.AddWithValue("@autoTipus", auto.AutoTipus.ToString());
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

                throw new Exception("Sikertelen feltöltés!", ex);
            }
        }
        public static void AutoModositasa(AutoOsztaly auto)
        {

            try
            {

                command.Parameters.Clear();
                command.CommandText = "UPDATE Auto SET szin = @szin WHERE marka = @marka";
                command.Parameters.AddWithValue("@szin", auto.Szin);
                command.Parameters.AddWithValue("@marka", auto.Marka);


                command.ExecuteNonQuery();

                command.Parameters.Clear();
                command.CommandText = "UPDATE Auto SET autoTipus = @autoTipus WHERE marka = @marka";
                command.Parameters.AddWithValue("@autoTipus", auto.AutoTipus);
                command.Parameters.AddWithValue("@marka", auto.Marka);

                command.ExecuteNonQuery();


            }
            catch (Exception ex)
            {
                throw new Exception("Sikertelen módosítás!", ex);
            }
        }

        public static void AutoTorlese(AutoOsztaly auto)

        {
            try
            {

                command.Parameters.Clear();
                command.CommandText = "DELETE FROM Auto WHERE marka = @marka";
                command.Parameters.AddWithValue("@marka", auto.Marka);

                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Sikertelen törlés!", ex);
            }
        }

    }
}
