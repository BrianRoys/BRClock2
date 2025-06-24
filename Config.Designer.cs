namespace BRClock2
{
    partial class Config
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
            fontDialog = new FontDialog();
            colorDialog = new ColorDialog();
            btnFont = new Button();
            button1 = new Button();
            lblFontName = new Label();
            SuspendLayout();
            // 
            // btnFont
            // 
            btnFont.Location = new Point(0, 0);
            btnFont.Name = "btnFont";
            btnFont.Size = new Size(75, 23);
            btnFont.TabIndex = 0;
            btnFont.Text = "Font";
            btnFont.UseVisualStyleBackColor = true;
            btnFont.Click += btnFont_Click;
            // 
            // button1
            // 
            button1.Location = new Point(81, 0);
            button1.Name = "button1";
            button1.Size = new Size(91, 23);
            button1.TabIndex = 1;
            button1.Text = "Background";
            button1.UseVisualStyleBackColor = true;
            // 
            // lblFontName
            // 
            lblFontName.AutoSize = true;
            lblFontName.Location = new Point(0, 26);
            lblFontName.Name = "lblFontName";
            lblFontName.Size = new Size(63, 15);
            lblFontName.TabIndex = 2;
            lblFontName.Text = "FontName";
            // 
            // Config
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblFontName);
            Controls.Add(button1);
            Controls.Add(btnFont);
            Name = "Config";
            Text = "Config";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FontDialog fontDialog;
        private ColorDialog colorDialog;
        private Button btnFont;
        private Button button1;
        private Label lblFontName;
    }
}