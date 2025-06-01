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

namespace Blinking_Balls
{
    public partial class Form1 : Form
    {
        Scene scene;
        public Form1()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
            scene = new Scene();
            timer1.Start();
            this.KeyPreview = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            scene.ChangeColor();
            scene.Grow();
            scene.RemoveTouchingBalls();
            Invalidate();
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            scene.Click(e.Location, e.Button);
            Invalidate();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            scene.Draw(e.Graphics);
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (scene.Selected != null)
            {
                const int step = 10;

                switch (keyData)
                {
                    case Keys.Left:
                        scene.Selected.Center = new Point(scene.Selected.Center.X - step, scene.Selected.Center.Y);
                        break;
                    case Keys.Right:
                        scene.Selected.Center = new Point(scene.Selected.Center.X + step, scene.Selected.Center.Y);
                        break;
                    case Keys.Up:
                        scene.Selected.Center = new Point(scene.Selected.Center.X, scene.Selected.Center.Y - step);
                        break;
                    case Keys.Down:
                        scene.Selected.Center = new Point(scene.Selected.Center.X, scene.Selected.Center.Y + step);
                        break;
                }

                scene.RemoveTouchingBalls();
                Invalidate();
            }

            return base.ProcessCmdKey(ref msg, keyData);
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
            scene = new Scene();
            Invalidate();
        }
    }
}
