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
            List<Document> listOfDocs = Model.GetDocument(Type.GetType(t)); //Marche pas?
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
            //view.Type = doc.GetType().ToString().Split('.')[2];
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
            string type = doc.GetType().Name;
            switch (type)
            {
                case "Audio": /***INFOS AUDIO***/

                    break;
                case "Video": /***INFOS VIDEO***/

                    break;
                case "Book": /***INFOS BOOK***/

                    break;
                case "Article": /***INFOS ARTICLE***/

                    break;
                case "Multimedia":

                    break;
                default:

                    break;
            }
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
         * 4 : review title
         * 5 : review editor
         * 6 : review number
         * -- Multimedia --
         * 
         */
        public void AddNewDocument(string[] tabInfos)
        {
            Random rand = new Random();
            /***INFOS DOCUMENT***/
            string generatedId = "" + Model.AllDocuments.Count + tabInfos[0].Substring(0, 3) + rand.Next(100) ; //ID auto générée
            bool copyR = tabInfos[2].Equals("true"); //Copyright
            string[] authName = tabInfos[1].Split(' '); //Nom et Prénom de l'auteur
            Author auth = new Author(authName[0], authName[1]); //Auteur du document
            Document newDoc;

            switch (tabInfos[3])
            {
                case "Audio": /***INFOS AUDIO***/
                    int durationAudio;
                    bool parsedAudio = Int32.TryParse(tabInfos[4], out durationAudio);
                    if (parsedAudio)
                    {
                        newDoc = new Audio(generatedId, tabInfos[0], auth, copyR, durationAudio);
                        this.updateViewDetailValues(newDoc);
                    }
                    break;
                case "Video": /***INFOS VIDEO***/
                    int durationVideo;
                    bool parsedVideo = Int32.TryParse(tabInfos[4], out durationVideo);
                    if (parsedVideo)
                    {
                        newDoc = new Video(generatedId, tabInfos[0], auth, copyR, durationVideo);
                        this.updateViewDetailValues(newDoc);
                    }
                    break;
                case "Book": /***INFOS BOOK***/
                    int pubYear;
                    bool parsedYear = Int32.TryParse(tabInfos[5], out pubYear);
                    if (parsedYear)
                    {
                        newDoc = new Book(generatedId, tabInfos[0], auth, copyR, tabInfos[4], pubYear);
                        this.updateViewDetailValues(newDoc);
                    }
                    break;
                case "Article": /***INFOS ARTICLE***/
                    Review review = new Review(tabInfos[4], tabInfos[5], tabInfos[6]);
                    newDoc = new Article(generatedId, tabInfos[0], auth, copyR, review);
                    this.updateViewDetailValues(newDoc);
                    break;
                case "Multimedia":
                    //CHIANT
                    break;
                default:
                    newDoc = new Document();
                    this.updateViewDetailValues(newDoc);
                    break;
            }
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
