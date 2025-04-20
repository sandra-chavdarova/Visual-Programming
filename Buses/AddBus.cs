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
    public partial class AddBus : Form
    {

        public Bus bus;
        public AddBus()
        {
            InitializeComponent();
        }

        private void AddBus_Load(object sender, EventArgs e)
        {

        }

        private void tbName_Validating(object sender, CancelEventArgs e)
        {
            if (tbName.Text == "")
            {
                errorProvider1.SetError(tbName, "Името е празно");
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(tbName, null);
            }
        }

        private void tbPlates_Validating(object sender, CancelEventArgs e)
        {
            if (tbPlates.TextLength != 4)
            {
                errorProvider1.SetError(tbPlates, "Регистрацијата треба да има точно 4 цифри");
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(tbPlates, null);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            bus = new Bus(tbName.Text, tbPlates.Text, true ? (cbLocal.Checked) : false);
            this.DialogResult = DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
