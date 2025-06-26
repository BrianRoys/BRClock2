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
			ClockInstance = clock;
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
				ClockInstance.ClockTextColor = FontDialog.Color; 
				UpdateSampleText();
			}
		}

		private void BackgroundColorButton_Click(object sender, EventArgs e)
		{
			colorDialog.Color = ClockInstance.ClockBackgroundColor; // Use the instance
			if (colorDialog.ShowDialog() == DialogResult.OK)
			{
				ClockInstance.ClockBackgroundColor = colorDialog.Color;
				UpdateSampleText();
			}
		}

		private void SaveButton_Click(object sender, EventArgs e)
		{
			ClockInstance.SaveSettings();
			this.Close();
		}

		private void FormatTextBox_TextChanged(object sender, EventArgs e)
		{
			ClockInstance.ClockDateTimeFormat = FormatTextBox.Text;
			UpdateSampleText();
		}
		private void UpdateSampleText()
		{
			SampleLabel.BackColor = ClockInstance.ClockBackgroundColor;
			SampleLabel.ForeColor = ClockInstance.ClockTextColor; // Use the instance's text color
			SampleLabel.Font = ClockInstance.ClockFont; // Use the instance's font
			SampleLabel.Text = $"{FontDialog.Font.Name} {FontDialog.Font.SizeInPoints} pts";
		}
	}
}
