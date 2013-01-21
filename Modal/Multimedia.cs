using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaSharp.Model
{
    public class Multimedia : Document
    {
        private Audio sound;
        private Video image;
        private Text text;

        #region SETTERS&GETTERS
        public Audio Sound { get; set; }
        public Video Image { get; set; }
        public Text Text { get; set; }
        #endregion
    }
}
