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
        public void TestConstructor1()
        {
            Mediatheque med = new Mediatheque();
            Assert.AreEqual(med.AllDocuments.Count, 0, "Creation d'une mediatheque non vide.");
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
            Assert.AreEqual(med.AllDocuments.Count, 1, "Mediatheque : erreur ajout document.");
            med.AddDocument(docs[1]);
            Assert.AreEqual(med.AllDocuments.Count, 2, "Mediatheque : erreur ajout document.");
            med.AddDocument(docs[2]);
            Assert.AreEqual(med.AllDocuments.Count, 3, "Mediatheque : erreur ajout document.");
           
            //REMOVE
            med.DeleteDocument(docs[0]);
            Assert.AreEqual(med.AllDocuments.Count, 2, "Mediatheque : erreur suppression document.");
            
            med.ClearLibrary();
            Assert.AreEqual(med.AllDocuments.Count, 0, "Mediatheque : erreur ClearLibrary() document.");

            med.DeleteDocument(docs[0]);
            Assert.AreEqual(med.AllDocuments.Count, 0, "Mediatheque : erreur suppression document.");
        }
        #endregion
    }
}
