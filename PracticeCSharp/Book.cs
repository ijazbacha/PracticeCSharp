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
        public static int count = 0;

        public Book(string aTitle, string aAuthor,int aNumpage)
        {
            title = aTitle;
            author = aAuthor;
            numPages = aNumpage;
            count++;
        }

        public string GetTitle()
        {
            return title + " this is title";
        }

        public int GetCount()
        {
            return count;
        }
    }

    
}
