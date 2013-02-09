using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace MediaSharp.Model
{
    [Serializable()]
    public class Duration : ISerializable
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
        #region Special serialization
        public Duration (SerializationInfo info, StreamingContext ctxt)
        {
            this.hours = (int)info.GetValue("Hours", typeof(int));
            this.minutes = (int)info.GetValue("Minutes", typeof(int));
            this.secondes = (int)info.GetValue("Secondes", typeof(int));
        }

        public void GetObjectData(SerializationInfo info, StreamingContext ctxt)
        {
            info.AddValue("Hours", this.hours);
            info.AddValue("Minutes", this.minutes);
            info.AddValue("Secondes", this.secondes);
        }
        #endregion

    }
}
