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

namespace MergingBalls
{
    public partial class Form1 : Form
    {
        Scene scene;
        public bool Paused { get; set; } = true;
        public int Seconds = 0;
        public Form1()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
            scene = new Scene(this.Width, this.Height);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void startToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Paused)
            {
                timer1.Start();
                startToolStripMenuItem.Text = "Stop";
            }
            else
            {
                timer1.Stop();
                startToolStripMenuItem.Text = "Start";
            }
            Paused = !Paused;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            scene.Move();
            scene.MergeBalls();
            UpdateLabel();
            Invalidate();
            Seconds += 100;
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            scene.Draw(e.Graphics);
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            scene.AddBall(e.Location);
            scene.MergeBalls();
            UpdateLabel();
            Invalidate();
        }

        private void UpdateLabel()
        {
            int minutes = Seconds / 1000 / 60;
            int seconds = Seconds / 1000 % 60;
            String minutesString = minutes.ToString();
            String secondsString = seconds.ToString();
            if (minutes < 10)
                minutesString = $"0{minutes}";
            if (seconds < 10)
                secondsString = $"0{seconds}";
            tsslTime.Text = $"{minutesString}:{secondsString}";
            tsslCounter.Text = $"Balls: {scene.Balls.Count}";
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

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            scene = new Scene(this.Width, this.Height);
            Invalidate();
        }
    }
}
