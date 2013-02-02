using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using MediaSharp.Model;

namespace MediaSharp.Controller
{
    public class Ctrl_mediatheque
    {
        Mediatheque model;
        IDocView view;
        Document selectedDoc;

        public MediaSharp.Model.Mediatheque Model
        {
           get { return model; }
           set { model = value; }
        }

        public Ctrl_mediatheque(Mediatheque m, IDocView v)
        {
            Model = m;
            view = v;
            view.SetController(this);
        }

       

        #region The hard work of control the view
        public void LoadView()
        {
            view.ClearGrid();
            foreach (Document doc in Model.AllDocuments)
            {
                view.AddDocumentToGrid(doc);
            }

            view.SetSelectedDocumentInGrid((Document)Model.AllDocuments[0]);
        }

        public void RemoveAllDocumentWithType(string t)
        {
            List<Document> listOfDocs = Model.GetDocument(Type.GetType(t));
            foreach (Document doc in listOfDocs)
            {
                view.RemoveDocumentFromGrid(doc);
            }
        }

        public void AddAllDocumentWithType(string t)
        {
            List<Document> listOfDocs = Model.GetDocument(Type.GetType(t));
            foreach (Document doc in listOfDocs)
            {
                view.AddDocumentToGrid(doc);
            }
        }

        private void updateViewDetailValues(Document doc)
        {
            
            //Vue de detail a realisé
            view.ID = doc.ID;
            view.Title = doc.Title;
            view.Type = doc.GetType().ToString().Split('.')[2];
            view.Author = doc.Author;
            view.Copyright = doc.Copyright;

        }

        private void updateDocumentWithViewValues(Document doc)
        {
            doc.ID = view.ID;
            doc.Title = view.Title;
            doc.Author = view.Author;
            doc.Copyright = view.Copyright;
        }

        public void SelectedDocumentChanged(string selectedDocId)
        {
            foreach (Document doc in Model.AllDocuments)
            {
                if (doc.ID == selectedDocId)
                {
                    selectedDoc = doc;
                    updateViewDetailValues(doc);
                    view.SetSelectedDocumentInGrid(doc);
                    this.view.CanModifyID = false;
                    break;
                }
            }
        }

        /* TabInfos[i] for i =
         * 0 : Title of the document
         * 1 : Author name and surname
         * 2 : Copyright
         * 3 : Type
         * -- Audio & Video --
         * 4 : duration
         * -- Book --
         * 4 : editor
         * 5 : publication year
         * -- Article --
         * 4 : review name
         * -- Multimedia --
         * Chaud du zboob
         */
        public void AddNewDocument(string[] tabInfos)
        {
            Random rand = new Random();
            string generatedId = "" + Model.AllDocuments.Count + tabInfos[0].Substring(0, 3) + rand.Next(100) ;
            bool copyR = tabInfos[2].Equals("true");
            string[] authName = tabInfos[1].Split(' ');
            Author auth = new Author(authName[0], authName[1]);
            Document newDoc;
            switch (tabInfos[3])
            {
                case "Audio":
                    int duration;
                    bool parsed = Int32.TryParse(tabInfos[4], out duration);
                    if (parsed)
                        newDoc = new Audio(generatedId, tabInfos[0], auth, copyR, duration);
                    break;
            }
            selectedDoc = new Document();

            this.updateViewDetailValues(selectedDoc);
            this.view.CanModifyID = true;
        }

        public void RemoveDocument()
        {
            string id = this.view.GetIdOfSelectedDocumentInGrid();
            Document docToRemove = null;

            if (id != "")
            {
                foreach (Document doc in this.Model.AllDocuments)
                {
                    if (doc.ID == id)
                    {
                        docToRemove = doc;
                        break;
                    }
                }

                if (docToRemove != null)
                {
                    int newSelectedIndex = Model.AllDocuments.IndexOf(docToRemove);
                    Model.AllDocuments.Remove(docToRemove);
                    this.view.RemoveDocumentFromGrid(docToRemove);

                    if (newSelectedIndex > -1 && newSelectedIndex < Model.AllDocuments.Count)
                    {
                        this.view.SetSelectedDocumentInGrid((Document)Model.AllDocuments[newSelectedIndex]);
                    }
                }
            }
        }

        public void Save()
        {
            updateDocumentWithViewValues(selectedDoc);
            if (Model.AllDocuments.Contains(selectedDoc))
            {
                // Update existing
                this.view.UpdateGridWithChangedDocument(selectedDoc);
            }
            else
            {
                // Add new user
                Model.AddDocument(selectedDoc);
                this.view.AddDocumentToGrid(selectedDoc);
            }
            view.SetSelectedDocumentInGrid(selectedDoc);
            this.view.CanModifyID = false;

        }

        #endregion
    }
}
