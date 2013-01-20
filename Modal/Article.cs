using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaSharp.Modal
{
    public class Article
    {
        public Review review;

        public string Review
        {
            get { return review.ToString(); }
        }
    }
}
