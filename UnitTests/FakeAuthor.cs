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
        private string name;
        private string firstName;

        public FakeAuthor()
        {
            name = "NoName";
            firstName = "NoFisrtName";
        }
    }
}
