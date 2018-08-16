using System;
using System.Collections.Generic;

namespace _10._6_Add_validation
{
    class Program
    {
        static void Main(string[] args)
        {

            Dictionary<int, string> products = BuildProductDictionary();
            DisplayProductDictionary(products);
        }




        private static void DisplayProductDictionary(Dictionary<int, string> dic)
        {
            foreach (var item in dic)
            {
                Console.WriteLine("Product ID = " + item.Key + " and name: " + item.Value);

            }
        }


        private static Dictionary<int, string> BuildProductDictionary()
        {
            var dic = new Dictionary<int, string>();

            while (true)
            {

                Console.WriteLine("Enter Product ID and name (separated by comma), press enter to quit");
                string inmatat = Console.ReadLine();

                if (inmatat == "")
                    break;

                string[] products = inmatat.Split(',');

                int id;
                string name;

                try
                {
                    id = Convert.ToInt32(products[0]);
                    name = products[1];
                }

                catch (System.FormatException)
                {
                    Console.WriteLine("Invalid input!");
                    continue;
                }

                catch (System.IndexOutOfRangeException)
                {
                    Console.WriteLine("Invalid input!");
                    continue;
                }
              

                if (dic.ContainsKey(id))
                {
                    Console.WriteLine("The product list already contains the ID " + id);
                    continue;
                }

                dic.Add(id, name);



            }
            return dic;
        }
    }

}
