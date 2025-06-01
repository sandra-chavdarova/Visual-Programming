using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HuntingBalls
{
    public partial class Form1 : Form
    {
        Scene scene;
        public static Random Random { get; set; } = new Random();
        public int TimerTick { get; set; }
        public bool Paused { get; set; } = false;
        public Form1()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
            List<Ball> balls = new List<Ball>();
            for (int i = 0; i < 3; i++)
            {
                Point center = new Point(Random.Next(this.Width + Ball.Radius), Random.Next(this.Height + Ball.Radius));
                balls.Add(new Ball(center));
            }
            scene = new Scene(balls, this.Height, this.Width);
            timer1.Start();
            TimerTick = 0;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            TimerTick++;
            if (TimerTick % 10 == 0)
            {
                scene.AddBall();
            }
            scene.Move();
            Invalidate();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            scene.Draw(e.Graphics);
        }

        private void Form1_ResizeEnd(object sender, EventArgs e)
        {
            scene.Height = this.Height;
            scene.Width = this.Width;
            Invalidate();
        }

        private void pauseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Paused)
            {
                timer1.Start();
                Paused = false;
                pauseToolStripMenuItem.Text = "Pause";
            }
            else
            {
                timer1.Stop();
                Paused = true;
                pauseToolStripMenuItem.Text = "Resume";
            }
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (scene.BlackBall != null)
            {
                scene.BlackBall.Move(e.Location);
                Hunt();
            }
            Invalidate();
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            if (scene.BlackBall == null)
            {
                scene.BlackBall = new BlackBall(e.Location);
                Hunt();
            }
            Invalidate();
        }

        private void Hunt()
        {
            for (int i = 0; i < scene.Balls.Count; i++)
            {
                if (scene.Balls[i].Hit(scene.BlackBall.Center))
                {
                    scene.BlackBall.Radius += 5;
                    scene.Balls.RemoveAt(i);
                    if (scene.BlackBall.Radius > 70)
                    {
                        scene.BlackBall = null;
                        break;
                    }
                }
            }
        }

        private void SaveScene(String path)
        {
            FileStream fs = new FileStream(path, FileMode.OpenOrCreate);
            IFormatter formatter = new BinaryFormatter();
            formatter.Serialize(fs, scene);
            fs.Close();
        }

        private void OpenScene(String path)
        {
            FileStream fs = new FileStream(path, FileMode.Open);
            IFormatter formatter = new BinaryFormatter();
            scene = (Scene)formatter.Deserialize(fs);
            fs.Close();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                SaveScene(saveFileDialog.FileName);
            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                OpenScene(openFileDialog.FileName);
            }
        }
    }
}
