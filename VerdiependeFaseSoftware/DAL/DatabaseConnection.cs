using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using VerdiependeFaseSoftware.BO;

namespace VerdiependeFaseSoftware
{
    public class DatabaseConnection
    {
        private string connectionString = "Data Source=localhost;Initial Catalog=football;Integrated Security=True";
        private SqlConnection connection;
        #region Constructor
        public DatabaseConnection()
        {
            connection = new SqlConnection(connectionString);
            Connect();
        }
        #endregion
        #region Connect
        public bool Connect()
        {
            try
            {
                connection.Open();
                return true;
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Fout bij het verbinden met de database: " + ex.Message);
                return false;
            }
        }
        #endregion
        #region Disconnect
        public void Disconnect()
        {
            connection.Close();
        }
        #endregion
        #region ExecuteQuery
        public SqlDataReader ExecuteQuery(string query)
        {
            try
            {
                if (connection.State != ConnectionState.Open)
                    connection.Open();

                SqlCommand command = new SqlCommand(query, connection);
                return command.ExecuteReader();
            }
            catch (SqlException ex)
            {
                Console.WriteLine("Fout bij het uitvoeren van de query: " + ex.Message);
                return null;
            }
        }
        #endregion Einde ExecuteQuery


        public List<Team> GetTeamsWithLeagueInfo(string leagueName)
        {
            List<Team> teams = new List<Team>();

            string query = "SELECT T.teamName, L.leagueName, L.country " +
                           "FROM Team T " +
                           "INNER JOIN League L ON T.leagueID = L.leagueID " +
                           "WHERE L.leagueName = @LeagueName";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@LeagueName", leagueName);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    string teamName = reader["teamName"].ToString();


                    Team team = new Team
                    {
                        Name = teamName,
                    };

                    teams.Add(team);
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error executing query: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }

            return teams;
        }



        #region Haal Players op
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
                    player.Name = reader["playerName"].ToString();
                    player.Attack = Convert.ToInt32(reader["pAttack"]);
                    player.Control = Convert.ToInt32(reader["pControl"]);
                    player.Defend = Convert.ToInt32(reader["pDefend"]);
                    player.Position = reader["pPosition"].ToString();
                    player.Nationality = reader["pNationality"].ToString();
                    player.Rating = Convert.ToInt32(reader["pRating"]);

