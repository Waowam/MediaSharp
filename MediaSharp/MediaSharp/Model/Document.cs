using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaSharp.Model
{
    class Document
    {
        private string title;
        private Author[] authors;
        private bool copyright;

        public string Title { public get; public set; }
        
        public string[] Authors {
            public get
            {
                List<string> allAuth = new List<string>;
                
                foreach(Author a in authors){
                    allAuth.Add(a.Name);
                }
                return allAuth.ToArray();
            }
            public set;
        }

        public string Copyright
        {
            public get;
            public set;
        }

        public string Print { }
    }
}
