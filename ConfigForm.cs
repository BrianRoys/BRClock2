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
			FormatTextBox.Text = ClockInstance.ClockDateTimeFormat;
		}

		private void FontButton_Click(object sender, EventArgs e)
		{
			FontDialog.Font = new Font(ClockInstance.ClockFont, ClockInstance.ClockFont.Style);
			FontDialog.ShowColor = true;
			FontDialog.Color = ClockInstance.ClockTextColor;
			if (FontDialog.ShowDialog() == DialogResult.OK)
			{
				ClockInstance.ClockFont = FontDialog.Font;
				ClockInstance.ClockTextColor = FontDialog.Color; // Update the text color in the clock instance

				// Update the sample label
				SampleLabel.Text = $"{FontDialog.Font.Name} {FontDialog.Font.SizeInPoints} pts"; 

			}
		}

		private void BackgroundColorButton_Click(object sender, EventArgs e)
		{
			colorDialog.Color = ClockInstance.ClockBackgroundColor; // Use the instance
			if (colorDialog.ShowDialog() == DialogResult.OK)
			{
				ClockInstance.ClockBackgroundColor = colorDialog.Color;
				SampleLabel.BackColor = colorDialog.Color; // Update the sample label background color
			}
		}

		private void SaveButton_Click(object sender, EventArgs e)
		{
			ClockInstance.ClockDateTimeFormat = FormatTextBox.Text;

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
