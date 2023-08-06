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

namespace Student_Management_System
{
    public partial class Form1 : Form
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-OP623LH\\SQLEXPRESS;Initial Catalog=StudentSystem;Integrated Security=True");
        public static string username = "";

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ControlBox = false;
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM Login WHERE Username='" + textUser.Text + "' AND Password='" + textPass.Text + "'", con);
            SqlDataReader dr;
            dr = cmd.ExecuteReader();

            if(dr.Read())
            {
                Hide();
                Form2 f2 = new Form2();
                f2.Show();
                username = dr[0].ToString();
            }
            else
            {
                MessageBox.Show("Unable to login!", "ERROR!");
            }
            con.Close();
        }
    }
}
