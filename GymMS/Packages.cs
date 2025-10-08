using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Reflection;
using System.Security.Cryptography;

namespace GymMS
{
    public partial class Packages : Form
    {
        public Packages()
        {
            InitializeComponent();
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            


            MySqlConnection con = new MySqlConnection();
            con.ConnectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=gymnasium";
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = con;

            try
            {
                string name = textBoxName.Text;
                Int64 fee = Int64.Parse(textBoxfee.Text);
                string goal = textBoxgoal.Text;

                cmd.CommandText = "INSERT INTO packages (PName,PGoal,PFee) VALUES ('" + name + "','" + goal + "','" + fee + "')";


                MySqlDataAdapter ad = new MySqlDataAdapter(cmd);

                DataSet ds = new DataSet();
                ad.Fill(ds);
            }
            catch (Exception)
            {
                MessageBox.Show("Entered data may not in the correct format");
            }

            finally
            {
                MessageBox.Show("Refresh to see the results");
            }
        }

        private void btnedit_Click(object sender, EventArgs e)
        {
            

            MySqlConnection con = new MySqlConnection();
            con.ConnectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=gymnasium";
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = con;

            try
            {

                string name = textBoxName.Text;
                Int64 fee = Int64.Parse(textBoxfee.Text);
                string goal = textBoxgoal.Text;

                cmd.CommandText = "Update packages set Pfee='" + fee + "' where PName = '" + name + "' ";
                MySqlDataAdapter ad = new MySqlDataAdapter(cmd);

                DataSet ds = new DataSet();
                ad.Fill(ds);
            }
            catch (Exception)
            {
                MessageBox.Show("Data may not in the correct format or entered name is not in the list");
            }
            finally
            {
                MessageBox.Show("Refresh to see the results");
            }

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection con = new MySqlConnection();
                con.ConnectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=gymnasium";
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = con;


                cmd.CommandText = "delete from packages where PID = " + textBoxdel.Text + " ";

                MySqlDataAdapter ad = new MySqlDataAdapter(cmd);

                DataSet ds = new DataSet();
                ad.Fill(ds);
            }
            catch (Exception)
            {
                MessageBox.Show("Id is not in the correct format or entered id is not in the list");
            }
            finally
            {
                MessageBox.Show("Refresh to see the results");
            }
        }

        private void btnrefresh_Click(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection();
            con.ConnectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=gymnasium";
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = con;

            cmd.CommandText = "SELECT * from packages";


            MySqlDataAdapter ad = new MySqlDataAdapter(cmd);

            DataSet ds = new DataSet();
            ad.Fill(ds);

            dataGridView1.DataSource = ds.Tables[0];
        }

        private void Packages_Load(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection();
            con.ConnectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=gymnasium";
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = con;

            cmd.CommandText = "SELECT * from packages";


            MySqlDataAdapter ad = new MySqlDataAdapter(cmd);

            DataSet ds = new DataSet();
            ad.Fill(ds);

            dataGridView1.DataSource = ds.Tables[0];
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            textBoxName.Clear();
            textBoxgoal.Clear();
            textBoxfee.Clear();
            textBoxdel.Clear();
            
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
            this.Close();
        }

        private void btnExit_Click(object sender, EventArgs e)
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
