using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UniversityClasses;

namespace University
{
    public partial class ManagerPanel : Form
    {
        EnterPage enterPagePanel = new EnterPage();
        RemoveManagerPanel removeManagerPanel;
        RemoveMasterPanel removeMasterPanel;
        string id;
        Manager mng;
        public ManagerPanel(string id)
        {
            Console.WriteLine("panel");
            this.id = id;
            removeManagerPanel = new RemoveManagerPanel(id);
            removeMasterPanel = new RemoveMasterPanel(id);
            InitializeComponent();
            if (id != "")
            {
               
                mng = Manager.SearchManager(id).info;
                if (mng != null)
                {
                    managername.Text = mng.firstName + " " + mng.lastName;
                    managerid.Text = mng.id.ToString();
                }
            }
        }
        private void btn_change_password_Click(object sender, EventArgs e)
        {
            ChangePassword changePasswordPanel = new ChangePassword(id);
            changePasswordPanel.setId(id);
            changePasswordPanel.Show();
            this.Hide();
        }

        private void btn_control_unit_choose_Click(object sender, EventArgs e)
        {

        }

        private void btn_back1_Click(object sender, EventArgs e)
        {
            enterPagePanel.Show();
            this.Hide();
        }

        private void btn_sign_up_master_Click(object sender, EventArgs e)
        {
            SignUpMasterPanel addMasterPanelPanel = new SignUpMasterPanel(id);
            addMasterPanelPanel.Show();
            this.Hide();
        }

  

        private void btn_sign_up_student_Click(object sender, EventArgs e)
        {
            SignUpStudentPanel signupStudentPanel = new SignUpStudentPanel(id);
            signupStudentPanel.Show();
            this.Hide();
        }

        private void btn_sign_up_manager_Click(object sender, EventArgs e)
        {
            SignUpManagerPanel signUpManagerPanel = new SignUpManagerPanel(id);
            signUpManagerPanel.Show();
            this.Hide();
        }

        private void btn_remove_student_Click(object sender, EventArgs e)
        {
            RemovingStudentPanel removeStudentPanel = new RemovingStudentPanel(id);
            removeStudentPanel.Show();
            this.Hide();
        }

        private void btn_remove_manager_Click(object sender, EventArgs e)
        {
            removeManagerPanel.Show();
            this.Close();
        }

        private void btn_remove_student_term_Click(object sender, EventArgs e)
        {
            RemoveStudentSemesterPanel removeStudentSemesterPanel = new RemoveStudentSemesterPanel(id);
            removeStudentSemesterPanel.Show();
            this.Hide();
        }

        private void btn_remove_master_Click(object sender, EventArgs e)
        {
            removeMasterPanel.Show();
            this.Hide();
        }

        private void ManagerPanel_Load(object sender, EventArgs e)
        {

        }

        private void btn_add_course_Click(object sender, EventArgs e)
        {
            AddCoursePanel addCoursePanel = new AddCoursePanel(id);
            addCoursePanel.Show();
            this.Hide();
        }

        private void btn_control_add_remove_course_Click(object sender, EventArgs e)
        {
            ControlerPanel controlerPanel = new ControlerPanel(id);
            controlerPanel.Show();
            this.Hide();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            mng.EndingSemester();

        }
    }
}
