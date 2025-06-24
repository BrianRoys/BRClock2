using Timer = System.Windows.Forms.Timer;

namespace BRClock2
{
    public partial class frmClock : Form
    {
        /// Configuration settings for the clock
        public string ClockFontName { get; set; } = "Arial";
        public float ClockFontSize { get; set; } = 12.0f;
        public Color ClockFontColor { get; set; } = Color.Black;
        public Color ClockBackgroundColor { get; set; } = Color.White;
        public string ClockFormat { get; set; } = "yyyy-MM-dd HH:mm:ss";

        private void UpdateClock(object? sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToString(ClockFormat);
        }

        public frmClock()
        {
            InitializeComponent();

            // Update the time every second
            Timer timer = new Timer();
            timer.Interval = 1000; // 1000 milliseconds = 1 second
            timer.Tick += UpdateClock;
            timer.Start();
        }

        private void SetClockConfig()
        {
            lblTime.Font = new Font(ClockFontName, ClockFontSize);
            lblTime.BackColor = ClockBackgroundColor;
            
        }

        private void lblTime_Click(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                Config configForm = new Config(this);
                configForm.ShowDialog();
                SetClockConfig();
            }
        }
    }
}
