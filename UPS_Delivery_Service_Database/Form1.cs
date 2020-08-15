using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UPS_Delivery_Service_Database
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void shipped_itemsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.shipped_itemsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.database1DataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database1DataSet.transportation_events' table. You can move, or remove it, as needed.
            this.transportation_eventsTableAdapter.Fill(this.database1DataSet.transportation_events);
            // TODO: This line of code loads data into the 'database1DataSet.Retail_Center' table. You can move, or remove it, as needed.
            this.retail_CenterTableAdapter.Fill(this.database1DataSet.Retail_Center);
            // TODO: This line of code loads data into the 'database1DataSet.shipped_items' table. You can move, or remove it, as needed.
            this.shipped_itemsTableAdapter.Fill(this.database1DataSet.shipped_items);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form4 transport = new Form4();
            transport.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 ship = new Form2();
            ship.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 retail = new Form3();
            retail.Show();
        }
    }
}
