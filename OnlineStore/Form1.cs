using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kolokviumska
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        StoreItem selectedItem;

        private void btnAdd_Click(object sender, EventArgs e)
        {
            StoreItem item = new StoreItem(tbId.Text, tbName.Text, int.Parse(tbPrice.Text), int.Parse(tbQuantity.Text));
            lbItems.Items.Add(item);
            findSum();
        }

        private void tbId_Validating(object sender, CancelEventArgs e)
        {
            string id = tbId.Text;
            foreach (StoreItem item in lbItems.Items)
            {
                if (item.ID == id)
                {
                    errorProvider1.SetError(tbId, "Ова ИД веќе постои");
                    e.Cancel = true;
                }
                else
                {
                    errorProvider1.SetError(tbId, null);
                }
            }
        }

        private void tbName_Validating(object sender, CancelEventArgs e)
        {
            if (tbName.Text == "")
            {
                errorProvider1.SetError(tbName, "Внесете име");
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(tbName, null);
            }
        }

        void findSum()
        {
            int sum = 0;
            foreach (StoreItem item in lbItems.Items)
            {
                sum += item.Price * item.Quantity;
            }

            tbTotal.Text = sum.ToString();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            selectedItem = lbItems.SelectedItem as StoreItem;
            if (selectedItem != null)
            {
                DialogResult dr = MessageBox.Show("Дали сакате да ја избришете ставката?", "Избриши ставка", MessageBoxButtons.OKCancel);
                if (dr == DialogResult.OK)
                {
                    lbItems.Items.Remove(selectedItem);
                    findSum();
                }
            }
        }

        private void lbItems_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedItem = lbItems.SelectedItem as StoreItem;
            if (selectedItem != null)
            {
                tbId.Text = selectedItem.ID;
                tbName.Text = selectedItem.Name;
                tbPrice.Text = selectedItem.Price.ToString();
                tbQuantity.Text = selectedItem.Quantity.ToString();

            }
            else
            {
                tbId.Text = "";
                tbName.Text = "";
                tbPrice.Text = "";
                tbQuantity.Text = "";
            }
        }
    }
}
