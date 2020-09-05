using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student_Manahement_Software
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void student_managementBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.student_managementBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.studentmanagementDataSet);

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'studentmanagementDataSet.student_management' table. You can move, or remove it, as needed.
            this.student_managementTableAdapter.Fill(this.studentmanagementDataSet.student_management);

        }
    }
}
