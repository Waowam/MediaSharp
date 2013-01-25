using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaSharp.Model
{
    public class Video : Document
    {
        private int duration;

        #region SETTERS&GETTERS
        public int Duration
        {
            get;
            set;
        }
        #endregion
        #region CONSTRUCTORS
        public Video(String t, Author[] a, bool c, int d) : base(t, a, c)
        {
            Duration = d;

        }

        public Video(String t, Author a, bool c, int d) : base(t, a, c)
        {
            Duration = d;

        }

        public Video() : base()
        {
            Duration = 0;
        }
        #endregion
    }
}
