using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace LoginForm
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            textBox2.Text = Form1.user_name;
            GetStudentRecord();
        }

        private void GetStudentRecord()
        {
            string cs = "data source =.; database = Sample; integrated security = SSPI";
            SqlConnection con = new SqlConnection(cs);
            SqlCommand cmd = new SqlCommand("select Username,Login_name,Employment_type," +
                "Department,User_active,Role,Modify_by,created_on from details1", con);
            DataTable dt = new DataTable();
            con.Open();
            SqlDataReader rdr = cmd.ExecuteReader();
            dt.Load(rdr);
            con.Close();
            details.DataSource = dt;
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void label6_Click(object sender, EventArgs e)
        {

        }
        private void button2_Click(object sender, EventArgs e)
        {
            string cs = "data source =.; database = Sample; integrated security = SSPI";
            SqlConnection con = new SqlConnection(cs);
            string username = textBox2.Text;
            con.Open();
            SqlCommand c = new SqlCommand("exec deletedata1 '" + username + "'", con);
            c.ExecuteNonQuery();
            GetStudentRecord();
            textBox2.Clear();
            con.Close();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string cs = "data source =.; database = Sample; integrated security = SSPI";
            SqlConnection con = new SqlConnection(cs);
            string username = textBox2.Text, login_name = textBox3.Text,
                password = textBox1.Text, employment_type = comboBox2.Text,
                department = textBox4.Text, role = comboBox1.Text,
                  useractive = "";
            if (checkbox1.Checked == true) { useractive = "Y"; }
            else { useractive = "N"; }
            con.Open();
            SqlCommand c = new SqlCommand("exec insertdata1 '" + username + "','" + login_name + "','" + password + "'," +
                "" + "'" + employment_type + "','" + department + "'," +
                "'" + useractive + "','" + role + "','" + null + "'," +
                "'" + DateTime.Now.ToString("MMMM dd yyyy HH:mm:ss") + "'", con);
            c.ExecuteNonQuery();
            GetStudentRecord();
            textBox1.Clear(); textBox3.Clear(); textBox4.Clear(); textBox2.Clear();
            checkbox1.Checked = false; comboBox1.Text = " "; comboBox2.Text = " ";
            con.Close();
        }
        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == (Keys.Escape))
            {
                Close();
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }
        private void password_Click(object sender, EventArgs e)
        {

        }
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void useractive_CheckedChanged(object sender, EventArgs e)
        {

        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int ind = e.RowIndex;
            DataGridViewRow selectedRows = details.Rows[ind];
            textBox2.Text = selectedRows.Cells[0].Value.ToString();
            textBox3.Text = selectedRows.Cells[1].Value.ToString();
            comboBox2.Text = selectedRows.Cells[2].Value.ToString();
            textBox4.Text = selectedRows.Cells[3].Value.ToString();
            comboBox1.Text = selectedRows.Cells[5].Value.ToString();
            checkbox1.Text = selectedRows.Cells[4].Value.ToString();
           // textBox1.ReadOnly = true;

        }          
    private void searchbtn_Click(object sender, EventArgs e)
        {
            string cs = "data source =.; database = Sample; integrated security = SSPI";
            SqlConnection con = new SqlConnection(cs);
            string username = textBox5.Text;
            SqlCommand c = new SqlCommand("exec loaddetails1 '" + username + "'", con);
            DataTable dt = new DataTable();
            con.Open();
            SqlDataReader rdr = c.ExecuteReader();
            dt.Load(rdr);
            textBox5.Clear();
            con.Close();
            details.DataSource = dt;
        }
        private void update_Click(object sender, EventArgs e)
        {
            string cs = "data source =.; database = Sample; integrated security = SSPI";
            SqlConnection con = new SqlConnection(cs);
            string username = textBox2.Text, login_name = textBox3.Text,
                 employment_type = comboBox2.Text,
                department = textBox4.Text, role = comboBox1.Text,
                  useractive = "";
            
            if (checkbox1.Checked == true) { useractive = "Y"; }
            else { useractive = "N"; }
            con.Open();
            SqlCommand c = new SqlCommand("exec updatedata1 '" + username + "'," +
                "'" + login_name + "'," + "'" + employment_type + "','" + department + "'," +
                "'" + useractive + "','" + role + "','" + Form1.user_name + "'", con);
            c.ExecuteNonQuery();
            GetStudentRecord();
            
            textBox2.Clear(); textBox3.Clear(); textBox4.Clear();
            checkbox1.Checked = false; comboBox1.Text = " "; comboBox2.Text = " ";
            
            con.Close();
        }
        private void changepass_Click(object sender, EventArgs e)
        {
            string cs = "data source =.; database = Sample; integrated security = SSPI";
            SqlConnection con = new SqlConnection(cs);
            string username = textBox2.Text,
                password = textBox1.Text;
            con.Open();
            SqlCommand c = new SqlCommand("exec changepass1 '" + password + "','" + username + "'", con);
            c.ExecuteNonQuery();
            GetStudentRecord();
            textBox1.Clear(); textBox2.Clear();
            con.Close();
        }
        private void button1_Click_2(object sender, EventArgs e)
        {
            GetStudentRecord(); 
        }
        private void button2_Click_1(object sender, EventArgs e)
        {
            textBox1.Clear(); textBox2.Clear(); textBox3.Clear(); textBox4.Clear();
            textBox5.Clear(); checkbox1.Checked = false; comboBox1.Text = " "; 
            comboBox2.Text = " ";
            Form1.user_name = username.Text;
        }
    }
}
