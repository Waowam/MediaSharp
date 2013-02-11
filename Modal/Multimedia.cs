using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace MediaSharp.Model
{
    [Serializable()]
    public class Multimedia : Document, ISerializable
    {
        #region SETTERS&GETTERS
        public Duration Sound { get; set; }
        public Duration Image { get; set; }
        public string Text_title { get; set; }
        #endregion
        #region CONSTRUCTORS
        public Multimedia(String i, String t, Author a, bool c, int mA,int  sA, int hV,int mV,int  sV, string ttle) : base(i,t, a, c)
        {
            Sound = new Duration(0,mA,sA);
            Image = new Duration(hV,mV,sV);
            Text_title = ttle;

        }

        public Multimedia() : base()
        {
            Sound = new Duration();
            Image = new Duration();
            Text_title = "no_title";
        }
        #endregion
        #region Special serialization
        public Multimedia(SerializationInfo info, StreamingContext ctxt)
            : base(info, ctxt)
        {
            this.Sound = (Duration)info.GetValue("Sound", typeof(Duration));
            this.Image = (Duration)info.GetValue("Image", typeof(Duration));
            this.Text_title = (string)info.GetValue("Text", typeof(string));
        }

        new public void GetObjectData(SerializationInfo info, StreamingContext ctxt)
        {
            base.GetObjectData(info, ctxt);
            info.AddValue("Sound", this.Sound);
            info.AddValue("Image", this.Image);
            info.AddValue("Text", this.Text_title);
        }
        #endregion
    }
}
