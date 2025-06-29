using System.Diagnostics;
using System.Windows.Forms;

namespace BRClock2
{

	// This is JUST the Clock Configuration dialog box, not the settings themselves, 
	// they are in the ClockForm class. This is just a dialog box to change the settings.
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
			SampleLabel.Text = $"{ClockInstance.ClockFont.Name} {ClockInstance.ClockFont.SizeInPoints} pts";
		}

		private void DateTimeFormatHelpLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			try
			{

				var psi = new ProcessStartInfo
				{
					FileName = @"https://learn.microsoft.com/en-us/dotnet/api/system.datetime.tostring?view=net-9.0&devlangs=csharp&f1url=%3FappId%3DDev17IDEF1%26l%3DEN-US%26k%3Dk(System.DateTime.ToString)%3Bk(DevLang-csharp)%26rd%3Dtrue",
					UseShellExecute = true
				};
				Process.Start(psi);
			}
			catch (Exception ex)
			{
				Console.WriteLine($"Error opening URL: {ex.Message}");
			}
		}

		private void ConfigForm_Load(object sender, EventArgs e)
		{
			toolTip1.SetToolTip(DateTimeFormatHelpLinkLabel, "Click here for help on formatting.");
		}
	}
}
