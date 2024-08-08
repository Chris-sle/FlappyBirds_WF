namespace FlappyBirds_WF
{
    public partial class FlappyBirdStartPage : Form
    {
        public FlappyBirdStartPage()
        {
            InitializeComponent();
        }

        private void StartGameButton_Click(object? sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void ScoreboardButton_Click(object? sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Yes;
            this.Close();
        }

        private void ExitGameButton_Click(object? sender, EventArgs e)
        {
            this.Close();
        }
    }
}
