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
        public Audio Sound { get; set; }
        public Video Image { get; set; }
        public Text Text { get; set; }
        #endregion
        #region CONSTRUCTORS
        public Multimedia(String i, String t, Author a, bool c, Audio s, Video v, Text te) : base(i,t, a, c)
        {
            Sound = s;
            Image = v;
            Text = te;

        }

        public Multimedia() : base()
        {
            Sound = null;
            Image = null;
            Text = null;
        }
        #endregion
        #region Special serialization
        public Multimedia(SerializationInfo info, StreamingContext ctxt)
            : base(info, ctxt)
        {
            this.Sound = (Audio)info.GetValue("Sound", typeof(Audio));
            this.Image = (Video)info.GetValue("Image", typeof(Video));
            this.Text = (Text)info.GetValue("Text", typeof(Text));
        }

        new public void GetObjectData(SerializationInfo info, StreamingContext ctxt)
        {
            base.GetObjectData(info, ctxt);
            info.AddValue("Sound", this.Sound);
            info.AddValue("Image", this.Image);
            info.AddValue("Text", this.Text);
        }
        #endregion
    }
}
