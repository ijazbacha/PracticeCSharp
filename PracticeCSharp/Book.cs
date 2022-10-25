using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace PracticeCSharp
{
    internal class Book
    {
        public string title;
        public string author;
        public int numPages;

        public Book(string aTitle, string aAuthor,int aNumpage)
        {
            title = aTitle;
            author = aAuthor;
            numPages = aNumpage;
        }

        public string GetTitle(string title)
        {
            return title + " this is title";
        }
    }

    
}
