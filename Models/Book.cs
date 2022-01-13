using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BookStore.Models
{
    public class Book
    {
        public Book(int iD, string tittle, string author, int publishYear, double price, string cover)
        {
            this.iD = iD;
            this.tittle = tittle;
            this.author = author;
            this.publishYear = publishYear;
            this.price = price;
            this.cover = cover;
        }


        public int iD { get; set; }
        public string tittle { get; set; }
        public string author { get; set; }
        public int publishYear { get; set; }
        public double price { get; set; }
        public string cover { get; set; }
    }
}