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
            this.timePicker = new System.Windows.Forms.DateTimePicker();
            this.txtReEditor = new System.Windows.Forms.TextBox();
            this.txtReTitle = new System.Windows.Forms.TextBox();
            this.spinReviewNumber = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.elementHost2 = new System.Windows.Forms.Integration.ElementHost();
            this.userControl11 = new WpfControlLibrary1.UserControl1();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.chkB_CopyR = new System.Windows.Forms.CheckBox();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.txtAuthor = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.spinReviewNumber)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(98, 326);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 0;
            this.btnCancel.Text = "&Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
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
            this.elementHost2.Location = new System.Drawing.Point(2, 87);
            this.elementHost2.Name = "elementHost2";
            this.elementHost2.Size = new System.Drawing.Size(263, 233);
            this.elementHost2.TabIndex = 7;
            this.elementHost2.Text = "elementHost2";
            this.elementHost2.Child = this.userControl11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Doc\'s Title";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Authors\' Name";
            // 
            // chkB_CopyR
            // 
            this.chkB_CopyR.AutoSize = true;
            this.chkB_CopyR.Location = new System.Drawing.Point(87, 64);
            this.chkB_CopyR.Name = "chkB_CopyR";
            this.chkB_CopyR.Size = new System.Drawing.Size(70, 17);
            this.chkB_CopyR.TabIndex = 10;
            this.chkB_CopyR.Text = "Copyright";
            this.chkB_CopyR.UseVisualStyleBackColor = true;
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(87, 16);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(165, 20);
            this.txtTitle.TabIndex = 11;
            // 
            // txtAuthor
            // 
            this.txtAuthor.Location = new System.Drawing.Point(87, 38);
            this.txtAuthor.Name = "txtAuthor";
            this.txtAuthor.Size = new System.Drawing.Size(165, 20);
            this.txtAuthor.TabIndex = 12;
            // 
            // AddForm
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.Dialog;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(264, 352);
            this.Controls.Add(this.txtAuthor);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.chkB_CopyR);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.elementHost2);
            this.Controls.Add(this.btnCancel);
            this.Name = "AddForm";
            this.Text = "addForm";
            ((System.ComponentModel.ISupportInitialize)(this.spinReviewNumber)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.DateTimePicker timePicker;
        private System.Windows.Forms.TextBox txtReEditor;
        private System.Windows.Forms.TextBox txtReTitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown spinReviewNumber;
        private System.Windows.Forms.Integration.ElementHost elementHost2;
        private WpfControlLibrary1.UserControl1 userControl11;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox chkB_CopyR;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.TextBox txtAuthor;
    }
}