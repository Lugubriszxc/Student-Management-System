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
    public partial class Form4 : Form
    {
        public static string StudentID = "";
        public static string FirstName = "";
        public static string MiddleName = "";
        public static string LastName = "";
        public static string Sex = "";
        public static string Birthdate = "";
        public static string Province = "";
        public static string City = "";
        public static string Barangay = "";
        public static string Citizenship = "";
        public static string Religion = "";
        public static string Contact = "";
        public static string Email = "";
        public static string SchoolName = "";    //
        public static string DegreeProgram = ""; //
        public static string DepartmentName = ""; //
        public static string YearLevel = "";  //
        public static string MotherFirst = "";
        public static string MotherMiddle = "";
        public static string MotherLast = "";
        public static string MotherCitizenship = "";
        public static string MotherReligion = "";
        public static string MotherOccupation = "";
        public static string MotherContact= "";
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
        public static string SchoolYear = "";
        public static string Semester = "";
        public static string Section = "";
        public static string GWA = "";
        public static string Assessment = "";
        public static string TotalUnits = "";
        public static string SubjectID = "";

        public static int choice = 0;

        const int SIZE = 500;
        public static int totalUnit = 0;
        public static int totalUnit1 = 0;
        public static int[] unit = new int[SIZE];
        public static string[] grade = new string[SIZE];
        public static double GWA1;
        public static string[] result = new string[SIZE];
        public static double totalResult;
        public static double totalResult1;

        public static string subjectID = "";

        public static int totalRows = 0;
        public static int verifyRows = 0;
        SqlConnection con = new SqlConnection("Data Source=LAPTOP-K946DC8Q\\SQLEXPRESS;Initial Catalog=DBLOGIN;Integrated Security=True");

        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dBLOGINDataSet.Grades' table. You can move, or remove it, as needed.
            //this.gradesTableAdapter.Fill(this.dBLOGINDataSet.Grades);
            con.Open();
            StudentID = Form2.StudentID;
            checkBox2.Hide(); //Add New Subject
            dataGridView1.AllowUserToAddRows = false;
            checkBox1.Checked = false; // Edit mode
            textTotalUnit.Enabled = false;
            textGWA.Enabled = false;
            textAssessment1.Enabled = false;

            SqlCommand cmd = new SqlCommand("SELECT * FROM StudInfo WHERE StudentID='"+StudentID+"'",con);
            SqlDataReader dr;
            dr = cmd.ExecuteReader();

            if (dr.Read())
            {
                FirstName = dr.GetValue(1).ToString();
                MiddleName = dr.GetValue(2).ToString();
                LastName = dr.GetValue(3).ToString();
                Sex = dr.GetValue(4).ToString();
                Birthdate = dr.GetValue(12).ToString();
                Province = dr.GetValue(5).ToString();
                City = dr.GetValue(6).ToString();
                Barangay = dr.GetValue(7).ToString();
                Citizenship = dr.GetValue(8).ToString();
                Religion = dr.GetValue(9).ToString();
                Contact = dr.GetValue(10).ToString();
                Email = dr.GetValue(11).ToString();
             
                textFirst.Text = FirstName;
                textMiddle.Text = MiddleName;
                textLast.Text = LastName;
                comboSex.Text = Sex;
                textDate.Text = Birthdate;
                textProvince.Text = Province;
                textCity.Text = City;
                textBarangay.Text = Barangay;
                textCitizenship.Text = Citizenship;
                textReligion.Text = Religion;
                textContactNumber.Text = Contact;
                textEmail.Text = Email;
                dr.Close();
            
                SqlCommand cmde = new SqlCommand("SELECT * FROM Parent WHERE StudentID = '"+StudentID+"'", con);
                dr = cmde.ExecuteReader();
                if (dr.Read())
                {
                    MotherFirst = dr.GetValue(1).ToString();
                    MotherMiddle = dr.GetValue(2).ToString();
                    MotherLast = dr.GetValue(3).ToString();
                    MotherCitizenship = dr.GetValue(4).ToString();
                    MotherReligion = dr.GetValue(5).ToString();
                    MotherOccupation = dr.GetValue(6).ToString();
                    MotherContact = dr.GetValue(7).ToString();
                    FatherFirst = dr.GetValue(8).ToString();
                    FatherMiddle = dr.GetValue(9).ToString();
                    FatherLast = dr.GetValue(10).ToString();
                    FatherCitizenship = dr.GetValue(11).ToString();
                    FatherReligion = dr.GetValue(12).ToString();
                    FatherOccupation = dr.GetValue(13).ToString();
                    FatherContact = dr.GetValue(14).ToString();
                    GuardianFirst = dr.GetValue(15).ToString();
                    GuardianMiddle = dr.GetValue(16).ToString();
                    GuardianLast = dr.GetValue(17).ToString();
                    GuardianCitizenship = dr.GetValue(18).ToString();
                    GuardianReligion = dr.GetValue(19).ToString();
                    GuardianOccupation = dr.GetValue(20).ToString();
                    GuardianContact = dr.GetValue(21).ToString();

                    textMotherFirst.Text = MotherFirst;
                    textMotherMiddle.Text = MotherMiddle;
                    textMotherLast.Text = MotherLast;
                    textMotherCitizenship.Text = MotherCitizenship;
                    textMotherReligion.Text = MotherReligion;
                    textMotherOccupation.Text = MotherOccupation;
                    textMotherContactNumber.Text = MotherContact;
                    textFatherFirst.Text = FatherFirst;
                    textFatherMiddle.Text = FatherMiddle;
                    textFatherLast.Text = FatherLast;
                    textFatherCitizenship.Text = FatherCitizenship;
                    textFatherReligion.Text = FatherReligion;
                    textFatherOccupation.Text = FatherOccupation;
                    textFatherContactNumber.Text = FatherContact;
                    textGuardianFirst.Text = GuardianFirst;
                    textGuardianMiddle.Text = GuardianMiddle;
                    textGuardianLast.Text = GuardianLast;
                    textGuardianCitizenship.Text = GuardianCitizenship;
                    textGuardianReligion.Text = GuardianReligion;
                    textGuardianOccupation.Text = GuardianOccupation;
                    textGuardianContactNumber.Text = GuardianContact;
                    dr.Close();

                    SqlCommand cmd3 = new SqlCommand("SELECT * FROM SubDepartment WHERE StudentID = '" + StudentID + "'", con);
                    dr = cmd3.ExecuteReader();
                    if(dr.Read())
                    {
                        SchoolYear = dr.GetValue(1).ToString();
                        SchoolName = dr.GetValue(2).ToString();
                        DepartmentName = dr.GetValue(3).ToString();
                        YearLevel = dr.GetValue(4).ToString();
                        DegreeProgram = dr.GetValue(5).ToString();
                        Semester = dr.GetValue(6).ToString();
                        Section = dr.GetValue(7).ToString();

                        textSchoolYear.Text = SchoolYear;
                        textSchoolName.Text = SchoolName;
                        textDepartment.Text = DepartmentName;
                        textYearLevel.Text = YearLevel;
                        textDegree.Text = DegreeProgram;
                        textSemester.Text = Semester;
                        textSection.Text = Section;
                        dr.Close();

                        SqlCommand cmd4 = new SqlCommand("SELECT * FROM Grades WHERE StudentID = '" + StudentID + "'", con);
                        dr = cmd4.ExecuteReader();
                        if(dr.Read())
                        {
                            GWA = dr.GetValue(6).ToString();
                            TotalUnits = dr.GetValue(3).ToString();
                            Assessment = dr.GetValue(8).ToString();

                            textGWA.Text = GWA;
                            textTotalUnit.Text = TotalUnits;
                            textAssessment1.Text = Assessment;

                            dr.Close();
                            loadDataGrid();
                        }

                        dr.Close();
                    }
                }
            }
            dr.Close();

            ControlBox = false;
            button1.Hide();
            buttonDone.Enabled = false;
            enableText(2);

            con.Close();
            }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
              if(checkBox1.Checked)
            {
                checkBox2.Show();
                button1.Enabled = true;
                button1.Show();
                buttonBack.Hide();
                buttonDone.Enabled = true;
                enableText(1);
                choice = 0;
            }
            else
            {
                checkBox2.Checked = false;
                checkBox2.Hide();
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    dataGridView1.ReadOnly = true;
                }
                button1.Enabled = false;
                button1.Hide();
                buttonBack.Show();
                buttonDone.Enabled = false;
                enableText(2);
                choice = 0;
            }
        }

        private void buttonDone_Click(object sender, EventArgs e)
        {
            con.Open();

            SqlCommand cmd1 = new SqlCommand("UPDATE StudInfo SET FirstName = '" + textFirst.Text + "', MiddleName = '" + textMiddle.Text + "', LastName = '" + textLast.Text + "', Sex = '" + comboSex.Text + "', AddProvince = '" + textProvince.Text + "', AddCity = '" + textCity.Text + "', AddBarangay = '" + textBarangay.Text + "', Citizenship = '" + textCitizenship.Text + "', Religion = '" + textReligion.Text + "', Contact = '" + textContactNumber.Text + "', Email = '" + textEmail.Text + "', Birthdate = '" + textDate.Text + "' WHERE StudentID = '"+StudentID+"'",con);
            cmd1.ExecuteNonQuery();
            SqlCommand cmd2 = new SqlCommand("UPDATE  Parent SET MotherFirst = '" + textMotherFirst.Text + "', MotherMiddle = '" + textMotherMiddle.Text + "', MotherLast = '" + textMotherLast.Text + "', MotherCitizenship = '" + textMotherCitizenship.Text + "', MotherReligion = '" + textMotherReligion.Text + "', MotherOccupation = '" + textMotherOccupation.Text + "', MotherContact = '" + textGuardianContactNumber.Text + "', FatherFirst = '" + textFatherFirst.Text + "', FatherMiddle = '" + textFatherMiddle.Text + "', FatherLast = '" + textFatherLast.Text + "', FatherCitizenship = '" + textFatherCitizenship.Text + "', FatherReligion = '" + textFatherReligion.Text + "', FatherOccupation = '" + textFatherOccupation.Text + "', FatherContact = '" + textFatherContactNumber.Text + "', GuardianFirst = '" + textGuardianFirst.Text + "', GuardianMiddle = '" + textGuardianMiddle.Text + "', GuardianLast = '" + textGuardianLast.Text + "', GuardianCitizenship = '" + textGuardianCitizenship.Text + "', GuardianReligion = '" + textGuardianReligion.Text + "', GuardianOccupation = '" + textGuardianOccupation.Text + "', GuardianContact = '" + textGuardianContactNumber.Text + "' WHERE StudentID = '"+StudentID+"'", con);
            cmd2.ExecuteNonQuery();
            SqlCommand cmd3 = new SqlCommand("UPDATE SubDepartment SET SchoolYear = '" + textSchoolYear.Text + "', SchoolName = '" + textSchoolName.Text + "', DepartmentName = '" + textDepartment.Text + "', YearLevel = '" + textYearLevel.Text + "', DegreeProgram = '" + textDegree.Text + "', Semester = '" + textSemester.Text + "', Section = '" + textSection.Text + "' WHERE StudentID = '"+StudentID+"'", con);
            cmd3.ExecuteNonQuery();

            SqlDataReader dr;
            try
            {
                if (choice == 1) //checkbox2 // Add new subject
                {
                    for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                    {
                            SqlCommand cmd4 = new SqlCommand("INSERT INTO Grades (TotalUnit, GWA, Remarks, StudentID) VALUES ('" + textTotalUnit.Text + "', '" + textGWA.Text + "', '" + textAssessment1.Text + "', '" + StudentID + "')", con);
                            cmd4.ExecuteNonQuery();

                            SqlCommand cmd5 = new SqlCommand("SELECT MAX(SubjectID) FROM Grades WHERE StudentID = '" + StudentID + "'", con);
                            dr = cmd5.ExecuteReader();

                            if (dr.Read())
                            {
                                SubjectID = dr.GetValue(0).ToString();
                            }
                            dr.Close();

                            SqlCommand cmd6 = new SqlCommand("UPDATE Grades SET Subject = @Subject, Unit = @Unit, Instructor = @Instructor, Grade = @Grade WHERE SubjectID = '" + SubjectID + "'", con);
                            cmd6.Parameters.AddWithValue("@Subject", Convert.ToString(dataGridView1.Rows[i].Cells[1].Value));
                            cmd6.Parameters.AddWithValue("@Unit", Convert.ToString(dataGridView1.Rows[i].Cells[2].Value));
                            cmd6.Parameters.AddWithValue("@Instructor", Convert.ToString(dataGridView1.Rows[i].Cells[3].Value));
                            cmd6.Parameters.AddWithValue("@Grade", Convert.ToString(dataGridView1.Rows[i].Cells[4].Value));
                            cmd6.ExecuteNonQuery();         
                    }
                    MessageBox.Show("SUCCESSFULLY CREATED NEW SUBJECT!");
                    checkBox2.Checked = false;
                }
                else if (choice == 0)
                {
                    for (int i = 0; i < dataGridView1.Rows.Count; i++)
                    {
                            SqlCommand cmd4 = new SqlCommand("UPDATE Grades SET Subject = @Subject, Unit = @Unit, TotalUnit = '" + textTotalUnit.Text + "', Instructor = @Instructor, Grade = @Grade, GWA = '" + textGWA.Text + "', Remarks = '" + textAssessment1.Text + "' WHERE SubjectID = @SubjectID", con);
                            cmd4.Parameters.AddWithValue("@SubjectID", dataGridView1.Rows[i].Cells[0].Value);
                            cmd4.Parameters.AddWithValue("@Subject", dataGridView1.Rows[i].Cells[1].Value);
                            cmd4.Parameters.AddWithValue("@Unit", dataGridView1.Rows[i].Cells[2].Value);
                            cmd4.Parameters.AddWithValue("@Instructor", dataGridView1.Rows[i].Cells[3].Value);
                            cmd4.Parameters.AddWithValue("@Grade", dataGridView1.Rows[i].Cells[4].Value);
                            cmd4.ExecuteNonQuery();
                    }
                    MessageBox.Show("UPDATED SUCCESSFULLY!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    checkBox1.Checked = false;
                }
            }
            catch
            {
                MessageBox.Show("AN ERROR OCCURRED!");
            }

            con.Close();
        }

        private void BUTTONBACK_Click(object sender, EventArgs e)
        {
            Close();
            Form2 f2 = new Form2();
            f2.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cancelEditMode();
            checkBox2.Checked = false;
        }

        private void textFirst_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonBack_Click_1(object sender, EventArgs e)
        {
            Close();
            Form2 f2 = new Form2();
            f2.Show();
        }

        private void textContactNumber_TextChanged(object sender, EventArgs e)
        {

        }

        private void textContactNumber_Enter(object sender, EventArgs e)
        {
            
        }

        private void textContactNumber_Leave(object sender, EventArgs e)
        {
            
        }

        private void textDegree_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textFatherFirst_TextChanged(object sender, EventArgs e)
        {

        }

        private void textFatherMiddle_TextChanged(object sender, EventArgs e)
        {

        }

        private void textFatherLast_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textReligion_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textCitizenship_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void textSubject1_TextChanged(object sender, EventArgs e)
        {
            
        }

        public void enableText(int choice)
        {
            if(choice == 1) // enable edit mode
            {
                dataGridView1.ReadOnly = false;
                textFirst.Enabled = true;
                textMiddle.Enabled = true;
                textLast.Enabled = true;
                comboSex.Enabled = true;
                textDate.Enabled = true;
                textProvince.Enabled = true;
                textCity.Enabled = true;
                textBarangay.Enabled = true;
                textCitizenship.Enabled = true;
                textReligion.Enabled = true;
                textContactNumber.Enabled = true;
                textEmail.Enabled = true;
                textSchoolName.Enabled = false;
                textDegree.Enabled = true;
                textDepartment.Enabled = true;
                textYearLevel.Enabled = true;
                textMotherFirst.Enabled = true;
                textMotherMiddle.Enabled = true;
                textMotherLast.Enabled = true;
                textMotherCitizenship.Enabled = true;
                textMotherReligion.Enabled = true;
                textMotherOccupation.Enabled = true;
                textMotherContactNumber.Enabled = true;
                textFatherFirst.Enabled = true;
                textFatherMiddle.Enabled = true;
                textFatherLast.Enabled = true;
                textFatherCitizenship.Enabled = true;
                textFatherReligion.Enabled = true;
                textFatherOccupation.Enabled = true;
                textFatherContactNumber.Enabled = true;
                textGuardianFirst.Enabled = true;
                textGuardianMiddle.Enabled = true;
                textGuardianLast.Enabled = true;
                textGuardianCitizenship.Enabled = true;
                textGuardianReligion.Enabled = true;
                textGuardianOccupation.Enabled = true;
                textGuardianContactNumber.Enabled = true;
                textSchoolYear.Enabled = true;
                textSemester.Enabled = true;
                textSection.Enabled = true;
            }
            else if(choice == 2)
            {
                dataGridView1.ReadOnly = true;
                textFirst.Enabled = false;
                textMiddle.Enabled = false;
                textLast.Enabled = false;
                comboSex.Enabled = false;
                textDate.Enabled = false;
                textProvince.Enabled = false;
                textCity.Enabled = false;
                textBarangay.Enabled = false;
                textCitizenship.Enabled = false;
                textReligion.Enabled = false;
                textContactNumber.Enabled = false;
                textEmail.Enabled = false;
                textSchoolName.Enabled = false;
                textDegree.Enabled = false;
                textDepartment.Enabled = false;
                textYearLevel.Enabled = false;
                textMotherFirst.Enabled = false;
                textMotherMiddle.Enabled = false;
                textMotherLast.Enabled = false;
                textMotherCitizenship.Enabled = false;
                textMotherReligion.Enabled = false;
                textMotherOccupation.Enabled = false;
                textMotherContactNumber.Enabled = false;
                textFatherFirst.Enabled = false;
                textFatherMiddle.Enabled = false;
                textFatherLast.Enabled = false;
                textFatherCitizenship.Enabled = false;
                textFatherReligion.Enabled = false;
                textFatherOccupation.Enabled = false;
                textFatherContactNumber.Enabled = false;
                textGuardianFirst.Enabled = false;
                textGuardianMiddle.Enabled = false;
                textGuardianLast.Enabled = false;
                textGuardianCitizenship.Enabled = false;
                textGuardianReligion.Enabled = false;
                textGuardianOccupation.Enabled = false;
                textGuardianContactNumber.Enabled = false;
                textSchoolYear.Enabled = false;
                textSemester.Enabled = false;
                textSection.Enabled = false;
            }
        }

        private void textDepartment_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textYearLevel_SelectedIndexChanged(object sender, EventArgs e)
        {
            int yr = textYearLevel.SelectedIndex;
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

        private void textSemester_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tabControl1_MouseClick(object sender, MouseEventArgs e)
        {

        }

        public void calculateUnit()
        {
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                try
                {
                    unit[i] = int.Parse(dataGridView1.Rows[i].Cells[2].Value.ToString());
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

        public void calculateGWA()
        {
            double gradeskie;
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                try
                {
                    gradeskie = double.Parse(dataGridView1.Rows[i].Cells[4].Value.ToString());
                    grade[i] = gradeskie.ToString();
                }
                catch
                {
                    gradeskie = 0;
                    grade[i] = gradeskie.ToString();
                }
            }

            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                double gradeDummy = double.Parse(grade[i].ToString());
                int unitDummy = int.Parse(unit[i].ToString());

                double resultDummy = gradeDummy * unitDummy;
                result[i] = resultDummy.ToString();
                double res = double.Parse(result[i].ToString());
                totalResult = totalResult + res;
            }
            totalResult = totalResult / totalUnit1;
            GWA1 = totalResult;
            GWA1 = Math.Round(GWA1, 2);
            totalResult = 0;
            textGWA.Text = GWA1.ToString();

            string interpretation = "";

            if (GWA1 == 1.00) //1.0
            {
                interpretation = "Excellent";
            }
            else if (GWA1 > 1.00 && GWA1 <= 1.25) //1.25
            {
                interpretation = "Superior";
            }
            else if (GWA1 > 1.25 && GWA1 <= 1.50) //1.50
            {
                interpretation = "Very Good";
            }
            else if (GWA1 > 1.50 && GWA1 <= 1.75) // 1.75
            {
                interpretation = "Good";
            }
            else if (GWA1 > 1.75 && GWA1 <= 2.00) // 2.00            
            {
                interpretation = "Very Satisfactory";
            }
            else if (GWA1 > 2.00 && GWA1 <= 2.25) //2.25
            {
                interpretation = "Satisfactory";
            }
            else if (GWA1 > 2.25 && GWA1 <= 2.50) //2.50
            {
                interpretation = "Average";
            }
            else if (GWA1 > 2.50 && GWA1 <= 2.75 && GWA1 < 3.00) // 2.75
            {
                interpretation = "Fair";
            }
            else if (GWA1 < 4.00 && GWA1 >= 3.00) // 3.00
            {
                interpretation = "Passed";
            }
            else if (GWA1 >= 4.00)   //4.00
            {
                interpretation = "Failed";
            }
            textAssessment1.Text = interpretation;
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

        private void textUnit4_TextChanged(object sender, EventArgs e)
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

        private void textGrade1_TextChanged(object sender, EventArgs e)
        {
           
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

        private void textSubject10_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void textSection_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tabPage3_Click(object sender, EventArgs e)
        {
            calculateUnit();
            calculateGWA();
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            
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

        public void loadDataGrid()
        {
            con.Close();
            con.Open();
            SqlCommand cmd5 = new SqlCommand("SELECT SubjectID, Subject, Unit, Instructor, Grade FROM Grades WHERE StudentID = '" + StudentID + "'", con);
            cmd5.ExecuteNonQuery();

            DataTable dt = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(cmd5);
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
            calculateUnit();
            calculateGWA();
            con.Close();
        }

        public void cancelEditMode()
        {
            checkBox1.Checked = false;
            textFirst.Text = FirstName;
            textMiddle.Text = MiddleName;
            textLast.Text = LastName;
            comboSex.Text = Sex;
            textDate.Text = Birthdate;
            textProvince.Text = Province;
            textCity.Text = City;
            textBarangay.Text = Barangay;
            textCitizenship.Text = Citizenship;
            textReligion.Text = Religion;
            textContactNumber.Text = Contact;
            textEmail.Text = Email;
            textSchoolName.Text = SchoolName;
            textDegree.Text = DegreeProgram;
            textDepartment.Text = DepartmentName;
            textYearLevel.Text = YearLevel;
            textMotherFirst.Text = MotherFirst;
            textMotherMiddle.Text = MotherMiddle;
            textMotherLast.Text = MotherLast;
            textMotherCitizenship.Text = MotherCitizenship;
            textMotherReligion.Text = MotherReligion;
            textMotherOccupation.Text = MotherOccupation;
            textMotherContactNumber.Text = MotherContact;
            textFatherFirst.Text = FatherFirst;
            textFatherMiddle.Text = FatherMiddle;
            textFatherLast.Text = FatherLast;
            textFatherCitizenship.Text = FatherCitizenship;
            textFatherReligion.Text = FatherReligion;
            textFatherOccupation.Text = FatherOccupation;
            textFatherContactNumber.Text = FatherContact;
            textGuardianFirst.Text = GuardianFirst;
            textGuardianMiddle.Text = GuardianMiddle;
            textGuardianLast.Text = GuardianLast;
            textGuardianCitizenship.Text = GuardianCitizenship;
            textGuardianReligion.Text = GuardianReligion;
            textGuardianOccupation.Text = GuardianOccupation;
            textGuardianContactNumber.Text = GuardianContact;
            textSemester.Text = Semester;
            textSection.Text = Section;
            textSchoolYear.Text = SchoolYear;
            textGWA.Text = GWA;
            textAssessment1.Text = Assessment;
            loadDataGrid();  
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox2.Checked)
            {
                totalRows = dataGridView1.Rows.Count - 1;
                dataGridView1.DataSource = null;
                dataGridView1.Rows.Clear();
                dataGridView1.Refresh();
                choice = 1;
                dataGridView1.AllowUserToAddRows = true;
            }
            else
            {
                dataGridView1.AllowUserToAddRows = false;
                dataGridView1.DataSource = null;
                dataGridView1.Rows.Clear();
                dataGridView1.Refresh();
                loadDataGrid();
                choice = 0;
            }
        }

        public void createOrUpdate()
        {
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void buttonDeleteSub_Click(object sender, EventArgs e)
        {
            
            if(choice == 0)
            {
                subjectID = !string.IsNullOrEmpty(dataGridView1.CurrentRow.Cells[0].Value.ToString()) ? dataGridView1.CurrentRow.Cells[0].Value.ToString() : " ";
                con.Open();
                SqlCommand cmd = new SqlCommand("DELETE FROM Grades WHERE SubjectID = '" + subjectID + "'", con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("SUCCESSFULLY DELETED THE SUBJECT");
                loadDataGrid();
                con.Close();
            }
            else if(choice == 1)
            {
                try
                {
                    dataGridView1.Rows.Remove(dataGridView1.CurrentRow);
                }
                catch
                {
                    dataGridView1.CurrentRow.Cells[0].Value = "";
                    dataGridView1.CurrentRow.Cells[1].Value = "";
                    dataGridView1.CurrentRow.Cells[2].Value = "";
                    dataGridView1.CurrentRow.Cells[3].Value = "";
                }
            }
        }

        private void textSearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }
    }
}
