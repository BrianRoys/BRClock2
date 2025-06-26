using System.Text;
using Timer = System.Windows.Forms.Timer;

namespace BRClock2
{
	public partial class ClockForm : Form
	{
		/// Configuration settings for the clock
		public Font ClockFont { get; set; } = new Font("Arial", 12, FontStyle.Regular);
		public Color ClockBackgroundColor { get; set; } = Color.White;
		public string ClockDateTimeFormat { get; set; } = "yyyy-MM-dd HH:mm:ss";
		public Color ClockTextColor { get; internal set; } = Color.Black;

		private void UpdateClock(object? sender, EventArgs e)
		{
			TimeLabel.Font = ClockFont;
			TimeLabel.BackColor = ClockBackgroundColor;
			TimeLabel.ForeColor = ClockTextColor;
			TimeLabel.Text = DateTime.Now.ToString(ClockDateTimeFormat);
		}

		public ClockForm()
		{
			InitializeComponent();
			LoadSettings();

			// Update the time every second
			Timer timer = new Timer();
			timer.Interval = 1000; // 1000 milliseconds = 1 second
			timer.Tick += UpdateClock;
			timer.Start();
		}

		private void TimeLabel_MouseClick(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Right)
			{
				ConfigForm configForm = new ConfigForm(this);
				configForm.ShowDialog();
			}
		}

		// Settings can be only primitive types or serializable objects.
		// We have to break Fonts and Colors down in and out.
		public void LoadSettings()
		{
			ClockDateTimeFormat = Properties.Settings.Default.ClockDateTimeFormat;
			ClockBackgroundColor = Color.FromArgb
			(
				Properties.Settings.Default.ClockBackgroundColorA,
				Properties.Settings.Default.ClockBackgroundColorR,
				Properties.Settings.Default.ClockBackgroundColorG,
				Properties.Settings.Default.ClockBackgroundColorB
			);
			ClockTextColor = Color.FromArgb
			(
				Properties.Settings.Default.ClockTextColorA,
				Properties.Settings.Default.ClockTextColorR,
				Properties.Settings.Default.ClockTextColorG,
				Properties.Settings.Default.ClockTextColorB
			);
			ClockFont = new Font(
				Properties.Settings.Default.ClockFontFamily,
				(float)Properties.Settings.Default.ClockFontSize,
				(FontStyle)Properties.Settings.Default.ClockFontStyle
			);
		}

		public void SaveSettings()
		{
			Properties.Settings.Default["ClockDateTimeFormat"] = ClockDateTimeFormat;
			Properties.Settings.Default["ClockBackgroundColorA"] = ClockBackgroundColor.A;
			Properties.Settings.Default["ClockBackgroundColorR"] = ClockBackgroundColor.R;
			Properties.Settings.Default["ClockBackgroundColorG"] = ClockBackgroundColor.G;
			Properties.Settings.Default["ClockBackgroundColorB"] = ClockBackgroundColor.B;
			Properties.Settings.Default["ClockTextColorA"] = ClockTextColor.A;
			Properties.Settings.Default["ClockTextColorR"] = ClockTextColor.R;
			Properties.Settings.Default["ClockTextColorG"] = ClockTextColor.G;
			Properties.Settings.Default["ClockTextColorB"] = ClockTextColor.B;
			Properties.Settings.Default["ClockFontFamily"] = ClockFont.FontFamily.Name;
			Properties.Settings.Default["ClockFontSize"] = ClockFont.Size;
			Properties.Settings.Default["ClockFontStyle"] = (int)ClockFont.Style;

			Properties.Settings.Default.Save();
	}
}
}
