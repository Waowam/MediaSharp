using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace MediaSharp.Model
{
    [Serializable()]
    public class Author, ISerializable
    {
        #region SETTERS&GETTERS
        public string Name { get; set; }

        public string FirstName { get; set; }
        #endregion
        #region CONSTRUCTORS
        public Author(Model.Author a)
        {
            Name = a.Name;
        }

        public Author(String n, String fn)
        {
            Name = n;
            FirstName = fn;
        }

        public Author() : this("","")
        {
        }
        #endregion
        #region Special serialization
        public Author(SerializationInfo info, StreamingContext ctxt)
        {
            this.Name = (string)info.GetValue("Name", typeof(string));
            this.FirstName = (string)info.GetValue("FirstName", typeof(string));
        }

        public void GetObjectData(SerializationInfo info, StreamingContext ctxt)
        {
            info.AddValue("Name", this.Name);
            info.AddValue("FirstName", this.FirstName);
        }
        #endregion
    }
}
