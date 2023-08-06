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
    public partial class Form2 : Form
    {
        public static string names = "";
        public static string StudentID = "";

        SqlConnection con = new SqlConnection("Data Source=DESKTOP-OP623LH\\SQLEXPRESS;Initial Catalog=SManagementSystem;Integrated Security=True");
        public Form2()
        {
            InitializeComponent();
        }

        private void textSearch_TextChanged(object sender, EventArgs e)
        {
            con.Open();
            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand("SELECT StudInfo.StudentID, StudInfo.LastName, StudInfo.FirstName, StudInfo.MiddleName, SubDepartment.DegreeProgram, SubDepartment.DepartmentName FROM SubDepartment INNER JOIN StudInfo ON SubDepartment.StudentID = StudInfo.StudentID WHERE StudInfo.StudentID LIKE '"+textSearch.Text+"%' OR StudInfo.LastName LIKE '"+textSearch.Text+"%' OR StudInfo.FirstName LIKE '"+textSearch.Text+"%' OR StudInfo.MiddleName LIKE '"+textSearch.Text+"%' OR SubDepartment.DegreeProgram LIKE '"+textSearch.Text+"%' OR SubDepartment.DepartmentName LIKE '"+textSearch.Text+"%'", con);
            SqlDataReader dr;

            dr = cmd.ExecuteReader();
            if(dr.Read())
            {
                dr.Close();
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            else
            {
                dr.Close();
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dt);
                dataGridView1.DataSource = dt;
            }

            con.Close();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            con.Open();
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.ReadOnly = true;
            SqlCommand cmd = new SqlCommand("SELECT StudInfo.StudentID, StudInfo.LastName, StudInfo.FirstName, StudInfo.MiddleName, SubDepartment.DegreeProgram, SubDepartment.DepartmentName FROM SubDepartment INNER JOIN StudInfo ON SubDepartment.StudentID = StudInfo.StudentID", con);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }

       
        private void dELETEToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void de(object sender, EventArgs e)
        {
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
         
        }

        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            StudentID = !string.IsNullOrEmpty(dataGridView1.CurrentRow.Cells[0].Value.ToString()) ? dataGridView1.CurrentRow.Cells[0].Value.ToString() : " ";

            Close();
            Form4 f4 = new Form4();
            f4.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            f3.Show();
            Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            DialogResult dialogresult = MessageBox.Show("DELETE SELECTED DATA?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (dialogresult == DialogResult.Yes)
            {
                con.Open();

                names = !string.IsNullOrEmpty(dataGridView1.CurrentRow.Cells[0].Value.ToString()) ? dataGridView1.CurrentRow.Cells[0].Value.ToString() : " ";

                SqlCommand cmd1 = new SqlCommand("DELETE FROM StudInfo WHERE StudentID ='" + names + "'", con);
                cmd1.ExecuteNonQuery();
                SqlCommand cmd2 = new SqlCommand("DELETE FROM Parent WHERE StudentID = '" + names + "'", con);
                cmd2.ExecuteNonQuery();
                SqlCommand cmd3 = new SqlCommand("DELETE FROM SubDepartment WHERE StudentID = '" + names + "'", con);
                cmd3.ExecuteNonQuery();
                SqlCommand cmd4 = new SqlCommand("DELETE FROM Grades WHERE StudentID = '" + names + "'", con);
                cmd4.ExecuteNonQuery();

                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter();
                SqlCommand cmde = new SqlCommand("SELECT StudInfo.StudentID, StudInfo.LastName, StudInfo.FirstName, StudInfo.MiddleName, SubDepartment.DegreeProgram, SubDepartment.DepartmentName FROM SubDepartment INNER JOIN StudInfo ON SubDepartment.StudentID = StudInfo.StudentID", con);
                da = new SqlDataAdapter(cmde);
                da.Fill(dt);
                dataGridView1.DataSource = dt; //REFRESH DATA. 

                con.Close();
            }
            else if(dialogresult == DialogResult.No)
            {
                   //Do nothing and go back to main page.
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            DialogResult dialogresult = MessageBox.Show("ARE YOU SURE YOU WANT TO LOGOUT?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (dialogresult == DialogResult.Yes)
            { 
                Form1 f1 = new Form1();
                f1.Show();
                Close();
            } 
        }
    }
}
