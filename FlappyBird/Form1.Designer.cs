
namespace FlappyBird
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.pipeTop = new System.Windows.Forms.PictureBox();
            this.pipeBottom = new System.Windows.Forms.PictureBox();
            this.Ground = new System.Windows.Forms.PictureBox();
            this.flappyBird = new System.Windows.Forms.PictureBox();
            this.ScoreText = new System.Windows.Forms.Label();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pipeTop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeBottom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ground)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.flappyBird)).BeginInit();
            this.SuspendLayout();
            // 
            // pipeTop
            // 
            this.pipeTop.Image = global::FlappyBird.Properties.Resources.pipedown;
            this.pipeTop.Location = new System.Drawing.Point(689, 2);
            this.pipeTop.Name = "pipeTop";
            this.pipeTop.Size = new System.Drawing.Size(125, 272);
            this.pipeTop.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pipeTop.TabIndex = 0;
            this.pipeTop.TabStop = false;
            // 
            // pipeBottom
            // 
            this.pipeBottom.Image = global::FlappyBird.Properties.Resources.pipe;
            this.pipeBottom.Location = new System.Drawing.Point(512, 454);
            this.pipeBottom.Name = "pipeBottom";
            this.pipeBottom.Size = new System.Drawing.Size(125, 199);
            this.pipeBottom.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pipeBottom.TabIndex = 1;
            this.pipeBottom.TabStop = false;
            // 
            // Ground
            // 
            this.Ground.Image = global::FlappyBird.Properties.Resources.ground;
            this.Ground.Location = new System.Drawing.Point(1, 646);
            this.Ground.Name = "Ground";
            this.Ground.Size = new System.Drawing.Size(828, 120);
            this.Ground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Ground.TabIndex = 2;
            this.Ground.TabStop = false;
            // 
            // flappyBird
            // 
            this.flappyBird.Image = global::FlappyBird.Properties.Resources.bird;
            this.flappyBird.Location = new System.Drawing.Point(94, 318);
            this.flappyBird.Name = "flappyBird";
            this.flappyBird.Size = new System.Drawing.Size(79, 62);
            this.flappyBird.TabIndex = 3;
            this.flappyBird.TabStop = false;
            // 
            // ScoreText
            // 
            this.ScoreText.AutoSize = true;
            this.ScoreText.BackColor = System.Drawing.Color.NavajoWhite;
            this.ScoreText.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ScoreText.Location = new System.Drawing.Point(12, 683);
            this.ScoreText.Name = "ScoreText";
            this.ScoreText.Size = new System.Drawing.Size(134, 45);
            this.ScoreText.TabIndex = 4;
            this.ScoreText.Text = "Score:0";
            // 
            // gameTimer
            // 
            this.gameTimer.Enabled = true;
            this.gameTimer.Interval = 20;
            this.gameTimer.Tick += new System.EventHandler(this.gameTimerEvent);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aqua;
            this.ClientSize = new System.Drawing.Size(823, 737);
            this.Controls.Add(this.flappyBird);
            this.Controls.Add(this.ScoreText);
            this.Controls.Add(this.Ground);
            this.Controls.Add(this.pipeBottom);
            this.Controls.Add(this.pipeTop);
            this.Name = "Form1";
            this.Text = "FlappyBird";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gamekeyisdown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.gamekeyisup);
            ((System.ComponentModel.ISupportInitialize)(this.pipeTop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeBottom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ground)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.flappyBird)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pipeTop;
        private System.Windows.Forms.PictureBox pipeBottom;
        private System.Windows.Forms.PictureBox Ground;
        private System.Windows.Forms.PictureBox flappyBird;
        private System.Windows.Forms.Label ScoreText;
        private System.Windows.Forms.Timer gameTimer;
    }
}

