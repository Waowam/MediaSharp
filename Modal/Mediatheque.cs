using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace MediaSharp.Model
{
    [Serializable()]
    public class Mediatheque : ISerializable
    {
        #region SETTERS&GETTERS
        public List<Document> AllDocuments { get; set; }

        #endregion
        #region CONSTRUCTORS
        public Mediatheque()
        {
            AllDocuments = new List<Document>();
        }

        public Mediatheque(Model.Mediatheque m)
        {
            AllDocuments = m.AllDocuments;
        }

        public Mediatheque(Document[] d)
        {
            foreach (Document doc in d)
            {
                AllDocuments.Add(doc);
            }
        }
        #endregion
        #region Special serialization
        public Mediatheque(SerializationInfo info, StreamingContext ctxt)
        {
            this.AllDocuments = (List<Document>)info.GetValue("Documents", typeof(List<Document>));
        }

        public void GetObjectData(SerializationInfo info, StreamingContext ctxt)
        {
            info.AddValue("Documents", this.AllDocuments);
        }
        #endregion
        #region METHODS
        public void AddDocument(Document d)
        {
            AllDocuments.Add(d);
        }

        public void DeleteDocument(Document d)
        {
            if (AllDocuments.Contains(d))
                AllDocuments.Remove(d);
        }

        public void ClearLibrary()
        {
            AllDocuments.Clear();
        }

        public List<Document> GetDocument(string t)
        {
            var selectRes = from d in AllDocuments where d.GetType().ToString() == t select d;
            List<Document> res = new List<Document>();
            foreach (Document doc in selectRes) { res.Add(doc); }
            return res;
        }
        #endregion
    }
}
