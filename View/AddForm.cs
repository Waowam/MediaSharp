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

        private void cbBType_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbBType.ForeColor = SystemColors.WindowText;
            panelDetails_Load(cbBType.SelectedItem.ToString());
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
         * Chaud du zboob
         */
        private void btnAdd_Click(object sender, EventArgs e)
        {
            List<string> infos = new List<string>();
            infos.Add(txtTitle.Text);
            infos.Add(txtAuthor.Text);
            infos.Add("false");
            //Will make the tab contain the info of the document switch the type
            switch (cbBType.SelectedItem.ToString())
            {
                case "Audio":
                    infos.Add(timePicker.Text);
                    break;
                default:
                    Console.WriteLine("PAS BON DE PRINT CA");
                    break;
            }
            controller.AddNewDocument(infos.ToArray());
            this.Close();
        }


        #endregion

        public void SetController(Ctrl_mediatheque _controller)
        {
            controller = _controller;
        }

        private void panelDetails_Load (string type)
        {
            switch (type)
            {
                case "Audio":
                    Console.WriteLine("Panel detail : " + type);
                    // 
                    // groupBox1
                    // 
                    this.groupBox1.Controls.Add(this.label1);
                    this.groupBox1.Controls.Add(this.timePicker);
                    this.groupBox1.Location = new System.Drawing.Point(-8, 0);
                    this.groupBox1.Name = "groupBox1";
                    this.groupBox1.Size = new System.Drawing.Size(327, 46);
                    this.groupBox1.TabIndex = 0;
                    this.groupBox1.TabStop = false;
                    this.groupBox1.Text = type;
                    // 
                    // timePicker
                    // 
                    this.timePicker.CustomFormat = "H:M:S";
                    this.timePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
                    this.timePicker.Location = new System.Drawing.Point(74, 19);
                    this.timePicker.Name = "timePicker";
                    this.timePicker.ShowUpDown = true;
                    this.timePicker.Size = new System.Drawing.Size(68, 20);
                    this.timePicker.TabIndex = 0;
                    this.timePicker.Value = new System.DateTime(2013, 1, 28, 0, 0, 0, 0);
                    //Resize buttons
                    this.btnCancel.Location = new System.Drawing.Point(195, 149);
                    this.btnAdd.Location = new System.Drawing.Point(276, 148);
                    //Resize the window
                    this.ClientSize = new System.Drawing.Size(363, 176);

                    break;
                case "Article":
                    // 
                    // groupBox1
                    // 
                    this.groupBox1.Controls.Add(this.label1);
                    this.groupBox1.Controls.Add(this.spinReviewNumber);
                    this.groupBox1.Controls.Add(this.txtReEditor);
                    this.groupBox1.Controls.Add(this.txtReTitle);
                    this.groupBox1.Location = new System.Drawing.Point(3, 0);
                    this.groupBox1.Name = "groupBox1";
                    this.groupBox1.Size = new System.Drawing.Size(196, 133);
                    this.groupBox1.TabIndex = 0;
                    this.groupBox1.TabStop = false;
                    // 
                    // textBox2
                    // 
                    this.txtReEditor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    this.txtReEditor.ForeColor = System.Drawing.SystemColors.InactiveCaption;
                    this.txtReEditor.Location = new System.Drawing.Point(9, 46);
                    this.txtReEditor.Size = new System.Drawing.Size(152, 20);
                    this.txtReEditor.TabIndex = 3;
                    this.txtReEditor.Text = "Editor\'s Name";
                    // 
                    // textBox1
                    // 
                    this.txtReTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    this.txtReTitle.ForeColor = System.Drawing.SystemColors.InactiveCaption;
                    this.txtReTitle.Location = new System.Drawing.Point(9, 20);
                    this.txtReTitle.Size = new System.Drawing.Size(152, 20);
                    this.txtReTitle.TabIndex = 2;
                    this.txtReTitle.Text = "Review\'s Title";
                    // 
                    // spinReviewNumber
                    // 
                    this.spinReviewNumber.Location = new System.Drawing.Point(130, 72);
                    this.spinReviewNumber.Maximum = new decimal(new int[] {
                    500,
                    0,
                    0,
                    0});
                    this.spinReviewNumber.Minimum = new decimal(new int[] {
                    1,
                    0,
                    0,
                    0});
                    this.spinReviewNumber.Name = "spinReviewNumber";
                    this.spinReviewNumber.Size = new System.Drawing.Size(30, 20);
                    this.spinReviewNumber.TabIndex = 6;
                    this.spinReviewNumber.Value = new decimal(new int[] {
                    1,
                    0,
                    0,
                    0});
                    // 
                    // label1
                    // 
                    this.label1.AutoSize = true;
                    this.label1.Location = new System.Drawing.Point(6, 74);
                    this.label1.Size = new System.Drawing.Size(90, 13);
                    this.label1.TabIndex = 7;
                    this.label1.Text = "Review\'s Number";
                    //Resize butts
                    this.btnCancel.Location = new System.Drawing.Point(65, 237);
                    this.btnAdd.Location = new System.Drawing.Point(146, 236);
                    //Resize window
                    this.ClientSize = new System.Drawing.Size(236, 271);
                    break;
                case "Book":
                    break;
                case "Multimedia":
                    break;
                case "Video":
                    // 
                    // groupBox1
                    // 
                    this.groupBox1.Controls.Add(this.label1);
                    this.groupBox1.Controls.Add(this.timePicker);
                    this.groupBox1.Location = new System.Drawing.Point(-8, 0);
                    this.groupBox1.Name = "groupBox1";
                    this.groupBox1.Size = new System.Drawing.Size(327, 46);
                    this.groupBox1.TabIndex = 0;
                    this.groupBox1.TabStop = false;
                    this.groupBox1.Text = type;
                    // 
                    // timePicker
                    // 
                    this.timePicker.CustomFormat = "H:M:S";
                    this.timePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
                    this.timePicker.Location = new System.Drawing.Point(74, 19);
                    this.timePicker.Name = "timePicker";
                    this.timePicker.ShowUpDown = true;
                    this.timePicker.Size = new System.Drawing.Size(68, 20);
                    this.timePicker.TabIndex = 0;
                    this.timePicker.Value = new System.DateTime(2013, 1, 28, 0, 0, 0, 0);
                    break;
            }
            this.panelDetails.Controls.Add(this.groupBox1);
            this.panelDetails.Size = new System.Drawing.Size(338, 49);
            this.groupBox1.PerformLayout();
        }
    }
}
