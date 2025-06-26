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
			FontDialog = new FontDialog();
			colorDialog = new ColorDialog();
			FontButton = new Button();
			BackgroundColorButton = new Button();
			FormatTextBox = new TextBox();
			label1 = new Label();
			btnSave = new Button();
			btnCancel = new Button();
			SampleLabel = new Label();
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
			BackgroundColorButton.Location = new Point(12, 126);
			BackgroundColorButton.Name = "BackgroundColorButton";
			BackgroundColorButton.Size = new Size(144, 23);
			BackgroundColorButton.TabIndex = 1;
			BackgroundColorButton.Text = "Background Color";
			BackgroundColorButton.UseVisualStyleBackColor = true;
			BackgroundColorButton.Click += BackgroundColorButton_Click;
			// 
			// FormatTextBox
			// 
			FormatTextBox.Location = new Point(100, 87);
			FormatTextBox.Name = "FormatTextBox";
			FormatTextBox.Size = new Size(188, 23);
			FormatTextBox.TabIndex = 3;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(16, 90);
			label1.Name = "label1";
			label1.Size = new Size(78, 15);
			label1.TabIndex = 4;
			label1.Text = "Time Format:";
			// 
			// btnSave
			// 
			btnSave.Location = new Point(47, 164);
			btnSave.Name = "btnSave";
			btnSave.Size = new Size(75, 23);
			btnSave.TabIndex = 5;
			btnSave.Text = "&Save";
			btnSave.UseVisualStyleBackColor = true;
			btnSave.Click += SaveButton_Click;
			// 
			// btnCancel
			// 
			btnCancel.Location = new Point(176, 164);
			btnCancel.Name = "btnCancel";
			btnCancel.Size = new Size(75, 23);
			btnCancel.TabIndex = 6;
			btnCancel.Text = "Cancel";
			btnCancel.UseVisualStyleBackColor = true;
			// 
			// SampleLabel
			// 
			SampleLabel.AutoSize = true;
			SampleLabel.Location = new Point(16, 49);
			SampleLabel.Name = "SampleLabel";
			SampleLabel.Size = new Size(45, 15);
			SampleLabel.TabIndex = 7;
			SampleLabel.Text = "sample";
			// 
			// ConfigForm
			// 
			AcceptButton = btnSave;
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			CancelButton = btnCancel;
			ClientSize = new Size(321, 203);
			Controls.Add(SampleLabel);
			Controls.Add(btnCancel);
			Controls.Add(btnSave);
			Controls.Add(label1);
			Controls.Add(FormatTextBox);
			Controls.Add(BackgroundColorButton);
			Controls.Add(FontButton);
			MaximizeBox = false;
			MinimizeBox = false;
			Name = "ConfigForm";
			Text = "Config";
			TopMost = true;
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private FontDialog FontDialog;
        private ColorDialog colorDialog;
        private Button FontButton;
        private Button BackgroundColorButton;
        private TextBox FormatTextBox;
        private Label label1;
        private Button btnSave;
        private Button btnCancel;
		private Label SampleLabel;
	}
}