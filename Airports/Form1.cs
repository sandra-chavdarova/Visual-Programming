using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadDestinations();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnAddAirport_Click(object sender, EventArgs e)
        {
            AddAirport addAirport = new AddAirport();
            if (addAirport.ShowDialog() == DialogResult.OK)
            {
                lbAirports.Items.Add(addAirport.airport);
            }
        }

        private void btnDeleteAirport_Click(object sender, EventArgs e)
        {
            if (lbAirports.SelectedIndex == -1)
            {
                return;
            }
            DialogResult dg = MessageBox.Show("Дали си сигурен?", "Сигурен ли си  бе?", MessageBoxButtons.OKCancel);
            if (dg == DialogResult.OK)
            {
                int selectedIndex = lbAirports.SelectedIndex;
                lbAirports.Items.RemoveAt(selectedIndex);
            }
        }

        private void btnAddDestination_Click(object sender, EventArgs e)
        {
            if (lbAirports.SelectedIndex != -1)
            {
                AddDestination AddDestinationForm = new AddDestination();
                if (AddDestinationForm.ShowDialog() == DialogResult.OK)
                {
                    Airport SelectedAirport = lbAirports.Items[lbAirports.SelectedIndex] as Airport;
                    SelectedAirport.Destinations.Add(AddDestinationForm.CreatedDestination);
                    loadDestinations();
                }
            }
        }

        private void loadDestinations()
        {
            lbDestinations.Items.Clear();
            tbAverageDestination.Clear();
            tbMostExpensiveDestination.Clear();
            if (lbAirports.SelectedIndex != -1)
            {
                Airport SelectedAirport = lbAirports.Items[lbAirports.SelectedIndex] as Airport;

                foreach (Destination destination in SelectedAirport.Destinations)
                {
                    lbDestinations.Items.Add(destination);
                }
                // average distance
                double sum = 0;
                foreach (Destination destination in SelectedAirport.Destinations)
                {
                    sum += destination.Distance;
                }
                if (SelectedAirport.Destinations.Count() != 0)
                {
                    double average = sum / SelectedAirport.Destinations.Count();
                    tbAverageDestination.Text = $"{average}";
                }
                else
                {
                    tbAverageDestination.Text = "Овој аеродром нема дестинација";
                }

                // most expensive destination
                if (SelectedAirport.Destinations.Count() == 0)
                {
                    tbMostExpensiveDestination.Text = "Овој аеродром нема дестинација";
                }
                else
                {
                    Destination max = SelectedAirport.Destinations[0];
                    for (int i = 1; i < SelectedAirport.Destinations.Count(); i++)
                    {
                        if (SelectedAirport.Destinations[i].Price > max.Price)
                        {
                            max = SelectedAirport.Destinations[i];
                        }
                    }
                    tbMostExpensiveDestination.Text = max.ToString();
                }
            }
        }

        private void lbAirports_SelectedValueChanged(object sender, EventArgs e)
        {
            loadDestinations();
        }
    }
}
