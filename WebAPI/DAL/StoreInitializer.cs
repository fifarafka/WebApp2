using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using WebApp.Models;

namespace WebApp.DAL
{
    public class StoreInitializer : DropCreateDatabaseIfModelChanges<StoreContext>
    {
        protected override void Seed(StoreContext context)
        {
            var authors = new List<Author>
            {
                new Author() {AuthorName = "Adrianna", AuthorSurname = "Grande"},
                new Author() {AuthorName = "Janusz", AuthorSurname = "Bieber"},

            };
            authors.ForEach(i => context.Authors.Add(i));
            context.SaveChanges();

            var books = new List<Book>()
            {
                new Book() {BookTitle = "Dlaczego ja?"},
                new Book() {BookTitle="Pamietniki z wakacji"}
            };
            books.ForEach(g => context.Books.Add(g));
            context.SaveChanges();

        }
    }
}