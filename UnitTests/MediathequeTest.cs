using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MediaSharp.Model;

namespace UnitTests
{
    [TestClass]
    public class MediathequeTest
    {
        #region TEST : Constructors
        [TestMethod]
        public void TestConstructor()
        {
            Mediatheque med = new Mediatheque();
            Assert.AreEqual(0, med.AllDocuments.Count, "Creation d'une mediatheque non vide.");
        }
        #endregion
        #region TEST : Methods
        [TestMethod]
        public void Test_ManageDocument()
        {
            Mediatheque med = new Mediatheque();
            FakeDocument[] docs = new FakeDocument[3];
                docs[0] = new FakeDocument();
                docs[1] = new FakeDocument();
                docs[2] = new FakeDocument();

            //ADD
            med.AddDocument(docs[0]);
            Assert.AreEqual(1, med.AllDocuments.Count, "Mediatheque : erreur ajout document.");
            med.AddDocument(docs[1]);
            Assert.AreEqual(2, med.AllDocuments.Count, "Mediatheque : erreur ajout document.");
            med.AddDocument(docs[2]);
            Assert.AreEqual(3, med.AllDocuments.Count, "Mediatheque : erreur ajout document.");
           
            //REMOVE
            med.DeleteDocument(docs[0]);
            Assert.AreEqual(2, med.AllDocuments.Count, "Mediatheque : erreur suppression document.");
            
            med.ClearLibrary();
            Assert.AreEqual(0, med.AllDocuments.Count, "Mediatheque : erreur ClearLibrary() document.");

            med.DeleteDocument(docs[0]);
            Assert.AreEqual(0, med.AllDocuments.Count, "Mediatheque : erreur suppression document.");
        }
        #endregion
    }
}
