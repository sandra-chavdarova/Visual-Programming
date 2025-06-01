using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DrawObjects
{
    public partial class Form1 : Form
    {
        public Scene Scene { get; set; }
        public Form1()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
            Scene = new Scene();
            timer1.Interval = 500;
            timer1.Start();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
<<<<<<< HEAD
            
=======
        
>>>>>>> 02fe172578896ceeba637fff84c005a54bf35cdd
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Scene.Draw(e.Graphics);
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            Scene.Click(e.Location, e.Button);
            Invalidate();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Scene.Pulse();
            Invalidate();
        }
    }
}
