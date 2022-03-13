namespace T_Rex_Game_Runner
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.txtScore = new System.Windows.Forms.Label();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.txtEndScore = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cactus = new System.Windows.Forms.PictureBox();
            this.twocactus = new System.Windows.Forms.PictureBox();
            this.trex = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cactus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.twocactus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trex)).BeginInit();
            this.SuspendLayout();
            // 
            // txtScore
            // 
            this.txtScore.AutoSize = true;
            this.txtScore.Font = new System.Drawing.Font("Press Start 2P", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtScore.ForeColor = System.Drawing.Color.Black;
            this.txtScore.Location = new System.Drawing.Point(21, 18);
            this.txtScore.Name = "txtScore";
            this.txtScore.Size = new System.Drawing.Size(99, 18);
            this.txtScore.TabIndex = 4;
            this.txtScore.Text = "Счет: 0";
            // 
            // gameTimer
            // 
            this.gameTimer.Interval = 20;
            this.gameTimer.Tick += new System.EventHandler(this.MainGameTimerEvent);
            // 
            // txtEndScore
            // 
            this.txtEndScore.AutoSize = true;
            this.txtEndScore.Font = new System.Drawing.Font("Press Start 2P", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtEndScore.ForeColor = System.Drawing.Color.Red;
            this.txtEndScore.Location = new System.Drawing.Point(219, 172);
            this.txtEndScore.Name = "txtEndScore";
            this.txtEndScore.Size = new System.Drawing.Size(362, 22);
            this.txtEndScore.TabIndex = 5;
            this.txtEndScore.Text = "Игра окончена. Счет: 0";
            this.txtEndScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.txtEndScore.Visible = false;
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.Black;
            this.btnReset.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReset.Font = new System.Drawing.Font("Press Start 2P", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnReset.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnReset.Location = new System.Drawing.Point(288, 209);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(225, 45);
            this.btnReset.TabIndex = 7;
            this.btnReset.Text = "Начать заного";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Visible = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Black;
            this.pictureBox1.Location = new System.Drawing.Point(-8, 408);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(815, 49);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // cactus
            // 
            this.cactus.BackgroundImage = global::T_Rex_Game_Runner.Properties.Resources.obstacle_1;
            this.cactus.ErrorImage = null;
            this.cactus.InitialImage = null;
            this.cactus.Location = new System.Drawing.Point(370, 362);
            this.cactus.Name = "cactus";
            this.cactus.Size = new System.Drawing.Size(23, 46);
            this.cactus.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.cactus.TabIndex = 3;
            this.cactus.TabStop = false;
            this.cactus.Tag = "obstacle";
            // 
            // twocactus
            // 
            this.twocactus.BackgroundImage = global::T_Rex_Game_Runner.Properties.Resources.obstacle_2;
            this.twocactus.ErrorImage = null;
            this.twocactus.InitialImage = null;
            this.twocactus.Location = new System.Drawing.Point(446, 375);
            this.twocactus.Name = "twocactus";
            this.twocactus.Size = new System.Drawing.Size(32, 33);
            this.twocactus.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.twocactus.TabIndex = 2;
            this.twocactus.TabStop = false;
            this.twocactus.Tag = "obstacle";
            // 
            // trex
            // 
            this.trex.BackColor = System.Drawing.Color.Transparent;
            this.trex.ErrorImage = null;
            this.trex.InitialImage = null;
            this.trex.Location = new System.Drawing.Point(100, 365);
            this.trex.Name = "trex";
            this.trex.Size = new System.Drawing.Size(40, 43);
            this.trex.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.trex.TabIndex = 1;
            this.trex.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.txtEndScore);
            this.Controls.Add(this.txtScore);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.cactus);
            this.Controls.Add(this.twocactus);
            this.Controls.Add(this.trex);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "T-Rex Runner";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.keyisdown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.keyisup);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cactus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.twocactus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trex)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox trex;
        private System.Windows.Forms.PictureBox twocactus;
        private System.Windows.Forms.PictureBox cactus;
        private System.Windows.Forms.Label txtScore;
        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.Label txtEndScore;
        private System.Windows.Forms.Button btnReset;
    }
}

