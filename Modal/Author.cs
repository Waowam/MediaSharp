using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaSharp.Model
{
    [Serializable()]
    public class Author
    {
        #region SETTERS&GETTERS
        public string Name { get; set; }

        public string FirstName { get; set; }
        #endregion
        #region CONSTRUCTORS
        public Author(Model.Author a)
        {
            Name = a.Name;
        }

        public Author(String n, String fn)
        {
            Name = n;
            FirstName = fn;
        }

        public Author() : this("","")
        {
        }
        #endregion
    }
}
