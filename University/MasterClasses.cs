using System;
using System.Collections;
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
    public partial class MasterClasses : Form
    {
        string id;
        Master master;
        Node<Master> masterNode;
        List<Course> lessons;
        public MasterClasses(string id)
        {
            InitializeComponent();
            this.id = id;
            masterNode = Manager.SearchMaster(id);
            if (masterNode != null)
            {
                master = masterNode.info;
                lessons = master.lessons;
                master_name.Text = master.firstName + " " + master.lastName;
            }
        }

        private void MasterClasses_Load(object sender, EventArgs e)
        {
            update();
        }
        public void update()
        {
            dataGridView1.ColumnCount = 4;
            dataGridView1.Columns[0].Name = "ردیف";
            dataGridView1.Columns[1].Name = "اسم درس";
            dataGridView1.Columns[2].Name = "تاریخ امتحان";
            dataGridView1.Columns[3].Name = "تعداد دانشجو";
           
            if (lessons == null)
            {
                lessons = new List<Course>();
            }
            for (int i = 0; i < lessons.Count; i++)
            {
                ArrayList row = new ArrayList();
                row.Add((i+1).ToString());
                row.Add(lessons[i].name.ToString());
                row.Add(lessons[i].examTime.ToString());
                row.Add(lessons[i].students.Count.ToString());
                dataGridView1.Rows.Add(row.ToArray());
            }
        }
        private void btn_search_stds_Click(object sender, EventArgs e)
        {

        }
    }
}
