using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dreamron_College
{
    public partial class ReportMethods : Form
    {
        public ReportMethods()
        {
            InitializeComponent();
        }
        DailyAttendenceReport attendence = new DailyAttendenceReport() { TopLevel = false, TopMost = true };
        SalaryReport salary = new SalaryReport() { TopLevel = false, TopMost = true };
        RegistartionReport registartion = new RegistartionReport() { TopLevel = false, TopMost = true };
        MonthlyLeaveReport leave = new MonthlyLeaveReport() { TopLevel = false, TopMost = true };
        MonthlyStudentPaymentReport payment = new MonthlyStudentPaymentReport() { TopLevel = false, TopMost = true };
        MonthlyCoursePaymentReport crspay =  new MonthlyCoursePaymentReport() { TopLevel = false, TopMost = true };

        private void clsoe_forms()
        {
            attendence.Hide();
            salary.Hide();
            registartion.Hide();
            leave.Hide();
            payment.Hide();
            crspay.Hide();


        }
        private void btn_go_home_Click(object sender, EventArgs e)
        {
            clsoe_forms();
            ManagerMenu managermenu = new ManagerMenu();
            managermenu.Show();
            this.Hide();
        }

        private void btn_monthly_sal_Click(object sender, EventArgs e)
        {
            clsoe_forms();
            salary.FormBorderStyle = FormBorderStyle.None;
            this.panel.Controls.Add(salary);
            salary.Show();
        }

        private void btn_anual_registartion_Click(object sender, EventArgs e)
        {
            clsoe_forms();
            registartion.FormBorderStyle = FormBorderStyle.None;
            this.panel.Controls.Add(registartion);
            registartion.Show();
        }

        private void btn_monthly_leave_Click(object sender, EventArgs e)
        {
            clsoe_forms();
            leave.FormBorderStyle = FormBorderStyle.None;
            this.panel.Controls.Add(leave);
            leave.Show();
        }

        private void btn_anual_emp_reg_Click(object sender, EventArgs e)
        {
            clsoe_forms();
            //resignation.FormBorderStyle = FormBorderStyle.None;
            //this.panel.Controls.Add(resignation);
            //resignation.Show();
        }

        private void btn_monthly_student_payment_Click(object sender, EventArgs e)
        {
            clsoe_forms();
            payment.FormBorderStyle = FormBorderStyle.None;
            this.panel.Controls.Add(payment);
            payment.Show();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            clsoe_forms();
            crspay.FormBorderStyle = FormBorderStyle.None;
            this.panel.Controls.Add(crspay);
            crspay.Show();
        }
    }
}
