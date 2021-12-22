using System;
using System.Linq;
using System.Data.Entity;
using ComicBookGalleryModel.Models;

namespace ComicBookGalleryModel
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var context = new Context())
            {
                var series = new Series()
                {
                    Title = "The amazing Spiderman"

                };
                context.ComicBooks.Add(new Models.ComicBook()
                {
                    Series = series,
                    IssueNumber = 1,
                    PublishedOn = DateTime.Today
                });
                context.ComicBooks.Add(new Models.ComicBook()
                {
                    Series = series,
                    IssueNumber = 2,
                    PublishedOn = DateTime.Today
                });
                context.SaveChanges();

                var comicBooks = context.ComicBooks
                    .Include(cb => cb.Series)
                    .ToList();

                foreach (var comicBook in comicBooks)
                {
                    Console.WriteLine(comicBook.DisplayText);
                }

                Console.ReadLine();
            }
        }
    }
}
