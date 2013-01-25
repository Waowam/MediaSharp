﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaSharp.Model
{
    public class Text : Document
    {
        #region METHODS
        public string Print()
        {
            return "Document printing. Wait a moment...";
        }
        #endregion
        #region CONSTRUCTORS
        public Text(String t, Author[] a, bool c) : base(t, a, c)
        {

        }

        public Text(String t, Author a, bool c) : base(t, a, c)
        {

        }

        public Text() : base()
        {
        }
        #endregion
    }
}
