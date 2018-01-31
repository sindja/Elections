using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IzboriApp
{
    public partial class Pocetna : Form
    {
        public Pocetna()
        {
            InitializeComponent();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
           if (txtBoxUsername.Text == "izbori" && txtBoxPassword.Text == "izbori")
            {
                this.Hide();
                Glavna f = new Glavna(this);
                f.Show();
           }
            else
            {
                txtBoxUsername.Text = "";
                txtBoxPassword.Text = "";
                MessageBox.Show("Greška pri unosu, pokušajte ponovo.");
            }
        }

        private void txtBoxUsername_Click(object sender, EventArgs e)
        {
            txtBoxUsername.Text = "";
        }

        private void txtBoxPassword_Click(object sender, EventArgs e)
        {
            txtBoxPassword.Text = "";
        }

        private void txtBoxPassword_TextChanged(object sender, EventArgs e)
        {
            txtBoxPassword.UseSystemPasswordChar = true;
        }

    }
}
