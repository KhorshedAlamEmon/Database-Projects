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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void transportation_eventsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.transportation_eventsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.database1DataSet);

        }

        private void Form4_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database1DataSet.transportation_events' table. You can move, or remove it, as needed.
            this.transportation_eventsTableAdapter.Fill(this.database1DataSet.transportation_events);

        }
    }
}
