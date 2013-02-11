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
using View;

namespace MediaSharp.View
{
    public partial class View_mdtq : Form, IDocView
    {
        Ctrl_mediatheque controler;

        public View_mdtq()
        {
            InitializeComponent();
        }

        #region Setters/getters spéciaux

        public string chkB_Article
        {
            get { return new Article().GetType().ToString(); }
        }

        public string chkB_Audio
        {
            get { return new Audio().GetType().ToString(); }
        }

        public string chkB_Book
        {
            get { return new Book().GetType().ToString(); }
        }

        public string chkB_Multimedia
        {
            get { return new Multimedia().GetType().ToString(); }
        }

        public string chkB_Video
        {
            get { return new Video().GetType().ToString();  }
        }
        #endregion

        #region Events raised  back to controller

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddForm adding_dialog = new AddForm();
            adding_dialog.SetController(controler);
            adding_dialog.ShowDialog();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            this.controler.RemoveDocument();
        }

        private void btnSaveEdit_Click(object sender, EventArgs e)
        {
            this.controler.UpdatePrimariesInfos();
        }

        private void grdDocs_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.grdDocs.SelectedItems.Count > 0)
                this.controler.SelectedDocumentChanged(this.grdDocs.SelectedItems[0].Text);
           
        }

        private void chBAll_CheckedChanged(object sender, EventArgs e)
        {
            if (chBAll.Checked == true)
            {
                this.controler.LoadView();
                this.chBArt.Checked = true;
                this.chBAudio.Checked = true;
                this.chBBook.Checked = true; 
                this.chBMulti.Checked = true;
                this.chBVideo.Checked = true;
            }
        }

        private void chBArt_CheckedChanged(object sender, EventArgs e)
        {
            if (!chBArt.Checked)
            {
                chBAll.Checked = false;
                this.controler.RemoveAllDocumentWithType(this.chkB_Article);
            }
            else
                this.controler.AddAllDocumentWithType(this.chkB_Article);
        }

        private void chBAudio_CheckedChanged(object sender, EventArgs e)
        {
            if (!chBAudio.Checked)
            {
                chBAll.Checked = false;
                this.controler.RemoveAllDocumentWithType(this.chkB_Audio);
            }
            else
                this.controler.AddAllDocumentWithType(this.chkB_Audio);
        }

        private void chBBook_CheckedChanged(object sender, EventArgs e)
        {
            if (!chBBook.Checked)
            {
                chBAll.Checked = false;
                this.controler.RemoveAllDocumentWithType(this.chkB_Book);
            }
            else
                this.controler.AddAllDocumentWithType(this.chkB_Book);
        }

        private void chBMulti_CheckedChanged(object sender, EventArgs e)
        {
            if (!chBMulti.Checked)
            {
                chBAll.Checked = false;
                this.controler.RemoveAllDocumentWithType(this.chkB_Multimedia);
            }
            else
                this.controler.AddAllDocumentWithType(this.chkB_Multimedia);
        }

        private void chBVideo_CheckedChanged(object sender, EventArgs e)
        {
            if (!chBVideo.Checked)
            {
                chBAll.Checked = false;
                this.controler.RemoveAllDocumentWithType(this.chkB_Video);
            }
            else
                this.controler.AddAllDocumentWithType(this.chkB_Video);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            AddForm adding_dialog = new AddForm(this.controler.SelectedDocument);
            adding_dialog.SetController(controler);
            adding_dialog.ShowDialog();
        }

        private void butt_SaveAll_Click(object sender, EventArgs e)
        {
            controler.Save_Library();
        }

        private void butt_print_Click(object sender, EventArgs e)
        {
            if (controler.print())
            {
                MessageBox.Show("Your document is printing");
            }
            else 
            {
                MessageBox.Show("Impossible to print the selected document");
            }
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

            this.grdDocs.Columns.Add("ID", 70, HorizontalAlignment.Left);
            this.grdDocs.Columns.Add("Type",70, HorizontalAlignment.Left);
            this.grdDocs.Columns.Add("Title", 150, HorizontalAlignment.Left);
            this.grdDocs.Columns.Add("Author", 150, HorizontalAlignment.Left);
            this.grdDocs.Columns.Add("Copyright", 50, HorizontalAlignment.Left);

            Console.WriteLine(this.grdDocs.Columns.Count);
            // Add rows to grid
            this.grdDocs.Items.Clear();
        }

        public void AddDocumentToGrid(Document doc) 
        {
            if (!this.grdDocs.Items.ContainsKey(doc.ID))
            {
                ListViewItem parent;
                parent = this.grdDocs.Items.Add(doc.ID);
                parent.SubItems.Add(doc.GetType().ToString().Split('.')[2]);
                parent.SubItems.Add(doc.Title);
                parent.SubItems.Add(doc.Author);
                parent.SubItems.Add(doc.Copyright);
                parent.Name = doc.ID;
            }
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
                rowToUpdate.SubItems[1].Text = doc.GetType().Name;
                rowToUpdate.SubItems[2].Text = doc.Title;
                rowToUpdate.SubItems[3].Text = doc.Author;
                rowToUpdate.SubItems[4].Text = doc.Copyright;
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

        public string Type
        {
            set { this.txtType.Text = value; }
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
