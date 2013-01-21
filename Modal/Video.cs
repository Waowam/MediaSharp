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
    }
}
