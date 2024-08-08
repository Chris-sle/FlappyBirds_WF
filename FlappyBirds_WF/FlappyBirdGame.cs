using System.Runtime.CompilerServices;

namespace FlappyBirds_WF
{
    public partial class FlappyBird : Form
    {
        private int _pipeSpeed = 8;
        private int _gravity = 10;
        private int _score = 0;
        private int _highScore = 0;
        private int _numberOfPipes = 2;
        private int _difficultyLevel = 1;
        private List<PictureBox> pipeTops = new List<PictureBox>();
        private List<PictureBox> pipeBottoms = new List<PictureBox>();


        public FlappyBird()
        {
            InitializeComponent();
            InitializePipes();

            GameOverWindow.Hide();
            GameOverHighScore.Hide();
            GameOverCurrentScore.Hide();
            UsernameInput.Hide();
            UsernameInput.Enabled = false;
            SubmitHighScoreButton.Hide();
            RestartButton.Hide();
            ExitButton.Hide();
        }

        private void InitializePipes()
        {
            Random rnd = new Random();

            for (int i = 0; i < _numberOfPipes; i++)
            {
                PictureBox newPipeTop = new PictureBox();
                newPipeTop.Image = Properties.Resources.pipedown;
                newPipeTop.SizeMode = PictureBoxSizeMode.StretchImage;
                newPipeTop.Size = new Size(110, 194);
                newPipeTop.Location = new Point(this.ClientSize.Width + i * 300, rnd.Next(-150, 0)); // Position and randomize height
                pipeTops.Add(newPipeTop);
                this.Controls.Add(newPipeTop);

                PictureBox newPipeBottom = new PictureBox();
                newPipeBottom.Image = Properties.Resources.pipe;
                newPipeBottom.SizeMode = PictureBoxSizeMode.StretchImage;
                newPipeBottom.Size = new Size(110, 316);
                newPipeBottom.Location = new Point(this.ClientSize.Width + i * 300, newPipeTop.Bottom + 160); // Position and randomize height
                pipeBottoms.Add(newPipeBottom);
                this.Controls.Add(newPipeBottom);
            }
        }

        private void GameTimerEvent(object sender, EventArgs e)
        {
            bird.Top += _gravity;
            pipeBottom.Left -= _pipeSpeed;
            pipeTop.Left -= _pipeSpeed;
            scoreText.Text = "Score: " + _score;

            BirdMovement();
            CollisionLogic();
            IncrementingDifficulty();
        }

        private void BirdMovement()
        {
            var originalSize = bird.Size;

            if (_gravity == 5) bird.Image = Properties.Resources.bird;
            if (_gravity > 5) bird.Image = Properties.Resources.birdDown;
            if(_gravity < 5) bird.Image = Properties.Resources.birdUp;

            bird.SizeMode = PictureBoxSizeMode.StretchImage;
            bird.Size = originalSize;
        }

        private void IncrementingDifficulty()
        {
            int milestone = 10;
            int difficultyIncrease = 2;

            if (_score >= milestone * _difficultyLevel)
            {
                _pipeSpeed += difficultyIncrease;
                _numberOfPipes += 1;
                _difficultyLevel++;
            }
        }

        private void CollisionLogic()
        {
            for (int i = 0; i < pipeTops.Count; i++)
            {
                pipeBottoms[i].Left -= _pipeSpeed;
                pipeTops[i].Left -= _pipeSpeed;

                if (pipeBottoms[i].Left < 0)
                {
                    pipeBottoms[i].Left = this.ClientSize.Width;
                    pipeTops[i].Left = this.ClientSize.Width;
                    _score++;
                }

                if (bird.Bounds.IntersectsWith(pipeBottoms[i].Bounds) ||
                    bird.Bounds.IntersectsWith(pipeTops[i].Bounds) ||
                    bird.Bounds.IntersectsWith(ground.Bounds))
                {
                    EndGame();
                }
            }

            if (bird.Top == this.ClientSize.Height)
            {
                EndGame();
            }

            scoreText.Text = "Score: " + _score;
        }

        private void EndGame()
        {
            gameTimer.Stop();
            scoreText.Text += " Game Over!";
            GameOverCurrentScore.Text = "Current Score: " + _score;
            if (_score > _highScore)
            {
                _highScore = _score;
            }

            GameOverHighScore.Text = "High Score: " + _highScore;

            GameOverWindow.Visible = true;
            GameOverHighScore.Visible = true;
            GameOverCurrentScore.Visible = true;
            UsernameInput.Visible = true;
            UsernameInput.Enabled = true;
            SubmitHighScoreButton.Visible = true;
            RestartButton.Visible = true;
            ExitButton.Visible = true;
        }

        private void GameKeyIsDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                _gravity = -5;
            }
        }

        private void GameKeyIsUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                _gravity = 5;
            }
        }

        private void RestartButton_Click(object sender, EventArgs e)
        {
            bird.Location = new Point(142, 239);
            
            Random rnd = new Random();
            for (int i = 0; i < pipeTops.Count; i++)
            {
                pipeTops[i].Left = this.ClientSize.Width + i * 300;
                pipeTops[i].Top = rnd.Next(-150, 0);
                pipeBottoms[i].Left = this.ClientSize.Width + i * 300;
                pipeBottoms[i].Top = pipeTops[i].Bottom + 150;
            }

            _score = 0;
            _pipeSpeed = 8;
            scoreText.Text = "Score: 0";
            gameTimer.Start();

            GameOverWindow.Hide();
            GameOverHighScore.Hide();
            GameOverCurrentScore.Hide();
            UsernameInput.Hide();
            UsernameInput.Enabled = false;
            SubmitHighScoreButton.Hide();
            RestartButton.Hide();
            ExitButton.Hide();

            this.Focus();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SubmitHighScoreButton_Click(object sender, EventArgs e)
        {
            string username = UsernameInput.Text.Trim();
            if (!string.IsNullOrEmpty(username))
            {
                DatabaseHelper dbHelper = new DatabaseHelper();
                dbHelper.InsertScore(username, _score);
                MessageBox.Show("Score submitted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Please enter a username.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
