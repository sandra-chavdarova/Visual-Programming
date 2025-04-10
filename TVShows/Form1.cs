using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TVShows
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public ProductionForm productionForm;
        Series show;
        public List<Series> shows = new List<Series>();
        //public List<int> codes = new List<int>();

        private void btnAdd_Click(object sender, EventArgs e)
        {
            productionForm = new ProductionForm();
            productionForm.existingProductions = cbProduction.Items.Cast<Production>().ToList();

            if (productionForm.ShowDialog() == DialogResult.OK)
            {
                cbProduction.Items.Add(productionForm.production);
                //codes.Add(productionForm.production.Code);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            show = new Series(productionForm.production, tbName.Text, (float)nudRating.Value, (int)nudSeasons.Value);
            lbShows.Items.Add(show);
            shows.Add(show);
            updateBoxes();
        }

        private void updateBoxes()
        {
            float sumRatings = 0;
            Series max = null;
            if (shows.Count() == 0)
            {
                tbAverage.Text = "Нема нови серии";
                tbMostSeasons.Text = "Нема нови серии";
                return;
            }
            if (shows.Count() != 0)
            {
                max = shows[0];
            }
            foreach (Series show in shows)
            {
                sumRatings += show.Rating;
                if (show.Seasons > max.Seasons)
                    max = show;
            }
            tbAverage.Text = (sumRatings / shows.Count()).ToString();
            tbMostSeasons.Text = show.ToString();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (lbShows.SelectedItem != null)
            {
                lbShows.Items.Remove(lbShows.SelectedItem);
            }
            updateBoxes();
        }
    }
}
