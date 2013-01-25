using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaSharp.Model
{
    public class Mediatheque
    {
        #region SETTERS&GETTERS
        public List<Document> AllDocuments { get; set; }

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
            AllDocuments.Add(d);
        }

        public void DeleteDocument(Document d)
        {
            if (AllDocuments.Contains(d))
                AllDocuments.Remove(d);
        }

        public void ClearLibrary()
        {
            foreach (Document d in AllDocuments)
            {
                AllDocuments.Remove(d);
            }
        }

        public List<Document> GetAudio()
        {
            List<Document> resAudio = new List<Document>();
            foreach (Document d in AllDocuments)
            {
                if (d is Audio)
                    resAudio.Add(d);
            }
            return resAudio;
        }

        public List<Document> GetVideo()
        {
            List<Document> resAudio = new List<Document>();
            foreach (Document d in AllDocuments)
            {
                if (d is Video)
                    resAudio.Add(d);
            }
            return resAudio;
        }

        public List<Document> GetText()
        {
            List<Document> resAudio = new List<Document>();
            foreach (Document d in AllDocuments)
            {
                if (d is Text)
                    resAudio.Add(d);
            }
            return resAudio;
        }

        public List<Document> GetMultimedia()
        {
            List<Document> resAudio = new List<Document>();
            foreach (Document d in AllDocuments)
            {
                if (d is Audio)
                    resAudio.Add(d);
            }
            return resAudio;
        }
        #endregion
    }
}
