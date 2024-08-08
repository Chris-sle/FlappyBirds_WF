namespace FlappyBirds_WF
{
    partial class FlappyBird
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FlappyBird));
            bird = new PictureBox();
            pipeTop = new PictureBox();
            pipeBottom = new PictureBox();
            ground = new PictureBox();
            gameTimer = new System.Windows.Forms.Timer(components);
            scoreText = new Label();
            GameOverWindow = new Panel();
            ExitButton = new Button();
            GameOverCurrentScore = new Label();
            SubmitHighScoreButton = new Button();
            RestartButton = new Button();
            UsernameInput = new TextBox();
            GameOverHighScore = new Label();
            ((System.ComponentModel.ISupportInitialize)bird).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pipeTop).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pipeBottom).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ground).BeginInit();
            GameOverWindow.SuspendLayout();
            SuspendLayout();
            // 
            // bird
            // 
            bird.AccessibleName = "flappyBird";
            bird.Image = Properties.Resources.bird;
            bird.Location = new Point(142, 239);
            bird.Name = "bird";
            bird.Size = new Size(72, 55);
            bird.SizeMode = PictureBoxSizeMode.StretchImage;
            bird.TabIndex = 0;
            bird.TabStop = false;
            // 
            // pipeTop
            // 
            pipeTop.AccessibleName = "pipeTop";
            pipeTop.Image = Properties.Resources.pipedown;
            pipeTop.Location = new Point(511, -23);
            pipeTop.Name = "pipeTop";
            pipeTop.Size = new Size(110, 194);
            pipeTop.SizeMode = PictureBoxSizeMode.StretchImage;
            pipeTop.TabIndex = 1;
            pipeTop.TabStop = false;
            // 
            // pipeBottom
            // 
            pipeBottom.AccessibleName = "pipeBottom";
            pipeBottom.Image = Properties.Resources.pipe;
            pipeBottom.Location = new Point(642, 348);
            pipeBottom.Name = "pipeBottom";
            pipeBottom.Size = new Size(110, 216);
            pipeBottom.SizeMode = PictureBoxSizeMode.StretchImage;
            pipeBottom.TabIndex = 2;
            pipeBottom.TabStop = false;
            // 
            // ground
            // 
            ground.AccessibleName = "Ground";
            ground.Image = Properties.Resources.ground;
            ground.Location = new Point(-5, 509);
            ground.Name = "ground";
            ground.Size = new Size(796, 55);
            ground.SizeMode = PictureBoxSizeMode.StretchImage;
            ground.TabIndex = 3;
            ground.TabStop = false;
            // 
            // gameTimer
            // 
            gameTimer.Enabled = true;
            gameTimer.Interval = 20;
            gameTimer.Tick += GameTimerEvent;
            // 
            // scoreText
            // 
            scoreText.AccessibleName = "scoreText";
            scoreText.AutoSize = true;
            scoreText.Font = new Font("Arial", 25.8113213F, FontStyle.Bold, GraphicsUnit.Point, 0);
            scoreText.Location = new Point(12, 9);
            scoreText.Name = "scoreText";
            scoreText.Size = new Size(170, 45);
            scoreText.TabIndex = 4;
            scoreText.Text = "Score: 0";
            // 
            // GameOverWindow
            // 
            GameOverWindow.BackColor = Color.YellowGreen;
            GameOverWindow.Controls.Add(ExitButton);
            GameOverWindow.Controls.Add(GameOverCurrentScore);
            GameOverWindow.Controls.Add(SubmitHighScoreButton);
            GameOverWindow.Controls.Add(RestartButton);
            GameOverWindow.Controls.Add(UsernameInput);
            GameOverWindow.Controls.Add(GameOverHighScore);
            GameOverWindow.Location = new Point(238, 135);
            GameOverWindow.Name = "GameOverWindow";
            GameOverWindow.Size = new Size(306, 233);
            GameOverWindow.TabIndex = 5;
            // 
            // ExitButton
            // 
            ExitButton.Location = new Point(200, 193);
            ExitButton.Name = "ExitButton";
            ExitButton.Size = new Size(83, 25);
            ExitButton.TabIndex = 5;
            ExitButton.Text = "Exit";
            ExitButton.UseVisualStyleBackColor = true;
            ExitButton.Click += ExitButton_Click;
            // 
            // GameOverCurrentScore
            // 
            GameOverCurrentScore.AutoSize = true;
            GameOverCurrentScore.Font = new Font("MV Boli", 12.2264156F, FontStyle.Bold, GraphicsUnit.Point, 0);
            GameOverCurrentScore.Location = new Point(56, 49);
            GameOverCurrentScore.Name = "GameOverCurrentScore";
            GameOverCurrentScore.Size = new Size(176, 23);
            GameOverCurrentScore.TabIndex = 4;
            GameOverCurrentScore.Text = "Current Score: 0";
            // 
            // SubmitHighScoreButton
            // 
            SubmitHighScoreButton.Location = new Point(78, 150);
            SubmitHighScoreButton.Name = "SubmitHighScoreButton";
            SubmitHighScoreButton.Size = new Size(166, 37);
            SubmitHighScoreButton.TabIndex = 3;
            SubmitHighScoreButton.Text = "Submit Highscore";
            SubmitHighScoreButton.UseVisualStyleBackColor = true;
            SubmitHighScoreButton.Click += SubmitHighScoreButton_Click;
            // 
            // RestartButton
            // 
            RestartButton.Location = new Point(39, 193);
            RestartButton.Name = "RestartButton";
            RestartButton.Size = new Size(83, 25);
            RestartButton.TabIndex = 2;
            RestartButton.Text = "Restart";
            RestartButton.UseVisualStyleBackColor = true;
            RestartButton.Click += RestartButton_Click;
            // 
            // UsernameInput
            // 
            UsernameInput.Font = new Font("MV Boli", 14.2641506F, FontStyle.Italic, GraphicsUnit.Point, 0);
            UsernameInput.Location = new Point(29, 85);
            UsernameInput.Name = "UsernameInput";
            UsernameInput.Size = new Size(254, 41);
            UsernameInput.TabIndex = 1;
            UsernameInput.Text = "Username here";
            // 
            // GameOverHighScore
            // 
            GameOverHighScore.AutoSize = true;
            GameOverHighScore.Font = new Font("MV Boli", 12.2264156F, FontStyle.Bold, GraphicsUnit.Point, 0);
            GameOverHighScore.Location = new Point(88, 13);
            GameOverHighScore.Name = "GameOverHighScore";
            GameOverHighScore.Size = new Size(144, 23);
            GameOverHighScore.TabIndex = 0;
            GameOverHighScore.Text = "High Score: 0";
            // 
            // FlappyBird
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(128, 255, 255);
            ClientSize = new Size(784, 559);
            Controls.Add(GameOverWindow);
            Controls.Add(scoreText);
            Controls.Add(ground);
            Controls.Add(pipeBottom);
            Controls.Add(pipeTop);
            Controls.Add(bird);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FlappyBird";
            Text = "FlappyBird";
            KeyDown += GameKeyIsDown;
            KeyUp += GameKeyIsUp;
            ((System.ComponentModel.ISupportInitialize)bird).EndInit();
            ((System.ComponentModel.ISupportInitialize)pipeTop).EndInit();
            ((System.ComponentModel.ISupportInitialize)pipeBottom).EndInit();
            ((System.ComponentModel.ISupportInitialize)ground).EndInit();
            GameOverWindow.ResumeLayout(false);
            GameOverWindow.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox bird;
        private PictureBox pipeTop;
        private PictureBox pipeBottom;
        private PictureBox ground;
        private System.Windows.Forms.Timer gameTimer;
        private Label scoreText;
        private Panel GameOverWindow;
        private Button SubmitHighScoreButton;
        private Button RestartButton;
        private TextBox UsernameInput;
        private Label GameOverHighScore;
        private Button ExitButton;
        private Label GameOverCurrentScore;
    }
}
