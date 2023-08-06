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
        public static string FirstName = "";
        public static string MiddleName = "";
        public static string LastName = "";
        public static string Sex = "";
        public static string BirthMonth = "";
        public static string BirthDay = "";
        public static string BirthYear = "";
        public static string Province = "";
        public static string City = "";
        public static string Barangay = "";
        public static string Citizenship = "";
        public static string Religion = "";
        public static string Contact = "";
        public static string Email = "";
        public static string SchoolName = "";
        public static string DegreeProgram = "";
        public static string DepartmentName = "";
        public static string YearLevel = "";
        public static string MotherFirst = "";
        public static string MotherMiddle = "";
        public static string MotherLast = "";
        public static string MotherCitizenship = "";
        public static string MotherReligion = "";
        public static string MotherOccupation = "";
        public static string MotherContact = "";
        public static string FatherFirst = "";
        public static string FatherMiddle = "";
        public static string FatherLast = "";
        public static string FatherCitizenship = "";
        public static string FatherReligion = "";
        public static string FatherOccupation = "";
        public static string FatherContact = "";
        public static string GuardianFirst = "";
        public static string GuardianMiddle = "";
        public static string GuardianLast = "";
        public static string GuardianCitizenship = "";
        public static string GuardianReligion = "";
        public static string GuardianOccupation = "";
        public static string GuardianContact = "";




        SqlConnection con = new SqlConnection("Data Source=DESKTOP-OP623LH\\SQLEXPRESS;Initial Catalog=StudentSystem;Integrated Security=True");
        public Form2()
        {
            InitializeComponent();
        }

        private void textSearch_TextChanged(object sender, EventArgs e)
        {
            con.Open();
            
            DataTable dt = new DataTable();

            using(SqlCommand cmd = new SqlCommand("SElECT LastName, FirstName, MiddleName, DegreeProgram, DepartmentName FROM StudentInformation WHERE FirstName LIKE '" + textSearch.Text + "%' OR LastName LIKE '"+textSearch.Text+"%' OR MiddleName LIKE '"+textSearch.Text+"%'", con))
            {
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
            }
            con.Close();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            comboMenu.Text = "MENU";
            ControlBox = false;
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT LastName, FirstName, MiddleName, DegreeProgram, DepartmentName FROM StudentInformation", con);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void comboMenu_SelectedIndexChanged(object sender, EventArgs e)
        {
            int choice = 0;
            choice = comboMenu.SelectedIndex;

            if(choice == 0)
            {
                Form3 f3 = new Form3();
                f3.Show();
                Close();
            }
            else if(choice == 1)
            {
                Form1 f1 = new Form1();
                f1.Show();
                Close();
            }

        }

        private void dELETEToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void de(object sender, EventArgs e)
        {
            con.Open();

            names = !string.IsNullOrEmpty(dataGridView1.CurrentRow.Cells[0].Value.ToString()) ? dataGridView1.CurrentRow.Cells[0].Value.ToString() : " ";
            string names2 = !string.IsNullOrEmpty(dataGridView1.CurrentRow.Cells[1].Value.ToString()) ? dataGridView1.CurrentRow.Cells[1].Value.ToString() : " ";
            string names3 = !string.IsNullOrEmpty(dataGridView1.CurrentRow.Cells[2].Value.ToString()) ? dataGridView1.CurrentRow.Cells[2].Value.ToString() : " ";

            SqlCommand cmd = new SqlCommand("DELETE FROM StudentInformation WHERE Lastname='" + names + "' AND FirstName='"+ names2 +"' AND MiddleName='"+ names3 +"'", con);
            
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter();
            int result = cmd.ExecuteNonQuery();

            if(result > 0)
            {
                MessageBox.Show("SUCCESS!");
                SqlCommand cmde = new SqlCommand("SELECT LastName, FirstName, MiddleName, DegreeProgram, DepartmentName FROM StudentInformation", con);
                da = new SqlDataAdapter(cmde);
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            else
            {
                MessageBox.Show("UNABLE TO FULFILL YOUR REQUEST!");
                SqlCommand cmde = new SqlCommand("SELECT LastName, FirstName, MiddleName, DegreeProgram, DepartmentName FROM StudentInformation", con);
                da = new SqlDataAdapter(cmde);
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }

            con.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
         
        }

        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            con.Open();
            names = !string.IsNullOrEmpty(dataGridView1.CurrentRow.Cells[0].Value.ToString()) ? dataGridView1.CurrentRow.Cells[0].Value.ToString() : " ";
            string names2 = !string.IsNullOrEmpty(dataGridView1.CurrentRow.Cells[1].Value.ToString()) ? dataGridView1.CurrentRow.Cells[1].Value.ToString() : " ";
            string names3 = !string.IsNullOrEmpty(dataGridView1.CurrentRow.Cells[2].Value.ToString()) ? dataGridView1.CurrentRow.Cells[2].Value.ToString() : " ";

            SqlDataReader dr;
            SqlCommand cmd = new SqlCommand("SELECT * FROM StudentInformation WHERE LastName='" + names + "' AND FirstName='" + names2 + "' AND MiddleName='" + names3 + "'", con);
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                FirstName = dr.GetValue(1).ToString();
                MiddleName = dr.GetValue(2).ToString();
                LastName = dr.GetValue(3).ToString();
                Sex = dr.GetValue(4).ToString();
                BirthMonth = dr.GetValue(5).ToString();
                BirthDay = dr.GetValue(6).ToString();
                BirthYear = dr.GetValue(7).ToString();
                Province = dr.GetValue(8).ToString();
                City = dr.GetValue(9).ToString();
                Barangay = dr.GetValue(10).ToString();
                Citizenship = dr.GetValue(11).ToString();
                Religion = dr.GetValue(12).ToString();
                Contact = dr.GetValue(13).ToString();
                Email = dr.GetValue(14).ToString();
                SchoolName = dr.GetValue(15).ToString();
                DegreeProgram = dr.GetValue(16).ToString();
                DepartmentName = dr.GetValue(17).ToString();
                YearLevel = dr.GetValue(18).ToString();
                MotherFirst = dr.GetValue(19).ToString();
                MotherMiddle = dr.GetValue(20).ToString();
                MotherLast = dr.GetValue(21).ToString();
                MotherCitizenship = dr.GetValue(22).ToString();
                MotherReligion = dr.GetValue(23).ToString();
                MotherOccupation = dr.GetValue(24).ToString();
                MotherContact = dr.GetValue(25).ToString();
                FatherFirst = dr.GetValue(26).ToString();
                FatherMiddle = dr.GetValue(27).ToString(); ;
                FatherLast = dr.GetValue(28).ToString();
                FatherCitizenship = dr.GetValue(29).ToString();
                FatherReligion = dr.GetValue(30).ToString();
                FatherOccupation = dr.GetValue(31).ToString();
                FatherContact = dr.GetValue(32).ToString(); ;
                GuardianFirst = dr.GetValue(33).ToString();
                GuardianMiddle = dr.GetValue(34).ToString();
                GuardianLast = dr.GetValue(35).ToString();
                GuardianCitizenship = dr.GetValue(36).ToString();
                GuardianReligion = dr.GetValue(37).ToString();
                GuardianOccupation = dr.GetValue(38).ToString();
                GuardianContact = dr.GetValue(39).ToString();
            }
            dr.Close();
            con.Close();

            Close();
            Form4 f4 = new Form4();
            f4.Show();
        }

    }
}
