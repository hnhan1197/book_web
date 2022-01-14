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

        public ActionResult Detail(int? id)
        {
            if (id == null)
                return HttpNotFound();
            Book book = listBooks.FirstOrDefault(p => p.iD == id);
            if (book == null)
            {
                return HttpNotFound();
            }
            return View(book);
        }

        public ActionResult Edit(int? id)
        {
            if (id == null)
                return HttpNotFound();
            Book book = listBooks.FirstOrDefault(p => p.iD == id);
            if (book == null)
            {
                return HttpNotFound();
            }
            return View(book);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Book book)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    var editBook = listBooks.FirstOrDefault(p => p.iD == book.iD);
                    editBook.tittle = book.tittle;
                    editBook.author = book.author;
                    editBook.cover = book.cover;
                    editBook.author = book.author;
                    editBook.publishYear = book.publishYear;
                    return View("ListBooks", listBooks);
                }
                catch
                {
                    return HttpNotFound();
                    throw;
                }
            }else
            {
                ModelState.AddModelError("","Input Model Not Valid!");
                return View(book);
            }
        }
    }
}