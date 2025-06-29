namespace BRClock2
{
    partial class ConfigForm
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
			components = new System.ComponentModel.Container();
			FontDialog = new FontDialog();
			colorDialog = new ColorDialog();
			FontButton = new Button();
			BackgroundColorButton = new Button();
			FormatTextBox = new TextBox();
			btnSave = new Button();
			btnCancel = new Button();
			SampleLabel = new Label();
			DateTimeFormatHelpLinkLabel = new LinkLabel();
			toolTip1 = new ToolTip(components);
			SuspendLayout();
			// 
			// FontButton
			// 
			FontButton.Location = new Point(16, 12);
			FontButton.Name = "FontButton";
			FontButton.Size = new Size(140, 23);
			FontButton.TabIndex = 0;
			FontButton.Text = "Select Font";
			FontButton.UseVisualStyleBackColor = true;
			FontButton.Click += FontButton_Click;
			// 
			// BackgroundColorButton
			// 
			BackgroundColorButton.Location = new Point(176, 12);
			BackgroundColorButton.Name = "BackgroundColorButton";
			BackgroundColorButton.Size = new Size(144, 23);
			BackgroundColorButton.TabIndex = 1;
			BackgroundColorButton.Text = "Background Color";
			BackgroundColorButton.UseVisualStyleBackColor = true;
			BackgroundColorButton.Click += BackgroundColorButton_Click;
			// 
			// FormatTextBox
			// 
			FormatTextBox.Location = new Point(16, 62);
			FormatTextBox.Name = "FormatTextBox";
			FormatTextBox.Size = new Size(220, 23);
			FormatTextBox.TabIndex = 3;
			FormatTextBox.TextChanged += FormatTextBox_TextChanged;
			// 
			// btnSave
			// 
			btnSave.Location = new Point(48, 151);
			btnSave.Name = "btnSave";
			btnSave.Size = new Size(75, 23);
			btnSave.TabIndex = 5;
			btnSave.Text = "&Save";
			btnSave.UseVisualStyleBackColor = true;
			btnSave.Click += SaveButton_Click;
			// 
			// btnCancel
			// 
			btnCancel.Location = new Point(213, 151);
			btnCancel.Name = "btnCancel";
			btnCancel.Size = new Size(75, 23);
			btnCancel.TabIndex = 6;
			btnCancel.Text = "Cancel";
			btnCancel.UseVisualStyleBackColor = true;
			// 
			// SampleLabel
			// 
			SampleLabel.AutoSize = true;
			SampleLabel.Location = new Point(16, 88);
			SampleLabel.Name = "SampleLabel";
			SampleLabel.Size = new Size(45, 15);
			SampleLabel.TabIndex = 7;
			SampleLabel.Text = "sample";
			// 
			// DateTimeFormatHelpLinkLabel
			// 
			DateTimeFormatHelpLinkLabel.AutoSize = true;
			DateTimeFormatHelpLinkLabel.Location = new Point(16, 44);
			DateTimeFormatHelpLinkLabel.Name = "DateTimeFormatHelpLinkLabel";
			DateTimeFormatHelpLinkLabel.Size = new Size(107, 15);
			DateTimeFormatHelpLinkLabel.TabIndex = 8;
			DateTimeFormatHelpLinkLabel.TabStop = true;
			DateTimeFormatHelpLinkLabel.Text = "Date-Time Format:";
			DateTimeFormatHelpLinkLabel.LinkClicked += DateTimeFormatHelpLinkLabel_LinkClicked;
			// 
			// ConfigForm
			// 
			AcceptButton = btnSave;
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			CancelButton = btnCancel;
			ClientSize = new Size(340, 193);
			Controls.Add(DateTimeFormatHelpLinkLabel);
			Controls.Add(SampleLabel);
			Controls.Add(btnCancel);
			Controls.Add(btnSave);
			Controls.Add(FormatTextBox);
			Controls.Add(BackgroundColorButton);
			Controls.Add(FontButton);
			MaximizeBox = false;
			MinimizeBox = false;
			Name = "ConfigForm";
			Text = "Config";
			TopMost = true;
			Load += ConfigForm_Load;
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private FontDialog FontDialog;
        private ColorDialog colorDialog;
        private Button FontButton;
        private Button BackgroundColorButton;
        private TextBox FormatTextBox;
        private Button btnSave;
        private Button btnCancel;
		private Label SampleLabel;
		private LinkLabel DateTimeFormatHelpLinkLabel;
		private ToolTip toolTip1;
	}
}