using System;
using System.Collections.Generic;

namespace _10._5_Product_list_with_dictionary
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
                Console.WriteLine("Product ID = "+ item.Key + " and name: " + item.Value);
              
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

                int id = Convert.ToInt32(products[0]);
                string name = products[1];

                if (dic.ContainsKey(id))
                {
                    Console.WriteLine("The product list already contains the id" + id);
                    continue;
                }

                dic.Add(id, name);


            }
            return dic;
        }
    }
}