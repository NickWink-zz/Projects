namespace Barcode_Final
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
            this.components = new System.ComponentModel.Container();
            this.textBarcode = new System.Windows.Forms.TextBox();
            this.code39Control1 = new Barcode_Final.Code39Control();
            this.SuspendLayout();
            // 
            // textBarcode
            // 
            this.textBarcode.Location = new System.Drawing.Point(157, 255);
            this.textBarcode.Name = "textBarcode";
            this.textBarcode.Size = new System.Drawing.Size(231, 20);
            this.textBarcode.TabIndex = 0;
            this.textBarcode.TextChanged += new System.EventHandler(this.textBarcode_TextChanged);
            // 
            // code39Control1
            // 
            this.code39Control1.BackColor = System.Drawing.Color.White;
            this.code39Control1.Location = new System.Drawing.Point(75, 12);
            this.code39Control1.Name = "code39Control1";
            this.code39Control1.Size = new System.Drawing.Size(400, 200);
            this.code39Control1.TabIndex = 1;
            this.code39Control1.Text = "code39Control1";
            this.code39Control1.WideNarrowRatio = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(546, 314);
            this.Controls.Add(this.code39Control1);
            this.Controls.Add(this.textBarcode);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBarcode;
        private Code39Control code39Control1;
    }
}

