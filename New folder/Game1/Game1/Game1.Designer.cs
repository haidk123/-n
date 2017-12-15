namespace Game1
{
    partial class Game1
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
            this.components = new System.ComponentModel.Container();
            this.picRodA = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.picRodB = new System.Windows.Forms.PictureBox();
            this.B = new System.Windows.Forms.Label();
            this.picRodC = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Disk1 = new System.Windows.Forms.PictureBox();
            this.Disk2 = new System.Windows.Forms.PictureBox();
            this.Disk8 = new System.Windows.Forms.PictureBox();
            this.Disk7 = new System.Windows.Forms.PictureBox();
            this.Disk6 = new System.Windows.Forms.PictureBox();
            this.Disk5 = new System.Windows.Forms.PictureBox();
            this.Disk4 = new System.Windows.Forms.PictureBox();
            this.Disk3 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.Time = new System.Windows.Forms.Label();
            this.MoveCount = new System.Windows.Forms.Label();
            this.Level = new System.Windows.Forms.NumericUpDown();
            this.ChonDia = new System.Windows.Forms.Label();
            this.Play = new System.Windows.Forms.Button();
            this.GiveIn = new System.Windows.Forms.Button();
            this.ShowRule = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picRodA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRodB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRodC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Disk1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Disk2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Disk8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Disk7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Disk6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Disk5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Disk4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Disk3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Level)).BeginInit();
            this.SuspendLayout();
            // 
            // picRodA
            // 
            this.picRodA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.picRodA.Image = global::Game1.Properties.Resources.trụ;
            this.picRodA.Location = new System.Drawing.Point(86, 309);
            this.picRodA.Name = "picRodA";
            this.picRodA.Size = new System.Drawing.Size(370, 392);
            this.picRodA.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picRodA.TabIndex = 0;
            this.picRodA.TabStop = false;
            this.picRodA.Click += new System.EventHandler(this.picRod_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(257, 704);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "A";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // picRodB
            // 
            this.picRodB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.picRodB.Image = global::Game1.Properties.Resources.trụ;
            this.picRodB.Location = new System.Drawing.Point(530, 309);
            this.picRodB.Name = "picRodB";
            this.picRodB.Size = new System.Drawing.Size(370, 392);
            this.picRodB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picRodB.TabIndex = 0;
            this.picRodB.TabStop = false;
            this.picRodB.Click += new System.EventHandler(this.picRod_Click);
            // 
            // B
            // 
            this.B.AutoSize = true;
            this.B.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B.ForeColor = System.Drawing.Color.Black;
            this.B.Location = new System.Drawing.Point(703, 704);
            this.B.Name = "B";
            this.B.Size = new System.Drawing.Size(26, 25);
            this.B.TabIndex = 1;
            this.B.Text = "B";
            this.B.Click += new System.EventHandler(this.label1_Click);
            // 
            // picRodC
            // 
            this.picRodC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.picRodC.Image = global::Game1.Properties.Resources.trụ;
            this.picRodC.Location = new System.Drawing.Point(986, 309);
            this.picRodC.Name = "picRodC";
            this.picRodC.Size = new System.Drawing.Size(370, 392);
            this.picRodC.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picRodC.TabIndex = 0;
            this.picRodC.TabStop = false;
            this.picRodC.Click += new System.EventHandler(this.picRod_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(1151, 704);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 25);
            this.label3.TabIndex = 1;
            this.label3.Text = "C";
            this.label3.Click += new System.EventHandler(this.label1_Click);
            // 
            // Disk1
            // 
            this.Disk1.Image = global::Game1.Properties.Resources.d1;
            this.Disk1.Location = new System.Drawing.Point(88, 620);
            this.Disk1.Name = "Disk1";
            this.Disk1.Size = new System.Drawing.Size(366, 27);
            this.Disk1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.Disk1.TabIndex = 2;
            this.Disk1.TabStop = false;
            this.Disk1.Tag = "1";
            this.Disk1.Visible = false;
            this.Disk1.Click += new System.EventHandler(this.picDisk_Click);
            // 
            // Disk2
            // 
            this.Disk2.Image = global::Game1.Properties.Resources.d2;
            this.Disk2.Location = new System.Drawing.Point(532, 620);
            this.Disk2.Name = "Disk2";
            this.Disk2.Size = new System.Drawing.Size(366, 27);
            this.Disk2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.Disk2.TabIndex = 2;
            this.Disk2.TabStop = false;
            this.Disk2.Tag = "2";
            this.Disk2.Visible = false;
            this.Disk2.Click += new System.EventHandler(this.picDisk_Click);
            // 
            // Disk8
            // 
            this.Disk8.Image = global::Game1.Properties.Resources._8;
            this.Disk8.Location = new System.Drawing.Point(988, 619);
            this.Disk8.Name = "Disk8";
            this.Disk8.Size = new System.Drawing.Size(366, 27);
            this.Disk8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.Disk8.TabIndex = 2;
            this.Disk8.TabStop = false;
            this.Disk8.Tag = "8";
            this.Disk8.Visible = false;
            this.Disk8.Click += new System.EventHandler(this.picDisk_Click);
            // 
            // Disk7
            // 
            this.Disk7.Image = global::Game1.Properties.Resources.d7;
            this.Disk7.Location = new System.Drawing.Point(988, 592);
            this.Disk7.Name = "Disk7";
            this.Disk7.Size = new System.Drawing.Size(366, 27);
            this.Disk7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.Disk7.TabIndex = 2;
            this.Disk7.TabStop = false;
            this.Disk7.Tag = "7";
            this.Disk7.Visible = false;
            this.Disk7.Click += new System.EventHandler(this.picDisk_Click);
            // 
            // Disk6
            // 
            this.Disk6.Image = global::Game1.Properties.Resources.d6;
            this.Disk6.Location = new System.Drawing.Point(988, 554);
            this.Disk6.Name = "Disk6";
            this.Disk6.Size = new System.Drawing.Size(366, 27);
            this.Disk6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.Disk6.TabIndex = 2;
            this.Disk6.TabStop = false;
            this.Disk6.Tag = "6";
            this.Disk6.Visible = false;
            this.Disk6.Click += new System.EventHandler(this.picDisk_Click);
            // 
            // Disk5
            // 
            this.Disk5.Image = global::Game1.Properties.Resources.d5;
            this.Disk5.Location = new System.Drawing.Point(988, 521);
            this.Disk5.Name = "Disk5";
            this.Disk5.Size = new System.Drawing.Size(366, 27);
            this.Disk5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.Disk5.TabIndex = 2;
            this.Disk5.TabStop = false;
            this.Disk5.Tag = "5";
            this.Disk5.Visible = false;
            this.Disk5.Click += new System.EventHandler(this.picDisk_Click);
            // 
            // Disk4
            // 
            this.Disk4.Image = global::Game1.Properties.Resources.d4;
            this.Disk4.Location = new System.Drawing.Point(988, 488);
            this.Disk4.Name = "Disk4";
            this.Disk4.Size = new System.Drawing.Size(366, 27);
            this.Disk4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.Disk4.TabIndex = 2;
            this.Disk4.TabStop = false;
            this.Disk4.Tag = "4";
            this.Disk4.Visible = false;
            this.Disk4.Click += new System.EventHandler(this.picDisk_Click);
            // 
            // Disk3
            // 
            this.Disk3.Image = global::Game1.Properties.Resources.d3;
            this.Disk3.Location = new System.Drawing.Point(988, 455);
            this.Disk3.Name = "Disk3";
            this.Disk3.Size = new System.Drawing.Size(366, 27);
            this.Disk3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.Disk3.TabIndex = 2;
            this.Disk3.TabStop = false;
            this.Disk3.Tag = "3";
            this.Disk3.Visible = false;
            this.Disk3.Click += new System.EventHandler(this.picDisk_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Time
            // 
            this.Time.AutoSize = true;
            this.Time.BackColor = System.Drawing.Color.White;
            this.Time.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Time.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Time.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.Time.Location = new System.Drawing.Point(632, 9);
            this.Time.Name = "Time";
            this.Time.Size = new System.Drawing.Size(182, 27);
            this.Time.TabIndex = 3;
            this.Time.Text = "Thời Gian 00:00:00";
            // 
            // MoveCount
            // 
            this.MoveCount.AutoSize = true;
            this.MoveCount.BackColor = System.Drawing.Color.White;
            this.MoveCount.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.MoveCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MoveCount.ForeColor = System.Drawing.Color.Red;
            this.MoveCount.Location = new System.Drawing.Point(618, 41);
            this.MoveCount.Name = "MoveCount";
            this.MoveCount.Size = new System.Drawing.Size(212, 27);
            this.MoveCount.TabIndex = 3;
            this.MoveCount.Text = "Số lần di chuyển: 0 lần";
            // 
            // Level
            // 
            this.Level.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Level.Location = new System.Drawing.Point(733, 75);
            this.Level.Maximum = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.Level.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.Level.Name = "Level";
            this.Level.Size = new System.Drawing.Size(40, 30);
            this.Level.TabIndex = 4;
            this.Level.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // ChonDia
            // 
            this.ChonDia.AutoSize = true;
            this.ChonDia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ChonDia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChonDia.Location = new System.Drawing.Point(652, 77);
            this.ChonDia.Name = "ChonDia";
            this.ChonDia.Size = new System.Drawing.Size(77, 25);
            this.ChonDia.TabIndex = 5;
            this.ChonDia.Text = "Số Đĩa";
            // 
            // Play
            // 
            this.Play.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.Play.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Play.ForeColor = System.Drawing.Color.Black;
            this.Play.Location = new System.Drawing.Point(482, 131);
            this.Play.Name = "Play";
            this.Play.Size = new System.Drawing.Size(158, 60);
            this.Play.TabIndex = 6;
            this.Play.Text = "CHƠI";
            this.Play.UseVisualStyleBackColor = true;
            this.Play.Click += new System.EventHandler(this.Play_Click);
            // 
            // GiveIn
            // 
            this.GiveIn.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.GiveIn.Enabled = false;
            this.GiveIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GiveIn.ForeColor = System.Drawing.Color.Black;
            this.GiveIn.Location = new System.Drawing.Point(646, 131);
            this.GiveIn.Name = "GiveIn";
            this.GiveIn.Size = new System.Drawing.Size(158, 60);
            this.GiveIn.TabIndex = 6;
            this.GiveIn.Text = "CHỊU THUA";
            this.GiveIn.UseVisualStyleBackColor = true;
            this.GiveIn.Click += new System.EventHandler(this.GiveIn_Click);
            // 
            // ShowRule
            // 
            this.ShowRule.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.ShowRule.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShowRule.ForeColor = System.Drawing.Color.Black;
            this.ShowRule.Location = new System.Drawing.Point(810, 131);
            this.ShowRule.Name = "ShowRule";
            this.ShowRule.Size = new System.Drawing.Size(158, 60);
            this.ShowRule.TabIndex = 6;
            this.ShowRule.Text = "LUẬT CHƠI";
            this.ShowRule.UseVisualStyleBackColor = true;
            this.ShowRule.Click += new System.EventHandler(this.ShowRule_Click);
            // 
            // Game1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1385, 754);
            this.Controls.Add(this.ShowRule);
            this.Controls.Add(this.GiveIn);
            this.Controls.Add(this.Play);
            this.Controls.Add(this.ChonDia);
            this.Controls.Add(this.Level);
            this.Controls.Add(this.MoveCount);
            this.Controls.Add(this.Time);
            this.Controls.Add(this.Disk3);
            this.Controls.Add(this.Disk4);
            this.Controls.Add(this.Disk5);
            this.Controls.Add(this.Disk6);
            this.Controls.Add(this.Disk7);
            this.Controls.Add(this.Disk8);
            this.Controls.Add(this.Disk2);
            this.Controls.Add(this.Disk1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.B);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.picRodC);
            this.Controls.Add(this.picRodB);
            this.Controls.Add(this.picRodA);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "Game1";
            this.Text = "Game Xếp Đĩa";
            this.Load += new System.EventHandler(this.Game1_Load);
            this.Click += new System.EventHandler(this.picDisk_Click);
            ((System.ComponentModel.ISupportInitialize)(this.picRodA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRodB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRodC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Disk1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Disk2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Disk8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Disk7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Disk6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Disk5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Disk4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Disk3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Level)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picRodA;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox picRodB;
        private System.Windows.Forms.Label B;
        private System.Windows.Forms.PictureBox picRodC;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox Disk1;
        private System.Windows.Forms.PictureBox Disk2;
        private System.Windows.Forms.PictureBox Disk8;
        private System.Windows.Forms.PictureBox Disk7;
        private System.Windows.Forms.PictureBox Disk6;
        private System.Windows.Forms.PictureBox Disk5;
        private System.Windows.Forms.PictureBox Disk4;
        private System.Windows.Forms.PictureBox Disk3;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label Time;
        private System.Windows.Forms.Label MoveCount;
        private System.Windows.Forms.NumericUpDown Level;
        private System.Windows.Forms.Label ChonDia;
        private System.Windows.Forms.Button Play;
        private System.Windows.Forms.Button GiveIn;
        private System.Windows.Forms.Button ShowRule;
    }
}

