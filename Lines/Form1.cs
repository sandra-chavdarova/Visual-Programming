using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lines
{
    public partial class Form1 : Form
    {
        Scene scene;
        public Form1()
        {
            InitializeComponent();
            scene = new Scene(this.Width, this.Height);
            toolStripMenuItem2.Checked = true;
            positionToolStripMenuItem.Checked = true;
            this.DoubleBuffered = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            scene.Draw(e.Graphics);
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            scene.Click(e.Location);
            linesCountLabel.Text = $"Lines: {scene.lines.Count}";
            Invalidate();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            scene.lines.Clear();
            scene.PreviousLocation = Point.Empty;
            Invalidate();
            linesCountLabel.Text = $"Lines: {scene.lines.Count}";
        }

        private void colorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog dg = new ColorDialog();
            if (dg.ShowDialog() == DialogResult.OK)
            {
                scene.Color = dg.Color;
            }
        }

        private void positionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            positionToolStripMenuItem.Checked = !positionToolStripMenuItem.Checked;
            scene.DrawPosition = !scene.DrawPosition;
        }
        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            toolStripMenuItem2.Checked = true;
            toolStripMenuItem3.Checked = false;
            toolStripMenuItem4.Checked = false;
            scene.Thickness = 1;
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            toolStripMenuItem2.Checked = false;
            toolStripMenuItem3.Checked = true;
            toolStripMenuItem4.Checked = false;
            scene.Thickness = 2;
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            toolStripMenuItem2.Checked = false;
            toolStripMenuItem3.Checked = false;
            toolStripMenuItem4.Checked = true;
            scene.Thickness = 3;
        }

        private void linesCountLabel_MouseMove(object sender, MouseEventArgs e)
        {

        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            scene.Cursor = e.Location;
            Invalidate();
        }
    }
}
