using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaSharp.Model
{
    class Author
    {
        private string name;
        private string firstName;

        public string Name
        {
            public get { return name + firstName; }
            public set;
        }
    }
}
