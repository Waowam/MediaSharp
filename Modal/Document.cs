using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaSharp.Modal
{
    public class Document
    {
        private string title;
        private Author[] authors;
        private bool copyright;

        public string Title 
        {
            get { return title; }
            set { title = value;}
        }
        
        public string[] Authors {
            get
            {
                List<string> allAuth = new List<string>();
                
                foreach(Author a in authors){
                    allAuth.Add(a.Name);
                }
                return allAuth.ToArray();
            }
        }

        public string Copyright
        {
            get { return copyright == true ? "©" : ""; }
        }

        public string Print()
        {
            string authors = "";
            string lastAut = Authors.Last();
            foreach (string a in Authors)
            {
                authors = a;
                authors += ((lastAut==a) ? "" : ", ");
            }
            return "\"" + Title + "\"" + authors + "- " + Copyright;
        }

        public Document(String t, Author[] a, bool c)
        {
            Title = t;
            authors = a;
            copyright = c;
        }
            public Document(String t, Author a, bool c)
        {
            Title = t;
            authors = new Modal.Author[] { a };
            copyright = c;
        }
    }
}
