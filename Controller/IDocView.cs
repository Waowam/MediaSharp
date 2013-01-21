using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MediaSharp.Model;

namespace MediaSharp.Controller
{
    public interface IDocView
    {
        void SetController(Ctrl_mediatheque _controller);
        void ClearGrid();
        void AddDocumentToGrid(Document _document);
        void UpdateGridWithChangedDocument(Document _document);
        void RemoveDocumentFromGrid(Document _document);
        string GetIdOfSelectedUserInGrid();
        void SetSelectedDocumentInGrid(Document _document);

       /* string Title { get; set; }
        string Authors { get; set; }
        string Copyright { get; set; }*/
    }
}
