namespace FlappyBirds_WF
{
    partial class FlappyBirdStartPage
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FlappyBirdStartPage));
            bindingSource1 = new BindingSource(components);
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            Title = new Label();
            StartGameButton = new Button();
            ScoreboardButton = new Button();
            ExitGameButton = new Button();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.ground;
            pictureBox1.Location = new Point(-3, 505);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(800, 62);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.pipe;
            pictureBox2.Location = new Point(78, 336);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(110, 211);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.pipedown;
            pictureBox3.Location = new Point(652, -22);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(110, 172);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 2;
            pictureBox3.TabStop = false;
            // 
            // Title
            // 
            Title.AutoSize = true;
            Title.Font = new Font("MV Boli", 27.8490562F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            Title.Location = new Point(293, 96);
            Title.Name = "Title";
            Title.Size = new Size(249, 54);
            Title.TabIndex = 3;
            Title.Text = "Flappy Bird";
            // 
            // StartGameButton
            // 
            StartGameButton.Font = new Font("MV Boli", 16.3018875F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            StartGameButton.Location = new Point(318, 179);
            StartGameButton.Name = "StartGameButton";
            StartGameButton.Size = new Size(178, 56);
            StartGameButton.TabIndex = 4;
            StartGameButton.Text = "Start Game";
            StartGameButton.UseVisualStyleBackColor = true;
            StartGameButton.Click += StartGameButton_Click;
            // 
            // ScoreboardButton
            // 
            ScoreboardButton.Font = new Font("MV Boli", 16.3018875F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            ScoreboardButton.Location = new Point(318, 252);
            ScoreboardButton.Name = "ScoreboardButton";
            ScoreboardButton.Size = new Size(178, 56);
            ScoreboardButton.TabIndex = 5;
            ScoreboardButton.Text = "Scoreboard";
            ScoreboardButton.UseVisualStyleBackColor = true;
            ScoreboardButton.Click += ScoreboardButton_Click;
            // 
            // ExitGameButton
            // 
            ExitGameButton.Font = new Font("MV Boli", 16.3018875F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            ExitGameButton.Location = new Point(318, 323);
            ExitGameButton.Name = "ExitGameButton";
            ExitGameButton.Size = new Size(178, 56);
            ExitGameButton.TabIndex = 6;
            ExitGameButton.Text = "Exit Game";
            ExitGameButton.UseVisualStyleBackColor = true;
            ExitGameButton.Click += this.ExitGameButton_Click;
            // 
            // FlappyBirdStartPage
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(128, 255, 255);
            ClientSize = new Size(784, 559);
            Controls.Add(ExitGameButton);
            Controls.Add(ScoreboardButton);
            Controls.Add(StartGameButton);
            Controls.Add(Title);
            Controls.Add(pictureBox1);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox3);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FlappyBirdStartPage";
            Text = "FlappyBird Startpage";
            ((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private BindingSource bindingSource1;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private Label Title;
        private Button StartGameButton;
        private Button ScoreboardButton;
        private Button ExitGameButton;
    }
}