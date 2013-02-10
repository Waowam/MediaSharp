using MediaSharp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTests
{
    class FakeAuthor : Author
    {
        public string Name { get; set; }

        public string FirstName { get; set; }

        public FakeAuthor()
        {
            Name = "NoName";
            FirstName = "NoFirstName";
        }
    }
}
