using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bloggy.Domain;

namespace Bloggy
{
    public class DataAccess
    {
        string conString = @"Server= (localdb)\mssqllocaldb;Database=BlogDB";

        internal List<BlogPost> GetAllBlogPosts()
        {
            string sql = @"select ID, Title, Author From BlogPost";

            using (SqlConnection connection = new SqlConnection(conString))
            using (SqlCommand command = new SqlCommand(sql, connection))
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();
                var result = new List<BlogPost>();

                while (reader.Read())
                {
                    var bp = new BlogPost();

                    int id = reader.GetSqlInt32(0).Value;
                    string title = reader.GetSqlString(1).Value;
                    string author = reader.GetSqlString(2).Value;

                    bp.Id = id;
                    bp.Title = title;
                    bp.Author = author;

                    result.Add(bp);
                }
                return result;
            }
        }

        internal BlogPost GetBlogPostById(int postId)
        {
            string sql = @"select ID, Title, Author From BlogPost where ID=@ID";

            using (SqlConnection connection = new SqlConnection(conString))
            using (SqlCommand command = new SqlCommand(sql, connection))
            {
                connection.Open();
                command.Parameters.Add(new SqlParameter("ID", postId));

                SqlDataReader reader = command.ExecuteReader();


                reader.Read();

                var bp = new BlogPost();

                int id = reader.GetSqlInt32(0).Value;
                string title = reader.GetSqlString(1).Value;
                string author = reader.GetSqlString(2).Value;

                bp.Id = id;
                bp.Title = title;
                bp.Author = author;

                return bp;
            }
        }

        internal void UpdateBlogPost(BlogPost post)
        {
            string sql = @"update BlogPost set Title=@Title where ID=@ID";
            using (SqlConnection connection = new SqlConnection(conString))
            using (SqlCommand command = new SqlCommand(sql, connection))
            {
                connection.Open();

                command.Parameters.Add(new SqlParameter("ID", post.Id));
                command.Parameters.Add(new SqlParameter("Title", post.Title));
                command.ExecuteNonQuery();

            }
        }
    }
}