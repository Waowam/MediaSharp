using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaSharp.Model
{
    public class Audio : Document
    {
        #region SETTERS&GETTERS
        public string Duration
        {
            get;
            set;
        }
        #endregion
        #region CONSTRUCTORS
        public Audio(String i, String t, Author a, bool c, string d)
            : base(i,t, a, c)
        {
            Duration = d;

        }

        public Audio() : base()
        {
            Duration = "00:00:00";
        }
        #endregion
    }
}