                    players.Add(player);
                }

                reader.Close();
            }

            return players;
        }
        #endregion

        public List<League> GetLeagues()
        {
            List<League> leagues = new List<League>();

            string query = "SELECT * FROM League";
            SqlDataReader reader = ExecuteQuery(query);

            if (reader != null)
            {
                while (reader.Read())
                {

                    League league = new League();
                    league.Name = (string)reader["leagueName"];
                    league.Country = (string)reader["country"];


                    leagues.Add(league);
                }
                reader.Close();
            }

            return leagues;
        }
        public List<Player> GetPlayersByClub(string clubName)
        {
            List<Player> players = new List<Player>();

            string query = "SELECT playerName, pAttack, pControl, pDefend, pPosition, pNationality, pRating " +
                           "FROM Player " +
                           "WHERE teamID IN (SELECT teamID FROM Team WHERE teamName = @ClubName)";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@ClubName", clubName);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    Player player = new Player
                    {
                        Name = reader["playerName"].ToString(),
                        Attack = Convert.ToInt32(reader["pAttack"]),
                        Control = Convert.ToInt32(reader["pControl"]),
                        Defend = Convert.ToInt32(reader["pDefend"]),
                        Position = reader["pPosition"].ToString(),
                        Nationality = reader["pNationality"].ToString(),
                        Rating = Convert.ToInt32(reader["pRating"])
                    };

                    players.Add(player);
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error executing query: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }

            return players;
        }

            #region Haal Teams op
            public List<Team> GetTeams()
        {
            List<Team> teams = new List<Team>();

            string query = "SELECT * FROM Team";
            SqlDataReader reader = ExecuteQuery(query);

            if (reader != null)
            {
                while (reader.Read())
                {

                    Team team = new Team();
                    team.Name = (string)reader["teamName"];

                    teams.Add(team);
                }
                reader.Close();
            }

            return teams;
        }
        #endregion
        /* public Fifa GetAll()
         {
             Fifa fifa = new Fifa();
             string selectStatement = "SELECT * " +
                                      "FROM league " +
                                      "    INNER JOIN team ON team.leagueID = League.leagueID " +
                                      "    INNER JOIN player ON player.teamID = Team.teamID";

             SqlDataReader reader = ExecuteQuery(selectStatement);

             if (reader != null)
             {
                 while (reader.Read())
                 {
                     string lName = reader.GetString(reader.GetOrdinal("leagueName"));

                     League league = fifa.Leagues.First(e => e.Name != null && e.Name.Equals(lName));
                     if (league == null)
                     {
                         league = new League();
                         league.Name = lName;
                         league.Country = reader.GetString(reader.GetOrdinal("country"));
                         fifa.Leagues.Add(league);
                     }

                     string tName = reader.GetString(reader.GetOrdinal("teamName"));

                     Team team = league.Teams.FirstOrDefault(e => e.Name != null && e.Name.Equals(tName));
                     if (team == null)
                     {
                         team = new Team();
                         team.Name = tName;
                         league.Teams.Add(team);
                     }

                     Player player = new Player();
                     player.Name = reader.GetString(reader.GetOrdinal("playerName"));
                     player.Attack = reader.GetInt32(reader.GetOrdinal("pAttack"));
                     player.Control = reader.GetInt32(reader.GetOrdinal("pControl"));
                     player.Defend = reader.GetInt32(reader.GetOrdinal("pDefend"));
                     player.Position = reader.GetString(reader.GetOrdinal("pPosition"));
                     player.Nationality = reader.GetString(reader.GetOrdinal("pNationality"));
                     player.Rating = reader.GetInt32(reader.GetOrdinal("pRating"));

                     team.players.Add(player);
                 }
                 reader.Close();
             }
             return fifa;
         }*/
        #region Haal spelers en de team op
        public List<Team> GetTeamsWithPlayers()
        {
            List<Team> teams = new List<Team>();

            string query = "SELECT t.TeamID, t.TeamName, p.playerName, p.pAttack, p.pControl, p.pDefend, p.pPosition, p.pNationality, p.pRating " +
                           "FROM Team t " +
                           "JOIN Player p ON t.TeamID = p.TeamID"; // Voeg de juiste kolomnamen en tabelnamen toe

            SqlDataReader reader = ExecuteQuery(query);

            if (reader != null)
            {
                while (reader.Read())
                {
                    int teamID = Convert.ToInt32(reader["TeamID"]);
                    string teamName = reader["TeamName"].ToString();

                    // Controleer of het huidige team al aanwezig is in de lijst
                    Team team = teams.FirstOrDefault(t => t.LeagueID == teamID);
                    if (team == null)
                    {
                        team = new Team
                        {
                            LeagueID = teamID,
                            Name = teamName,
                            players = new List<Player>()
                        };

                        teams.Add(team);
                    }

                    Player player = new Player
                    {
                        Name = reader["playerName"].ToString(),
                        Attack = Convert.ToInt32(reader["pAttack"]),
                        Control = Convert.ToInt32(reader["pControl"]),
                        Defend = Convert.ToInt32(reader["pDefend"]),
                        Position = reader["pPosition"].ToString(),
                        Nationality = reader["pNationality"].ToString(),
                        Rating = Convert.ToInt32(reader["pRating"])
                    };

                    team.players.Add(player);
                }

                reader.Close();
            }

            return teams;

        }
        #endregion
        public List<Team> GetTeamsWithLeague(string leagueName)
        {
            List<Team> teams = new List<Team>();

            string query = "SELECT T.teamName, L.leagueName, L.country " +
                           "FROM Team T " +
                           "INNER JOIN League L ON T.leagueID = L.leagueID " +
                           "WHERE L.leagueName = @LeagueName";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@LeagueName", leagueName);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    string teamName = reader["teamName"].ToString();

                    Team team = new Team
                    {
                        Name = teamName,
                    };

                    teams.Add(team);
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error executing query: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }

            return teams;
        }
    }
}