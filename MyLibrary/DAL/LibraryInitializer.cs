using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using MyLibrary.Models;

namespace MyLibrary.DAL
{
    public class LibraryInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<LibraryContext>
    {
        protected override void Seed(LibraryContext context)
        {
            var books = new List<Book>
            {
            new Book{Title="The Lord of the Rings : Two Towers",Author="J.R.R. Tolkien",Description="Multuple races try to melt a ring",PublishDate=DateTime.Parse("1954-11-11")},
            new Book{Title="A Game of Thrones : A Song of Ice and Fire", Description="A book about people dying",Author="George R.R. Martin",PublishDate=DateTime.Parse("1996-08-01")},
            new Book{Title="KingKiller Chronicles : The Name of the Wind",Description="Alchemy + School + Dragons = What more could you ask for?",Author="Patrick Rothfuss",PublishDate=DateTime.Parse("2007-03-27")},
            new Book{Title="Harry Potter and The Sorcerer's Stone ",Author="J.K. Rowling", Description ="Boy wizard wins against impossible odds.",PublishDate=DateTime.Parse("1997-06-26")},
            new Book{Title="The Last Wish",Author="Andrzej Sapkowski",Description="A witcher goes on hilarious adventures.",PublishDate=DateTime.Parse("2008-05-01")},
            new Book{Title="American Gods",Author="Neil Gaimen", Description="What do you knkow, a tale about old gods",PublishDate=DateTime.Parse("2001-06-19")},
            new Book{Title="The Wizard Knight",Author="Gene Wolfe",Description="The Childhood I should have had",PublishDate=DateTime.Parse("2004-01-04")},
            new Book{Title="Dragon Prince",Author="Melanie Rawn",Description="Epic Fantasy, whats not to love.",PublishDate=DateTime.Parse("1988-12-06")}
            };

            books.ForEach(s => context.Books.Add(s));
            context.SaveChanges();           
        }
    }
}