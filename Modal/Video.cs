using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaSharp.Model
{
    public class Video : Document
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
    }
}
