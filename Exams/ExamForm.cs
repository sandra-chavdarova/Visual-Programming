using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exams
{
    public partial class ExamForm : Form
    {
        public ExamForm()
        {
            InitializeComponent();
        }

        public Exam exam;

        private void comboBox1_Validating(object sender, CancelEventArgs e)
        {
            if (cbMonth.Text == "")
            {
                errorProvider1.SetError(cbMonth, "Изберете месец!");
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(cbMonth, null);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            exam = new Exam((int)nudYear.Value, cbMonth.Text);
            this.DialogResult = DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
