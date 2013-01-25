using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaSharp.Model
{
    public class Article : Text
    {
        private Review review;

        #region SETTERS&GETTERS
        public string Review
        {
            get { return review.ToString(); }
        }
        #endregion
        #region CONSTRUCTORS
        public Article(String i, String t, Author a, bool c, Review r)
            : base(i, t, a, c)
        {
            review = r;
        }

        public Article()
            : base()
        {
            review = null;
        }
        #endregion
    }
}
