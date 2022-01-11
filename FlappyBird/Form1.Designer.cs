namespace FlappyBird
{
    partial class FlappyBird
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FlappyBird));
            this.bird = new System.Windows.Forms.PictureBox();
            this.pipDown = new System.Windows.Forms.PictureBox();
            this.pipUp = new System.Windows.Forms.PictureBox();
            this.ground = new System.Windows.Forms.PictureBox();
            this.scoreText = new System.Windows.Forms.Label();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.bird)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipUp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ground)).BeginInit();
            this.SuspendLayout();
            // 
            // bird
            // 
            this.bird.Image = ((System.Drawing.Image)(resources.GetObject("bird.Image")));
            this.bird.Location = new System.Drawing.Point(85, 85);
            this.bird.Name = "bird";
            this.bird.Size = new System.Drawing.Size(50, 40);
            this.bird.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bird.TabIndex = 0;
            this.bird.TabStop = false;
            // 
            // pipDown
            // 
            this.pipDown.Image = ((System.Drawing.Image)(resources.GetObject("pipDown.Image")));
            this.pipDown.Location = new System.Drawing.Point(257, 285);
            this.pipDown.Name = "pipDown";
            this.pipDown.Size = new System.Drawing.Size(82, 273);
            this.pipDown.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pipDown.TabIndex = 0;
            this.pipDown.TabStop = false;
            // 
            // pipUp
            // 
            this.pipUp.Image = ((System.Drawing.Image)(resources.GetObject("pipUp.Image")));
            this.pipUp.Location = new System.Drawing.Point(257, -3);
            this.pipUp.Name = "pipUp";
            this.pipUp.Size = new System.Drawing.Size(82, 146);
            this.pipUp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pipUp.TabIndex = 0;
            this.pipUp.TabStop = false;
            // 
            // ground
            // 
            this.ground.Image = ((System.Drawing.Image)(resources.GetObject("ground.Image")));
            this.ground.Location = new System.Drawing.Point(-7, 477);
            this.ground.Name = "ground";
            this.ground.Size = new System.Drawing.Size(397, 90);
            this.ground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ground.TabIndex = 0;
            this.ground.TabStop = false;
            // 
            // scoreText
            // 
            this.scoreText.AutoSize = true;
            this.scoreText.BackColor = System.Drawing.Color.Transparent;
            this.scoreText.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.scoreText.Location = new System.Drawing.Point(12, 9);
            this.scoreText.Name = "scoreText";
            this.scoreText.Size = new System.Drawing.Size(123, 31);
            this.scoreText.TabIndex = 1;
            this.scoreText.Text = "Score: 0";
            this.scoreText.Click += new System.EventHandler(this.label1_Click);
            // 
            // gameTimer
            // 
            this.gameTimer.Enabled = true;
            this.gameTimer.Tick += new System.EventHandler(this.gameTimer_Tick);
            // 
            // FlappyBird
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aqua;
            this.ClientSize = new System.Drawing.Size(384, 561);
            this.Controls.Add(this.ground);
            this.Controls.Add(this.scoreText);
            this.Controls.Add(this.bird);
            this.Controls.Add(this.pipUp);
            this.Controls.Add(this.pipDown);
            this.Name = "FlappyBird";
            this.Text = "Flappy Bird Game";
            this.Load += new System.EventHandler(this.FlappyBird_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gameKeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.gameKeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.bird)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipUp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ground)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox bird;
        private System.Windows.Forms.PictureBox pipDown;
        private System.Windows.Forms.PictureBox pipUp;
        private System.Windows.Forms.PictureBox ground;
        private System.Windows.Forms.Label scoreText;
        private System.Windows.Forms.Timer gameTimer;
    }
}

