namespace View
{
    partial class AddForm
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
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.cbBType = new System.Windows.Forms.ComboBox();
            this.panelDetails = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtAuthor = new System.Windows.Forms.TextBox();
            this.timePicker = new System.Windows.Forms.DateTimePicker();
            this.panelDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(65, 237);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 0;
            this.btnCancel.Text = "&Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(146, 236);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "&Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtTitle
            // 
            this.txtTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTitle.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtTitle.Location = new System.Drawing.Point(12, 12);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(165, 20);
            this.txtTitle.TabIndex = 2;
            this.txtTitle.Text = "Title of the document";
            this.txtTitle.MouseLeave += new System.EventHandler(this.txtTitle_MouseLeave);
            this.txtTitle.MouseHover += new System.EventHandler(this.txtTitle_MouseHover);
            // 
            // cbBType
            // 
            this.cbBType.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbBType.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.cbBType.FormattingEnabled = true;
            this.cbBType.Items.AddRange(new object[] {
            "Article",
            "Audio",
            "Book",
            "Multimedia",
            "Video"});
            this.cbBType.Location = new System.Drawing.Point(13, 67);
            this.cbBType.Name = "cbBType";
            this.cbBType.Size = new System.Drawing.Size(121, 21);
            this.cbBType.TabIndex = 3;
            this.cbBType.Text = "Type of Document";
            this.cbBType.SelectedIndexChanged += new System.EventHandler(this.cbBType_SelectedIndexChanged);
            // 
            // panelDetails
            // 
            this.panelDetails.Controls.Add(this.groupBox1);
            this.panelDetails.Location = new System.Drawing.Point(13, 94);
            this.panelDetails.Name = "panelDetails";
            this.panelDetails.Size = new System.Drawing.Size(208, 136);
            this.panelDetails.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(3, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(196, 133);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // txtAuthor
            // 
            this.txtAuthor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAuthor.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtAuthor.Location = new System.Drawing.Point(13, 38);
            this.txtAuthor.Name = "txtAuthor";
            this.txtAuthor.Size = new System.Drawing.Size(165, 20);
            this.txtAuthor.TabIndex = 5;
            this.txtAuthor.Text = "Author of the document";
            this.txtAuthor.MouseLeave += new System.EventHandler(this.txtAuthor_MouseLeave);
            this.txtAuthor.MouseHover += new System.EventHandler(this.txtAuthor_MouseHover);
            // 
            // timePicker
            // 
            this.timePicker.Location = new System.Drawing.Point(0, 0);
            this.timePicker.Name = "timePicker";
            this.timePicker.Size = new System.Drawing.Size(200, 20);
            this.timePicker.TabIndex = 0;
            // 
            // AddForm
            // 
            this.AcceptButton = this.btnAdd;
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.Dialog;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(236, 271);
            this.Controls.Add(this.txtAuthor);
            this.Controls.Add(this.panelDetails);
            this.Controls.Add(this.cbBType);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnCancel);
            this.Name = "AddForm";
            this.Text = "addForm";
            this.panelDetails.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.ComboBox cbBType;
        private System.Windows.Forms.Panel panelDetails;
        private System.Windows.Forms.TextBox txtAuthor;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker timePicker;
        private System.Windows.Forms.TextBox txtReEditor;
        private System.Windows.Forms.TextBox txtReTitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown spinReviewNumber;
    }
}