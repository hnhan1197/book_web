using BookStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BookStore.Controllers
{
    public class BookController : Controller
    {
        private List<Book> listBooks;

        public BookController()
        {
            listBooks = new List<Book>();
            listBooks.Add(new Book(1, "Sách 1", "Tác giả 1", 2017, 500000,"Content/img/book1.png"));
            listBooks.Add(new Book(2, "Sách 2", "Tác giả 2", 2013, 700000, "Content/img/book2.jpg"));
            listBooks.Add(new Book(3, "Sách 3", "Tác giả 3", 2019, 100000, "Content/img/book3.jpg"));
        }
        // GET: Book
        public ActionResult ListBooks()
        {
            return View(listBooks);
        }
    }
}