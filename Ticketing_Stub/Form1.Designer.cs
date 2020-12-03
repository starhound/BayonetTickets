namespace Ticketing_Stub
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.issueLabel = new System.Windows.Forms.Label();
            this.submitButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.issueTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.instructionsLabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.uploadButton = new System.Windows.Forms.Button();
            this.generalComboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.specificComboBox = new System.Windows.Forms.ComboBox();
            this.screenShotLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // issueLabel
            // 
            this.issueLabel.AutoSize = true;
            this.issueLabel.Location = new System.Drawing.Point(9, 261);
            this.issueLabel.Name = "issueLabel";
            this.issueLabel.Size = new System.Drawing.Size(35, 13);
            this.issueLabel.TabIndex = 16;
            this.issueLabel.Text = "Issue:";
            // 
            // submitButton
            // 
            this.submitButton.Location = new System.Drawing.Point(12, 493);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(75, 23);
            this.submitButton.TabIndex = 9;
            this.submitButton.Text = "Submit";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(169, 493);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(75, 23);
            this.clearButton.TabIndex = 11;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(481, 493);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 12;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // issueTextBox
            // 
            this.issueTextBox.Location = new System.Drawing.Point(12, 277);
            this.issueTextBox.Multiline = true;
            this.issueTextBox.Name = "issueTextBox";
            this.issueTextBox.Size = new System.Drawing.Size(544, 160);
            this.issueTextBox.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(292, 164);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 26);
            this.label1.TabIndex = 10;
            this.label1.Text = "If this is an IT emergency\r\nplease call (727) 933-5322";
            // 
            // instructionsLabel
            // 
            this.instructionsLabel.AutoSize = true;
            this.instructionsLabel.Location = new System.Drawing.Point(292, 6);
            this.instructionsLabel.Name = "instructionsLabel";
            this.instructionsLabel.Size = new System.Drawing.Size(268, 208);
            this.instructionsLabel.TabIndex = 12;
            this.instructionsLabel.Text = resources.GetString("instructionsLabel.Text");
            // 
            // pictureBox1
            // 
            this.pictureBox1.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.ErrorImage")));
            this.pictureBox1.Image = global::Ticketing_Stub.Properties.Resources.Bayonet_4x8_01A_50_1_50;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(258, 116);
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(327, 493);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(75, 23);
            this.searchButton.TabIndex = 21;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // uploadButton
            // 
            this.uploadButton.Location = new System.Drawing.Point(12, 444);
            this.uploadButton.Name = "uploadButton";
            this.uploadButton.Size = new System.Drawing.Size(127, 23);
            this.uploadButton.TabIndex = 22;
            this.uploadButton.Text = "Upload ScreenShot";
            this.uploadButton.UseVisualStyleBackColor = true;
            this.uploadButton.Click += new System.EventHandler(this.uploadButton_Click);
            // 
            // generalComboBox
            // 
            this.generalComboBox.FormattingEnabled = true;
            this.generalComboBox.Location = new System.Drawing.Point(12, 180);
            this.generalComboBox.Name = "generalComboBox";
            this.generalComboBox.Size = new System.Drawing.Size(258, 21);
            this.generalComboBox.TabIndex = 24;
            this.generalComboBox.SelectedIndexChanged += new System.EventHandler(this.generalComboBox_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 164);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 25;
            this.label2.Text = "Issue Type:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 218);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 13);
            this.label3.TabIndex = 26;
            this.label3.Text = "Specific Issue";
            // 
            // specificComboBox
            // 
            this.specificComboBox.FormattingEnabled = true;
            this.specificComboBox.Location = new System.Drawing.Point(12, 235);
            this.specificComboBox.Name = "specificComboBox";
            this.specificComboBox.Size = new System.Drawing.Size(258, 21);
            this.specificComboBox.TabIndex = 27;
            // 
            // screenShotLabel
            // 
            this.screenShotLabel.AutoSize = true;
            this.screenShotLabel.Location = new System.Drawing.Point(145, 449);
            this.screenShotLabel.Name = "screenShotLabel";
            this.screenShotLabel.Size = new System.Drawing.Size(0, 13);
            this.screenShotLabel.TabIndex = 28;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(574, 528);
            this.Controls.Add(this.screenShotLabel);
            this.Controls.Add(this.specificComboBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.generalComboBox);
            this.Controls.Add(this.uploadButton);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.instructionsLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.issueTextBox);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.issueLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Bayonet IT Ticket Program v1.9.4";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label issueLabel;
        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.TextBox issueTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label instructionsLabel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Button uploadButton;
        private System.Windows.Forms.ComboBox generalComboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox specificComboBox;
        private System.Windows.Forms.Label screenShotLabel;
    }
}

