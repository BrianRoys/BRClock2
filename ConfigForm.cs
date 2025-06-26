using DocumentFormat.OpenXml.CustomProperties;
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
		private ClockForm ClockInstance; // Add a reference to an instance of the Clock.

		public ConfigForm(ClockForm clock)
		{
			InitializeComponent();
			ClockInstance = clock; // Initialize the instance
			txtFormat.Text = ClockInstance.ClockDateTimeFormat;
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

			// Save off the configuration.
			//Properties.Settings.Default.ClockDateTimeFormat = ClockInstance.ClockDateTimeFormat;
			//Properties.Settings.Default.ClockFont = ClockInstance.ClockFont.Name;
			//Properties.Settings.Default.ClockFontSize = ClockInstance.ClockFont.Size;
			//Properties.Settings.Default.ClockFontStyle = (int)ClockInstance.ClockFont.Style;
			//Properties.Settings.Default.ClockBackgroundColor = ClockInstance.ClockBackgroundColor.ToArgb();
				
			this.Close();
		}
	}
}
