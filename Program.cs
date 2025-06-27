namespace BRClock2
{
    internal static class Program
    {
		/// <summary>
		///  The main entry point for the application.
		///  It is just a clock. Just a stupid clock. It is, however, a clock that can be configured to your liking.
		///  Font, background color, text color, and date/time format can all be changed.
        ///  Just a clock.
		/// </summary>
		[STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new ClockForm());
        }
    }
}