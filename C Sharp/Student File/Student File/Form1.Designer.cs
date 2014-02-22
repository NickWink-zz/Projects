namespace Student_File
{
    partial class Form1
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
            this.labelMeid = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.labelEmail = new System.Windows.Forms.Label();
            this.labelHomePhone = new System.Windows.Forms.Label();
            this.buttonNewStdnt = new System.Windows.Forms.Button();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.textBoxMeid = new System.Windows.Forms.TextBox();
            this.buttonExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelMeid
            // 
            this.labelMeid.AutoSize = true;
            this.labelMeid.Location = new System.Drawing.Point(243, 9);
            this.labelMeid.Name = "labelMeid";
            this.labelMeid.Size = new System.Drawing.Size(136, 13);
            this.labelMeid.TabIndex = 0;
            this.labelMeid.Text = "Jose Saldana JOSJB29311";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(87, 92);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(38, 13);
            this.labelName.TabIndex = 1;
            this.labelName.Text = "Name:";
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Location = new System.Drawing.Point(87, 123);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(76, 13);
            this.labelEmail.TabIndex = 2;
            this.labelEmail.Text = "Email Address:";
            // 
            // labelHomePhone
            // 
            this.labelHomePhone.AutoSize = true;
            this.labelHomePhone.Location = new System.Drawing.Point(87, 156);
            this.labelHomePhone.Name = "labelHomePhone";
            this.labelHomePhone.Size = new System.Drawing.Size(37, 13);
            this.labelHomePhone.TabIndex = 3;
            this.labelHomePhone.Text = "MEID:";
            // 
            // buttonNewStdnt
            // 
            this.buttonNewStdnt.Location = new System.Drawing.Point(75, 253);
            this.buttonNewStdnt.Name = "buttonNewStdnt";
            this.buttonNewStdnt.Size = new System.Drawing.Size(84, 38);
            this.buttonNewStdnt.TabIndex = 5;
            this.buttonNewStdnt.Text = "Submit New Student";
            this.buttonNewStdnt.UseVisualStyleBackColor = true;
            this.buttonNewStdnt.Click += new System.EventHandler(this.buttonNewStdnt_Click);
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(175, 89);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(118, 20);
            this.textBoxName.TabIndex = 6;
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new System.Drawing.Point(175, 120);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(118, 20);
            this.textBoxEmail.TabIndex = 7;
            // 
            // textBoxMeid
            // 
            this.textBoxMeid.Location = new System.Drawing.Point(175, 153);
            this.textBoxMeid.Name = "textBoxMeid";
            this.textBoxMeid.Size = new System.Drawing.Size(118, 20);
            this.textBoxMeid.TabIndex = 8;
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(226, 253);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(84, 38);
            this.buttonExit.TabIndex = 10;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonShowFile_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(391, 342);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.textBoxMeid);
            this.Controls.Add(this.textBoxEmail);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.buttonNewStdnt);
            this.Controls.Add(this.labelHomePhone);
            this.Controls.Add(this.labelEmail);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.labelMeid);
            this.Name = "Form1";
            this.Text = "Student File";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelMeid;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.Label labelHomePhone;
        private System.Windows.Forms.Button buttonNewStdnt;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.TextBox textBoxMeid;
        private System.Windows.Forms.Button buttonExit;
    }
}

