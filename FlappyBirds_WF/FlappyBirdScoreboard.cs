namespace FlappyBirds_WF
{
    public partial class FlappyBirdScoreboard : Form
    {
        private readonly DatabaseHelper _dbHelper;

        public FlappyBirdScoreboard()
        {
            InitializeComponent();
            _dbHelper = new DatabaseHelper();
            LoadScores();
        }

        private void LoadScores()
        {
            var scores = _dbHelper.GetScores();
            dataGridViewScores.DataSource = scores;
        }

        private void ReturnToStartPage(object? sender, EventArgs e)
        {
            this.Close();
        }
    }
}