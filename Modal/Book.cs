using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaSharp.Modal
{
    public class Book
    {
        private string editor;
        private int publicationYear;

        public string Editor
        {
            get { return editor; }
            set { editor = value; }
        }

        public string PublicationYear
        {
            get { return publicationYear.ToString(); }
        }
    }
}
