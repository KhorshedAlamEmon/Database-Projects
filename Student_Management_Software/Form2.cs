using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Student_Manahement_Software
{
    public partial class Form2 : Form
    {
        SqlConnection dbms = new SqlConnection(@" Data Source=LAPTOP-JD6ROHJ5;Initial Catalog=studentmanagement;Integrated Security=True");

        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            dbms.Open();
            SqlCommand dbms1 = new SqlCommand("INSERT INTO student_management VALUES('"+textBox1.Text+"', '"+textBox2.Text+"', '"+textBox3.Text+ "','" + textBox4.Text + "', '" + textBox5.Text + "','" + textBox6.Text +  "')", dbms);
            dbms1.ExecuteNonQuery();
            
            MessageBox.Show("Data Inserted");
            dbms.Close(); 
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dbms.Open();
            SqlCommand dbms1 = new SqlCommand("UPDATE student_management SET student_name= '" + textBox1.Text + "', semester= '" + textBox3.Text + "', cgpa= '" + textBox4.Text + "', program= '" + textBox5.Text + "', department='" + textBox6.Text + "' WHERE student_id= '" + textBox2.Text + "'", dbms);
            dbms1.ExecuteNonQuery();
            MessageBox.Show("Data Updated");
           
            dbms.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            dbms.Open();
            SqlCommand dbms1 = new SqlCommand("DELETE student_management WHERE student_id = '"+textBox2.Text+"'", dbms);
            dbms1.ExecuteNonQuery();
            MessageBox.Show("DATA DELETED");
            dbms.Close();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'studentmanagementDataSet.student_management' table. You can move, or remove it, as needed.
            this.student_managementTableAdapter.Fill(this.studentmanagementDataSet.student_management);
            label1.BackColor = Color.Transparent;
            label2.BackColor = Color.Transparent;
            label3.BackColor = Color.Transparent;
            label4.BackColor = Color.Transparent;
            label5.BackColor = Color.Transparent;
            label6.BackColor = Color.Transparent;
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void student_managementBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.student_managementBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.studentmanagementDataSet);

        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {

        }

        public void student_managementDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Update();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Show();
        }
    }
}
