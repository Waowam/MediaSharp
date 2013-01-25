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

        #region Events raised  back to controller

        private void btnAdd_Click(object sender, EventArgs e)
        {
            this.controler.AddNewDocument();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            this.controler.RemoveDocument();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            this.controler.Save();
        }

        private void grdDocs_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.grdDocs.SelectedItems.Count > 0)
                this.controler.SelectedDocumentChanged(this.grdDocs.SelectedItems[0].Text);
           
        }


        #endregion

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

            this.grdDocs.Columns.Add("ID", 150, HorizontalAlignment.Left);
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
            parent = this.grdDocs.Items.Add(doc.ID);
            parent.SubItems.Add(doc.Title);
            parent.SubItems.Add(doc.Author);
            parent.SubItems.Add(doc.Copyright);
        }

        public void UpdateGridWithChangedDocument(Document doc)
        {
            ListViewItem rowToUpdate = null;

            foreach (ListViewItem row in this.grdDocs.Items)
            {
                if (row.Text == doc.ID)
                {
                    rowToUpdate = row;
                }
            }

            if (rowToUpdate != null)
            {
                rowToUpdate.Text = doc.ID;
                rowToUpdate.SubItems[1].Text = doc.Title;
                rowToUpdate.SubItems[2].Text = doc.Author;
                rowToUpdate.SubItems[3].Text = doc.Copyright;
            }
        }

        public void RemoveDocumentFromGrid(Document doc) 
        {
            ListViewItem rowToRemove = null;

            foreach (ListViewItem row in this.grdDocs.Items)
            {
                if (row.Text == doc.ID)
                {
                    rowToRemove = row;
                }
            }

            if (rowToRemove != null)
            {
                this.grdDocs.Items.Remove(rowToRemove);
                this.grdDocs.Focus();
            }
        }

        public string GetIdOfSelectedDocumentInGrid() 
        {
            if (this.grdDocs.SelectedItems.Count > 0)
                return this.grdDocs.SelectedItems[0].Text;
            else
                return "";
        }

        public void SetSelectedDocumentInGrid(Document doc)
        {
            foreach (ListViewItem row in this.grdDocs.Items)
            {
                if (row.Text == doc.ID)
                {
                    row.Selected = true;
                }
            }
        }

        public string Title 
        {
            get { return this.txtTitle.Text; }
            set { this.txtTitle.Text = value; }
        }

        public string Author 
        {
            get { return this.txtAuthor.Text; }
            set { this.txtAuthor.Text = value; }
        }

        public string ID
        { 
            get { return this.txtID.Text; }
            set { this.txtID.Text = value; } 
        }

        public string Copyright
        {
            get { return this.chBox_copyrght.CheckState == CheckState.Checked ? "true" : "false"; }
            set 
            { 
                if(value=="true")
                    this.chBox_copyrght.CheckState = CheckState.Checked; 
                else
                    this.chBox_copyrght.CheckState = CheckState.Unchecked;
            }
        }

        public bool CanModifyID
        {
            set { this.txtID.Enabled = value; }
        }

        #endregion

    }
}
