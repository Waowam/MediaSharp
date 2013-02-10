using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace MediaSharp.Model
{
    [Serializable()]
    public class Document : ISerializable
    {
        private Author author;
        private bool copyright;


        #region SETTERS&GETTERS
        public string ID { get; set; }

        public string Title { get; set; }
        
        public string Author {
            get { return author.Name + " " + author.FirstName; }
            set 
            {
                string[] tmp= value.Split(' ');
                author = new Author(tmp[0], tmp[1]);
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
            author = new Author("UnknownName", "UnknownFirstName");
            copyright = false;
        }
        #endregion
        #region Special serialization
        public Document(SerializationInfo info, StreamingContext ctxt)
        {
            this.ID = (string)info.GetValue("ID", typeof(string));
            this.Title = (string)info.GetValue("Title", typeof(string));
            this.Author = (string)info.GetValue("Author", typeof(string));
            this.Copyright = (string)info.GetValue("Copyright", typeof(string));
        }

        public void GetObjectData(SerializationInfo info, StreamingContext ctxt)
        {
            info.AddValue("ID", this.ID);
            info.AddValue("Title", this.Title);
            info.AddValue("Author", this.Author);
            info.AddValue("Copyright", this.Copyright);
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
