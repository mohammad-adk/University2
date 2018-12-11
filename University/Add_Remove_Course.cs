using System;
using System.Windows.Forms;
using UniversityClasses;
namespace University
{
    public partial class Add_Remove_Course : Form
    {
         string id;
        public Add_Remove_Course(string id)
        {
            this.id = id;
            InitializeComponent();
        }

        private void btn_back38_Click(object sender, EventArgs e)
        {
            StudentPanel studentPanel = new StudentPanel(id);
            studentPanel.Show();
            this.Hide();
        }

        private void btn_remove_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                errorProvider1.SetError(textBox1, "کد درسی وارد نشده است");
            }
            // else if (Manager.SearchStudent(id).info.choosenLessons.Contains()) {
            //Have to search if there is that code in Student chosen Code 

          

          //  }
        }
        private void btn_add_Click(object sender, EventArgs e)
        {
      
        }
     

    }
}
