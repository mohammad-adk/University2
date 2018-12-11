using System;
using System.Windows.Forms;

namespace University
{
    public partial class ChooseCourse : Form
    {
        string id;
        public ChooseCourse(string id)
        {
            this.id = id;
            InitializeComponent();
        }

        private void btn_ok_Click(object sender, EventArgs e)
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
