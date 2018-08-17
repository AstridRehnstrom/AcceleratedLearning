using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace _11._2_Work_with_list_of_Customers
{
    public enum Gender
    {
        Female, Male, Other
    }


    class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public int Age { get; set; }
        public Gender Gender { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {

            var allLines = File.ReadAllLines("People.txt");
            var allCustomers = new List<Customer>();


            foreach (var line in allLines)
            {

                var splittedLine = line.Split(',');
                var id = splittedLine[0];
                var name = splittedLine[1];
                var lastName = splittedLine[2];
                var email = splittedLine[3];
                var gender = splittedLine[4];
                var age = splittedLine[5];

                var customer = new Customer();

                //var xx = Enum.Parse<Gender>("aaaa");
                customer.Id = int.Parse(id);
                customer.Name = name;
                customer.LastName = lastName;
                customer.Email = email;
                customer.Age = int.Parse(age);
                customer.Gender = Enum.Parse<Gender>(gender);

                allCustomers.Add(customer);
            }

            Console.WriteLine("Sorted list by age:");

            var sortedByAge = allCustomers.OrderBy(x => x.Age);

            foreach (var item in sortedByAge)
            {
                Console.WriteLine(item.Name.PadRight(10) + "    " + item.Age.ToString().PadRight(4) + " " + item.Gender);
            }


            Console.WriteLine();
            Console.WriteLine("Sorted list by name:");
            var sortedByName = allCustomers.OrderBy(x => x.Name);

            foreach (var item in sortedByName)
            {
                Console.WriteLine(item.Name.PadRight(10) + "    " + item.Age.ToString().PadRight(4) + " " + item.Gender);
            }


            Console.WriteLine();
            Console.WriteLine("Men Older than 35:");
            var menOlder = allCustomers.Where(x => x.Gender == Gender.Male && x.Age > 35).OrderBy(x => x.Name);

            foreach (var item in menOlder)
            {
                Console.WriteLine(item.Name.PadRight(10) + "    " + item.Age.ToString().PadRight(4) + " " + item.Gender);
            }


            Console.WriteLine();
            Console.WriteLine("Men Older than 35, manipulated:");
            var menOlderPlus = allCustomers.Where(x => x.Gender == Gender.Male && x.Age > 35).OrderBy(x => x.Name);

            foreach (var item in menOlderPlus)
            {
                item.Age = item.Age + 1000;
                Console.WriteLine(item.Name.PadRight(10) + "    " + item.Age.ToString().PadRight(4) + " " + item.Gender);
            }

            //List<int> x1 = allCustomers.Select(x => x.Age).ToList();
            //List<string> x2 = allCustomers.Select(x => x.Name).ToList();
            //List<int> x3 = allCustomers.Select(x => x.Name.Count()).ToList();

            List<Customer> x4 = menOlder.Select(x =>

                new Customer
                {
                    Name=x.Name,
                    Gender = Gender.Male,
                    Age = x.Age + 1000
                }

            ).ToList();

            Console.WriteLine();
            Console.WriteLine("Men Older than 35, manipulated with selected:");

            foreach (var item in x4)
            {
                Console.WriteLine(item.Name.PadRight(10) + "    " + item.Age.ToString().PadRight(4) + " " + item.Gender);
            }


        }

    }
}

