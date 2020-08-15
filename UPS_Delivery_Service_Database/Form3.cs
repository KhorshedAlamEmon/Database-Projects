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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void retail_CenterBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.retail_CenterBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.database1DataSet);

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database1DataSet.Retail_Center' table. You can move, or remove it, as needed.
            this.retail_CenterTableAdapter.Fill(this.database1DataSet.Retail_Center);

        }
    }
}
