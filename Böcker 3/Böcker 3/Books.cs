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
        //private int _id;


        //public int GetProductId()
        //{
        //    return _id;
        //}

        //public void SetProductId(int id)
        //{
        //    _id = id;

        //}

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
        //private string _isbn;
        //private string _author;
        //private double _number;
        //private double _title;

        public string Isbn { get; set; }
        public string Author { get; set; }
        public double NrOfPages { get; set; }
        public string Title { get; set; }

        public Book(string isbn, string title)
        {
            Isbn = isbn;
            Title = title;
        }


        //public string GetIsbn()
        //{
        //    return _isbn;
        //}

        //public void SetIsbn(string isbn)
        //{
        //    _isbn = isbn;

        //}

        //public string GetAuthor()
        //{
        //    return _author;
        //}

        //public void SetAuthor(string author)
        //{
        //    _author = author;

        //}


        //public double GetNrOfPages()
        //{
        //    return _number;
        //}

        //public void SetNrOfPages(double number)
        //{
        //    _number = number;

        //}


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

