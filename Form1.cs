using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace LoginForm
{
    public partial class Form1 : Form
    {
        public static string user_name ="";

        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string cs = "data source =.; database = Sample; integrated security = SSPI";
            SqlConnection con = new SqlConnection(cs);

            SqlCommand com = new SqlCommand("select * from details1 where Username='" 
                + this.username.Text + "'and Password='" + this.password.Text + "';", con);
            SqlDataReader reader;
            con.Open();
            reader = com.ExecuteReader();
            int count = 0;
            while (reader.Read()){
                count = count + 1;
            }
            if(count == 1)
            {
                MessageBox.Show("Valid Credentials, Welcome!");
                user_name = username.Text;
                this.Hide();
                Form2 f2 = new Form2();
                f2.ShowDialog();
            }
            else 
            {
                MessageBox.Show("Invalid credentials");
                password.Clear();
            }
            con.Close();
        }
    }
}
