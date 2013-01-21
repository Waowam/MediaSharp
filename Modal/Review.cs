using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaSharp.Model
{
    public class Review
    {
        private string title;
        private string editor;
        private string number;

        #region SETTERS&GETTERS
        public string Title
        {
            get { return title; }
            set { title = value; }
        }

        public string Editor
        {
             get { return editor; }
             set { editor = value; }
        }

        public string Number
        {
            get { return number; }
            set{ number = value; }
        }
        #endregion
    }
}
