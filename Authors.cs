using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicLibrariy
{
    public class Authors
    {

        public int AuthorId { get; set; }
        public string AuthorName { get; set; }
        public Authors(int authorId,string authorName)
        {
            AuthorId = authorId;    
            AuthorName = authorName;
        }
    }
}
