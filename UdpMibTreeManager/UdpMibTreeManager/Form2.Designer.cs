namespace UdpMibTreeManager
{
    partial class Form2
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
            this.messegesListBox = new System.Windows.Forms.ListBox();
            this.okButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // messegesListBox
            // 
            this.messegesListBox.FormattingEnabled = true;
            this.messegesListBox.Location = new System.Drawing.Point(12, 12);
            this.messegesListBox.Name = "messegesListBox";
            this.messegesListBox.Size = new System.Drawing.Size(260, 251);
            this.messegesListBox.TabIndex = 0;
            // 
            // okButton
            // 
            this.okButton.Location = new System.Drawing.Point(12, 267);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(260, 23);
            this.okButton.TabIndex = 1;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 302);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.messegesListBox);
            this.Name = "Form2";
            this.Text = "Powiadomienia TRAP";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox messegesListBox;
        private System.Windows.Forms.Button okButton;
    }
}