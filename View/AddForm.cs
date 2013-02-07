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

        public AddForm(Document d)
        {
            InitializeComponent();

            this.txtTitle.Text = d.Title;
            this.txtAuthor.Text = d.Author;
            this.chkB_CopyR.Checked = (d.Copyright=="true"? true:false);

            switch (d.GetType().Name)
            {
                case "Article" :
                    Article ar = (Article)d;
                    this.userControl11.txt_R_title.Text = ar.Review_title;
                    this.userControl11.txt_E_Name.Text = ar.Review_Editor;
                    this.userControl11.spin_R_numb.Text = ar.Review_Number;
                    this.userControl11.xpder_Article.IsExpanded = true;
                    break;
                case "Audio" :
                    Audio au = (Audio)d;
                    this.userControl11.spin_Minutes_Audio.Value = au.Duration.Minutes;
                    this.userControl11.spin_Secondes_Audio.Value = au.Duration.Secondes;
                    this.userControl11.xpder_Audio.IsExpanded = true;
                    break;
                case "Book":
                    Book b = (Book)d;
                    this.userControl11.txt_E_Book.Text = b.Editor;
                    this.userControl11.spin_Publication.Text = b.PublicationYear;
                    this.userControl11.xpder_Book.IsExpanded = true;
                    break;
                case "Multimedia":
                    Multimedia m = (Multimedia)d;
                    //pas fais.
                    break;
                case "Video":
                    Video v = (Video)d;
                    this.userControl11.spin_Hours_Video.Value = v.Duration.Hours;
                    this.userControl11.spin_Minutes_Video.Value = v.Duration.Minutes;
                    this.userControl11.spin_Secondes_Video.Value = v.Duration.Secondes;
                    this.userControl11.xpder_Video.IsExpanded = true;
                    break;
                default:
                    break;
            }
        }

        #region Events and stuffs

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

            controller.AddNewDocumentBis(new Audio(generatedId, this.txtTitle.Text, auth, copyR, (int)this.userControl11.spin_Minutes_Audio.Value,(int)this.userControl11.spin_Secondes_Audio.Value));
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

            controller.AddNewDocumentBis(new Video(generatedId, this.txtTitle.Text, auth, copyR, (int)this.userControl11.spin_Hours_Video.Value,(int)this.userControl11.spin_Minutes_Video.Value,(int)this.userControl11.spin_Secondes_Video.Value));
            this.Dispose();
        }


        #endregion

        public void SetController(Ctrl_mediatheque _controller)
        {
            controller = _controller;
        }
    }
}
