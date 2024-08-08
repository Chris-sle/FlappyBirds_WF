using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

namespace FlappyBirds_WF
{
    internal class DatabaseHelper
    {
        private string _connectionString = "Data Source=(localdb)\\ProjectModels;Initial Catalog=FlappyBirdScoreBoard;Integrated Security=True;Connect Timeout=30;Encrypt=True;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False";

        public List<Score> GetScores()
        {
            List<Score> scores = new List<Score>();

            using SqlConnection con = new SqlConnection(_connectionString);
            con.Open();
            const string query = "SELECT * FROM scoreboard ORDER BY Score DESC";
            using SqlCommand cmd = new SqlCommand(query, con);
            using SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                scores.Add(new Score
                {   
                    PlayerName = reader["Username"].ToString(),
                    ScoreValue = Convert.ToInt32(reader["Score"]),
                });
            }

            return scores;
        }

        public void InsertScore(string username, int score)
        {
            using SqlConnection con = new SqlConnection(_connectionString);
            con.Open();
            const string query = "INSERT INTO scoreboard (Username, Score, Date) VALUES (@Username, @Score, @Date)";
            using SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@Username", username);
            cmd.Parameters.AddWithValue("@Score", score);
            cmd.Parameters.AddWithValue("@Date", DateTime.UtcNow.ToString("yyyy-MM-ddTHH:mm:ssZ"));
            cmd.ExecuteNonQuery();
        }
    }
}
