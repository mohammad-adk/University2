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
    public partial class PassedCoursesListPanel : Form
    {
        List<Course> lessons;
        string id;
        public PassedCoursesListPanel(string id)
        {
            InitializeComponent();
            this.id = id;
            if (Manager.SearchStudent(id) != null)
            {
                Student std = Manager.SearchStudent(id).info;
                label1.Text = std.firstName + " " + std.lastName;
                lessons = std.choosenLessons;
            }
        }

        private void PassedCoursesListPanel_Load(object sender, EventArgs e)
        {
            update();
        }
        public void update()
        {

            if(lessons == null)
            {
                lessons = new List<Course>();
            }
            dataGridView2.ColumnCount = 3; 
            dataGridView2.Columns[0].Name = "اسم درس";
            dataGridView2.Columns[1].Name = "نمره گرفته شده";
            dataGridView2.Columns[2].Name = "استاد";

        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            StudentPanel studentPanelPanel = new StudentPanel(id);
            studentPanelPanel.Show();
            this.Hide();

        }
    }
}
