using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Valutaappen_2._0.Domain;

namespace Valutaappen_2._0
{

    public class GetDataAccess
    {
        string conString = @"Server=(localdb)\mssqllocaldb;Database=Valuta";

        public void InsertIntoSQL(GetAPI api)
        {
            foreach (var item in api.Currencies)
            {

                string sql = @"Insert into ExchangeRate ( Code, Rate, Date) 
                            Values (@Code, @Rate, @Date)";
                //where Code=@Code";

                using (SqlConnection connection = new SqlConnection(conString))
                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    connection.Open();
                    command.Parameters.Add(new SqlParameter("Code", item.Code));
                    command.Parameters.Add(new SqlParameter("Rate", item.Rate));
                    command.Parameters.Add(new SqlParameter("Date", api.Date));


                    command.ExecuteNonQuery();

                }
            }


        }

        internal List<Currency> GetAllRates()
        {
            string sql = @"Select Code, Country, Rate from ExchangeRate
                           join CurrencyLocation on CurrencyLocation.CodeID = ExchangeRate.Code";


            using (SqlConnection connection = new SqlConnection(conString))
            using (SqlCommand command = new SqlCommand(sql, connection))
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();


                var result = new List<Currency>();

                while (reader.Read())
                {

                    var c = new Currency();

                    string code = reader.GetSqlString(0).Value;
                    string country = reader.GetSqlString(1).Value;
                    decimal rate = reader.GetSqlDecimal(2).Value;



                    c.Code = code;
                    c.Rate = rate;
                    c.Name = country;

                    result.Add(c);

                }

                return result;
            }
        }

        internal void GetConvertRates(string valuta, string valuta2, decimal money)
        {
            decimal rate1 = GetRateForCurrencyCode(valuta);
            decimal rate2 = GetRateForCurrencyCode(valuta2);

            decimal finalRate = Math.Round((rate2 / rate1 * money), 2);
            
            Console.WriteLine($"Du får {finalRate} {valuta2} för {money} {valuta}");
        }

        private decimal GetRateForCurrencyCode(string code)
        {
            string sql = @"Select Top 1 Rate from ExchangeRate
                        where code= @code
                        order by Date, Id desc";
            
            using (SqlConnection connection = new SqlConnection(conString))
            using (SqlCommand command = new SqlCommand(sql, connection))
            {
                connection.Open();
                command.Parameters.Add(new SqlParameter("code", code));

                SqlDataReader reader = command.ExecuteReader();
                reader.Read();
                return reader.GetSqlDecimal(0).Value;

            }
            
        }
    }
}

