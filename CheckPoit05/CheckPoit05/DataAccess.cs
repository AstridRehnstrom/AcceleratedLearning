using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckPoit05
{
    internal class DataAccess
    {
        string conString = @"Server= (localdb)\mssqllocaldb;Database=GnomeDb";

        internal List<Gnomes> GetGnomesFromDatabase()

        {
            string sql = @"select Name, Skägg, Ond, Temperament, Rastyp
                            from Gnome
                           left join Ras on Ras.Id=Gnome.RasId";
                                

            using (SqlConnection connection = new SqlConnection(conString))
            using (SqlCommand command = new SqlCommand(sql, connection))
            {
                connection.Open();

                
                SqlDataReader reader = command.ExecuteReader();
                var result = new List<Gnomes>();

                while (reader.Read())
                {
                    var g = new Gnomes();
                 
                    string name = reader.GetSqlString(0).Value;
                    //string skägg = reader.GetSqlString(1).Value;
                    //string ond = reader.GetSqlString(2).Value;
                    //int temperament = reader.GetSqlInt32(3).Value;
                    //string rastyp = reader.GetSqlString(4).Value;

                    g.Name= name;
                    //g.Skägg = skägg;
                    //g.Ond = ond;
                    //g.Temperament = temperament;
                    //g.Ras = rastyp;

                   
                    result.Add(g);
                }
                return result;
            }
        }

        internal void AddGnome2(string name2)
        {
            string sql = @"insert into Gnome (Name) values ('" + name2 + "')";

            using (SqlConnection connection = new SqlConnection(conString))
            using (SqlCommand command = new SqlCommand(sql, connection))
            {
                connection.Open();
                Console.WriteLine(sql);
                command.ExecuteNonQuery();
            }
        }

        internal void AddGnome(string name)
        {
            string sql = @"insert into Gnome (Name) values (@Name)";
            using (SqlConnection connection = new SqlConnection(conString))
            using (SqlCommand command = new SqlCommand(sql, connection))
            {
                connection.Open();
                command.Parameters.Add(new SqlParameter("Name", name));              
                command.ExecuteNonQuery();
            }

        }
        
    }
}