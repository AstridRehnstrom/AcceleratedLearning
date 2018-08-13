using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace _2._3_String_creation
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList fruit = new ArrayList();

            Console.WriteLine("How many fruits do you want to add?");
            int number = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < number; i++)
            {
                Console.WriteLine("Add a fruit");
                fruit.Add(Console.ReadLine());

             
            }


            

            Console.Write ("Enter fruit 1: ");
            string fruit1 = Console.ReadLine();
            Console.Write("Enter fruit 2: ");
            string fruit2 = Console.ReadLine();
            Console.Write("Enter fruit 3: ");
            string fruit3 = Console.ReadLine();

            Console.WriteLine(fruit1 + " " + fruit2+ " " + fruit3);
            string result = string.Format("Fruit1: {0} Fruit2: {1} Fruit3: {2}", fruit1, fruit2, fruit3);
            Console.WriteLine(result);
            var result2 = $"Fruit1: {fruit1} Fruit2: {fruit2} Fruit3: {fruit3}";
            Console.WriteLine(result2);
        }
    }
}
