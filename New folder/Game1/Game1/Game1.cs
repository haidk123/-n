using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game1
{
    public partial class Game1 : Form
    {
        TimeSpan time;
        int moveCount;
        PictureBox[] disks;
        String temp;
        Stack<PictureBox> disksA, disksB, disksC, firstClickedDisks, secondClickedDisks;
        const int FIRSTY = 525, DISKHIGHT = 22, DISTXFROMRODTODISK = 3;

        public Game1()
        {
            InitializeComponent();
            disks = new PictureBox[] { Disk1, Disk2, Disk3, Disk4, Disk5, Disk6, Disk7, Disk8 };
            picRodA.Tag = disksA = new Stack<PictureBox>();
            picRodB.Tag = disksB = new Stack<PictureBox>();
            picRodC.Tag = disksC = new Stack<PictureBox>();
        }

        private void Game1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ShowRule_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Luật chơi: \n - Mỗi lần di chuyển 1 đĩa trên cùng của cọc. \n - Đĩa nằm trên phải nhỏ hơn đĩa dưới.",
                "Luật Chơi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Disk2_Click(object sender, EventArgs e)
        {

        }

       
        private void timer1_Tick(object sender, EventArgs e)
        {
            time = DateTime.Parse(DateTime.Now.ToLongTimeString()) - DateTime.Parse(temp);
            Time.Text = string.Format("Thời Gian: {0:00}:{1:00}:{2:00}", time.Hours, time.Minutes, time.Seconds);
        }

        private void GiveIn_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            Level.Enabled = true;
            GiveIn.Enabled = false;
            Play.Text = "CHƠI";
        }

        private void Play_Click(object sender, EventArgs e)
        {
            //reset
            timer1.Stop();
            foreach (PictureBox disk in disks)
                disk.Visible = false;
            time = new TimeSpan(0);
            moveCount = 0;
            Time.Text = "Thời Gian: 00:00:00";
            MoveCount.Text = "Số lần di chuyển: 0 lần";
            disksA.Clear();
            disksB.Clear();
            disksC.Clear();
            picRodA.BorderStyle = picRodB.BorderStyle = picRodC.BorderStyle = BorderStyle.None;
            firstClickedDisks = secondClickedDisks = null;

            // khởi tạo
            Level.Enabled = false;
            GiveIn.Enabled = true;
            Play.Text = "CHƠI LẠI";
            int x = picRodA.Location.X + DISTXFROMRODTODISK, y = FIRSTY;

            for (int i = (int)Level.Value - 1; i >= 0; --i, y -= DISKHIGHT)
            {
                disks[i].Location = new Point(x,y);
                disks[i].Visible = true;
                disksA.Push(disks[i]);
            }
            timer1.Start();
            temp = DateTime.Now.ToLongTimeString();
        }
        private void picRod_Click(object sender, EventArgs e)
        {
            if (Level.Enabled)
                return;  // không chơi
            PictureBox clickedRod = (PictureBox)sender;
            Stack<PictureBox> disksOfClickedRod = (Stack<PictureBox>)clickedRod.Tag;

            if (firstClickedDisks == null)
            {
                if (disksOfClickedRod.Count == 0)
                    return;
                firstClickedDisks = disksOfClickedRod;
                clickedRod.BorderStyle = BorderStyle.FixedSingle;
            }
            else if (secondClickedDisks == null)
            {
                if (disksOfClickedRod == firstClickedDisks)
                {
                    firstClickedDisks = null;
                    clickedRod.BorderStyle = BorderStyle.None;
                    return;
                }
                secondClickedDisks = disksOfClickedRod;
                ProcessMovingDisk(clickedRod);
            }
        }
         private void ProcessMovingDisk(PictureBox clickedRod)
        {
            if (secondClickedDisks.Count == 0)
                MoveDisk(new Point(clickedRod.Location.X + DISTXFROMRODTODISK, FIRSTY));
            else
            {
                PictureBox firstTopDisk = firstClickedDisks.Peek();
                PictureBox secondTopDisk = secondClickedDisks.Peek();
                if (int.Parse(firstTopDisk.Tag.ToString()) < int.Parse(secondTopDisk.Tag.ToString()))
                    MoveDisk(new Point(secondTopDisk.Location.X, secondTopDisk.Location.Y - DISKHIGHT));
                else
                    secondClickedDisks = null;
            }
        }
        private void MoveDisk(Point point)
        {
            PictureBox firstTopDisk = firstClickedDisks.Pop();
            firstTopDisk.Location = point;
            secondClickedDisks.Push(firstTopDisk);
            ++moveCount;
            MoveCount.Text = string.Format("Số lần di chuyển: {0} lần", moveCount);
            firstClickedDisks = secondClickedDisks = null;
            picRodA.BorderStyle = picRodB.BorderStyle = picRodC.BorderStyle = BorderStyle.None;

            if (disksC.Count == Level.Value)
            {
                GiveIn.PerformClick();
                MessageBox.Show("Chúc mừng bạn đã hoàn thành trò chơi", "Chúc Mừng");
            }
        }
        private void picDisk_Click(object sender, EventArgs e)
        {
            PictureBox clickedDisk = (PictureBox)sender;
            if (disksA.Contains(clickedDisk))
                picRod_Click(picRodA, new EventArgs());
            else if (disksB.Contains(clickedDisk))
                picRod_Click(picRodB, new EventArgs());
            else
                picRod_Click(picRodC, new EventArgs());
        }
    }
}
