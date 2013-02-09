using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace MediaSharp.Model
{
    [Serializable()]
    public class Audio : Document, ISerializable
    {

        #region SETTERS&GETTERS
        public Duration Duration
        {
            get;
            set;
        }
        #endregion
        #region CONSTRUCTORS
        public Audio(String i, String t, Author a, bool c,int m,int s)
            : base(i,t, a, c)
        {
            Duration = new Duration(0,m,s);

        }

        public Audio() : base()
        {
            Duration = new Duration(00,00,00);
        }
        #endregion
        #region Special serialization
        public Audio(SerializationInfo info, StreamingContext ctxt)
            : base(info, ctxt)
        {
            this.Duration = (Duration)info.GetValue("Duration", typeof(Duration));
        }

        new public void GetObjectData(SerializationInfo info, StreamingContext ctxt)
        {
            base.GetObjectData(info, ctxt);
            info.AddValue("Duration", this.Duration);
        }
        #endregion
    }
}
