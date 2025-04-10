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
    public partial class Form1 : Form
    {
        Bus selectedBus;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAddBus_Click(object sender, EventArgs e)
        {
            AddBus Bus = new AddBus();
            if (Bus.ShowDialog() == DialogResult.OK)
            {
                lbBuses.Items.Add(Bus.bus);
                loadLines();
            }
        }

        private void btnDeleteBus_Click(object sender, EventArgs e)
        {
            selectedBus = lbBuses.SelectedItem as Bus;
            if (selectedBus != null)
            {
                DialogResult dr = MessageBox.Show("Дали сте сигурни дека сакате да го избришете автобусот?", "Избриши автобус", MessageBoxButtons.OKCancel);
                if (dr == DialogResult.OK)
                {
                    lbBuses.Items.Remove(selectedBus);
                    loadLines();
                }
            }
        }

        private void loadLines()
        {
            lbLines.Items.Clear();
            tbMostExpensive.Clear();
            tbAveragePrice.Clear();
            if (lbBuses.SelectedIndex != -1)
            {
                Bus selectedBus = lbBuses.Items[lbBuses.SelectedIndex] as Bus;
                double sum = 0;
                foreach (Line line in selectedBus.Lines)
                {
                    lbLines.Items.Add(line);
                    sum += line.Price;
                }

                if (selectedBus.Lines.Count() != 0)
                {
                    Line maxLine = lbLines.Items[0] as Line;
                    foreach (Line line in lbLines.Items)
                    {
                        if (line.Price > maxLine.Price)
                        {
                            maxLine = line;
                        }
                    }
                    tbMostExpensive.Text = maxLine.ToString();
                }
                else
                {
                    tbMostExpensive.Text = "Нема линии за овој автобус";
                }

                double averagePrice;
                if (selectedBus.Lines.Count() != 0)
                {
                    averagePrice = sum / selectedBus.Lines.Count();
                }
                else
                {
                    averagePrice = 0;
                    // maxLine = null;
                }

                tbAveragePrice.Text = averagePrice.ToString();

            }
        }

        private void btnAddLine_Click(object sender, EventArgs e)
        {
            if (lbBuses.SelectedIndex != -1)
            {
                AddLine addLine = new AddLine();
                if (addLine.ShowDialog() == DialogResult.OK)
                {
                    Bus selectedBus = lbBuses.Items[lbBuses.SelectedIndex] as Bus;
                    selectedBus.Lines.Add(addLine.line);
                    loadLines();
                }
            }
        }

        private void lbLines_SelectedValueChanged(object sender, EventArgs e)
        {
            loadLines();
        }

        private void lbBuses_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadLines();
        }
    }
}
