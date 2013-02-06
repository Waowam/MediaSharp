using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using MediaSharp.Controller;
using MediaSharp.Model;

namespace View
{
    public partial class AddForm : Form
    {
        Ctrl_mediatheque controller;

        public AddForm()
        {
            InitializeComponent();
        }

        #region Events and stuffs

        private void txtTitle_MouseHover(object sender, EventArgs e)
        {
           if (txtTitle.Text == "Title of the document")
            {
                txtTitle.Text = "";
                txtTitle.ForeColor = SystemColors.WindowText;
                txtTitle.Font = SystemFonts.DefaultFont;
            }
        }

        private void txtTitle_MouseLeave(object sender, EventArgs e)
        {
            if (txtTitle.Text == "")
            {
                txtTitle.Text = "Title of the document";
                txtTitle.ForeColor = SystemColors.InactiveCaption;
                txtTitle.Font = SystemFonts.CaptionFont;
            }
        }

        private void txtAuthor_MouseHover(object sender, EventArgs e)
        {
            if (txtAuthor.Text == "Author of the document")
            {
                txtAuthor.Text = "";
                txtAuthor.ForeColor = SystemColors.WindowText;
                txtAuthor.Font = SystemFonts.DefaultFont;
            }
        }

        private void txtAuthor_MouseLeave(object sender, EventArgs e)
        {
            if (txtAuthor.Text == "")
            {
                txtAuthor.Text = "Author of the document";
                txtAuthor.ForeColor = SystemColors.InactiveCaption;
                txtAuthor.Font = SystemFonts.CaptionFont;
            }
        }

        void butt_Add_Article_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            Random rand = new Random();
            /***INFOS DOCUMENT***/
            string generatedId = "" + controller.Model.AllDocuments.Count + this.txtTitle.Text.Substring(0, 3) + rand.Next(100); //ID auto générée
            bool copyR = true; //Copyright
            string[] authName = this.txtAuthor.Text.Split(' '); //Nom et Prénom de l'auteur
            Author auth = new Author(authName[0], authName[1]); //Auteur du document

            controller.AddNewDocumentBis(new Article(generatedId,this.txtTitle.Text,auth,copyR,new Review(this.userControl11.txt_R_title.Text,this.userControl11.txt_E_Name.Text,this.userControl11.spin_R_numb.Text)));
            this.Dispose();
        }

        void butt_Add_Audio_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            Random rand = new Random();
            /***INFOS DOCUMENT***/
            string generatedId = "" + controller.Model.AllDocuments.Count + this.txtTitle.Text.Substring(0, 3) + rand.Next(100); //ID auto générée
            bool copyR = true; //Copyright
            string[] authName = this.txtAuthor.Text.Split(' '); //Nom et Prénom de l'auteur
            Author auth = new Author(authName[0], authName[1]); //Auteur du document

            controller.AddNewDocumentBis(new Audio(generatedId, this.txtTitle.Text, auth, copyR, this.userControl11.spin_Minutes_Audio.Text+":"+this.userControl11.spin_Secondes_Audio.Text));
            this.Dispose();
        }

        void butt_Add_Book_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            Random rand = new Random();
            /***INFOS DOCUMENT***/
            string generatedId = "" + controller.Model.AllDocuments.Count + this.txtTitle.Text.Substring(0, 3) + rand.Next(100); //ID auto générée
            bool copyR = true; //Copyright
            string[] authName = this.txtAuthor.Text.Split(' '); //Nom et Prénom de l'auteur
            Author auth = new Author(authName[0], authName[1]); //Auteur du document

            controller.AddNewDocumentBis(new Book(generatedId, this.txtTitle.Text, auth, copyR, this.userControl11.txt_E_Book.Text, (int)this.userControl11.spin_Publication.Value));
            this.Dispose();
        }

        void butt_Add_Video_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            Random rand = new Random();
            /***INFOS DOCUMENT***/
            string generatedId = "" + controller.Model.AllDocuments.Count + this.txtTitle.Text.Substring(0, 3) + rand.Next(100); //ID auto générée
            bool copyR = true; //Copyright
            string[] authName = this.txtAuthor.Text.Split(' '); //Nom et Prénom de l'auteur
            Author auth = new Author(authName[0], authName[1]); //Auteur du document

            controller.AddNewDocumentBis(new Video(generatedId, this.txtTitle.Text, auth, copyR, this.userControl11.spin_Hours_Video.Text+":"+this.userControl11.spin_Minutes_Video.Text+":"+this.userControl11.spin_Secondes_Video.Text));
            this.Dispose();
        }


        #endregion

        public void SetController(Ctrl_mediatheque _controller)
        {
            controller = _controller;
        }


    }
}
