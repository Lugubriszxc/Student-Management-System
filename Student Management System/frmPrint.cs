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
using Dapper;
using Microsoft.Reporting.WinForms;

namespace Student_Management_System
{
    public partial class frmPrint : Form
    {
        public string studentID = "";
        StudInfo _studinfo;
        List<StudInfo> _list;
        public frmPrint(StudInfo studinfo, List<StudInfo> list)
        {
            InitializeComponent();
            _studinfo = studinfo;
            _list = list;
        }

        private void frmPrint_Load(object sender, EventArgs e)
        {
            studentID = Form2.StudentID.ToString();
            school m = new school();
            SqlConnection con = new SqlConnection("Data Source=LAPTOP-K946DC8Q\\SQLEXPRESS;Initial Catalog=DBLOGIN;Integrated Security=True");
            SqlDataAdapter da = new SqlDataAdapter("SELECT StudInfo.StudentID, Grades.Subject, Grades.Unit, Grades.Instructor, Grades.Grade, Grades.GWA FROM StudInfo INNER JOIN Grades ON StudInfo.StudentID = Grades.StudentID WHERE StudInfo.StudentID = '" + studentID + "'", con);
            da.Fill(m, m.Tables[0].TableName);

            ReportDataSource rds = new ReportDataSource("studinfo", m.Tables[0]);
            this.reportViewer.LocalReport.DataSources.Clear();
            this.reportViewer.LocalReport.DataSources.Add(rds);
            this.reportViewer.LocalReport.Refresh();

            Microsoft.Reporting.WinForms.ReportParameter[] p = new Microsoft.Reporting.WinForms.ReportParameter[]
            {
                new Microsoft.Reporting.WinForms.ReportParameter("pStudentID", _studinfo.StudentID.ToString()),
                new Microsoft.Reporting.WinForms.ReportParameter("pName", _studinfo.Name.ToString()),
                new Microsoft.Reporting.WinForms.ReportParameter("pAddress", _studinfo.Address.ToString()),
                new Microsoft.Reporting.WinForms.ReportParameter("pSection", _studinfo.section.ToString()),
                new Microsoft.Reporting.WinForms.ReportParameter("pDateIssued", DateTime.Now.ToString("MM/dd/yyyy")),
                new Microsoft.Reporting.WinForms.ReportParameter("pTimeIssued", DateTime.Now.ToString("hh:mm:ss tt")),
                new Microsoft.Reporting.WinForms.ReportParameter("pDepartment", _studinfo.DepartmentName.ToString()),
                new Microsoft.Reporting.WinForms.ReportParameter("pCourse", _studinfo.DegreeProgram.ToString()),
                new Microsoft.Reporting.WinForms.ReportParameter("pYearLevel", _studinfo.YearLevel.ToString()),
                new Microsoft.Reporting.WinForms.ReportParameter("pSemester", _studinfo.Semester.ToString()),
                new Microsoft.Reporting.WinForms.ReportParameter("pTotalUnit", _studinfo.TotalUnit.ToString()),
                new Microsoft.Reporting.WinForms.ReportParameter("pGWA", _studinfo.GWA.ToString()),

            };
            this.reportViewer.LocalReport.ReportPath = "../../rptStudInfo.rdlc";
            this.reportViewer.LocalReport.SetParameters(p);
            this.reportViewer.RefreshReport();
        }
    }
}
