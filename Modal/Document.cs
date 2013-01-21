using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaSharp.Model
{
    public class Document
    {
        private string id;
        private string title;
        private Author[] authors;
        private bool copyright;


        #region SETTERS&GETTERS
        public string Id
        {
            get { return id; }
            set { id = value; }
        }

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

        #endregion
        #region CONSTRUCTORS
        public Document(String t, Author[] a, bool c)
        {
            Title = t;
            authors = a;
            copyright = c;
        }

        public Document(String t, Author a, bool c)
        {
            Title = t;
            authors = new Model.Author[] { a };
            copyright = c;
        }
        #endregion
        #region METHODS
        public string Display()
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
        #endregion
    }
}
