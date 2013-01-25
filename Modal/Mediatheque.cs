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

        #region SETTERS&GETTERS
        public List<Document> AllDocuments
        {
            get { return docs; }
            set { docs = value; }
        }
        #endregion
        #region CONSTRUCTORS
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
            foreach (Document doc in d)
            {
                docs.Add(doc);
            }
        }
        #endregion
        #region METHODS
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

        public List<Document> GetAudio()
        {
            List<Document> resAudio = new List<Document>();
            foreach (Document d in docs)
            {
                if (d is Audio)
                    resAudio.Add(d);
            }
            return resAudio;
        }

        public List<Document> GetVideo()
        {
            List<Document> resAudio = new List<Document>();
            foreach (Document d in docs)
            {
                if (d is Video)
                    resAudio.Add(d);
            }
            return resAudio;
        }

        public List<Document> GetText()
        {
            List<Document> resAudio = new List<Document>();
            foreach (Document d in docs)
            {
                if (d is Text)
                    resAudio.Add(d);
            }
            return resAudio;
        }

        public List<Document> GetMultimedia()
        {
            List<Document> resAudio = new List<Document>();
            foreach (Document d in docs)
            {
                if (d is Audio)
                    resAudio.Add(d);
            }
            return resAudio;
        }
        #endregion
    }
}
