namespace MediaSharp.View
{
    partial class View_mdtq
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.grdDocs = new System.Windows.Forms.ListView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chBAll = new System.Windows.Forms.CheckBox();
            this.chBVideo = new System.Windows.Forms.CheckBox();
            this.chBMulti = new System.Windows.Forms.CheckBox();
            this.chBBook = new System.Windows.Forms.CheckBox();
            this.chBAudio = new System.Windows.Forms.CheckBox();
            this.chBArt = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtType = new System.Windows.Forms.TextBox();
            this.txtAuthor = new System.Windows.Forms.TextBox();
            this.chBox_copyrght = new System.Windows.Forms.CheckBox();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.butt_SaveAll = new System.Windows.Forms.Button();
            this.butt_print = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // grdDocs
            // 
            this.grdDocs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdDocs.FullRowSelect = true;
            this.grdDocs.Location = new System.Drawing.Point(0, 0);
            this.grdDocs.Name = "grdDocs";
            this.grdDocs.Size = new System.Drawing.Size(535, 225);
            this.grdDocs.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.grdDocs.TabIndex = 2;
            this.grdDocs.UseCompatibleStateImageBehavior = false;
            this.grdDocs.View = System.Windows.Forms.View.Details;
            this.grdDocs.SelectedIndexChanged += new System.EventHandler(this.grdDocs_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.Controls.Add(this.grdDocs);
            this.panel1.Location = new System.Drawing.Point(12, 227);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(535, 225);
            this.panel1.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chBAll);
            this.groupBox1.Controls.Add(this.chBVideo);
            this.groupBox1.Controls.Add(this.chBMulti);
            this.groupBox1.Controls.Add(this.chBBook);
            this.groupBox1.Controls.Add(this.chBAudio);
            this.groupBox1.Controls.Add(this.chBArt);
            this.groupBox1.Location = new System.Drawing.Point(12, 155);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(388, 66);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Categories";
            // 
            // chBAll
            // 
            this.chBAll.AutoSize = true;
            this.chBAll.Checked = true;
            this.chBAll.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chBAll.Location = new System.Drawing.Point(336, 29);
            this.chBAll.Name = "chBAll";
            this.chBAll.Size = new System.Drawing.Size(37, 17);
            this.chBAll.TabIndex = 5;
            this.chBAll.Text = "All";
            this.chBAll.UseVisualStyleBackColor = true;
            this.chBAll.CheckedChanged += new System.EventHandler(this.chBAll_CheckedChanged);
            // 
            // chBVideo
            // 
            this.chBVideo.AutoSize = true;
            this.chBVideo.Checked = true;
            this.chBVideo.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chBVideo.Location = new System.Drawing.Point(277, 29);
            this.chBVideo.Name = "chBVideo";
            this.chBVideo.Size = new System.Drawing.Size(53, 17);
            this.chBVideo.TabIndex = 4;
            this.chBVideo.Text = "Video";
            this.chBVideo.UseVisualStyleBackColor = true;
            this.chBVideo.CheckedChanged += new System.EventHandler(this.chBVideo_CheckedChanged);
            // 
            // chBMulti
            // 
            this.chBMulti.AutoSize = true;
            this.chBMulti.Checked = true;
            this.chBMulti.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chBMulti.Location = new System.Drawing.Point(195, 29);
            this.chBMulti.Name = "chBMulti";
            this.chBMulti.Size = new System.Drawing.Size(76, 17);
            this.chBMulti.TabIndex = 3;
            this.chBMulti.Text = "Multimedia";
            this.chBMulti.UseVisualStyleBackColor = true;
            this.chBMulti.CheckedChanged += new System.EventHandler(this.chBMulti_CheckedChanged);
            // 
            // chBBook
            // 
            this.chBBook.AutoSize = true;
            this.chBBook.Checked = true;
            this.chBBook.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chBBook.Location = new System.Drawing.Point(138, 29);
            this.chBBook.Name = "chBBook";
            this.chBBook.Size = new System.Drawing.Size(51, 17);
            this.chBBook.TabIndex = 2;
            this.chBBook.Text = "Book";
            this.chBBook.UseVisualStyleBackColor = true;
            this.chBBook.CheckedChanged += new System.EventHandler(this.chBBook_CheckedChanged);
            // 
            // chBAudio
            // 
            this.chBAudio.AutoSize = true;
            this.chBAudio.Checked = true;
            this.chBAudio.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chBAudio.Location = new System.Drawing.Point(79, 29);
            this.chBAudio.Name = "chBAudio";
            this.chBAudio.Size = new System.Drawing.Size(53, 17);
            this.chBAudio.TabIndex = 1;
            this.chBAudio.Text = "Audio";
            this.chBAudio.UseVisualStyleBackColor = true;
            this.chBAudio.CheckedChanged += new System.EventHandler(this.chBAudio_CheckedChanged);
            // 
            // chBArt
            // 
            this.chBArt.AutoSize = true;
            this.chBArt.Checked = true;
            this.chBArt.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chBArt.Location = new System.Drawing.Point(18, 29);
            this.chBArt.Name = "chBArt";
            this.chBArt.Size = new System.Drawing.Size(55, 17);
            this.chBArt.TabIndex = 0;
            this.chBArt.Text = "Article";
            this.chBArt.UseVisualStyleBackColor = true;
            this.chBArt.CheckedChanged += new System.EventHandler(this.chBArt_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtType);
            this.groupBox2.Controls.Add(this.txtAuthor);
            this.groupBox2.Controls.Add(this.chBox_copyrght);
            this.groupBox2.Controls.Add(this.txtTitle);
            this.groupBox2.Controls.Add(this.txtID);
            this.groupBox2.Controls.Add(this.button4);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(388, 137);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Details";
            // 
            // txtType
            // 
            this.txtType.Enabled = false;
            this.txtType.Location = new System.Drawing.Point(231, 26);
            this.txtType.Name = "txtType";
            this.txtType.Size = new System.Drawing.Size(141, 20);
            this.txtType.TabIndex = 11;
            // 
            // txtAuthor
            // 
            this.txtAuthor.Location = new System.Drawing.Point(66, 72);
            this.txtAuthor.Name = "txtAuthor";
            this.txtAuthor.Size = new System.Drawing.Size(99, 20);
            this.txtAuthor.TabIndex = 10;
            // 
            // chBox_copyrght
            // 
            this.chBox_copyrght.AutoSize = true;
            this.chBox_copyrght.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.chBox_copyrght.Location = new System.Drawing.Point(95, 106);
            this.chBox_copyrght.Name = "chBox_copyrght";
            this.chBox_copyrght.Size = new System.Drawing.Size(76, 18);
            this.chBox_copyrght.TabIndex = 9;
            this.chBox_copyrght.Text = "Copyright";
            this.chBox_copyrght.UseVisualStyleBackColor = true;
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(231, 72);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(142, 20);
            this.txtTitle.TabIndex = 7;
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(66, 27);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(99, 20);
            this.txtID.TabIndex = 5;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(277, 98);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(96, 23);
            this.button4.TabIndex = 4;
            this.button4.Text = "Save changes";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.btnSaveEdit_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(192, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Type :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Authors :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(192, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Title :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID :";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(431, 21);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(116, 23);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = "Add new";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(431, 81);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(116, 23);
            this.btnEdit.TabIndex = 8;
            this.btnEdit.Text = "Edit selected";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(431, 50);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(116, 23);
            this.btnRemove.TabIndex = 7;
            this.btnRemove.Text = "Remove selected";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // butt_SaveAll
            // 
            this.butt_SaveAll.Location = new System.Drawing.Point(433, 110);
            this.butt_SaveAll.Name = "butt_SaveAll";
            this.butt_SaveAll.Size = new System.Drawing.Size(114, 23);
            this.butt_SaveAll.TabIndex = 9;
            this.butt_SaveAll.Text = "Save library";
            this.butt_SaveAll.UseVisualStyleBackColor = true;
            this.butt_SaveAll.Click += new System.EventHandler(this.butt_SaveAll_Click);
            // 
            // butt_print
            // 
            this.butt_print.Location = new System.Drawing.Point(433, 139);
            this.butt_print.Name = "butt_print";
            this.butt_print.Size = new System.Drawing.Size(114, 23);
            this.butt_print.TabIndex = 10;
            this.butt_print.Text = "Print";
            this.butt_print.UseVisualStyleBackColor = true;
            this.butt_print.Click += new System.EventHandler(this.butt_print_Click);
            // 
            // View_mdtq
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 463);
            this.Controls.Add(this.butt_print);
            this.Controls.Add(this.butt_SaveAll);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Name = "View_mdtq";
            this.Text = "MediaTech";
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView grdDocs;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox chBAll;
        private System.Windows.Forms.CheckBox chBVideo;
        private System.Windows.Forms.CheckBox chBMulti;
        private System.Windows.Forms.CheckBox chBBook;
        private System.Windows.Forms.CheckBox chBAudio;
        private System.Windows.Forms.CheckBox chBArt;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.CheckBox chBox_copyrght;
        private System.Windows.Forms.TextBox txtAuthor;
        private System.Windows.Forms.TextBox txtType;
        private System.Windows.Forms.Button butt_SaveAll;
        private System.Windows.Forms.Button butt_print;
    }
}