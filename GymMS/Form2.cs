using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GymMS
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to exit?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();

            }
            else
            {
                MessageBox.Show("Welcome back", "Welcome", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("You are about to logout, Continue?", "Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
                Form1 f1 = new Form1();
                f1.Show();
            }
            else
            {
                MessageBox.Show("Welecome back", "Welcome", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            f3.Show();
        }

        private void membersbtn_Click(object sender, EventArgs e)
        {
            Members mm = new Members();
            mm.Show();
        }

        private void packagesbtn_Click(object sender, EventArgs e)
        {
            Packages pk = new Packages();
            pk.Show();
        }

        private void paymentsbtn_Click(object sender, EventArgs e)
        {
            Payments py = new Payments();
            py.Show();
        }
    }
}
