using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using Teams.Models;

namespace Teams.DAL
{
    public class TeamSqlDAO
    {
        private string connectionString;

        public TeamSqlDAO(string connectionString)
        {
            this.connectionString = connectionString;
        }


        public List<Team> GetAllTeams()
        {
            List<Team> List = new List<Team>();
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand("Select * from Team", conn);

                SqlDataReader rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    List.Add(RowToObject(rdr));
                }
            }
            return List;
        }

        public Team GetTeamById(int teamId)
        {
            Team team = null;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand("Select * from Team Where TeamId = @teamId", conn);

                cmd.Parameters.AddWithValue("@teamId", teamId);

                SqlDataReader rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    team = (RowToObject(rdr);
                }
            }
            return team;
        }



            return private Team RowToObject(SqlDataReader rdr)
        {
            throw new NotImplementedException();
        }

        team;
        }
        private Team RowToObject(SqlDataReader rdr)
        {
            Team team = new Team();

            team.TeamId = Convert.ToInt32(rdr["TeamId"]);
            team.Location = Convert.ToString(rdr["Location"]);
            team.TeamName = Convert.ToString(rdr["TeamName"]);
            team.Conference = (Conference)Convert.ToInt32(rdr["Conference"]);
            team.Division = (Division)Convert.ToInt32(rdr["Division"]);
            team.Wins = Convert.ToInt32(rdr["Wins"]);
            team.Losses = Convert.ToInt32(rdr["Losses"]);


            return team;
        }

    }
}
