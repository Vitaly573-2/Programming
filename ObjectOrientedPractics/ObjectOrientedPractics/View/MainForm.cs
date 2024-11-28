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
            ordersTab1.Customers = store.Customers;
            //создали событие itemsTab1.ItemsChanged 
            itemsTab1.ItemsChanged += ItemsChanged;

        }

        private void ItemsChanged(object sender, EventArgs e)
        {
            cartsTab1.RefreshData();
            cartsTab1.RefreshData();
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
            if (tabControl1.SelectedIndex == 2)
            {
                cartsTab1.RefreshData();
            }
            else if (tabControl1.SelectedIndex == 3)
            {
                ordersTab1.UpdateOrdersTab();
                
            }
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void ordersTab6_Load(object sender, EventArgs e)
        {

        }
    }
}
