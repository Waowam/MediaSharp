using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaSharp.Modal
{
    public class Author
    {
        private string name;
        private string firstName;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string FirstName { get { return firstName; } set { firstName = value; } }

        public Author(Modal.Author a)
        {
            a.Name = name;
        }

        public Author(String n, String fn)
        {
            name = n;
            firstName = fn;
        }
    }
}
