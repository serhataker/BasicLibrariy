using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicLibrariy
{
    public class Book
    {
        public int _bookId;
        public string _title;
        public int _authorId;


        public int BookId { get; set; }
        public string Title { get; set; }
        public int AuthorId { get; set; }
        public Book(int _bookId, string _title,int _authorId)
        {
            BookId = _bookId;
            Title = _title; 
            AuthorId = _authorId;
        }
    }
}
