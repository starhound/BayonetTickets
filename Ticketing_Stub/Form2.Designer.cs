namespace Ticketing_Stub
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
            this.currentTicketsListBox = new System.Windows.Forms.ListBox();
            this.expandButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.ticketOutputTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // currentTicketsListBox
            // 
            this.currentTicketsListBox.FormattingEnabled = true;
            this.currentTicketsListBox.Location = new System.Drawing.Point(12, 12);
            this.currentTicketsListBox.Name = "currentTicketsListBox";
            this.currentTicketsListBox.ScrollAlwaysVisible = true;
            this.currentTicketsListBox.Size = new System.Drawing.Size(619, 147);
            this.currentTicketsListBox.TabIndex = 0;
            // 
            // expandButton
            // 
            this.expandButton.Location = new System.Drawing.Point(12, 451);
            this.expandButton.Name = "expandButton";
            this.expandButton.Size = new System.Drawing.Size(75, 23);
            this.expandButton.TabIndex = 1;
            this.expandButton.Text = "Expand";
            this.expandButton.UseVisualStyleBackColor = true;
            this.expandButton.Click += new System.EventHandler(this.expandButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(556, 451);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 2;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // ticketOutputTextBox
            // 
            this.ticketOutputTextBox.Location = new System.Drawing.Point(13, 166);
            this.ticketOutputTextBox.Multiline = true;
            this.ticketOutputTextBox.Name = "ticketOutputTextBox";
            this.ticketOutputTextBox.ReadOnly = true;
            this.ticketOutputTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.ticketOutputTextBox.Size = new System.Drawing.Size(618, 268);
            this.ticketOutputTextBox.TabIndex = 3;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(643, 482);
            this.Controls.Add(this.ticketOutputTextBox);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.expandButton);
            this.Controls.Add(this.currentTicketsListBox);
            this.Name = "Form2";
            this.Text = "Bayonet IT Ticket Search";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox currentTicketsListBox;
        private System.Windows.Forms.Button expandButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.TextBox ticketOutputTextBox;
    }
}