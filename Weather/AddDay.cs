using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Weather
{
    public partial class AddDay : Form
    {
        public NewDay DayResult { get; set; }
        public AddDay()
        {
            InitializeComponent();
            foreach (string month in NewDay.MONTHS)
            {
                cbMonth.Items.Add(month);
            }
            for (int i = 1; i < 32; i++)
            {
                cbDay.Items.Add(i);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            DayResult = new NewDay();
            DayResult.Day = (int)cbDay.SelectedItem;
            DayResult.Month = cbMonth.SelectedIndex;
            this.DialogResult = DialogResult.OK;
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
