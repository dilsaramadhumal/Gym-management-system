using System.Diagnostics.Eventing.Reader;

namespace GymMS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text=="admin" && textBox2.Text=="1234")
            {
                Form2 f2 = new Form2();
                f2.Show();

            }
            else
            {
                MessageBox.Show("Incorrect username or Password. Please try again", "Try again", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
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
    }
}
