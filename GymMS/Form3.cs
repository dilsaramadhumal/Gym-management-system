using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Relational;
using System.Xml.Linq;
using System.Linq.Expressions;

namespace GymMS
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            

            try
            {

                int id = int.Parse(IDtextBox1.Text);
                string name = textBox2.Text;
                Int64 phone = Int64.Parse(textBox3.Text);
                string dob = dateTimePicker1.Text;
                string gender = "";
                bool ischecked = radioButton1.Checked;

                if (ischecked)
                {
                    gender = radioButton1.Text;
                }
                else
                {
                    gender = radioButton2.Text;
                }


                MySqlConnection con = new MySqlConnection();
                con.ConnectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=gymnasium";
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = con;
                con.Open();

                cmd.CommandText = "INSERT INTO coaches (CID,CName,CGender,CDOB,CPhone) VALUES ('" + id + "','" + name + "','" + gender + "','" + dob + "','" + phone + "')";


                MySqlDataAdapter ad = new MySqlDataAdapter(cmd);

                DataSet ds = new DataSet();
                ad.Fill(ds);
            }
            catch (Exception)
            {
                MessageBox.Show("Entered data may not in the correct format.");
            }
            finally
            {
                MessageBox.Show("Refresh to see the results");
            }

        }

        private void button3_Click(object sender, EventArgs e)
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

        private void Form3_Load(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection();
            con.ConnectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=gymnasium";
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = con;

            cmd.CommandText = "SELECT * from coaches";


            MySqlDataAdapter ad = new MySqlDataAdapter(cmd);

            DataSet ds = new DataSet();
            ad.Fill(ds);

            dataGridView1.DataSource = ds.Tables[0];
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
            this.Close();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            IDtextBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            dateTimePicker1.Value = DateTime.Now;
            searchtextBox1.Clear();
            dataGridView2.Visible = false;
        }

        private void refresh_Click(object sender, EventArgs e)
        {

            MySqlConnection con = new MySqlConnection();
            con.ConnectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=gymnasium";
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = con;

            cmd.CommandText = "SELECT * from coaches";


            MySqlDataAdapter ad = new MySqlDataAdapter(cmd);

            DataSet ds = new DataSet();
            ad.Fill(ds);

            dataGridView1.DataSource = ds.Tables[0];

        }

        private void deletebtn_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection con = new MySqlConnection();
                con.ConnectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=gymnasium";
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = con;


                cmd.CommandText = "delete from coaches where CID = " + searchtextBox1.Text + " ";

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

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void editbtn_Click(object sender, EventArgs e)
        {

            try
            {

                int id = int.Parse(IDtextBox1.Text);
                string name = textBox2.Text;
                Int64 phone = Int64.Parse(textBox3.Text);
                string dob = dateTimePicker1.Text;
                string gender = "";
                bool ischecked = radioButton1.Checked;

                if (ischecked)
                {
                    gender = radioButton1.Text;
                }
                else
                {
                    gender = radioButton2.Text;
                }


                MySqlConnection con = new MySqlConnection();
                con.ConnectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=gymnasium";
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = con;

                cmd.CommandText = "Update coaches set CName='" + name + "', CGender = '" + gender + "',  CDOB = '" + dob + "',  CPhone = '" + phone + "' where CID= '" + IDtextBox1.Text + "' ";


                MySqlDataAdapter ad = new MySqlDataAdapter(cmd);

                DataSet ds = new DataSet();
                ad.Fill(ds);
            }
            catch (Exception)
            {
                MessageBox.Show("Data may not in the correct format or entered id is not in the list");
            }
            finally
            {
                MessageBox.Show("Refresh to see the results");
            }
        }

        private void searchbutton1_Click(object sender, EventArgs e)
        {
            
            MySqlConnection con = new MySqlConnection();
            con.ConnectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=gymnasium";
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = con;

            try
            {
                int sid = int.Parse(searchtextBox1.Text);
                cmd.CommandText = "SELECT * from coaches where CID = '" + sid + "' ";


                MySqlDataAdapter ad = new MySqlDataAdapter(cmd);

                DataSet ds = new DataSet();
                ad.Fill(ds);

                dataGridView2.DataSource = ds.Tables[0];
                dataGridView2.Visible = true;
            }

            catch(Exception)
            {
                MessageBox.Show("Please enter a valid ID number");
                dataGridView2.Visible = false;
            }

                     
        }
    }
}
