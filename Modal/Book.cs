using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaSharp.Model
{
    public class Book : Text
    {
        private string editor;
        private int publicationYear;

        #region SETTERS&GETTERS
        public string Editor
        {
            get { return editor; }
            set { editor = value; }
        }

        public string PublicationYear
        {
            get { return publicationYear.ToString(); }
        }
        #endregion
    }
}
