using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaSharp.Model
{
    public class Mediatheque
    {
        private List<Document> docs;

        public List<Document> AllDocuments
        {
            get { return docs; }
            set { docs = value; }
        }

        public void AddDocument(Document d)
        {
            docs.Add(d);
        }

        public void DeleteDocument(Document d)
        {
            if (docs.Contains(d))
                docs.Remove(d);
        }

        public void ClearLibrary()
        {
            foreach(Document d in docs)
            {
                docs.Remove(d);
            }
        }

        public Mediatheque()
        {
            docs = new List<Document>();
        }

        public Mediatheque(Model.Mediatheque m)
        {
            docs = m.AllDocuments;
        }

        public Mediatheque(Document[] d)
        {
            foreach(Document doc in d)
            {
                docs.Add(doc);
            }
        }
    }
}
