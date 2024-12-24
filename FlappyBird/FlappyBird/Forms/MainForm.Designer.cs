namespace FlappyBird
{
    partial class MainForm
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
            picBird = new PictureBox();
            tmrBirdAnimation = new System.Windows.Forms.Timer(components);
            tmrBirdFall = new System.Windows.Forms.Timer(components);
            picGround1 = new PictureBox();
            picGround2 = new PictureBox();
            picGround3 = new PictureBox();
            picGround4 = new PictureBox();
            tmrSlidePipe = new System.Windows.Forms.Timer(components);
            pnlTop = new Panel();
            tmrCreatePipe = new System.Windows.Forms.Timer(components);
            label1 = new Label();
            lblScore = new Label();
            ((System.ComponentModel.ISupportInitialize)picBird).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picGround1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picGround2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picGround3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picGround4).BeginInit();
            SuspendLayout();
            // 
            // picBird
            // 
            picBird.BackgroundImage = Properties.Resources.Bird3;
            picBird.BackgroundImageLayout = ImageLayout.None;
            picBird.Location = new Point(82, 248);
            picBird.Name = "picBird";
            picBird.Size = new Size(64, 56);
            picBird.TabIndex = 0;
            picBird.TabStop = false;
            // 
            // tmrBirdAnimation
            // 
            tmrBirdAnimation.Enabled = true;
            tmrBirdAnimation.Interval = 120;
            tmrBirdAnimation.Tick += tmrBirdAnimation_Tick;
            // 
            // tmrBirdFall
            // 
            tmrBirdFall.Enabled = true;
            tmrBirdFall.Interval = 50;
            tmrBirdFall.Tick += tmrBirdFall_Tick;
            // 
            // picGround1
            // 
            picGround1.BackgroundImage = Properties.Resources.Ground;
            picGround1.BackgroundImageLayout = ImageLayout.Zoom;
            picGround1.Location = new Point(-15, 603);
            picGround1.Name = "picGround1";
            picGround1.Size = new Size(346, 99);
            picGround1.TabIndex = 1;
            picGround1.TabStop = false;
            // 
            // picGround2
            // 
            picGround2.BackgroundImage = Properties.Resources.Ground;
            picGround2.BackgroundImageLayout = ImageLayout.Zoom;
            picGround2.Location = new Point(326, 603);
            picGround2.Name = "picGround2";
            picGround2.Size = new Size(346, 99);
            picGround2.TabIndex = 1;
            picGround2.TabStop = false;
            // 
            // picGround3
            // 
            picGround3.BackgroundImage = Properties.Resources.Ground;
            picGround3.BackgroundImageLayout = ImageLayout.Zoom;
            picGround3.Location = new Point(668, 603);
            picGround3.Name = "picGround3";
            picGround3.Size = new Size(346, 99);
            picGround3.TabIndex = 1;
            picGround3.TabStop = false;
            // 
            // picGround4
            // 
            picGround4.BackgroundImage = Properties.Resources.Ground;
            picGround4.BackgroundImageLayout = ImageLayout.Zoom;
            picGround4.Location = new Point(1014, 681);
            picGround4.Name = "picGround4";
            picGround4.Size = new Size(346, 99);
            picGround4.TabIndex = 1;
            picGround4.TabStop = false;
            // 
            // tmrSlidePipe
            // 
            tmrSlidePipe.Enabled = true;
            tmrSlidePipe.Interval = 25;
            tmrSlidePipe.Tick += tmrSlidePipe_Tick;
            // 
            // pnlTop
            // 
            pnlTop.Location = new Point(3, -6);
            pnlTop.Name = "pnlTop";
            pnlTop.Size = new Size(983, 10);
            pnlTop.TabIndex = 3;
            // 
            // tmrCreatePipe
            // 
            tmrCreatePipe.Enabled = true;
            tmrCreatePipe.Interval = 2200;
            tmrCreatePipe.Tick += tmrCreatePipe_Tick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Comic Sans MS", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(12, 22);
            label1.Name = "label1";
            label1.Size = new Size(148, 51);
            label1.TabIndex = 4;
            label1.Text = "SCORE";
            // 
            // lblScore
            // 
            lblScore.AutoSize = true;
            lblScore.Font = new Font("Comic Sans MS", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblScore.ForeColor = Color.Fuchsia;
            lblScore.Location = new Point(152, 9);
            lblScore.Name = "lblScore";
            lblScore.Size = new Size(58, 67);
            lblScore.TabIndex = 4;
            lblScore.Text = "0";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(116, 198, 212);
            ClientSize = new Size(984, 661);
            Controls.Add(lblScore);
            Controls.Add(label1);
            Controls.Add(pnlTop);
            Controls.Add(picGround4);
            Controls.Add(picGround2);
            Controls.Add(picGround3);
            Controls.Add(picGround1);
            Controls.Add(picBird);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FlappyBird";
            ((System.ComponentModel.ISupportInitialize)picBird).EndInit();
            ((System.ComponentModel.ISupportInitialize)picGround1).EndInit();
            ((System.ComponentModel.ISupportInitialize)picGround2).EndInit();
            ((System.ComponentModel.ISupportInitialize)picGround3).EndInit();
            ((System.ComponentModel.ISupportInitialize)picGround4).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox picBird;
        private System.Windows.Forms.Timer tmrBirdAnimation;
        private System.Windows.Forms.Timer tmrBirdFall;
        private PictureBox picGround1;
        private PictureBox picGround2;
        private PictureBox picGround3;
        private PictureBox picGround4;
        private System.Windows.Forms.Timer tmrSlidePipe;
        private Panel pnlTop;
        private System.Windows.Forms.Timer tmrCreatePipe;
        private Label label1;
        private Label lblScore;
    }
}
