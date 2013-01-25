using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaSharp.Model
{
    public class Document
    {
        private Author author;
        private bool copyright;


        #region SETTERS&GETTERS
        public string ID { get; set; }

        public string Title { get; set; }
        
        public string Author {
            get { return author.FirstName + " " + author.Name;}
            set 
            {
                string[] tmp= value.Split(' ');
                author = new Author(tmp[1], tmp[0]);
            }
        }

        public string Copyright
        {
            get { return copyright == true ? "true" : "false"; }
            set {
                if (value == "true")
                    copyright = true ;
                else 
                    copyright = false;
            }
        }

        #endregion
        #region CONSTRUCTORS

        public Document(String id, String t, Author a, bool c)
        {
            Title = t;
            ID = id;
            Author =  a.Name+" "+a.FirstName ;
            Copyright = c.ToString();
        }
        public Document()
        {
            Title = "Sans titre";
            author = new Author();//Faut trouvé un moyen d'init mais pas a null
            copyright = false;
        }
        #endregion
        #region METHODS
        public string Display()
        {
            
            return "\"" + Title + "\"" + Author + "- " + Copyright;
        }
        #endregion
    }
}
