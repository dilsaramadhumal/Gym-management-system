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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace GymMS
{
    public partial class Members : Form
    {
        public Members()
        {
            InitializeComponent();
        }

        private void btnadd_Click(object sender, EventArgs e)
        {

            

            try
            {

                int id = int.Parse(textBoxID.Text);
                string name = textBoxName.Text;
                Int64 phone = Int64.Parse(textBoxPhone.Text);
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

                int cid = int.Parse(textBoxCoachid.Text);
                string pack = comboBox1.Text;


                MySqlConnection con = new MySqlConnection();
                con.ConnectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=gymnasium";
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = con;

                cmd.CommandText = "INSERT INTO members (MID,MName,MGender,MDOB,MPhone,MCoach,MPackage) VALUES ('" + id + "','" + name + "','" + gender + "','" + dob + "','" + phone + "','" + cid + "','" + pack + "')";


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
            
            

            try
            {

                string name = textBoxName.Text;
                Int64 phone = Int64.Parse(textBoxPhone.Text);
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

                int cid = int.Parse(textBoxCoachid.Text);
                string pack = comboBox1.Text;


                MySqlConnection con = new MySqlConnection();
                con.ConnectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=gymnasium";
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = con;

                int id = int.Parse(textBoxID.Text);
                cmd.CommandText = "Update members set MName='" + name + "', MGender = '" + gender + "',  MDOB = '" + dob + "',  MPhone = '" + phone + "',  MCoach = '" + cid + "',  MPackage = '" + pack + "' where MID= '" + id + "' ";


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

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection con = new MySqlConnection();
                con.ConnectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=gymnasium";
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = con;


                cmd.CommandText = "delete from members where MID = " + textBoxSearchdel.Text + " ";

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

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection();
            con.ConnectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=gymnasium";
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = con;

            try
            {
                int sid = int.Parse(textBoxSearchdel.Text);
                cmd.CommandText = "SELECT * from members where MID = '" + sid + "' ";


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

        private void btnReset_Click(object sender, EventArgs e)
        {
            textBoxID.Clear();
            textBoxName.Clear();
            textBoxPhone.Clear();
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            dateTimePicker1.Value = DateTime.Now;
            textBoxSearchdel.Clear();
            dataGridView2.Visible = false;
            comboBox1.ResetText();
            textBoxCoachid.Clear();

        }

        private void btnrefresh_Click(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection();
            con.ConnectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=gymnasium";
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = con;

            cmd.CommandText = "SELECT * from members";


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

        private void Members_Load(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection();
            con.ConnectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=gymnasium";
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = con;

            cmd.CommandText = "SELECT * from members";


            MySqlDataAdapter ad = new MySqlDataAdapter(cmd);

            DataSet ds = new DataSet();
            ad.Fill(ds);

            dataGridView1.DataSource = ds.Tables[0];
        }
    }
}
