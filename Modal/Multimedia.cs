using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaSharp.Model
{
    public class Multimedia : Document
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
    }
}
