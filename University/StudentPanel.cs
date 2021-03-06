﻿using System;
using System.Windows.Forms;
using UniversityClasses;
namespace University
{
    
    public partial class StudentPanel : Form
    {
        string id;
   
        public StudentPanel(string id)
        {
            InitializeComponent();
            this.id = id;
            Node<Student> node = Manager.SearchStudent(id);
            if ( node!= null)
            {
                studentId.Text = node.info.id.ToString();
                studentName.Text = node.info.firstName + " " + node.info.lastName;

            }


          
        }
         
        private void button1_Click(object sender, EventArgs e)
        {
       
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            EnterPage enterPagePanel = new EnterPage();
            enterPagePanel.Show();
            this.Hide();
        }

        private void btn_editPassword_Click(object sender, EventArgs e)
        {
            ChangePasswordStudent changePasswordPanel = new ChangePasswordStudent(id);
            changePasswordPanel.Show();
            this.Hide();
        }

        private void btn_addRemove_Click(object sender, EventArgs e)
        {
        
            Add_Remove_Course add_remove_Panel = new Add_Remove_Course(id);
            add_remove_Panel.Show();
            this.Hide();
        }

        private void btn_unitChoose_Click(object sender, EventArgs e)
        {
            ChooseCourse chooseCoursePanel = new ChooseCourse(id);
            chooseCoursePanel.Show();
            this.Close();
        }

        private void btn_getResult_Click(object sender, EventArgs e)
        {
            Grades gradesPanel = new Grades(id);
            gradesPanel.Show();
            this.Close();
        }

        private void btn_passed_courses_Click(object sender, EventArgs e)
        {
            PassedCoursesListPanel passedCoursesListPanel = new PassedCoursesListPanel(id);
            passedCoursesListPanel.Show();
            this.Close();
        }

        private void btn_presentedLessons_Click(object sender, EventArgs e)
        {
            TermCourses termCourses = new TermCourses(id);
            termCourses.Show();
            this.Close();
        }
    }
}