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

        public Document SelectedDocument { get { return selectedDoc; } }
       

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
            List<Document> listOfDocs = Model.GetDocument(t);
            foreach (Document doc in listOfDocs)
            {
                view.RemoveDocumentFromGrid(doc);
            }
        }

        public void AddAllDocumentWithType(string t)
        {
            List<Document> listOfDocs = Model.GetDocument(t);
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
            view.Type = doc.GetType().Name;
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

        public void AddNewDocument(Document d)
        {
            model.AddDocument(d);
            this.updateViewDetailValues(d);
            this.view.CanModifyID = true;
            LoadView();
        }

        public void UpdateAllInfos(Document d)
        {
            model.ReplaceDocument(d);
            updateViewDetailValues(d);
            this.view.UpdateGridWithChangedDocument(d);
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

        public void UpdatePrimariesInfos()
        {
            updateDocumentWithViewValues(selectedDoc);
            // Update existing
            this.view.UpdateGridWithChangedDocument(selectedDoc);

            view.SetSelectedDocumentInGrid(selectedDoc);
            this.view.CanModifyID = false;

        }

        #endregion
    }
}
