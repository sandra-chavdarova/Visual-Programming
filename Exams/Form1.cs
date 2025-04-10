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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            fillBoxes();
        }

        ExamForm examForm;

        private void btAdd_Click(object sender, EventArgs e)
        {
            examForm = new ExamForm();
            if (examForm.ShowDialog() == DialogResult.OK)
            {
                lbExams.Items.Add(examForm.exam);
            }
            fillBoxes();
        }

        private void fillBoxes()
        {
            Exam selectedExam = lbExams.SelectedItem as Exam;
            if (selectedExam != null)
            {
                tbComment1.Text = selectedExam.Comment1;
                tbComment2.Text = selectedExam.Comment2;
                nudPoints1.Value = selectedExam.Points1;
                nudPoints2.Value = selectedExam.Points2;
            }
            else
            {
                tbComment1.Text = "Нема избран испит";
                tbComment2.Text = "Нема избран испит";
                nudPoints1.Value = 0;
                nudPoints2.Value = 0;
            }
        }

        private void lbExams_SelectedIndexChanged(object sender, EventArgs e)
        {
            fillBoxes();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (lbExams.SelectedItem != null)
            {
                DialogResult dr = MessageBox.Show("Дали сакате да го избришете испитот?", "Избриши испит", MessageBoxButtons.OKCancel);
                if (dr == DialogResult.OK)
                    lbExams.Items.Remove(lbExams.SelectedItem);
            }
            fillBoxes();
        }

        private void btnSave1_Click(object sender, EventArgs e)
        {
            Exam selectedExam = lbExams.SelectedItem as Exam;
            if (selectedExam != null)
            {
                selectedExam.Comment1 = tbComment1.Text;
                selectedExam.Points1 = (int)nudPoints1.Value;
            }
            fillBoxes();
        }

        private void btnSave2_Click(object sender, EventArgs e)
        {
            Exam selectedExam = lbExams.SelectedItem as Exam;
            if (selectedExam != null)
            {
                selectedExam.Comment2 = tbComment2.Text;
                selectedExam.Points2 = (int)nudPoints2.Value;
            }
            fillBoxes();
        }
    }
}
