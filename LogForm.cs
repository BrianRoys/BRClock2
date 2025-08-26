using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BRClock2
{
    public partial class LogForm : Form
    {
        private ClockForm ClockInstance; // Add a reference to an instance of the Clock.

        public LogForm(ClockForm clock)
        {
            ClockInstance = clock;
            InitializeComponent();
            NewLogTextBox.Enabled = false;
        }

        private void LogForm_Load(object sender, EventArgs e)
        {
            // Load the log entries from the file
            try
            {
                if (!File.Exists("log.txt"))
                {
                    File.Create("log.txt").Close();
                    return;
                }
                string[] logEntries = File.ReadAllLines("log.txt");
                foreach (string entry in logEntries)
                {
                    LogListBox.Items.Add(entry);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading log: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            (this as Form)?.Close();
        }

        private void NewButton_Click(object sender, EventArgs e)
        {
            NewLogTextBox.Enabled = true;
            NewLogTextBox.Text = DateTime.Now.ToString(ClockInstance.ClockDateTimeFormat) + " ";
            NewLogTextBox.Focus();
            NewLogTextBox.SelectionStart = NewLogTextBox.Text.Length;
        }

        private void NewLogTextBox_Leave(object sender, EventArgs e)
        {
            LogListBox.Items.Add(NewLogTextBox.Text);
            NewLogTextBox.Text = "";
            NewLogTextBox.Enabled = false;
        }

        private void SaveButton_Click_1(object sender, EventArgs e)
        {
            WriteLogToFile();
            (this as Form)?.Close();
        }

        private void WriteLogToFile()
        {
            // Save the log entries to the file, the '1' is because Visual Studio insisted on adding it.
            try
            {
                File.WriteAllLines("log.txt", LogListBox.Items.Cast<string>());
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error saving log: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
