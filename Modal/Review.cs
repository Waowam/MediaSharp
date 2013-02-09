using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace MediaSharp.Model
{
    [Serializable()]
    public class Review : ISerializable
    {
        #region SETTERS&GETTERS
        public string Title { get; set; }

        public string Editor { get; set; }

        public string Number { get; set; }
        #endregion
        #region CONSTRUCTORS
        public Review(string t, string e, string n)
        {
            Title = t;
            Editor = e;
            Number = n;
        }

        public Review()
        {
            Title = "NoTitle";
            Editor = "Unknown";
            Number = "";
        }
        #endregion
        #region Special serialization
        public Review(SerializationInfo info, StreamingContext ctxt)
        {
            this.Title = (string)info.GetValue("Title", typeof(string));
            this.Editor = (string)info.GetValue("Editor", typeof(string));
            this.Number = (string)info.GetValue("Number", typeof(string));
        }

        public void GetObjectData(SerializationInfo info, StreamingContext ctxt)
        {
            info.AddValue("Title", this.Title);
            info.AddValue("Editor", this.Editor);
            info.AddValue("Number", this.Number);
        }
        #endregion
    }
}
