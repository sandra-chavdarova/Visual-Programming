using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Visual_Programming
{
    public partial class AddLine : Form
    {

        public Line line;
        public AddLine()
        {
            InitializeComponent();
        }

        private void tbDestination_Validating(object sender, CancelEventArgs e)
        {
            if (tbDestination.Text == "")
            {
                errorProvider1.SetError(tbDestination, "Пополнете дестинација");
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(tbDestination, null);
            }
        }

        private void AddLine_Load(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            line = new Line(tbDestination.Text, (int)nudHour.Value, (int)nudMinute.Value, (int)nudPrice.Value);
            this.DialogResult = DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
