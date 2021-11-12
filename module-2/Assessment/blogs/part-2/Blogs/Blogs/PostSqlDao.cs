using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace Blogs
{
    public class PostSqlDao : IPostDao
    {
        private readonly string connectionString;

        public PostSqlDao(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public IList<Post> GetAllPosts()
        {
            // Implement this method to pull in all posts from database

            List<Post> posts = new List<Post>();

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    string sqlQuery = "SELECT id, name, body, published, created FROM posts;";
                    SqlCommand cmd = new SqlCommand(sqlQuery, conn);
                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        Id = Convert.ToInt32(reader["id"]),
                        //where time ran out
                    }
                }
            }
            catch (SqlException)
            {
                throw;
            }
        }

        public void Save(Post newPost)
        {
            // Implement this method to save post to database
        }
    }
}