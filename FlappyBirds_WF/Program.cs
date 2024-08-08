namespace FlappyBirds_WF
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();

            while (true)
            {
                using FlappyBirdStartPage startPage = new FlappyBirdStartPage();
                var result = startPage.ShowDialog();

                if (result == DialogResult.OK)
                {
                    Application.Run(new FlappyBird());
                }
                else if (result == DialogResult.Yes)
                {
                    using FlappyBirdScoreboard scoreboard = new FlappyBirdScoreboard();
                    scoreboard.ShowDialog();
                }
                else
                {
                    break;
                }
            }
        }
    }
}