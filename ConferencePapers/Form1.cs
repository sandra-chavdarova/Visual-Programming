using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConferencePapers
{
    public partial class Form1 : Form
    {
        Conference conference;
        List<ConferencePaper> Conferences = new List<ConferencePaper>();
        public Form1()
        {
            InitializeComponent();
            cbYears.Items.Add(-1);
            loadYears();
            loadConferences();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            conference = new Conference();
            if (conference.ShowDialog() == DialogResult.OK)
            {
                lbConferences.Items.Add(conference.paper);
                Conferences.Add(conference.paper);
                loadYears();
                loadConferences();
            }
        }

        private void loadYears()
        {
            cbYears.Items.Clear();
            cbYears.Items.Add(-1);
            foreach (ConferencePaper c in Conferences)
            {
                cbYears.Items.Add(c.Year);
            }
        }

        private void loadConferences()
        {
            lbConferences.Items.Clear();
            if (cbYears.Text == "-1" || cbYears.Text == "")
            {
                foreach (ConferencePaper paper in Conferences)
                {
                    lbConferences.Items.Add(paper);
                }
            }
            else
            {
                int year = int.Parse(cbYears.Text);
                foreach (ConferencePaper paper in Conferences)
                {
                    if (year == paper.Year)
                    {
                        lbConferences.Items.Add(paper);
                    }
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (lbConferences.SelectedItem != null)
            {
                Conferences.Remove(lbConferences.SelectedItem as ConferencePaper);
                loadYears();
                loadConferences();
            }
        }

        private void cbYears_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadYears();
            loadConferences();
        }
    }
}
