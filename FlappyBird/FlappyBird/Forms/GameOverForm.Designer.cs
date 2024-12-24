namespace FlappyBird.Forms
{
    partial class GameOverForm
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
            label1 = new Label();
            lblScore = new Label();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 39.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(223, 31);
            label1.Name = "label1";
            label1.Size = new Size(355, 65);
            label1.TabIndex = 0;
            label1.Text = "Game Over";
            // 
            // lblScore
            // 
            lblScore.AutoSize = true;
            lblScore.Font = new Font("Verdana", 42.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblScore.ForeColor = Color.MediumSpringGreen;
            lblScore.Location = new Point(145, 140);
            lblScore.Name = "lblScore";
            lblScore.Size = new Size(510, 68);
            lblScore.TabIndex = 0;
            lblScore.Text = "Your Score is 0";
            // 
            // button1
            // 
            button1.BackColor = Color.Lime;
            button1.Font = new Font("Tahoma", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.Black;
            button1.Location = new Point(145, 261);
            button1.Name = "button1";
            button1.Size = new Size(250, 62);
            button1.TabIndex = 1;
            button1.Text = "Play Again";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Red;
            button2.Font = new Font("Tahoma", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.White;
            button2.Location = new Point(405, 261);
            button2.Name = "button2";
            button2.Size = new Size(250, 62);
            button2.TabIndex = 1;
            button2.Text = "Exit The Game";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // GameOverForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkRed;
            ClientSize = new Size(800, 365);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(lblScore);
            Controls.Add(label1);
            Name = "GameOverForm";
            Text = "GameOverForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label lblScore;
        private Button button1;
        private Button button2;
    }
}