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

namespace GymMS
{
    public partial class Form3_1 : Form
    {
        public Form3_1()
        {
            InitializeComponent();
        }

        private void coachenterid_Click(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection();
            con.ConnectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=gymnasium";
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = con;

            //MySqlConnection = con;

            cmd.CommandText = "delete from coaches where CID = " + coachdeletetextBox1.Text + " ";

            MySqlDataAdapter ad = new MySqlDataAdapter(cmd);

            DataSet ds = new DataSet();
            ad.Fill(ds);

            this.Close();
        }
    }
}
