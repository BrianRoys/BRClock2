namespace BRClock2
{
    partial class frmClock
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
            lblTime = new Label();
            SuspendLayout();
            // 
            // lblTime
            // 
            lblTime.AutoSize = true;
            lblTime.Location = new Point(3, 0);
            lblTime.Margin = new Padding(5);
            lblTime.Name = "lblTime";
            lblTime.Size = new Size(74, 15);
            lblTime.TabIndex = 0;
            lblTime.Text = "Hello, world.";
            lblTime.MouseClick += lblTime_Click;
            // 
            // frmClock
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(800, 450);
            ControlBox = false;
            Controls.Add(lblTime);
            MaximizeBox = false;
            MdiChildrenMinimizedAnchorBottom = false;
            MinimizeBox = false;
            Name = "frmClock";
            ShowInTaskbar = false;
            Text = "BRClock";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTime;
    }
}
