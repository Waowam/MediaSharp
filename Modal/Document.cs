using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace MediaSharp.Model
{
     [Serializable()]
    public class Document
    {
        private string id;
        private string title;
        private Author author;
        private bool copyright;


        #region SETTERS&GETTERS
        public string ID
        {
            get { return id; }
            set { id = value; }
        }

        public string Title 
        {
            get { return title; }
            set { title = value;}
        }
        
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

        public void serialize(string fileName)
        {
            FileStream s;
            s = new FileStream(fileName, FileMode.Create, FileAccess.ReadWrite);
            BinaryFormatter B = new BinaryFormatter();
            B.Serialize(s, this);
            s.Close();
        }

        public Document deSerialize(string fileName)
        {
            FileStream Fs = new FileStream(fileName, FileMode.Open, FileAccess.Read);
            BinaryFormatter F = new BinaryFormatter();
            Document s1 = (Document)F.Deserialize(Fs);
            Fs.Close();
            return s1;
        }
        #endregion
    }
}
