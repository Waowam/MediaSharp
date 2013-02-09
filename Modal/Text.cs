using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace MediaSharp.Model
{
    [Serializable()]
    public class Text : Document
    {
        #region METHODS
        public string Print()
        {
            return "Document printing. Wait a moment...";
        }
        #endregion
        #region CONSTRUCTORS

        public Text(String i,String t, Author a, bool c) : base(i,t, a, c)
        {

        }

        public Text() : base()
        {
        }
        #endregion
        #region Special serialization
        public Text(SerializationInfo info, StreamingContext ctxt)
        {
          
        }

        public void GetObjectData(SerializationInfo info, StreamingContext ctxt)
        {
            
        }
        #endregion
    }
}
