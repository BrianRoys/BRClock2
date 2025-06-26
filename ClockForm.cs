using Timer = System.Windows.Forms.Timer;

namespace BRClock2
{
	public partial class ClockForm : Form
	{
		/// Configuration settings for the clock
		public Font ClockFont { get; set; }
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
			ClockFont = TimeLabel.Font;

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
				configForm.Modal();
			}
		}
	}
}
