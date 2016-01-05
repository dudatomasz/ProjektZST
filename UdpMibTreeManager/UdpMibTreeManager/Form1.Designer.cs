namespace UdpMibTreeManager
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
            this.chosenTableGridView = new System.Windows.Forms.DataGridView();
            this.getTableButton = new System.Windows.Forms.Button();
            this.watchObjectButton = new System.Windows.Forms.Button();
            this.oidTextBox = new System.Windows.Forms.TextBox();
            this.oidLabel = new System.Windows.Forms.Label();
            this.delayNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.watchLabel = new System.Windows.Forms.Label();
            this.watchedValueLabel = new System.Windows.Forms.Label();
            this.watchTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.chosenTableGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.delayNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // chosenTableGridView
            // 
            this.chosenTableGridView.AllowUserToAddRows = false;
            this.chosenTableGridView.AllowUserToDeleteRows = false;
            this.chosenTableGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader;
            this.chosenTableGridView.BackgroundColor = System.Drawing.SystemColors.Menu;
            this.chosenTableGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.chosenTableGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.chosenTableGridView.Location = new System.Drawing.Point(12, 12);
            this.chosenTableGridView.Name = "chosenTableGridView";
            this.chosenTableGridView.ReadOnly = true;
            this.chosenTableGridView.Size = new System.Drawing.Size(485, 273);
            this.chosenTableGridView.TabIndex = 0;
            // 
            // getTableButton
            // 
            this.getTableButton.Location = new System.Drawing.Point(12, 334);
            this.getTableButton.Name = "getTableButton";
            this.getTableButton.Size = new System.Drawing.Size(175, 23);
            this.getTableButton.TabIndex = 1;
            this.getTableButton.Text = "Pobierz tabelę";
            this.getTableButton.UseVisualStyleBackColor = true;
            this.getTableButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // watchObjectButton
            // 
            this.watchObjectButton.Location = new System.Drawing.Point(12, 363);
            this.watchObjectButton.Name = "watchObjectButton";
            this.watchObjectButton.Size = new System.Drawing.Size(175, 23);
            this.watchObjectButton.TabIndex = 2;
            this.watchObjectButton.Text = "Monitoruj obiekt";
            this.watchObjectButton.UseVisualStyleBackColor = true;
            this.watchObjectButton.Click += new System.EventHandler(this.watchObjectButton_Click);
            // 
            // oidTextBox
            // 
            this.oidTextBox.Location = new System.Drawing.Point(12, 308);
            this.oidTextBox.Name = "oidTextBox";
            this.oidTextBox.Size = new System.Drawing.Size(175, 20);
            this.oidTextBox.TabIndex = 3;
            this.oidTextBox.Text = ".1.3.6.1.2.1.";
            // 
            // oidLabel
            // 
            this.oidLabel.AutoSize = true;
            this.oidLabel.Location = new System.Drawing.Point(13, 292);
            this.oidLabel.Name = "oidLabel";
            this.oidLabel.Size = new System.Drawing.Size(99, 13);
            this.oidLabel.TabIndex = 4;
            this.oidLabel.Text = "Wpisz OID obiektu:";
            // 
            // delayNumericUpDown
            // 
            this.delayNumericUpDown.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.delayNumericUpDown.Location = new System.Drawing.Point(194, 308);
            this.delayNumericUpDown.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.delayNumericUpDown.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.delayNumericUpDown.Name = "delayNumericUpDown";
            this.delayNumericUpDown.Size = new System.Drawing.Size(120, 20);
            this.delayNumericUpDown.TabIndex = 5;
            this.delayNumericUpDown.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // watchLabel
            // 
            this.watchLabel.AutoSize = true;
            this.watchLabel.Location = new System.Drawing.Point(191, 288);
            this.watchLabel.Name = "watchLabel";
            this.watchLabel.Size = new System.Drawing.Size(122, 13);
            this.watchLabel.TabIndex = 6;
            this.watchLabel.Text = "Przedział monitorowania";
            // 
            // watchedValueLabel
            // 
            this.watchedValueLabel.AutoSize = true;
            this.watchedValueLabel.Location = new System.Drawing.Point(193, 339);
            this.watchedValueLabel.Name = "watchedValueLabel";
            this.watchedValueLabel.Size = new System.Drawing.Size(183, 13);
            this.watchedValueLabel.TabIndex = 8;
            this.watchedValueLabel.Text = "Tu pokaże się monitorowana wartość";
            // 
            // watchTimer
            // 
            this.watchTimer.Interval = 1;
            this.watchTimer.Tick += new System.EventHandler(this.watchTimer_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(509, 403);
            this.Controls.Add(this.watchedValueLabel);
            this.Controls.Add(this.watchLabel);
            this.Controls.Add(this.delayNumericUpDown);
            this.Controls.Add(this.oidLabel);
            this.Controls.Add(this.oidTextBox);
            this.Controls.Add(this.watchObjectButton);
            this.Controls.Add(this.getTableButton);
            this.Controls.Add(this.chosenTableGridView);
            this.Name = "Form1";
            this.Text = "SNMP";
            ((System.ComponentModel.ISupportInitialize)(this.chosenTableGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.delayNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView chosenTableGridView;
        private System.Windows.Forms.Button getTableButton;
        private System.Windows.Forms.Button watchObjectButton;
        private System.Windows.Forms.TextBox oidTextBox;
        private System.Windows.Forms.Label oidLabel;
        private System.Windows.Forms.NumericUpDown delayNumericUpDown;
        private System.Windows.Forms.Label watchLabel;
        private System.Windows.Forms.Label watchedValueLabel;
        private System.Windows.Forms.Timer watchTimer;
    }
}

