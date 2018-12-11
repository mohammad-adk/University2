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
    public partial class TeacherPanel : Form
    {
        string id;
        public TeacherPanel(string id)
        {
            this.id = id;
            InitializeComponent();
            Node<Master> node = Manager.SearchMaster(id);
            if(node != null)
            {
                teachername.Text = node.info.firstName + " " + node.info.lastName;
                labelTeacherId.Text = node.info.id.ToString();
            }

        }

        private void btn_back2_Click(object sender, EventArgs e)
        {
            EnterPage enterPagePanel = new EnterPage();
            enterPagePanel.Show();
            this.Hide();
        }

        private void btn_change_password_Click(object sender, EventArgs e)
        {
            ChangePasswordMaster changePasswordPanel = new ChangePasswordMaster(id);
            changePasswordPanel.Show();
            this.Hide();
        }

        private void btn_set_grades_Click(object sender, EventArgs e)
        {

        }

        private void btn_get_classes_list_Click(object sender, EventArgs e)
        {

        }
    }
}
