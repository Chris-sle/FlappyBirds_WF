namespace FlappyBirds_WF
{
    partial class FlappyBirdScoreboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FlappyBirdScoreboard));
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            returnButton = new Button();
            dataGridViewScores = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewScores).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.ground;
            pictureBox1.Location = new Point(-8, 506);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(800, 62);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.pipe;
            pictureBox2.Location = new Point(12, 325);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(110, 211);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 4;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.pipedown;
            pictureBox3.Location = new Point(662, -13);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(110, 172);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 5;
            pictureBox3.TabStop = false;
            // 
            // returnButton
            // 
            returnButton.Location = new Point(339, 418);
            returnButton.Name = "returnButton";
            returnButton.Size = new Size(83, 25);
            returnButton.TabIndex = 26;
            returnButton.Text = "Return";
            returnButton.UseVisualStyleBackColor = true;
            returnButton.Click += ReturnToStartPage;
            // 
            // dataGridViewScores
            // 
            dataGridViewScores.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewScores.Location = new Point(243, 69);
            dataGridViewScores.Name = "dataGridViewScores";
            dataGridViewScores.RowHeadersWidth = 45;
            dataGridViewScores.Size = new Size(265, 307);
            dataGridViewScores.TabIndex = 27;
            // 
            // FlappyBirdScoreboard
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(128, 255, 255);
            ClientSize = new Size(784, 559);
            Controls.Add(dataGridViewScores);
            Controls.Add(returnButton);
            Controls.Add(pictureBox1);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox3);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FlappyBirdScoreboard";
            Text = "FlappyBird Scoreboard";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewScores).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private Label highscoreName1;
        private Label highscore1;
        private Label highscore2;
        private Label highscoreName2;
        private Label highscore3;
        private Label highscoreName3;
        private Label highscore6;
        private Label highscoreName6;
        private Label highscore5;
        private Label highscoreName5;
        private Label highscore4;
        private Label highscoreName4;
        private Label highscore10;
        private Label highscoreName10;
        private Label highscore9;
        private Label highscoreName9;
        private Label highscore8;
        private Label highscoreName8;
        private Label highscore7;
        private Label highscoreName7;
        private Button returnButton;
        private DataGridView dataGridViewScores;
    }
}