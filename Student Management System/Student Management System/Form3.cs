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
    public partial class Form3 : Form
    {
        const int SIZE = 500;

        public static int totalUnit = 0;
        public static int totalUnit1 = 0;
        public static int[] unit = new int[SIZE];
        public static string[] grade = new string[SIZE];
        public static double GWA;
        public static string[] result = new string[SIZE];
        public static double totalResult;
        public static double totalResult1;
        public static int studentID = 0;
        public static int departmentID = 0;
        public static string[] instructor = new string[SIZE];

        public static string SubjectID = "";
        public static string name = "";
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-OP623LH\\SQLEXPRESS;Initial Catalog=SManagementSystem;Integrated Security=True");
        public Form3()
        {
            InitializeComponent();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dBLOGINDataSet.Grades' table. You can move, or remove it, as needed.
            //this.gradesTableAdapter.Fill(this.dBLOGINDataSet.Grades);
            ControlBox = false;
            button1.Enabled = false;
            textTotalUnit.Enabled = false;
            textGWA.Enabled = false;
            textAssessment1.Enabled = false;
            textSchoolName.Enabled = false;       
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxMother.Checked)
            {
                textMotherFirst.Clear();
                textMotherMiddle.Clear();
                textMotherLast.Clear();
                textMotherCitizenship.Clear();
                textMotherReligion.Clear();
                textMotherOccupation.Clear();
                textMotherContactNumber.Clear();

                textMotherFirst.Enabled = false;
                textMotherMiddle.Enabled = false;
                textMotherLast.Enabled = false;
                textMotherCitizenship.Enabled = false;
                textMotherReligion.Enabled = false;
                textMotherOccupation.Enabled = false;
                textMotherContactNumber.Enabled = false;
            }
            else
            {
                textMotherFirst.Enabled = true;
                textMotherMiddle.Enabled = true;
                textMotherLast.Enabled = true;
                textMotherCitizenship.Enabled = true;
                textMotherReligion.Enabled = true;
                textMotherOccupation.Enabled = true;
                textMotherContactNumber.Enabled = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textFirst.Text = "";
            textMiddle.Text = "";
            textLast.Text = "";
            comboSex.Text = "";
            textProvince.Text = "";
            textCity.Text = "";
            textBarangay.Text = "";
            textCitizenship.Text = "";
            textReligion.Text = "";
            textContactNumber.Text = "";
            textEmail.Text = "";
            textSchoolName.Text = "";
            textDegree.Text = "";
            textDepartment.Text = "";
            textYearLevel.Text = "";
            textMotherFirst.Text = "";
            textMotherMiddle.Text = "";
            textMotherLast.Text = "";
            textMotherCitizenship.Text = "";
            textMotherReligion.Text = "";
            textMotherOccupation.Text = "";
            textMotherContactNumber.Text = "";
            textFatherFirst.Text = "";
            textFatherMiddle.Text = "";
            textFatherLast.Text = "";
            textFatherCitizenship.Text = "";
            textFatherReligion.Text = "";
            textFatherOccupation.Text = "";
            textFatherContactNumber.Text = "";
            textGuardianFirst.Text = "";
            textGuardianMiddle.Text = "";
            textGuardianLast.Text = "";
            textGuardianCitizenship.Text = "";
            textGuardianReligion.Text = "";
            textGuardianOccupation.Text = "";
            textGuardianContactNumber.Text = "";
        }

        private void checkBoxFather_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxFather.Checked)
            {
                textFatherFirst.Clear();
                textFatherMiddle.Clear();
                textFatherLast.Clear();
                textFatherCitizenship.Clear();
                textFatherReligion.Clear();
                textFatherOccupation.Clear();
                textFatherContactNumber.Clear();

                textFatherFirst.Enabled = false;
                textFatherMiddle.Enabled = false;
                textFatherLast.Enabled = false;
                textFatherCitizenship.Enabled = false;
                textFatherReligion.Enabled = false;
                textFatherOccupation.Enabled = false;
                textFatherContactNumber.Enabled = false;
            }
            else
            {
                textFatherFirst.Enabled = true;
                textFatherMiddle.Enabled = true;
                textFatherLast.Enabled = true;
                textFatherCitizenship.Enabled = true;
                textFatherReligion.Enabled = true;
                textFatherOccupation.Enabled = true;
                textFatherContactNumber.Enabled = true;
            }
        }

        private void checkBoxGuardian_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxGuardian.Checked)
            {
                textGuardianFirst.Clear();
                textGuardianMiddle.Clear();
                textGuardianLast.Clear();
                textGuardianCitizenship.Clear();
                textGuardianReligion.Clear();
                textGuardianOccupation.Clear();
                textGuardianContactNumber.Clear();

                textGuardianFirst.Enabled = false;
                textGuardianMiddle.Enabled = false;
                textGuardianLast.Enabled = false;
                textGuardianCitizenship.Enabled = false;
                textGuardianReligion.Enabled = false;
                textGuardianOccupation.Enabled = false;
                textGuardianContactNumber.Enabled = false;
            }
            else
            {
                textGuardianFirst.Enabled = true;
                textGuardianMiddle.Enabled = true;
                textGuardianLast.Enabled = true;
                textGuardianCitizenship.Enabled = true;
                textGuardianReligion.Enabled = true;
                textGuardianOccupation.Enabled = true;
                textGuardianContactNumber.Enabled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();

            SqlCommand cmd1 = new SqlCommand("INSERT INTO StudInfo (FirstName, MiddleName, LastName, Sex, AddProvince, AddCity, AddBarangay, Citizenship, Religion, Contact, Email, Birthdate) VALUES ('" + textFirst.Text + "', '" + textMiddle.Text + "', '" + textLast.Text + "', '" + comboSex.Text + "', '" + textProvince.Text + "', '" + textCity.Text + "', '" + textBarangay.Text + "', '" + textCitizenship.Text + "', '" + textReligion.Text + "', '" + textContactNumber.Text + "', '" + textEmail.Text + "', '" + dateTimePicker1.Text + "')", con);
            cmd1.ExecuteNonQuery();
            SqlCommand cmd1id = new SqlCommand("SELECT MAX(StudentID) FROM StudInfo", con);
            SqlDataReader dr;
            dr = cmd1id.ExecuteReader();
            if (dr.Read())
            {
                name = dr.GetValue(0).ToString();
            }
            dr.Close();


            SqlCommand cmd2 = new SqlCommand("INSERT INTO Parent (MotherFirst, MotherMiddle, MotherLast, MotherCitizenship, MotherReligion, MotherOccupation, MotherContact, FatherFirst, FatherMiddle, FatherLast, FatherCitizenship, FatherReligion, FatherOccupation, FatherContact, GuardianFirst, GuardianMiddle, GuardianLast, GuardianCitizenship, GuardianReligion, GuardianOccupation, GuardianContact, StudentID) VALUES ('" + textMotherFirst.Text + "', '" + textMotherMiddle.Text + "', '" + textMotherLast.Text + "', '" + textMotherCitizenship.Text + "', '" + textMotherReligion.Text + "', '" + textMotherOccupation.Text + "', '" + textMotherContactNumber.Text + "', '" + textFatherFirst.Text + "', '" + textFatherMiddle.Text + "', '" + textFatherLast.Text + "', '" + textFatherCitizenship.Text + "', '" + textFatherReligion.Text + "', '" + textFatherOccupation.Text + "', '" + textFatherContactNumber.Text + "', '" + textGuardianFirst.Text + "', '" + textGuardianMiddle.Text + "', '" + textGuardianLast.Text + "', '" + textGuardianCitizenship.Text + "', '" + textGuardianReligion.Text + "', '" + textGuardianOccupation.Text + "', '" + textGuardianContactNumber.Text + "', '" + name + "')", con);
            cmd2.ExecuteNonQuery();
            SqlCommand cmd3 = new SqlCommand("INSERT INTO SubDepartment (SchoolYear, SchoolName, DepartmentName, YearLevel, DegreeProgram, Semester, StudentID, section) VALUES ('" + textSchoolYear.Text + "', '" + textSchoolName.Text + "', '" + textDepartment.Text + "', '" + textYearLevel.Text + "', '" + textDegree.Text + "', '" + textSemester.Text + "', '" + name + "', '" + textSection.Text + "')", con);
            cmd3.ExecuteNonQuery();

            for (int i = 0; i < dataGridView0.Rows.Count - 1; i++)
            {
                    SqlCommand cmd4 = new SqlCommand("INSERT INTO Grades (TotalUnit, GWA, Remarks, StudentID) VALUES ('" + textTotalUnit.Text + "', '" + textGWA.Text + "', '" + textAssessment1.Text + "', '" + name + "')", con);
                    cmd4.ExecuteNonQuery();
                    SqlCommand cmd5 = new SqlCommand("SELECT MAX(SubjectID) FROM Grades WHERE StudentID = '" + name + "'", con);
                    dr = cmd5.ExecuteReader();

                    if (dr.Read())
                    {
                         SubjectID = dr.GetValue(0).ToString();
                    }
                    dr.Close();
                    
                    SqlCommand cmd6 = new SqlCommand("UPDATE Grades SET Subject = @Subject, Unit = @Unit, Instructor = @Instructor, Grade = @Grade WHERE SubjectID = '" + SubjectID + "'", con);
                    cmd6.Parameters.AddWithValue("@Subject", Convert.ToString(dataGridView0.Rows[i].Cells[0].Value));
                    cmd6.Parameters.AddWithValue("@Unit", Convert.ToString(dataGridView0.Rows[i].Cells[1].Value));
                    cmd6.Parameters.AddWithValue("@Instructor", Convert.ToString(dataGridView0.Rows[i].Cells[2].Value));
                    cmd6.Parameters.AddWithValue("@Grade", Convert.ToString(dataGridView0.Rows[i].Cells[3].Value));
                    cmd6.ExecuteNonQuery();
            }

            MessageBox.Show("SUCCESSFULLY CREATED THE DATA!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Form2 f2 = new Form2();
            f2.Show();
            Close();

            con.Close(); 
        }

        private void textFirst_TextChanged(object sender, EventArgs e)
        {
            if (textFirst.Text != "")
            {
                if (textLast.Text != "")
                {
                    button3.Hide();
                    button2.Show();
                    button1.Enabled = true;
                }
            }
            else
            {
                button3.Show();
                button2.Hide();
                button1.Enabled = false;
            }
        }

        private void textLast_TextChanged(object sender, EventArgs e)
        {
            if (textFirst.Text != "")
            {
                if (textLast.Text != "")
                {
                    button3.Hide();
                    button2.Show();
                    button1.Enabled = true;
                }
                else
                {
                    button3.Show();
                    button2.Hide();
                    button1.Enabled = false;
                }
            }
            else
            {
                button1.Enabled = false;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
            Form2 f2 = new Form2();
            f2.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textMotherFirst_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            textFirst.Text = "";
            textMiddle.Text = "";
            textLast.Text = "";
            comboSex.Text = "";
            textProvince.Text = "";
            textCity.Text = "";
            textBarangay.Text = "";
            textCitizenship.Text = "";
            textReligion.Text = "";
            textContactNumber.Text = "";
            textEmail.Text = "";
            textSchoolName.Text = "";
            textDegree.Text = "";
            textDepartment.Text = "";
            textYearLevel.Text = "";
            textMotherFirst.Text = "";
            textMotherMiddle.Text = "";
            textMotherLast.Text = "";
            textMotherCitizenship.Text = "";
            textMotherReligion.Text = "";
            textMotherOccupation.Text = "";
            textMotherContactNumber.Text = "";
            textFatherFirst.Text = "";
            textFatherMiddle.Text = "";
            textFatherLast.Text = "";
            textFatherCitizenship.Text = "";
            textFatherReligion.Text = "";
            textFatherOccupation.Text = "";
            textFatherContactNumber.Text = "";
            textGuardianFirst.Text = "";
            textGuardianMiddle.Text = "";
            textGuardianLast.Text = "";
            textGuardianCitizenship.Text = "";
            textGuardianReligion.Text = "";
            textGuardianOccupation.Text = "";
            textGuardianContactNumber.Text = "";

        }

        private void textDepartment_SelectedIndexChanged(object sender, EventArgs e)
        {
            int result = textDepartment.SelectedIndex;
            textDegree.Items.Clear();

            if (result == 0)
            {
                textDegree.Items.Add("Bachelor of Science in Information Technology");
            }
            else if (result == 1)
            {
                textDegree.Items.Add("Bachelor of Elementary Education");
                textDegree.Items.Add("Bachelor of Secondary Education Major in English");
                textDegree.Items.Add("Bachelor of Secondary Education Major in Mathematics");
                textDegree.Items.Add("Bachelor of Secondary Education Major in Science");
                textDegree.Items.Add("Bachelor of Secondary Education Major in Social Studies");

            }
            else if (result == 2)
            {
                textDegree.Items.Add("Bachelor of Science in Criminology");
            }
            else if (result == 3)
            {
                textDegree.Items.Add("Bachelor of Science in Accountancy");
                textDegree.Items.Add("Bachelor of Science in Accounting Technology");
                textDegree.Items.Add("Bachelor of Science in Business Administration Major in Financial Management");
                textDegree.Items.Add("Bachelor of Science in Hospitality Management");
                textDegree.Items.Add("Bachelor of Science in Hospitality Management Major in Food and Beverage");
                textDegree.Items.Add("Bachelor of Science in Tourism Management");
            }
            else if (result == 4)
            {
                textDegree.Items.Add("Bachelor of Science in Psychology");
            }
            else if (result == 5)
            {
                textDegree.Items.Add("Master of Arts in Education major in Education Management");
                textDegree.Items.Add("Master of Arts in Education major in Education Major in Mathematics");
            }
        }

        private void comboSex_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textDegree_SelectedIndexChanged(object sender, EventArgs e)
        {
            provideSubject();
        }

        private void textContactNumber_Enter(object sender, EventArgs e)
        {
            if (textContactNumber.Text == "(OPTIONAL)")
            {
                textContactNumber.Text = "";
                textContactNumber.ForeColor = Color.Black;
            }
        }

        private void textContactNumber_Leave(object sender, EventArgs e)
        {
            if (textContactNumber.Text == "")
            {
                textContactNumber.Text = "";
                textContactNumber.ForeColor = Color.Gray;
            }
        }

        private void textEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void textEmail_Enter(object sender, EventArgs e)
        {
            if (textEmail.Text == "(OPTIONAL)")
            {
                textEmail.Text = "";
                textEmail.ForeColor = Color.Black;
            }
        }

        private void textEmail_Leave(object sender, EventArgs e)
        {
            if (textEmail.Text == "")
            {
                textEmail.Text = "";
                textEmail.ForeColor = Color.Gray;
            }
        }

        private void textMotherContactNumber_Enter(object sender, EventArgs e)
        {
            if (textMotherContactNumber.Text == "(OPTIONAL)")
            {
                textMotherContactNumber.Text = "";
                textMotherContactNumber.ForeColor = Color.Black;
            }
        }

        private void textMotherContactNumber_Leave(object sender, EventArgs e)
        {
            if (textMotherContactNumber.Text == "")
            {
                textMotherContactNumber.Text = "";
                textMotherContactNumber.ForeColor = Color.Gray;
            }
        }

        private void textFatherContactNumber_Enter(object sender, EventArgs e)
        {
            if (textFatherContactNumber.Text == "(OPTIONAL)")
            {
                textFatherContactNumber.Text = "";
                textFatherContactNumber.ForeColor = Color.Black;
            }
        }

        private void textFatherContactNumber_Leave(object sender, EventArgs e)
        {
            if (textFatherContactNumber.Text == "")
            {
                textFatherContactNumber.Text = "";
                textFatherContactNumber.ForeColor = Color.Gray;
            }
        }

        private void textGuardianContactNumber_Enter(object sender, EventArgs e)
        {
            if (textGuardianContactNumber.Text == "(OPTIONAL)")
            {
                textGuardianContactNumber.Text = "";
                textGuardianContactNumber.ForeColor = Color.Black;
            }
        }

        private void textGuardianContactNumber_Leave(object sender, EventArgs e)
        {
            if (textGuardianContactNumber.Text == "")
            {
                textGuardianContactNumber.Text = "";
                textGuardianContactNumber.ForeColor = Color.Gray;
            }
        }

        private void label31_Click(object sender, EventArgs e)
        {

        }

        private void label30_Click(object sender, EventArgs e)
        {

        }

        private void label29_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textContactNumber_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textReligion_TextChanged(object sender, EventArgs e)
        {

        }

        private void textCitizenship_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBarangay_TextChanged(object sender, EventArgs e)
        {

        }

        private void textCity_TextChanged(object sender, EventArgs e)
        {

        }

        private void textProvince_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textMiddle_TextChanged(object sender, EventArgs e)
        {

        }

        private void label32_Click(object sender, EventArgs e)
        {

        }

        private void textSchoolName_TextChanged(object sender, EventArgs e)
        {

        }

        private void textYearLevel_SelectedIndexChanged(object sender, EventArgs e)
        {
            int yr = textYearLevel.SelectedIndex;
            provideSubject();

            textSection.Items.Clear();

            if (yr == 0)
            {
                textSection.Items.Add("1A");
                textSection.Items.Add("1B");
            }
            else if (yr == 1)
            {
                textSection.Items.Add("2A");
                textSection.Items.Add("2B");
            }
            else if (yr == 2)
            {
                textSection.Items.Add("3A");
                textSection.Items.Add("3B");
            }
            else if (yr == 3)
            {
                textSection.Items.Add("4A");
                textSection.Items.Add("4B");
            }
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void textFatherContactNumber_TextChanged(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void label28_Click(object sender, EventArgs e)
        {

        }

        private void label37_Click(object sender, EventArgs e)
        {

        }

        private void textGuardianContactNumber_TextChanged(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void textBox21_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click_1(object sender, EventArgs e)
        {

        }

        private void comboSemester_SelectedIndexChanged(object sender, EventArgs e)
        {
            provideSubject();
        }

        public void calculateUnit()
        {
            
            for (int i = 0; i < dataGridView0.Rows.Count; i++)
            {
                try
                {
                    unit[i] = int.Parse(dataGridView0.Rows[i].Cells[1].Value.ToString());
                    totalUnit = totalUnit + unit[i];
                }
                catch
                {
                    unit[i] = 0;
                    totalUnit = totalUnit + unit[i];
                }
            }

            textTotalUnit.Text = totalUnit.ToString();
            totalUnit1 = totalUnit;
            totalUnit = 0;
        }

        private void tabControl1_MouseClick(object sender, EventArgs e)
        {
            
        }

        private void textSubject2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textSubject3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textSubject4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textSubject5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textSubject6_TextChanged(object sender, EventArgs e)
        {
  
        }

        private void textSubject7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textSubject8_TextChanged(object sender, EventArgs e)
        {

        }

        private void textSubject9_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textUnit1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textUnit2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textUnit3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textUnit5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textUnit6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textUnit7_TextChanged(object sender, EventArgs e)
        {
;
        }

        private void textUnit8_TextChanged(object sender, EventArgs e)
        {
 
        }

        private void textUnit9_TextChanged(object sender, EventArgs e)
        {

        }

        private void textUnit10_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonUnit_Click(object sender, EventArgs e)
        {
            
        }

        private void textSubject10_TextChanged(object sender, EventArgs e)
        {

        }

        private void textGWA_TextChanged(object sender, EventArgs e)
        {

        }

        public void calculateGWA()
        {
            double gradeskie;
            for(int i = 0; i < dataGridView0.Rows.Count; i++)
            {
                try
                {
                    gradeskie = Convert.ToDouble(dataGridView0.Rows[i].Cells[3].Value);
                    grade[i] = gradeskie.ToString();
                }
                catch
                {
                    gradeskie = 0;
                    grade[i] = gradeskie.ToString();
                }
            }

            for(int i = 0; i < dataGridView0.Rows.Count; i++)
            {
                double gradeDummy = double.Parse(grade[i].ToString());
                int unitDummy = int.Parse(unit[i].ToString());

                double resultDummy = gradeDummy * unitDummy;
                result[i] = resultDummy.ToString();
                double res = double.Parse(result[i].ToString());
                totalResult = totalResult + res;
            }
            totalResult = totalResult / totalUnit1;
            GWA = totalResult;
            GWA = Math.Round(GWA, 2);
            totalResult = 0;
            textGWA.Text = GWA.ToString();

            string interpretation = "";

            if (GWA == 1.00) //1.0
            {
                interpretation = "Excellent";
            }
            else if (GWA > 1.00 && GWA <= 1.25) //1.25
            {
                interpretation = "Superior";
            }
            else if (GWA > 1.25 && GWA <= 1.50) //1.50
            {
                interpretation = "Very Good";
            }
            else if (GWA > 1.50 && GWA <= 1.75) // 1.75
            {
                interpretation = "Good";
            }
            else if (GWA > 1.75 && GWA <= 2.00) // 2.00            
            {
                interpretation = "Very Satisfactory";
            }
            else if (GWA > 2.00 && GWA <= 2.25) //2.25
            {
                interpretation = "Satisfactory";
            }
            else if (GWA > 2.25 && GWA <= 2.50) //2.50
            {
                interpretation = "Average";
            }
            else if (GWA > 2.50 && GWA <= 2.75 && GWA < 3.00) // 2.75
            {
                interpretation = "Fair";
            }
            else if (GWA < 4.00 && GWA >= 3.00) // 3.00
            {
                interpretation = "Passed";
            }
            else if (GWA >= 4.00)   //4.00
            {
                interpretation = "Failed";
            }
            textAssessment1.Text = interpretation;
        }

        private void textGrade2_TextChanged(object sender, EventArgs e)
        {
        }

        private void textGrade3_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textGrade4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textGrade5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textGrade6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textGrade7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textGrade8_TextChanged(object sender, EventArgs e)
        {

        }

        private void textGrade9_TextChanged(object sender, EventArgs e)
        {

        }

        private void textGrade10_TextChanged(object sender, EventArgs e)
        {

        }

        private void label48_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            calculateUnit();
            calculateGWA();
        }

        public void provideSubject()
        {
            int deg = textDegree.SelectedIndex;
            int sem = textSemester.SelectedIndex;
            int yr = textYearLevel.SelectedIndex;

            dataGridView0.DataSource = null;
            dataGridView0.Rows.Clear();
            dataGridView0.Refresh();

            if (deg == 0 && sem == 0 && yr == 0)
            {
                dataGridView0.Rows.Add();
                dataGridView0.Rows[0].Cells[0].Value = "Introduction to Computing"; dataGridView0.Rows[0].Cells[1].Value = "3"; dataGridView0.Rows.Add();
                dataGridView0.Rows[1].Cells[0].Value = "Computer Programming 1"; dataGridView0.Rows[1].Cells[1].Value = "3"; dataGridView0.Rows.Add();
                dataGridView0.Rows[2].Cells[0].Value = "Purposive Communication"; dataGridView0.Rows[2].Cells[1].Value = "3"; dataGridView0.Rows.Add();
                dataGridView0.Rows[3].Cells[0].Value = "Science, Technology and Society"; dataGridView0.Rows[3].Cells[1].Value = "3"; dataGridView0.Rows.Add();
                dataGridView0.Rows[4].Cells[0].Value = "Masisining na Pagpapahayag"; dataGridView0.Rows[4].Cells[1].Value = "3"; dataGridView0.Rows.Add();
                dataGridView0.Rows[5].Cells[0].Value = "Mathematical Translation and Transformation"; dataGridView0.Rows[5].Cells[1].Value = "3"; dataGridView0.Rows.Add();
                dataGridView0.Rows[6].Cells[0].Value = "Gymnastics and Physical Education"; dataGridView0.Rows[6].Cells[1].Value = "2";
                dataGridView0.Rows[7].Cells[0].Value = "National Service Training Program 1"; dataGridView0.Rows[7].Cells[1].Value = "3";
            }
            else if (deg == 0 && sem == 1 && yr == 0)
            {
                dataGridView0.Rows.Add();
                dataGridView0.Rows[0].Cells[0].Value = "Computer Programming 2"; dataGridView0.Rows[0].Cells[1].Value = "3"; dataGridView0.Rows.Add();
                dataGridView0.Rows[1].Cells[0].Value = "Discrete Structure"; dataGridView0.Rows[1].Cells[1].Value = "3"; dataGridView0.Rows.Add();
                dataGridView0.Rows[2].Cells[0].Value = "Fundamentals of Accounting"; dataGridView0.Rows[2].Cells[1].Value = "6"; dataGridView0.Rows.Add();
                dataGridView0.Rows[3].Cells[0].Value = "Readings in Philippine History"; dataGridView0.Rows[3].Cells[1].Value = "3"; dataGridView0.Rows.Add();
                dataGridView0.Rows[4].Cells[0].Value = "The Contemporary World"; dataGridView0.Rows[4].Cells[1].Value = "3"; dataGridView0.Rows.Add();
                dataGridView0.Rows[5].Cells[0].Value = "Advanced Grammar and Composition"; dataGridView0.Rows[5].Cells[1].Value = "3"; dataGridView0.Rows.Add();
                dataGridView0.Rows[6].Cells[0].Value = "Folk Dancing"; dataGridView0.Rows[6].Cells[1].Value = "2"; //unit7 = 2;
                dataGridView0.Rows[7].Cells[0].Value = "National Service Training Program 2"; dataGridView0.Rows[7].Cells[1].Value = "3"; //unit8 = 3;
            }
            else if (deg == 0 && sem == 0 && yr == 1)
            {
                dataGridView0.Rows.Add();
                dataGridView0.Rows[0].Cells[0].Value = "Data Structures and Algorithms"; dataGridView0.Rows[0].Cells[1].Value = "3"; dataGridView0.Rows.Add();
                dataGridView0.Rows[1].Cells[0].Value = "Digital Logic Design"; dataGridView0.Rows[1].Cells[1].Value = "3"; dataGridView0.Rows.Add();
                dataGridView0.Rows[2].Cells[0].Value = "The Life and Works of Rizal"; dataGridView0.Rows[2].Cells[1].Value = "3"; dataGridView0.Rows.Add();
                dataGridView0.Rows[3].Cells[0].Value = "Ang Panitikan ng Pilipinas"; dataGridView0.Rows[3].Cells[1].Value = "3"; dataGridView0.Rows.Add();
                dataGridView0.Rows[4].Cells[0].Value = "Mga Anyo ng Kontemporaryong Panitikang Pilipino"; dataGridView0.Rows[4].Cells[1].Value = "3"; dataGridView0.Rows.Add();
                dataGridView0.Rows[5].Cells[0].Value = "Dimensional Analysis"; dataGridView0.Rows[5].Cells[1].Value = "3"; //unit6 = 3;
                dataGridView0.Rows[6].Cells[0].Value = "Ballgames / Sports"; dataGridView0.Rows[6].Cells[1].Value = "2";//unit7 = 2;
            }
            else if (deg == 0 && sem == 1 && yr == 1)
            {
                dataGridView0.Rows.Add();
                dataGridView0.Rows[0].Cells[0].Value = "Object-Oriented Programming"; dataGridView0.Rows[0].Cells[1].Value = "3"; dataGridView0.Rows.Add();
                dataGridView0.Rows[1].Cells[0].Value = "Data Communication and Networking 1"; dataGridView0.Rows[1].Cells[1].Value = "3"; dataGridView0.Rows.Add();
                dataGridView0.Rows[2].Cells[0].Value = "Probability and Statistics"; dataGridView0.Rows[2].Cells[1].Value = "3"; dataGridView0.Rows.Add();
                dataGridView0.Rows[3].Cells[0].Value = "Mathematics in the Modern World"; dataGridView0.Rows[3].Cells[1].Value = "3"; dataGridView0.Rows.Add();
                dataGridView0.Rows[4].Cells[0].Value = "Art Appreciation"; dataGridView0.Rows[4].Cells[1].Value = "3"; dataGridView0.Rows.Add();
                dataGridView0.Rows[5].Cells[0].Value = "Ethics"; dataGridView0.Rows[5].Cells[1].Value = "3"; dataGridView0.Rows.Add();
                dataGridView0.Rows[6].Cells[0].Value = "Philippine Literature"; dataGridView0.Rows[6].Cells[1].Value = "3"; //unit7 = 3;
                dataGridView0.Rows[7].Cells[0].Value = "Recreational Games"; dataGridView0.Rows[7].Cells[1].Value = "2"; //unit8 = 2;
            }
            else if (deg == 0 && sem == 0 && yr == 2)
            {
                dataGridView0.Rows.Add();
                dataGridView0.Rows[0].Cells[0].Value = "Quantitative Methods"; dataGridView0.Rows[0].Cells[1].Value = "3"; dataGridView0.Rows.Add();
                dataGridView0.Rows[1].Cells[0].Value = "IT Elective 1"; dataGridView0.Rows[1].Cells[1].Value = "3"; dataGridView0.Rows.Add();
                dataGridView0.Rows[2].Cells[0].Value = "Applications Development & Emerging Technologies"; dataGridView0.Rows[2].Cells[1].Value = "3"; dataGridView0.Rows.Add();
                dataGridView0.Rows[3].Cells[0].Value = "Systems Analysis and Design"; dataGridView0.Rows[3].Cells[1].Value = "3"; dataGridView0.Rows.Add();
                dataGridView0.Rows[4].Cells[0].Value = "Operating Systems"; dataGridView0.Rows[4].Cells[1].Value = "3"; dataGridView0.Rows.Add();
                dataGridView0.Rows[5].Cells[0].Value = "Information Management 2"; dataGridView0.Rows[5].Cells[1].Value = "3"; //unit6 = 3;
                dataGridView0.Rows[6].Cells[0].Value = "Gender and Development"; dataGridView0.Rows[6].Cells[1].Value = "3"; //unit7 = 3;
            }
            else if (deg == 0 && sem == 1 && yr == 2)
            {
                dataGridView0.Rows.Add();
                dataGridView0.Rows[0].Cells[0].Value = "Data Communication and Networking 2"; dataGridView0.Rows[0].Cells[1].Value = "3"; dataGridView0.Rows.Add();
                dataGridView0.Rows[1].Cells[0].Value = "IT Elective 2"; dataGridView0.Rows[1].Cells[1].Value = "3"; dataGridView0.Rows.Add();
                dataGridView0.Rows[2].Cells[0].Value = "Information Assurance and Security"; dataGridView0.Rows[2].Cells[1].Value = "3"; dataGridView0.Rows.Add();
                dataGridView0.Rows[3].Cells[0].Value = "System Integration and Architecture"; dataGridView0.Rows[3].Cells[1].Value = "3"; dataGridView0.Rows.Add();
                dataGridView0.Rows[4].Cells[0].Value = "Introduction to Human Computer Interaction"; dataGridView0.Rows[4].Cells[1].Value = "3"; dataGridView0.Rows.Add();
                dataGridView0.Rows[5].Cells[0].Value = "Methods of Research in Computing"; dataGridView0.Rows[5].Cells[1].Value = "3"; dataGridView0.Rows.Add();
                dataGridView0.Rows[6].Cells[0].Value = "Fundamentals of Data Warehousing and Data Mining"; dataGridView0.Rows[6].Cells[1].Value = "3"; //unit7 = 3;
                dataGridView0.Rows[7].Cells[0].Value = "Web Programming"; dataGridView0.Rows[7].Cells[1].Value = "3"; //unit8 = 3;
            }
            else if (deg == 0 && sem == 0 && yr == 3)
            {
                dataGridView0.Rows.Add();
                dataGridView0.Rows[0].Cells[0].Value = "Systems Administration and Maintenance"; dataGridView0.Rows[0].Cells[1].Value = "3"; dataGridView0.Rows.Add();
                dataGridView0.Rows[1].Cells[0].Value = "Capstone Project 2"; dataGridView0.Rows[1].Cells[1].Value = "3"; dataGridView0.Rows.Add();
                dataGridView0.Rows[2].Cells[0].Value = "Certification Examination Review"; dataGridView0.Rows[2].Cells[1].Value = "3"; dataGridView0.Rows.Add();
                dataGridView0.Rows[3].Cells[0].Value = "IT Elective 4"; dataGridView0.Rows[3].Cells[1].Value = "3"; dataGridView0.Rows.Add();
                dataGridView0.Rows[4].Cells[0].Value = "World Literature"; dataGridView0.Rows[4].Cells[1].Value = "3"; dataGridView0.Rows.Add();
                dataGridView0.Rows[5].Cells[0].Value = "Career Development and Work Values"; dataGridView0.Rows[5].Cells[1].Value = "3"; dataGridView0.Rows.Add();
                dataGridView0.Rows[6].Cells[0].Value = "Reading Visual Arts"; dataGridView0.Rows[6].Cells[1].Value = "3";
                dataGridView0.Rows[7].Cells[0].Value = "Social Issues and Professionals Practices"; dataGridView0.Rows[7].Cells[1].Value = "3"; //unit8 = 3;

            }
            else if (deg == 0 && sem == 1 && yr == 3)
            {
                dataGridView0.Rows.Add();
                dataGridView0.Rows[0].Cells[0].Value = "Practicum"; dataGridView0.Rows[0].Cells[1].Value = "6"; //unit1 = 6;
                dataGridView0.Rows[1].Cells[0].Value = "Seminars and Tours"; dataGridView0.Rows[1].Cells[1].Value = "3"; //unit2 = 3;
            }

        }

        private void buttonCalculate_Click(object sender, EventArgs e)
        {
            calculateUnit();
            calculateGWA();
        }

        private void dataGridView1_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            calculateUnit();
            calculateGWA();
        }

        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            calculateUnit();
            calculateGWA();
        }

        private void deleteSub_Click(object sender, EventArgs e)
        {
            try
            {
                dataGridView0.Rows.Remove(dataGridView0.CurrentRow);
            }
            catch
            {
                dataGridView0.CurrentRow.Cells[0].Value = "";
                dataGridView0.CurrentRow.Cells[1].Value = "";
                dataGridView0.CurrentRow.Cells[2].Value = "";
                dataGridView0.CurrentRow.Cells[3].Value = "";
            }
        }
    }
}
