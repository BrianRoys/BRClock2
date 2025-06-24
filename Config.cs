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
        private frmClock clockInstance; // Add a reference to an instance of frmClock

        public Config(frmClock clock)
        {
            InitializeComponent();
            clockInstance = clock; // Initialize the instance
        }

        private void btnFont_Click(object sender, EventArgs e)
        {
            fontDialog.ShowColor = true;
            fontDialog.Font = new Font(clockInstance.ClockFontName, clockInstance.ClockFontSize); // Use the instance
            fontDialog.Color = clockInstance.ClockFontColor;

            if (fontDialog.ShowDialog() != DialogResult.Cancel)
            {
                clockInstance.ClockFontName = fontDialog.Font.Name;
                clockInstance.ClockFontSize = fontDialog.Font.Size;
                clockInstance.ClockFontColor = fontDialog.Color;

            }
        }
    }
}
