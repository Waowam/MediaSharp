using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace MediaSharp.Model
{
    [Serializable()]
    public class Video : Document, ISerializable
    {

        #region SETTERS&GETTERS
        public Duration Duration
        {
            get;
            set;
        }
        #endregion
        #region CONSTRUCTORS
        public Video(String i,String t, Author a, bool c, int h,int m,int s) : base(i ,t , a, c)
        {
            Duration = new Duration(h,m,s);

        }

        public Video() : base()
        {
            Duration = new Duration(00,00,00);
        }
        #endregion
        #region Special serialization
        public Video(SerializationInfo info, StreamingContext ctxt)
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
