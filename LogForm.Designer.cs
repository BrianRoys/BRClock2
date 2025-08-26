namespace BRClock2
{
    partial class LogForm
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
            SaveButton = new Button();
            CancelButton = new Button();
            NewButton = new Button();
            LogListBox = new ListBox();
            NewLogTextBox = new TextBox();
            SuspendLayout();
            // 
            // SaveButton
            // 
            SaveButton.Location = new Point(3, 12);
            SaveButton.Name = "SaveButton";
            SaveButton.Size = new Size(75, 23);
            SaveButton.TabIndex = 1;
            SaveButton.Text = "Save";
            SaveButton.UseVisualStyleBackColor = true;
            SaveButton.Click += SaveButton_Click_1;
            // 
            // CancelButton
            // 
            CancelButton.Location = new Point(84, 12);
            CancelButton.Name = "CancelButton";
            CancelButton.Size = new Size(75, 23);
            CancelButton.TabIndex = 2;
            CancelButton.Text = "Cancel";
            CancelButton.UseVisualStyleBackColor = true;
            CancelButton.Click += CancelButton_Click;
            // 
            // NewButton
            // 
            NewButton.Location = new Point(165, 12);
            NewButton.Name = "NewButton";
            NewButton.Size = new Size(75, 23);
            NewButton.TabIndex = 3;
            NewButton.Text = "New";
            NewButton.UseVisualStyleBackColor = true;
            NewButton.Click += NewButton_Click;
            // 
            // LogListBox
            // 
            LogListBox.FormattingEnabled = true;
            LogListBox.ItemHeight = 15;
            LogListBox.Location = new Point(3, 41);
            LogListBox.Name = "LogListBox";
            LogListBox.Size = new Size(573, 334);
            LogListBox.TabIndex = 4;
            // 
            // NewLogTextBox
            // 
            NewLogTextBox.Location = new Point(246, 12);
            NewLogTextBox.Name = "NewLogTextBox";
            NewLogTextBox.Size = new Size(330, 23);
            NewLogTextBox.TabIndex = 5;
            NewLogTextBox.Leave += NewLogTextBox_Leave;
            // 
            // LogForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(584, 383);
            Controls.Add(NewLogTextBox);
            Controls.Add(LogListBox);
            Controls.Add(NewButton);
            Controls.Add(CancelButton);
            Controls.Add(SaveButton);
            Name = "LogForm";
            Text = "LogForm";
            Load += LogForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button SaveButton;
        private Button CancelButton;
        private Button NewButton;
        private ListBox LogListBox;
        private TextBox NewLogTextBox;
    }
}