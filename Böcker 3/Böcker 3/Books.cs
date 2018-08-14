using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Böcker_3
{
    class Product
    {
        public string ProductId { get; set; }
        

    }



    class ElectronicBook : Book
    {
        public ElectronicBook(string isbn, string title) : base(isbn, title)
        {

        }

        public void SendBookTo(string emailAdress)
        {
            Console.WriteLine("Send book to " + emailAdress);
        }
    }




    class Book : Product
    {
        

        public string Isbn { get; set; }
        public string Author { get; set; }
        public double NrOfPages { get; set; }
        public string Title { get; set; }

        public Book(string isbn, string title)
        {
            Isbn = isbn;
            Title = title;
        }


       

        public double WeightInGram(double number)
        {
            return number * 0.8;

        }

        public string Size(double number)
        {
            if (number < 100)
            {
                return "Tunn";
            }
            else if (number > 100 && number < 299)
            {
                return "Normal";
            }
            else
                return "Tjock";
        }
    }
}

