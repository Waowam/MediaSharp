using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace MediaSharp.Model
{
    [Serializable()]
    public class Book : Text, ISerializable
    {
        private int publicationYear;

        #region SETTERS&GETTERS
        public string Editor { get; set; }

        public string PublicationYear
        {
            get { return publicationYear.ToString(); }
        }
        #endregion
        #region CONSTRUCTORS
        public Book(String i, String t, Author a, bool c, string e, int p)
            : base(i, t, a, c)
        {
            Editor = e;
            publicationYear = p;
        }

        public Book()
            : base()
        {
            Editor = "";
            publicationYear = 0;
        }
        #endregion
        #region Special serialization
        public Book(SerializationInfo info, StreamingContext ctxt)
            : base(info, ctxt)
        {
            this.Editor = (string)info.GetValue("Editor", typeof(string));
            this.publicationYear = (int)info.GetValue("PublicationYear", typeof(int));
        }

        new public void GetObjectData(SerializationInfo info, StreamingContext ctxt)
        {
            base.GetObjectData(info, ctxt);
            info.AddValue("Editor", this.Editor);
            info.AddValue("PublicationYear", this.publicationYear);
        }
        #endregion
    }
}
