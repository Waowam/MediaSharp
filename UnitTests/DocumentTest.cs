using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MediaSharp.Model;

namespace UnitTests
{
    [TestClass]
    public class DocumentTest
    {
        #region TEST : Constructors
        [TestMethod]
        public void TestConstructor()
        {
            FakeAuthor fAuthor = new FakeAuthor();
            Document doc = new Document("42","TitleTest",fAuthor,false);

            Assert.AreEqual("42", doc.ID, "Creation document : id incorrect.");
            Assert.AreEqual("TitleTest", doc.Title, "Creation document : titre incorrect.");
            Assert.AreEqual("false", doc.Copyright, "Creation document : copyright incorrect.");
        }
        #endregion
    }
}
