using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace BRClock2
{
    public partial class Config : Form
    {
        private Clock clockInstance; // Add a reference to an instance of the Clock.

        public Config(Clock clock)
        {
            InitializeComponent();
            clockInstance = clock; // Initialize the instance
        }

        private void btnFont_Click(object sender, EventArgs e)
        {
			fontDialog.Font = new Font(clockInstance.ClockFont, clockInstance.ClockFont.Style);
			fontDialog.ShowColor = true;
			if (fontDialog.ShowDialog() == DialogResult.OK)
            {
                clockInstance.ClockFont = fontDialog.Font;
            }
        }

        private void btnSetBackgroundColor_Click(object sender, EventArgs e)
        {
            colorDialog.Color = clockInstance.ClockBackgroundColor; // Use the instance
			if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                clockInstance.ClockBackgroundColor = colorDialog.Color; 
            }
        }
    }
}
