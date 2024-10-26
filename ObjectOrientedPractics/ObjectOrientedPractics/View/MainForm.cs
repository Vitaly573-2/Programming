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
        Store _store;

        public MainForm()
        {
            InitializeComponent();
            _store = new Store();

            itemsTab1.Items = _store.Items;
            customersTab1.Customers = _store.Customers;
        }

        private void customersTab1_Load(object sender, EventArgs e)
        {

        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }
    }
}
