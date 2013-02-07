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
    }
}
