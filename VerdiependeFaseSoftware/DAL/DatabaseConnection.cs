using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VerdiependeFaseSoftware.Classes;

namespace VerdiependeFaseSoftware
{
    public class DatabaseConnection
    {
        private string connectionString = "Data Source=YOUR_SERVER_NAME;Initial Catalog=YOUR_DATABASE_NAME;Integrated Security=True";
        private SqlConnection connection;

        public DatabaseConnection()
        {
            connection = new SqlConnection(connectionString);
        }

        public bool Connect()
        {
            try
            {
                connection.Open();
                return true;
            }
            catch (SqlException ex)
            {
                // Er is een fout opgetreden bij het verbinden met de database
                MessageBox.Show("Fout bij het verbinden met de database: " + ex.Message);
                return false;
            }
        }

        public void Disconnect()
        {
            connection.Close();
        }
        public SqlDataReader ExecuteQuery(string query)
        {
            try
            {
                SqlCommand command = new SqlCommand(query, connection);
                return command.ExecuteReader();
            }
            catch (SqlException ex)
            {
                // Er is een fout opgetreden bij het uitvoeren van de query
                MessageBox.Show("Fout bij het uitvoeren van de query: " + ex.Message);
                return null;
            }
        }
        public List<Player> GetPlayers()
        {
            List<Player> players = new List<Player>();

            string query = "SELECT * FROM Player";
            SqlDataReader reader = ExecuteQuery(query);

            if (reader != null)
            {
                while (reader.Read())
                {
                    Player player = new Player();
                    player.playerID = (int)reader["playerID"];
                    player.playerName = reader["playerName"].ToString();
                    player.attack = (int)reader["pAttack"];
                    player.control = (int)reader["pControl"];
                    player.defend = (int)reader["pDefend"];
                    player.position = reader["pPosition"].ToString();
                    player.nationality = reader["pNationality"].ToString();
                    player.rating = (int)reader["pRating"];
                    player.teamID = (int)reader["teamID"];

                    players.Add(player);
                }
                reader.Close();
            }

            return players;
        }
    }
}
