using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaSharp.Model
{
    public class Author
    {
        private string name;
        private string firstName;

        #region SETTERS&GETTERS
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string FirstName { get { return firstName; } set { firstName = value; } }
        #endregion
        #region CONSTRUCTORS
        public Author(Model.Author a)
        {
            a.Name = name;
        }

        public Author(String n, String fn)
        {
            name = n;
            firstName = fn;
        }
        #endregion
    }
}
