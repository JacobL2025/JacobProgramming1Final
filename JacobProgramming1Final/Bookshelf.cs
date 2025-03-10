using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JacobProgramming1Final
{
    public class Bookshelf
    {
        public int BookId { get; set; }
        public string BookTitle { get; set; }
        public string BookAuthor { get; set; }

        public override string ToString()
        {
            return $"{BookId} - {BookTitle} - {BookAuthor}";
        }
    }
}
