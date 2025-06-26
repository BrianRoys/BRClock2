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
			btnFont = new Button();
			btnColor = new Button();
			lblFontName = new Label();
			txtFormat = new TextBox();
			label1 = new Label();
			btnSave = new Button();
			btnCancel = new Button();
			SampleLabel = new Label();
			SuspendLayout();
			// 
			// btnFont
			// 
			btnFont.Location = new Point(109, 29);
			btnFont.Name = "btnFont";
			btnFont.Size = new Size(75, 23);
			btnFont.TabIndex = 0;
			btnFont.Text = "Font";
			btnFont.UseVisualStyleBackColor = true;
			btnFont.Click += btnFont_Click;
			// 
			// btnColor
			// 
			btnColor.Location = new Point(12, 29);
			btnColor.Name = "btnColor";
			btnColor.Size = new Size(91, 23);
			btnColor.TabIndex = 1;
			btnColor.Text = "Background";
			btnColor.UseVisualStyleBackColor = true;
			btnColor.Click += btnSetBackgroundColor_Click;
			// 
			// lblFontName
			// 
			lblFontName.AutoSize = true;
			lblFontName.Location = new Point(12, 71);
			lblFontName.Name = "lblFontName";
			lblFontName.Size = new Size(63, 15);
			lblFontName.TabIndex = 2;
			lblFontName.Text = "FontName";
			// 
			// txtFormat
			// 
			txtFormat.Location = new Point(96, 104);
			txtFormat.Name = "txtFormat";
			txtFormat.Size = new Size(188, 23);
			txtFormat.TabIndex = 3;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(12, 104);
			label1.Name = "label1";
			label1.Size = new Size(78, 15);
			label1.TabIndex = 4;
			label1.Text = "Time Format:";
			// 
			// btnSave
			// 
			btnSave.Location = new Point(37, 197);
			btnSave.Name = "btnSave";
			btnSave.Size = new Size(75, 23);
			btnSave.TabIndex = 5;
			btnSave.Text = "&Save";
			btnSave.UseVisualStyleBackColor = true;
			btnSave.Click += btnSave_Click;
			// 
			// btnCancel
			// 
			btnCancel.Location = new Point(132, 197);
			btnCancel.Name = "btnCancel";
			btnCancel.Size = new Size(75, 23);
			btnCancel.TabIndex = 6;
			btnCancel.Text = "Cancel";
			btnCancel.UseVisualStyleBackColor = true;
			// 
			// SampleLabel
			// 
			SampleLabel.AutoSize = true;
			SampleLabel.Location = new Point(12, 155);
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
			ClientSize = new Size(321, 450);
			Controls.Add(SampleLabel);
			Controls.Add(btnCancel);
			Controls.Add(btnSave);
			Controls.Add(label1);
			Controls.Add(txtFormat);
			Controls.Add(lblFontName);
			Controls.Add(btnColor);
			Controls.Add(btnFont);
			MaximizeBox = false;
			MinimizeBox = false;
			Name = "ConfigForm";
			Text = "Config";
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private FontDialog FontDialog;
        private ColorDialog colorDialog;
        private Button btnFont;
        private Button btnColor;
        private Label lblFontName;
        private TextBox txtFormat;
        private Label label1;
        private Button btnSave;
        private Button btnCancel;
		private Label SampleLabel;
	}
}