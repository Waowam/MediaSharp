using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using MediaSharp.Model;
using MediaSharp.Controller;

namespace MediaSharp.View
{
    public partial class View_mdtq : Form, IDocView
    {
        Ctrl_mediatheque controler;

        public View_mdtq()
        {
            InitializeComponent();
        }

        public void Update_ListBox()
        {
            //listBox1.DataSource = documents;
        }

        #region IDocView implementation

        public void SetController(Ctrl_mediatheque _controller)
        {
            controler = _controller;
        }

        public void ClearGrid()
        {
            Console.WriteLine("ClearGrid method");
            // Define columns in grid
            this.grdDocs.Columns.Clear();

            this.grdDocs.Columns.Add("Title", 150, HorizontalAlignment.Left);
            this.grdDocs.Columns.Add("Author", 150, HorizontalAlignment.Left);
            this.grdDocs.Columns.Add("Copyright", 150, HorizontalAlignment.Left);

            Console.WriteLine(this.grdDocs.Columns.Count);
            // Add rows to grid
            this.grdDocs.Items.Clear();
        }

        public void AddDocumentToGrid(Document doc) 
        {
            ListViewItem parent;
            parent = this.grdDocs.Items.Add(doc.Title);
            parent.SubItems.Add(doc.Authors[0]);
            parent.SubItems.Add(doc.Copyright);
        }

        public void UpdateGridWithChangedDocument(Document doc) { }

        public void RemoveDocumentFromGrid(Document doc) { }

        public string GetIdOfSelectedUserInGrid() { return ""; }

        public void SetSelectedDocumentInGrid(Document doc) { }

        /*
        string Title { get; set; }
        string Authors { get; set; }
        string Copyright { get; set; }
        */
        #endregion
    }
}
