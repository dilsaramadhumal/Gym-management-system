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
using System.Xml.Linq;

namespace GymMS
{
    public partial class Payments : Form
    {
        public Payments()
        {
            InitializeComponent();
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            

            try
            {

                int id = int.Parse(textBoxid.Text);
                string name = textBoxname.Text;
                Int64 fee = Int64.Parse(textBoxpay.Text);
                string date = dateTimePicker1.Text;


                MySqlConnection con = new MySqlConnection();
                con.ConnectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=gymnasium";
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = con;

                cmd.CommandText = "INSERT INTO payments (FID,FName,Start_Date,Payments) VALUES ('" + id + "','" + name + "','" + date + "','" + fee + "')";


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

                int id = int.Parse(textBoxid.Text);
                string name = textBoxname.Text;
                Int64 fee = Int64.Parse(textBoxpay.Text);
                string date = dateTimePicker1.Text;

                cmd.CommandText = "Update payments set FName = '" + name + "', Start_Date='" + date + "', Payments = '" + fee + "' where FID = '" + id + "' ";
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


                cmd.CommandText = "delete from payments where FID = " + textBoxdel.Text + " ";

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

        private void btnSearch_Click(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection();
            con.ConnectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=gymnasium";
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = con;

            try
            {
                int sid = int.Parse(textBoxdel.Text);
                cmd.CommandText = "SELECT * from payments where FID = '" + sid + "' ";


                MySqlDataAdapter ad = new MySqlDataAdapter(cmd);

                DataSet ds = new DataSet();
                ad.Fill(ds);

                dataGridView2.DataSource = ds.Tables[0];
                dataGridView2.Visible = true;
            }

            catch (Exception)
            {
                MessageBox.Show("Please enter a valid ID number");
                dataGridView2.Visible = false;
            }
        }

        private void btnrefresh_Click(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection();
            con.ConnectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=gymnasium";
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = con;

            cmd.CommandText = "SELECT * from payments";


            MySqlDataAdapter ad = new MySqlDataAdapter(cmd);

            DataSet ds = new DataSet();
            ad.Fill(ds);

            dataGridView1.DataSource = ds.Tables[0];
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            textBoxid.Clear();
            textBoxname.Clear();
            textBoxpay.Clear();
            textBoxdel.Clear();
            dateTimePicker1.Value = DateTime.Now;
            dataGridView2.Visible = false;
        }

        private void Payments_Load(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection();
            con.ConnectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=gymnasium";
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = con;

            cmd.CommandText = "SELECT * from payments";


            MySqlDataAdapter ad = new MySqlDataAdapter(cmd);

            DataSet ds = new DataSet();
            ad.Fill(ds);

            dataGridView1.DataSource = ds.Tables[0];
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
