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
                var series1 = new Series()
                {
                    Title = "The amazing Spiderman"

                };
                var series2 = new Series()
                {
                    Title = "The invincible Ironman"

                };

                var artist1 = new Artist()
                {
                    Name = "Stan Lee"
                };
                var artist2 = new Artist()
                {
                    Name = "Steve Dikto"
                }; 
                var artist3 = new Artist()
                {
                    Name = "Jack Kirby"
                };

                var comicBook1 = new ComicBook()
                {
                    Series = series1,
                    IssueNumber = 1,
                    PublishedOn = DateTime.Today
                };

                comicBook1.Artist.Add(artist1);
                comicBook1.Artist.Add(artist2);

                var comicBook2 = new ComicBook()
                {
                    Series = series1,
                    IssueNumber = 1,
                    PublishedOn = DateTime.Today
                };

                comicBook2.Artist.Add(artist1);
                comicBook2.Artist.Add(artist2);

                var comicBook3 = new ComicBook()
                {
                    Series = series2,
                    IssueNumber = 2,
                    PublishedOn = DateTime.Today
                };

                comicBook3.Artist.Add(artist1);
                comicBook3.Artist.Add(artist3);

                context.ComicBooks.Add(comicBook1);
                context.ComicBooks.Add(comicBook2);
                context.ComicBooks.Add(comicBook3);

                context.SaveChanges();

                var comicBooks = context.ComicBooks
                    .Include(cb => cb.Series)
                    .Include (cb => cb.Artist)
                    .ToList();

                foreach (var comicBook in comicBooks)
                {
                    var artistNames = comicBook.Artist.Select(a => a.Name).ToList();
                    var artistDisplayText = string.Join(", ", artistNames);

                    Console.WriteLine(comicBook.DisplayText);
                    Console.WriteLine(artistDisplayText);
                }

                Console.ReadLine();
            }
        }
    }
}
