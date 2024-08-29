using System;
namespace BasicLibrariy
{

    class Program
    {
        static void Main(string[] args)
        
        {

          List<Authors> Authorlist = new List<Authors>();
            Authorlist.Add(new Authors(1, "Kemal Tahir"));
            Authorlist.Add(new Authors(2, "Yaşar Kemal"));
            Authorlist.Add(new Authors(3, "Orhan Kemal"));
            
            List<Book> Booklist = new List<Book>();
            Booklist.Add(new Book(1, "İnce Memed",2));
            Booklist.Add(new Book(2, "Ağrı Dağı Efsanesi",2));
            Booklist.Add(new Book(3, "Esir Şehrin İnsanları",1));
            Booklist.Add(new Book(4, "72.Koğuş",3));
            Booklist.Add(new Book(5, "Hanımın Çiftliği",3));

            var AuthorAndBook = from Authors in Authorlist
                                join Book in Booklist
                                on Authors.AuthorId equals Book.AuthorId
                                select new {
                                    BookName = Book.Title,
                                    AuthorName = Authors.AuthorName
                                };
            foreach (var ab in AuthorAndBook) {

                Console.WriteLine($"Book Title: {ab.BookName} | Author Name: {ab.AuthorName}");

            }

        }

        
        }

}