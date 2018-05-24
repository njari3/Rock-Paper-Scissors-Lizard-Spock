namespace RPSLS
{
    partial class Form1
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.rbSpock = new System.Windows.Forms.RadioButton();
            this.rbLizard = new System.Windows.Forms.RadioButton();
            this.btnPlay = new System.Windows.Forms.Button();
            this.rbScissors = new System.Windows.Forms.RadioButton();
            this.rbPaper = new System.Windows.Forms.RadioButton();
            this.rbRock = new System.Windows.Forms.RadioButton();
            this.LblStatistics = new System.Windows.Forms.Label();
            this.TopPanel = new System.Windows.Forms.Panel();
            this.btnNewGame = new System.Windows.Forms.Button();
            this.BottomPanel = new System.Windows.Forms.Panel();
            this.LeftPanel = new System.Windows.Forms.Panel();
            this.RightPanel = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.LblPlayer = new System.Windows.Forms.Label();
            this.LblComputer = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.LblGameResult = new System.Windows.Forms.Label();
            this.pictureBoxComputer = new System.Windows.Forms.PictureBox();
            this.pictureBoxPlayer = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.TopPanel.SuspendLayout();
            this.BottomPanel.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxComputer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPlayer)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rbSpock);
            this.panel1.Controls.Add(this.rbLizard);
            this.panel1.Controls.Add(this.btnPlay);
            this.panel1.Controls.Add(this.rbScissors);
            this.panel1.Controls.Add(this.rbPaper);
            this.panel1.Controls.Add(this.rbRock);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(25, 206);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(561, 162);
            this.panel1.TabIndex = 7;
            // 
            // rbSpock
            // 
            this.rbSpock.Appearance = System.Windows.Forms.Appearance.Button;
            this.rbSpock.AutoSize = true;
            this.rbSpock.BackColor = System.Drawing.SystemColors.Control;
            this.rbSpock.Image = global::RPSLS.Properties.Resources._5;
            this.rbSpock.Location = new System.Drawing.Point(451, 3);
            this.rbSpock.Name = "rbSpock";
            this.rbSpock.Size = new System.Drawing.Size(106, 105);
            this.rbSpock.TabIndex = 5;
            this.rbSpock.TabStop = true;
            this.rbSpock.UseVisualStyleBackColor = true;
            // 
            // rbLizard
            // 
            this.rbLizard.Appearance = System.Windows.Forms.Appearance.Button;
            this.rbLizard.AutoSize = true;
            this.rbLizard.BackColor = System.Drawing.SystemColors.Control;
            this.rbLizard.Image = global::RPSLS.Properties.Resources._4;
            this.rbLizard.Location = new System.Drawing.Point(339, 3);
            this.rbLizard.Name = "rbLizard";
            this.rbLizard.Size = new System.Drawing.Size(107, 106);
            this.rbLizard.TabIndex = 4;
            this.rbLizard.TabStop = true;
            this.rbLizard.UseVisualStyleBackColor = true;
            // 
            // btnPlay
            // 
            this.btnPlay.Location = new System.Drawing.Point(3, 115);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(554, 41);
            this.btnPlay.TabIndex = 6;
            this.btnPlay.Text = "Play!";
            this.btnPlay.UseVisualStyleBackColor = true;
            this.btnPlay.Click += new System.EventHandler(this.BtnPlay_Click);
            // 
            // rbScissors
            // 
            this.rbScissors.Appearance = System.Windows.Forms.Appearance.Button;
            this.rbScissors.AutoSize = true;
            this.rbScissors.BackColor = System.Drawing.SystemColors.Control;
            this.rbScissors.Image = global::RPSLS.Properties.Resources._3;
            this.rbScissors.Location = new System.Drawing.Point(227, 3);
            this.rbScissors.Name = "rbScissors";
            this.rbScissors.Size = new System.Drawing.Size(106, 106);
            this.rbScissors.TabIndex = 3;
            this.rbScissors.TabStop = true;
            this.rbScissors.UseVisualStyleBackColor = true;
            // 
            // rbPaper
            // 
            this.rbPaper.Appearance = System.Windows.Forms.Appearance.Button;
            this.rbPaper.AutoSize = true;
            this.rbPaper.Image = global::RPSLS.Properties.Resources._2;
            this.rbPaper.Location = new System.Drawing.Point(115, 3);
            this.rbPaper.Name = "rbPaper";
            this.rbPaper.Size = new System.Drawing.Size(106, 106);
            this.rbPaper.TabIndex = 2;
            this.rbPaper.TabStop = true;
            this.rbPaper.UseVisualStyleBackColor = true;
            // 
            // rbRock
            // 
            this.rbRock.Appearance = System.Windows.Forms.Appearance.Button;
            this.rbRock.AutoSize = true;
            this.rbRock.Image = global::RPSLS.Properties.Resources._1;
            this.rbRock.Location = new System.Drawing.Point(3, 3);
            this.rbRock.Name = "rbRock";
            this.rbRock.Size = new System.Drawing.Size(106, 106);
            this.rbRock.TabIndex = 1;
            this.rbRock.TabStop = true;
            this.rbRock.UseVisualStyleBackColor = true;
            // 
            // LblStatistics
            // 
            this.LblStatistics.AutoSize = true;
            this.LblStatistics.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblStatistics.Location = new System.Drawing.Point(22, 7);
            this.LblStatistics.Name = "LblStatistics";
            this.LblStatistics.Size = new System.Drawing.Size(75, 16);
            this.LblStatistics.TabIndex = 10;
            this.LblStatistics.Text = "Statistics...";
            // 
            // TopPanel
            // 
            this.TopPanel.Controls.Add(this.btnNewGame);
            this.TopPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopPanel.Location = new System.Drawing.Point(0, 0);
            this.TopPanel.Name = "TopPanel";
            this.TopPanel.Size = new System.Drawing.Size(611, 31);
            this.TopPanel.TabIndex = 11;
            // 
            // btnNewGame
            // 
            this.btnNewGame.Location = new System.Drawing.Point(27, 2);
            this.btnNewGame.Name = "btnNewGame";
            this.btnNewGame.Size = new System.Drawing.Size(75, 23);
            this.btnNewGame.TabIndex = 7;
            this.btnNewGame.Text = "New Game";
            this.btnNewGame.UseVisualStyleBackColor = true;
            this.btnNewGame.Click += new System.EventHandler(this.BtnNewGame_Click);
            // 
            // BottomPanel
            // 
            this.BottomPanel.Controls.Add(this.LblStatistics);
            this.BottomPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BottomPanel.Location = new System.Drawing.Point(0, 368);
            this.BottomPanel.Name = "BottomPanel";
            this.BottomPanel.Size = new System.Drawing.Size(611, 32);
            this.BottomPanel.TabIndex = 12;
            // 
            // LeftPanel
            // 
            this.LeftPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.LeftPanel.Location = new System.Drawing.Point(0, 31);
            this.LeftPanel.Name = "LeftPanel";
            this.LeftPanel.Size = new System.Drawing.Size(25, 337);
            this.LeftPanel.TabIndex = 13;
            // 
            // RightPanel
            // 
            this.RightPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.RightPanel.Location = new System.Drawing.Point(586, 31);
            this.RightPanel.Name = "RightPanel";
            this.RightPanel.Size = new System.Drawing.Size(25, 337);
            this.RightPanel.TabIndex = 14;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(102)))), ((int)(((byte)(167)))));
            this.panel2.Controls.Add(this.LblPlayer);
            this.panel2.Controls.Add(this.LblComputer);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.pictureBoxComputer);
            this.panel2.Controls.Add(this.pictureBoxPlayer);
            this.panel2.Location = new System.Drawing.Point(0, 27);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(611, 163);
            this.panel2.TabIndex = 15;
            // 
            // LblPlayer
            // 
            this.LblPlayer.AutoSize = true;
            this.LblPlayer.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPlayer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(153)))), ((int)(((byte)(88)))));
            this.LblPlayer.Location = new System.Drawing.Point(43, 0);
            this.LblPlayer.Name = "LblPlayer";
            this.LblPlayer.Size = new System.Drawing.Size(69, 24);
            this.LblPlayer.TabIndex = 12;
            this.LblPlayer.Text = "Player";
            // 
            // LblComputer
            // 
            this.LblComputer.AutoSize = true;
            this.LblComputer.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblComputer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(153)))), ((int)(((byte)(88)))));
            this.LblComputer.Location = new System.Drawing.Point(483, 0);
            this.LblComputer.Name = "LblComputer";
            this.LblComputer.Size = new System.Drawing.Size(103, 24);
            this.LblComputer.TabIndex = 11;
            this.LblComputer.Text = "Computer";
            // 
            // panel3
            // 
            this.panel3.BackgroundImage = global::RPSLS.Properties.Resources.image2;
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel3.Controls.Add(this.LblGameResult);
            this.panel3.Location = new System.Drawing.Point(181, -8);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(250, 178);
            this.panel3.TabIndex = 10;
            // 
            // LblGameResult
            // 
            this.LblGameResult.BackColor = System.Drawing.Color.Transparent;
            this.LblGameResult.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.LblGameResult.Font = new System.Drawing.Font("Arial", 28F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblGameResult.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(153)))), ((int)(((byte)(88)))));
            this.LblGameResult.Location = new System.Drawing.Point(0, 127);
            this.LblGameResult.Name = "LblGameResult";
            this.LblGameResult.Size = new System.Drawing.Size(250, 51);
            this.LblGameResult.TabIndex = 0;
            this.LblGameResult.Text = "GameResult";
            this.LblGameResult.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pictureBoxComputer
            // 
            this.pictureBoxComputer.Location = new System.Drawing.Point(458, 10);
            this.pictureBoxComputer.Name = "pictureBoxComputer";
            this.pictureBoxComputer.Size = new System.Drawing.Size(150, 150);
            this.pictureBoxComputer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBoxComputer.TabIndex = 9;
            this.pictureBoxComputer.TabStop = false;
            // 
            // pictureBoxPlayer
            // 
            this.pictureBoxPlayer.Location = new System.Drawing.Point(3, 10);
            this.pictureBoxPlayer.Name = "pictureBoxPlayer";
            this.pictureBoxPlayer.Size = new System.Drawing.Size(150, 150);
            this.pictureBoxPlayer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBoxPlayer.TabIndex = 5;
            this.pictureBoxPlayer.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(611, 400);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.RightPanel);
            this.Controls.Add(this.LeftPanel);
            this.Controls.Add(this.BottomPanel);
            this.Controls.Add(this.TopPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "RPSLS";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.TopPanel.ResumeLayout(false);
            this.BottomPanel.ResumeLayout(false);
            this.BottomPanel.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxComputer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPlayer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBoxPlayer;
        private System.Windows.Forms.RadioButton rbRock;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton rbScissors;
        private System.Windows.Forms.RadioButton rbPaper;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.RadioButton rbSpock;
        private System.Windows.Forms.RadioButton rbLizard;
        private System.Windows.Forms.PictureBox pictureBoxComputer;
        private System.Windows.Forms.Label LblStatistics;
        private System.Windows.Forms.Panel TopPanel;
        private System.Windows.Forms.Panel BottomPanel;
        private System.Windows.Forms.Panel LeftPanel;
        private System.Windows.Forms.Panel RightPanel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label LblGameResult;
        private System.Windows.Forms.Label LblComputer;
        private System.Windows.Forms.Label LblPlayer;
        private System.Windows.Forms.Button btnNewGame;
    }
}

