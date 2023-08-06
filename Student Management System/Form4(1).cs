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

        SqlConnection con = new SqlConnection("Data Source=DESKTOP-OP623LH\\SQLEXPRESS;Initial Catalog=StudentSystem;Integrated Security=True");

        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            ControlBox = false;
            button1.Hide();
            buttonDone.Enabled = false;
            textFirst.Enabled = false;
            textMiddle.Enabled = false;
            textLast.Enabled = false;
            comboSex.Enabled = false;
            comboMonth.Enabled = false;
            comboDay.Enabled = false;
            comboYear.Enabled = false;
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


            FirstName = Form2.FirstName;
            MiddleName = Form2.MiddleName;
            LastName = Form2.LastName;
            Sex = Form2.Sex;
            BirthMonth = Form2.BirthMonth;
            BirthDay = Form2.BirthDay;
            BirthYear = Form2.BirthYear;
            Province = Form2.Province;
            City = Form2.City;
            Barangay = Form2.Barangay;
            Citizenship = Form2.Citizenship;
            Religion = Form2.Religion;
            Contact = Form2.Contact;
            Email = Form2.Email;
            SchoolName = Form2.SchoolName;
            DegreeProgram = Form2.DegreeProgram;
            DepartmentName = Form2.DepartmentName;
            YearLevel = Form2.YearLevel;
            MotherFirst = Form2.MotherFirst;
            MotherMiddle = Form2.MotherMiddle;
            MotherLast = Form2.MotherLast;
            MotherCitizenship = Form2.MotherCitizenship;
            MotherReligion = Form2.MotherReligion;
            MotherOccupation = Form2.MotherOccupation;
            MotherContact = Form2.MotherContact;
            FatherFirst = Form2.FatherFirst;
            FatherMiddle = Form2.FatherMiddle;
            FatherLast = Form2.FatherLast;
            FatherCitizenship = Form2.FatherCitizenship;
            FatherReligion = Form2.FatherReligion;
            FatherOccupation = Form2.FatherOccupation;
            FatherContact = Form2.FatherContact;
            GuardianFirst = Form2.GuardianFirst;
            GuardianMiddle = Form2.GuardianMiddle;
            GuardianLast = Form2.GuardianLast;
            GuardianCitizenship = Form2.GuardianCitizenship;
            GuardianReligion = Form2.GuardianReligion;
            GuardianOccupation = Form2.GuardianOccupation;
            GuardianContact = Form2.GuardianContact;


            textFirst.Text = Form2.FirstName;
            textMiddle.Text = Form2.MiddleName;
            textLast.Text = Form2.LastName;
            comboSex.Text = Form2.Sex;
            comboMonth.Text = Form2.BirthMonth;
            comboDay.Text = Form2.BirthDay;
            comboYear.Text = Form2.BirthYear;
            textProvince.Text = Form2.Province;
            textCity.Text = Form2.City;
            textBarangay.Text = Form2.Barangay;
            textCitizenship.Text = Form2.Citizenship;
            textReligion.Text = Form2.Religion;
            textContactNumber.Text = Form2.Contact;
            textEmail.Text = Form2.Email;
            textSchoolName.Text = Form2.SchoolName;
            textDegree.Text = Form2.DegreeProgram;
            textDepartment.Text = Form2.DepartmentName;
            textYearLevel.Text = Form2.YearLevel;
            textMotherFirst.Text = Form2.MotherFirst;
            textMotherMiddle.Text = Form2.MotherMiddle;
            textMotherLast.Text = Form2.MotherLast;
            textMotherCitizenship.Text = Form2.MotherCitizenship;
            textMotherReligion.Text = Form2.MotherReligion;
            textMotherOccupation.Text = Form2.MotherOccupation;
            textMotherContactNumber.Text = Form2.MotherContact;
            textFatherFirst.Text = Form2.FatherFirst;
            textFatherMiddle.Text = Form2.FatherMiddle;
            textFatherLast.Text = Form2.FatherLast;
            textFatherCitizenship.Text = Form2.FatherCitizenship;
            textFatherReligion.Text = Form2.FatherReligion;
            textFatherOccupation.Text = Form2.FatherOccupation;
            textFatherContactNumber.Text = Form2.FatherContact;
            textGuardianFirst.Text = Form2.GuardianFirst;
            textGuardianMiddle.Text = Form2.GuardianMiddle;
            textGuardianLast.Text = Form2.GuardianLast;
            textGuardianCitizenship.Text = Form2.GuardianCitizenship;
            textGuardianReligion.Text = Form2.GuardianReligion;
            textGuardianOccupation.Text = Form2.GuardianOccupation;
            textGuardianContactNumber.Text = Form2.GuardianContact;

            
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox1.Checked)
            {
                button1.Enabled = true;
                button1.Show();
                buttonDone.Enabled = true;
                textFirst.Enabled = true;
                textMiddle.Enabled = true;
                textLast.Enabled = true;
                comboSex.Enabled = true;
                comboMonth.Enabled = true;
                comboDay.Enabled = true;
                comboYear.Enabled = true;
                textProvince.Enabled = true;
                textCity.Enabled = true;
                textBarangay.Enabled = true;
                textCitizenship.Enabled = true;
                textReligion.Enabled = true;
                textContactNumber.Enabled = true;
                textEmail.Enabled = true;
                textSchoolName.Enabled = true;
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
            }
            else
            {
                button1.Enabled = false;
                button1.Hide();
                buttonDone.Enabled = false;
                textFirst.Enabled = false;
                textMiddle.Enabled = false;
                textLast.Enabled = false;
                comboSex.Enabled = false;
                comboMonth.Enabled = false;
                comboDay.Enabled = false;
                comboYear.Enabled = false;
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
            }
        }

        private void buttonDone_Click(object sender, EventArgs e)
        {
            con.Open();

            SqlCommand cmd = new SqlCommand("UPDATE StudentInformation SET FirstName = '" + textFirst.Text + "', MiddleName = '" + textMiddle.Text + "', LastName = '" + textLast.Text + "', Sex = '" + comboSex.Text + "', BirthMonth = '" + comboMonth.Text + "', Birthday = '" + comboDay.Text + "', BirthYear = '" + comboYear.Text + "' , AddProvince = '" + textProvince.Text + "', AddCity = '" + textCity.Text + "', AddBarangay='" + textBarangay.Text + "', Citizenship='" + textCitizenship.Text + "', Religion='" + textReligion.Text + "', Contact='" + textContactNumber.Text + "', Email='" + textEmail.Text + "', SchoolName='" + textSchoolName.Text + "', DegreeProgram = '" + textDegree.Text + "', DepartmentName='" + textDepartment.Text + "', YearLevel = '" + textYearLevel.Text + "', MotherFirst='" + textMotherFirst.Text + "', MotherMiddle='" + textMotherMiddle.Text + "', MotherLast='" + textMotherLast.Text + "', MotherCitizenship='" + textMotherCitizenship.Text + "', MotherReligion='" + textMotherReligion.Text + "', MotherOccupation='" + textMotherOccupation.Text + "', MotherContact='" + textMotherContactNumber.Text + "', FatherFirst = '" + textFatherFirst.Text + "', FatherMiddle = '" + textFatherMiddle.Text + "', FatherLast='" + textFatherLast.Text + "', FatherCitizenship='" + textFatherCitizenship.Text + "', FatherReligion='" + textFatherReligion.Text + "', FatherOccupation='" + textFatherOccupation.Text + "', FatherContact='" + textFatherContactNumber.Text + "', GuardianFirst='" + textGuardianFirst.Text + "', GuardianMiddle='" + textGuardianMiddle.Text + "', GuardianLast='" + textGuardianLast.Text + "', GuardianCitizenship='" + textGuardianCitizenship.Text + "', GuardianReligion='" + textGuardianReligion.Text + "', GuardianOccupation='" + textGuardianOccupation.Text + "', GuardianContact='" + textGuardianContactNumber.Text + "' WHERE FirstName = '" + FirstName + "' AND MiddleName = '" + MiddleName + "' AND LastName = '" + LastName + "' AND Sex = '" + Sex + "' AND BirthMonth = '" + BirthMonth + "' AND Birthday = '" + BirthDay + "' AND BirthYear = '" + BirthYear + "' AND AddProvince = '" + Province + "'AND AddCity = '" + City + "' AND AddBarangay='" + Barangay + "' AND Citizenship='" + Citizenship + "' AND Religion='" + Religion + "' AND Contact='" + Contact + "' AND Email='" + Email + "' AND SchoolName='" + SchoolName + "' AND DegreeProgram = '" + DegreeProgram + "' AND DepartmentName='" + DepartmentName + "' AND YearLevel = '" + YearLevel + "' AND MotherFirst='" + MotherFirst + "' AND MotherMiddle='" + MotherMiddle + "' AND MotherLast='" + MotherLast + "' AND MotherCitizenship='" + MotherCitizenship + "' AND MotherReligion='" + MotherReligion + "' AND MotherOccupation='" + MotherOccupation + "' AND MotherContact='" + MotherContact + "' AND FatherFirst = '" + FatherFirst + "' AND FatherMiddle = '" + FatherMiddle + "' AND FatherLast='" + FatherLast + "' AND FatherCitizenship='" + FatherCitizenship + "' AND FatherReligion='" + FatherReligion + "' AND FatherOccupation='" + FatherOccupation + "' AND FatherContact='" + FatherContact + "' AND GuardianFirst='" + GuardianFirst + "' AND GuardianMiddle='" + GuardianMiddle + "' AND GuardianLast='" + GuardianLast + "' AND GuardianCitizenship='" + GuardianCitizenship + "' AND GuardianReligion='" + GuardianReligion + "' AND GuardianOccupation='" + GuardianOccupation + "' AND GuardianContact='" + GuardianContact + "'", con);
            //string sql = "UPDATE StudentInformation SET FirstName = '" + textFirst.Text + "', MiddleName = '" + textMiddle.Text + "', LastName = '" + textLast.Text + "', Sex = '" + comboSex.Text + "', BirthMonth = '" + comboMonth.Text + "', Birthday = '" + comboDay.Text + "', BirthYear = '" + comboYear.Text + "' , AddProvince = '" + textProvince.Text + "', AddCity = '" + textCity.Text + "', AddBarangay='" + textBarangay.Text + "', Citizenship='" + textCitizenship.Text + "', Religion='" + textReligion.Text + "', Contact='" + textContactNumber.Text + "', Email='" + textEmail.Text + "', SchoolName='" + textSchoolName.Text + "', DegreeProgram = '" + textDegree.Text + "', DepartmentName='" + textDepartment.Text + "', YearLevel = '" + textYearLevel.Text + "', MotherFirst='" + textMotherFirst.Text + "', MotherMiddle='" + textMotherMiddle.Text + "', MotherLast='" + textMotherLast.Text + "', MotherCitizenship='" + textMotherCitizenship.Text + "', MotherReligion='" + textMotherReligion.Text + "', MotherOccupation='" + textMotherOccupation.Text + "', MotherContact='" + textMotherContactNumber.Text + "', FatherFirst = '" + textFatherFirst.Text + "', FatherMiddle = '" + textFatherMiddle.Text + "', FatherLast='" + textFatherLast.Text + "', FatherCitizenship='" + textFatherCitizenship.Text + "', FatherReligion='" + textFatherReligion.Text + "', FatherOccupation='" + textFatherOccupation.Text + "', FatherContact='" + textFatherContactNumber.Text + "', GuardianFirst='" + textGuardianFirst.Text + "', GuardianMiddle='" + textGuardianMiddle.Text + "', GuardianLast='" + textGuardianLast.Text + "', GuardianCitizenship='" + textGuardianCitizenship.Text + "', GuardianReligion='" + textGuardianReligion.Text + "', GuardianOccupation='" + textGuardianOccupation.Text + "', GuardianContact='" + textGuardianContactNumber.Text + "' WHERE FirstName = '" + FirstName + "' AND MiddleName = '" + MiddleName + "' AND LastName = '" + LastName + "' AND Sex = '" + Sex + "' AND BirthMonth = '" + BirthMonth + "' AND Birthday = '" + BirthDay + "' AND BirthYear = '" + BirthYear + "' AND AddProvince = '" + Province + "'AND AddCity = '" + City + "' AND AddBarangay='" + Barangay + "' AND Citizenship='" + Citizenship + "' AND Religion='" + Religion + "' AND Contact='" + Contact + "' AND Email='" + Email + "' AND SchoolName='" + SchoolName + "' AND DegreeProgram = '" + DegreeProgram + "' AND DepartmentName='" + DepartmentName + "' AND YearLevel = '" + YearLevel + "' AND MotherFirst='" + MotherFirst + "' AND MotherMiddle='" + MotherMiddle + "' AND MotherLast='" + MotherLast + "' AND MotherCitizenship='" + MotherCitizenship + "' AND MotherReligion='" + MotherReligion + "' AND MotherOccupation='" + MotherOccupation + "' AND MotherContact='" + MotherContact + "' AND FatherFirst = '" + FatherFirst + "' AND FatherMiddle = '" + FatherMiddle + "' AND FatherLast='" + FatherLast + "' AND FatherCitizenship='" + FatherCitizenship + "' AND FatherReligion='" + FatherReligion + "' AND FatherOccupation='" + FatherOccupation + "' AND FatherContact='" + FatherContact + "' AND GuardianFirst='" + GuardianFirst + "' AND GuardianMiddle='" + GuardianMiddle + "' AND GuardianLast='" + GuardianLast + "' AND GuardianCitizenship='" + GuardianCitizenship + "' AND GuardianReligion='" + GuardianReligion + "' AND GuardianOccupation='" + GuardianOccupation + "' AND GuardianContact='" + GuardianContact + "'";

            int result = cmd.ExecuteNonQuery();


            /*SqlCommand cmd = new SqlCommand("SELECT LastName, FirstName, MiddleName, DegreeProgram, DepartmentName FROM StudentInformation", con);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
             */

            if(result > 0)
            {
                Close();
                Form2 f2 = new Form2();
                f2.Show();
                MessageBox.Show("UPDATED SUCCESSFULLY!");

            }
            else
            {
                Close();
                Form2 f2 = new Form2();
                f2.Show();
                MessageBox.Show("UNABLE TO SAVE CHANGES.");
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
            checkBox1.Checked = false;
            textFirst.Text = Form2.FirstName;
            textMiddle.Text = Form2.MiddleName;
            textLast.Text = Form2.LastName;
            comboSex.Text = Form2.Sex;
            comboMonth.Text = Form2.BirthMonth;
            comboDay.Text = Form2.BirthDay;
            comboYear.Text = Form2.BirthYear;
            textProvince.Text = Form2.Province;
            textCity.Text = Form2.City;
            textBarangay.Text = Form2.Barangay;
            textCitizenship.Text = Form2.Citizenship;
            textReligion.Text = Form2.Religion;
            textContactNumber.Text = Form2.Contact;
            textEmail.Text = Form2.Email;
            textSchoolName.Text = Form2.SchoolName;
            textDegree.Text = Form2.DegreeProgram;
            textDepartment.Text = Form2.DepartmentName;
            textYearLevel.Text = Form2.YearLevel;
            textMotherFirst.Text = Form2.MotherFirst;
            textMotherMiddle.Text = Form2.MotherMiddle;
            textMotherLast.Text = Form2.MotherLast;
            textMotherCitizenship.Text = Form2.MotherCitizenship;
            textMotherReligion.Text = Form2.MotherReligion;
            textMotherOccupation.Text = Form2.MotherOccupation;
            textMotherContactNumber.Text = Form2.MotherContact;
            textFatherFirst.Text = Form2.FatherFirst;
            textFatherMiddle.Text = Form2.FatherMiddle;
            textFatherLast.Text = Form2.FatherLast;
            textFatherCitizenship.Text = Form2.FatherCitizenship;
            textFatherReligion.Text = Form2.FatherReligion;
            textFatherOccupation.Text = Form2.FatherOccupation;
            textFatherContactNumber.Text = Form2.FatherContact;
            textGuardianFirst.Text = Form2.GuardianFirst;
            textGuardianMiddle.Text = Form2.GuardianMiddle;
            textGuardianLast.Text = Form2.GuardianLast;
            textGuardianCitizenship.Text = Form2.GuardianCitizenship;
            textGuardianReligion.Text = Form2.GuardianReligion;
            textGuardianOccupation.Text = Form2.GuardianOccupation;
            textGuardianContactNumber.Text = Form2.GuardianContact;
        }

        private void textFirst_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
