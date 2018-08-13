using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace checkPoint1._2
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] NameList;

            Console.WriteLine("Ange kommando: ");
            string inputFromUser = Console.ReadLine();
            string response = inputFromUser.ToLower();
            NameList = NameArray(response);


            foreach (var item in NameList)
            {

                if (item.StartsWith("a"))
                {
                    string afterTrim = item.Trim('a');
                    int tal = int.Parse(afterTrim);
                    int rows = 1;
                    for (int j = 0; j < tal; j++)
                    {

                        Console.WriteLine();
                        for (int i = 0; i < rows; i++)
                        {

                            Console.Write("*");
                        }
                        rows++;
                        Console.WriteLine();
                    }
                }
                else if (item.StartsWith("b"))
                {
                    string afterTrim = item.Trim('b');
                    int tal = int.Parse(afterTrim);
                    int rows = tal;
                    for (int j = 0; j < tal; j++)
                    {
                        Console.WriteLine();
                        for (int i = 0; i < rows; i++)
                        {

                            Console.Write("*");
                        }
                        rows--;
                        Console.WriteLine();
                    }
                }
            }
        }

        static string[] NameArray(string response)
        {
            string[] list = response.Split(new[] { "-" }, StringSplitOptions.RemoveEmptyEntries);
            return list;
        }
    }
}


            

          
        
    
