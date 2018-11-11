using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.BLL
{
    class Book
    {
        string isbn;
        string title;
        double unitPrice;
        int yearPublished;
        int qoh;
        string category;

        public Book()
        {
            Isbn = "";
            Title = "";
            UnitPrice = 0.0;
            YearPublished = 1900;
            Qoh = 0;
            Category = "undefined";
        }

        public Book(string isbn, string title, double unitPrice, int yearPublished, int qoh, string category)
        {
            this.Isbn = isbn;
            this.Title = title;
            this.UnitPrice = unitPrice;
            this.YearPublished = yearPublished;
            this.Qoh = qoh;
            this.Category = category;
        }

        public string Isbn { get => isbn; set => isbn = value; }
        public string Title { get => title; set => title = value; }
        public double UnitPrice { get => unitPrice; set => unitPrice = value; }
        public int YearPublished { get => yearPublished; set => yearPublished = value; }
        public int Qoh { get => qoh; set => qoh = value; }
        public string Category { get => category; set => category = value; }
    }
}
