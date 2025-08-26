namespace BRClock2
{
    partial class ClockForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            TimeLabel = new Label();
            SuspendLayout();
            // 
            // TimeLabel
            // 
            TimeLabel.AutoSize = true;
            TimeLabel.Location = new Point(2, 4);
            TimeLabel.Margin = new Padding(0);
            TimeLabel.Name = "TimeLabel";
            TimeLabel.Size = new Size(81, 17);
            TimeLabel.TabIndex = 0;
            TimeLabel.Text = "Hello, world.";
            TimeLabel.DoubleClick += TimeLabel_DoubleClick;
            TimeLabel.MouseClick += TimeLabel_MouseClick;
            // 
            // ClockForm
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(800, 510);
            Controls.Add(TimeLabel);
            Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            MaximizeBox = false;
            MdiChildrenMinimizedAnchorBottom = false;
            MinimizeBox = false;
            Name = "ClockForm";
            Padding = new Padding(5, 7, 2, 1);
            ShowIcon = false;
            ShowInTaskbar = false;
            SizeGripStyle = SizeGripStyle.Hide;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "BRClock";
            TopMost = true;
            FormClosing += ClockForm_FormClosing;
            Load += ClockForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public Label TimeLabel;
    }
}
