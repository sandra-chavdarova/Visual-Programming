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
    public partial class ProductionForm : Form
    {
        public Production production;
        public List<Production> existingProductions { get; set; }

        public ProductionForm()
        {
            InitializeComponent();
        }


        private void tbName_Validating(object sender, CancelEventArgs e)
        {
            if (tbName.Text == "")
            {
                errorProvider1.SetError(tbName, "Внесете име!");
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(tbName, null);
            }
        }

        private void tbCode_Validating(object sender, CancelEventArgs e)
        {
            int code = int.Parse(tbCode.Text);
            if (code > 99 || code < 10 || code == null)
            {
                errorProvider1.SetError(tbCode, "Внесете двоцифрен код!");
                e.Cancel = true;
                return;
            }

            if (existingProductions != null)
            {
                foreach (Production p in existingProductions)
                {
                    if (p.Code == code)
                    {
                        errorProvider1.SetError(tbCode, "Шифрата веќе постои");
                        e.Cancel = true;
                        return;
                    }
                }
            }

            errorProvider1.SetError(tbCode, null);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            production = new Production(tbName.Text, int.Parse(tbCode.Text));
            this.DialogResult = DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
