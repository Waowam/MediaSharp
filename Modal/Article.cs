using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace MediaSharp.Model
{
    [Serializable()]
    public class Article : Text, ISerializable
    {
        private Review review;

        #region SETTERS&GETTERS
        public string Review
        {
            get { return review.ToString(); }
        }

        public string Review_title { get { return review.Title; } }
        public string Review_Editor { get { return review.Editor; } }
        public string Review_Number { get { return review.Number; } }
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
        #region Special serialization
        public Article(SerializationInfo info, StreamingContext ctxt)
        {
            this.review = (Review)info.GetValue("Review", typeof(Review));
        }

        public void GetObjectData(SerializationInfo info, StreamingContext ctxt)
        {
            info.AddValue("Review", this.review);
        }
        #endregion
    }
}
