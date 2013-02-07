using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaSharp.Model
{
    public class Duration
    {
        private int hours;
        private int minutes;
        private int secondes;

        #region GETTERS & SETTERS
        public int Hours { get { return hours; } set { if (value > 0) { hours = value; } else { hours = 0; } } }
        public int Minutes { get { return minutes; } set { if (value > 0) { minutes = value; } else { minutes = 0; } } }
        public int Secondes { get { return secondes; } set { if (value > 0) { secondes = value; } else { secondes = 1; } } }
        #endregion
        #region CONSTRUCTORS
        public Duration(int h, int m, int s)
        {
            Hours = h;
            Minutes = m;
            Secondes = s;
        }

        public Duration()
        {
            Hours = 0;
            Minutes = 0;
            Secondes = 0;
        }
        #endregion

    }
}
