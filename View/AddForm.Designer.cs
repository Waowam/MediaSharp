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
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.txtAuthor = new System.Windows.Forms.TextBox();
            this.timePicker = new System.Windows.Forms.DateTimePicker();
            this.txtReEditor = new System.Windows.Forms.TextBox();
            this.txtReTitle = new System.Windows.Forms.TextBox();
            this.spinReviewNumber = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.elementHost2 = new System.Windows.Forms.Integration.ElementHost();
            this.userControl11 = new WpfControlLibrary1.UserControl1();
            ((System.ComponentModel.ISupportInitialize)(this.spinReviewNumber)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(77, 277);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 0;
            this.btnCancel.Text = "&Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
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
            // txtReEditor
            // 
            this.txtReEditor.Location = new System.Drawing.Point(0, 0);
            this.txtReEditor.Name = "txtReEditor";
            this.txtReEditor.Size = new System.Drawing.Size(100, 20);
            this.txtReEditor.TabIndex = 0;
            // 
            // txtReTitle
            // 
            this.txtReTitle.Location = new System.Drawing.Point(0, 0);
            this.txtReTitle.Name = "txtReTitle";
            this.txtReTitle.Size = new System.Drawing.Size(100, 20);
            this.txtReTitle.TabIndex = 0;
            // 
            // spinReviewNumber
            // 
            this.spinReviewNumber.Location = new System.Drawing.Point(0, 0);
            this.spinReviewNumber.Name = "spinReviewNumber";
            this.spinReviewNumber.Size = new System.Drawing.Size(120, 20);
            this.spinReviewNumber.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 0;
            // 
            // elementHost2
            // 
            this.elementHost2.Location = new System.Drawing.Point(2, 64);
            this.elementHost2.Name = "elementHost2";
            this.elementHost2.Size = new System.Drawing.Size(224, 207);
            this.elementHost2.TabIndex = 7;
            this.elementHost2.Text = "elementHost2";
            this.elementHost2.Child = this.userControl11;
            // 
            // AddForm
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.Dialog;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(238, 316);
            this.Controls.Add(this.elementHost2);
            this.Controls.Add(this.txtAuthor);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.btnCancel);
            this.Name = "AddForm";
            this.Text = "addForm";
            ((System.ComponentModel.ISupportInitialize)(this.spinReviewNumber)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.TextBox txtAuthor;
        private System.Windows.Forms.DateTimePicker timePicker;
        private System.Windows.Forms.TextBox txtReEditor;
        private System.Windows.Forms.TextBox txtReTitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown spinReviewNumber;
        private System.Windows.Forms.Integration.ElementHost elementHost2;
        private WpfControlLibrary1.UserControl1 userControl11;
    }
}