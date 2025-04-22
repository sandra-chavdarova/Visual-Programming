using System.Windows.Forms;

namespace Weather
{
    public partial class formWeather : Form
    {
        NewDay SelectedDay;
        public formWeather()
        {
            InitializeComponent();
        }

        private void btnAddDay_Click(object sender, EventArgs e)
        {
            AddDay newDay = new AddDay();
            if (newDay.ShowDialog() == DialogResult.OK)
            {
                lbWeather.Items.Add(newDay.DayResult);
                findMinMax();
            }
        }

        private void findMinMax()
        {
            int min = int.MaxValue;
            int max = int.MinValue;
            NewDay minDay = null;
            NewDay maxDay = null;
            foreach (object obj in lbWeather.Items)
            {
                NewDay day = obj as NewDay;
                if (day.Max > max)
                {
                    max = day.Max;
                    maxDay = day;
                }
                if (day.Min < min)
                {
                    min = day.Min;
                    minDay = day;
                }
            }
            if (minDay != null)
            {
                tbDayMaxTemperature.Text = maxDay.ToString();
                tbDayMinTemperature.Text = minDay.ToString();
            }
        }

        private void btnDeleteDay_Click(object sender, EventArgs e)
        {
            if (SelectedDay != null)
            {
                DialogResult dr = MessageBox.Show("Дали сакате да ја избришете ставката?", "Избриши", MessageBoxButtons.OKCancel);
                if (dr == DialogResult.OK)
                {
                    lbWeather.Items.Remove(SelectedDay);
                    findMinMax();
                }
            }
        }

        private void lbWeather_SelectedIndexChanged(object sender, EventArgs e)
        {
            SelectedDay = lbWeather.SelectedItem as NewDay;
            if (SelectedDay != null)
            {
                tbDate.Text = SelectedDay.Date;
                nudMaxTemperature.Value = SelectedDay.Max;
                nudMinTemperature.Value = SelectedDay.Min;
            }
            else
            {
                tbDate.Text = "";
                nudMaxTemperature.ResetText();
                nudMinTemperature.ResetText();
            }
        }

        private void nudMinTemperature_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (nudMinTemperature.Value > nudMaxTemperature.Value)
            {
                errorProvider1.SetError(nudMaxTemperature, "Минималната температура треба да биде помала од максималната");
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(nudMaxTemperature, null);
            }
        }

        private void nudMaxTemperature_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (nudMaxTemperature.Value < nudMinTemperature.Value)
            {
                errorProvider1.SetError(nudMaxTemperature, "Максималната температура треба да биде поголема од минималната");
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(nudMinTemperature, null);
            }
        }

        private void nudMaxTemperature_ValueChanged(object sender, EventArgs e)
        {
            if (SelectedDay != null)
            {
                SelectedDay.Max = (int)nudMaxTemperature.Value;
                findMinMax();
            }
        }

        private void nudMinTemperature_ValueChanged(object sender, EventArgs e)
        {
            if (SelectedDay != null)
            {
                SelectedDay.Min = (int)nudMinTemperature.Value;
                findMinMax();
            }
        }
    }
}
