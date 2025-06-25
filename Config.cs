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
	public partial class ConfigForm : Form
	{
		private Clock ClockInstance; // Add a reference to an instance of the Clock.

		public ConfigForm(Clock clock)
		{
			InitializeComponent();
			ClockInstance = clock; // Initialize the instance
		}

		private void btnFont_Click(object sender, EventArgs e)
		{
			FontDialog.Font = new Font(ClockInstance.ClockFont, ClockInstance.ClockFont.Style);
			FontDialog.ShowColor = true;
			if (FontDialog.ShowDialog() == DialogResult.OK)
			{
				ClockInstance.ClockFont = FontDialog.Font;
				SampleLabel.Font = FontDialog.Font; // Update the sample label font
			}
		}

		private void btnSetBackgroundColor_Click(object sender, EventArgs e)
		{
			colorDialog.Color = ClockInstance.ClockBackgroundColor; // Use the instance
			if (colorDialog.ShowDialog() == DialogResult.OK)
			{
				ClockInstance.ClockBackgroundColor = colorDialog.Color;
				SampleLabel.BackColor = colorDialog.Color; // Update the sample label background color
			}
		}

		private void btnSave_Click(object sender, EventArgs e)
		{
			ClockInstance.ClockDateTimeFormat = txtFormat.Text;
			this.Close();
		}
	}
}
