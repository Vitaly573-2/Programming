using ObjectOrientedPractics.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ObjectOrientedPractics
{
    public partial class MainForm : Form
    {
        Store store; 

        public MainForm()
        {
            InitializeComponent();
            store = new Store();


            itemsTab2.Items = store.Items;
            customersTab1.Customers = store.Customers;

            cartsTab1.Items = store.Items;
            cartsTab1.Customers = store.Customers;
            

        }

        private void customersTab1_Load(object sender, EventArgs e)
        {

        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void cartsTab1_Load(object sender, EventArgs e)
        {

        }

        private void itemsTab2_Load(object sender, EventArgs e)
        {

        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            cartsTab1.RefreshData();
        }
    }
}
