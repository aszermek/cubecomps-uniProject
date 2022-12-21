using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projektfeladat_z7kfuz
{
    public partial class RegistrationForm : Form
    {
        Database1Entities context = new Database1Entities();

        public RegistrationForm()
        {
            InitializeComponent();
        }

        private void dateTimePicker_ValueChanged_1(object sender, EventArgs e)
        {
            if (DateTime.Today.Year - dateTimePicker.Value.Year < 18)
            {
                birthdateAlert.Visible = true;
            }
            else
            {
                birthdateAlert.Visible = false;
            }
        }

        private void textBoxName_TextChanged(object sender, EventArgs e)
        {
            Validate();
        }

        private void textBoxName_Validating(object sender, CancelEventArgs e)
        {
            Regex name = new Regex("[A-Z|À-Ž][a-z|à-ž]+[ ][A-Z|À-Ž][a-z|à-ž]+");
            if (!name.IsMatch(textBoxName.Text))
            {
                e.Cancel = true;
                textBoxName.BackColor = Color.LightSalmon;
            }
            else
            {
                textBoxName.BackColor = Color.PaleGreen;
            }
        }

        private void textBoxWCAID_TextChanged(object sender, EventArgs e)
        {
            Validate();
        }

        private void textBoxWCAID_Validating(object sender, CancelEventArgs e)
        {
            Regex wcaid = new Regex("([0-9]{4}[A-Z]{4}[0-9]{2}|^$)");
            if (!wcaid.IsMatch(textBoxWCAID.Text))
            {
                e.Cancel = true;
                textBoxWCAID.BackColor = Color.LightSalmon;
            }
            else
            {
                textBoxWCAID.BackColor = Color.PaleGreen;
            }
        }

        private void comboBoxCountry_TextChanged(object sender, EventArgs e)
        {
            Validate();
        }

        private void comboBoxCountry_Validating(object sender, CancelEventArgs e)
        {
            if (comboBoxCountry.Text == "")
            {
                e.Cancel = true;
                comboBoxCountry.BackColor = Color.LightSalmon;
            }
            else
            {
                comboBoxCountry.BackColor = Color.PaleGreen;
            }
        }
    }
}
