﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Böcker_1
{
    class Book
    {
        //public string Isbn { get; set; }
        //public string Author { get; set; }
        //public int NrOfPages { get; set; }

        private string _isbn;
        private string _author;
        private double _number;


        public string GetIsbn()
        {
            return _isbn;
        }

        public void SetIsbn(string isbn)
        {
            _isbn = isbn;
            
        }

        public string GetAuthor()
        {
            return _author;
        }

        public void SetAuthor(string author)
        {
            _author = author;

        }


        public double GetNrOfPages()
        {
            return _number;
        }

        public void SetNrOfPages(double number)
        {
            _number = number;

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


