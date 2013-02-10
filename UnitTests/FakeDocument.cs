using MediaSharp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTests
{
    class FakeDocument : Document
    {
        private FakeAuthor author;
        private bool copyright;
        private string title;
        private string id;

        public FakeDocument()
        {
            id = "0";
            title = "Sans titre";
            author = new FakeAuthor();
            copyright = false;
        }
    }
}
