using FlappyBird.Forms;
using System.Security.Cryptography;

namespace FlappyBird
{
    public partial class MainForm : Form
    {

        int birdAnimationSeconds = 1;
        int gravity = 10;

        public MainForm()
        {
            InitializeComponent();
            this.KeyDown += KeyControl;
        }

        private void KeyControl(object? sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                picBird.Location = new Point(picBird.Location.X, picBird.Location.Y - 80);
            }
        }

        private void tmrBirdAnimation_Tick(object sender, EventArgs e)
        {
            switch (birdAnimationSeconds)
            {
                case 1:
                    picBird.Image = global::FlappyBird.Properties.Resources.Bird1;
                    break;
                case 2:
                    picBird.Image = global::FlappyBird.Properties.Resources.Bird2;
                    break;
                case 3:
                    picBird.Image = global::FlappyBird.Properties.Resources.Bird3;
                    birdAnimationSeconds = 0;
                    break;
            }
            birdAnimationSeconds++;
        }

        int score = 0;
        private void tmrBirdFall_Tick(object sender, EventArgs e)
        {
            picBird.Location = new Point(picBird.Location.X, picBird.Location.Y + gravity);

            if (picBird.Bounds.IntersectsWith(picGround1.Bounds) || picBird.Bounds.IntersectsWith(pnlTop.Bounds))
            {
                tmrBirdFall.Stop();
                GameOver();
            }
            foreach (var pipe in Pipes)
            {
                if (picBird.Bounds.IntersectsWith(pipe.Bounds))
                {
                    tmrBirdFall.Stop();
                    GameOver();
                    break;
                }
            }

            

            for (int i = Points.Count - 1; i >= 0; i--)
            {
                if (picBird.Bounds.IntersectsWith(Points[i].Bounds))
                {
                    score++;
                    lblScore.Text = score.ToString();
                    this.Controls.Remove(Points[i]);
                    Points.RemoveAt(i);
                }
            }

        }

        private void GameOver()
        {
            GameOverForm gameOverForm = new GameOverForm(score);
            gameOverForm.Show();
            this.Hide();
        }

        PictureBox PipeTop;
        PictureBox PipeBottom;
        PictureBox GetPoint;

        List<PictureBox> Pipes = new List<PictureBox>();
        List<PictureBox> Points = new List<PictureBox>();
        private void tmrSlidePipe_Tick(object sender, EventArgs e)
        {
            foreach (var pipe in Pipes)
            {
                pipe.Location = new Point(pipe.Location.X - 6, pipe.Location.Y);
            }
            foreach (var point in Points)
            {
                point.Location = new Point(point.Location.X - 6, point.Location.Y);
            }
        }

        private void tmrCreatePipe_Tick(object sender, EventArgs e)
        {
            Random random = new Random();
            int topPipeHeight = random.Next(145, 315);
            int gap = 220;
            int bottomPipeY = topPipeHeight + gap;

            GetPoint = new PictureBox();
            GetPoint.Size = new Size(150, 200);
            GetPoint.BackColor = Color.Transparent;
            GetPoint.Location = new Point(836, topPipeHeight);

            PipeTop = new PictureBox();
            PipeTop.BackgroundImage = FlappyBird.Properties.Resources.PipeTop;
            PipeTop.BackgroundImageLayout = ImageLayout.Stretch;
            PipeTop.Location = new Point(836, 10);
            PipeTop.Size = new Size(150, topPipeHeight);

            PipeBottom = new PictureBox();
            PipeBottom.BackgroundImage = FlappyBird.Properties.Resources.PipeBottom;
            PipeBottom.BackgroundImageLayout = ImageLayout.Stretch;
            PipeBottom.Location = new Point(836, bottomPipeY);
            PipeBottom.Size = new Size(150, 605 - bottomPipeY);

            Pipes.Add(PipeTop);
            Pipes.Add(PipeBottom);
            Points.Add(GetPoint);

            this.Controls.Add(PipeTop);
            this.Controls.Add(PipeBottom);
            this.Controls.Add(GetPoint);

        }

    }
}
