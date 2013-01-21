using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaSharp.Model
{
    public class Article : Text
    {
        public Review review;

        #region SETTERS&GETTERS
        public string Review
        {
            get { return review.ToString(); }
        }
        #endregion
    }
}
