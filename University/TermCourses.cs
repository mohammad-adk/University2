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
    public partial class TermCourses : Form
    {
        string id;
        public TermCourses(string id)
        {
             InitializeComponent();
            this.id = id;
            Node<Student> node = Manager.SearchStudent(id);
            if(node != null)
            {
                label1.Text = node.info.firstName + " " + node.info.lastName;
            }




        }

        private void TermCourses_Load(object sender, EventArgs e)
        {
            update();
        }
        public void update()
        {






        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            StudentPanel studentPanelPanel = new StudentPanel(id);
            studentPanelPanel.Show();
            this.Hide();

        }

   
    }
}
