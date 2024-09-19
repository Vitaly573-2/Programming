using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Management.Instrumentation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ObjectOrientedPractics.Model;

namespace ObjectOrientedPractics.View.Tabs
{
    public partial class ItemsTab : UserControl
    {
        List<Item> _items = new List<Item>();
        private int select = -1;

        public ItemsTab()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
            
        private void ClearTextBoxes()//очищение TextBoxes
        {
            IdtextBox.Clear();
            CosttextBox.Clear();
            NametextBox.Clear();
            DescriptiontextBox.Clear();
        }

        //Обновлениие записей в ListBox
        private void UpdateItemsListBox()
        {
            ItemslistBox.Items.Clear();//очищает ItemsListBox

            foreach (Item it in _items)
            {
                ItemslistBox.Items.Add($"Id:{it.Id} Cost:{it.Cost} Name:{it.Name} Description:{it.Info}");
            }
        }

        private void UpdateSelectItemListBox()
        {
            if(select != -1)
            {
                Item selectItem = _items[select];
                //обновление по выбранному элементу в ItemsListBox
                ItemslistBox.Items[select] = $"Id:{selectItem.Id} Cost:{selectItem.Cost} " +
                    $"Name:{selectItem.Name} Description:{selectItem.Info}";
            }
        }

        //Удаление записей в ListBox
        private void Removebutton_Click(object sender, EventArgs e)
        {
            if (ItemslistBox.SelectedIndex != -1)
            {
                int select = ItemslistBox.SelectedIndex;
                _items.RemoveAt(select);
                UpdateItemsListBox();
                ClearTextBoxes();
            }

        private void DescriptiontextBox_TextChanged(object sender, EventArgs e)
        {
            if (DescriptiontextBox.Text.Any(char.IsDigit) || DescriptiontextBox.Text.Length > 1000)
            {
                DescriptiontextBox.BackColor = Color.Pink;
            }
            else
            {
                DescriptiontextBox.BackColor = Color.White;
                if (select != -1)
                {
                    _items[select].Info = DescriptiontextBox.Text;
                    UpdateSelectItemListBox();
                }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void NametextBox_TextChanged(object sender, EventArgs e)
        {
            //метод Any - проверяет есть хотя бы один символ в строке, который является цифрой(исп. из LINQ)
            //char.IsDigit - проверяет является ли символ числом
            if (NametextBox.Text.Any(char.IsDigit) || NametextBox.Text.Length > 200)
            {
                NametextBox.BackColor = Color.Pink;
            }
            else
            {
                NametextBox.BackColor = Color.White;
                if (select != -1)
                {
                    _items[select].Name = NametextBox.Text;
                    UpdateSelectItemListBox();
                }
            }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void CosttextBox_TextChanged(object sender, EventArgs e)
        {
            if (!double.TryParse(CosttextBox.Text, out double cost))
            {
                CosttextBox.BackColor = Color.Pink;
            }
            else
            {
                if (cost < 0 || cost > 100000)
                {
                    CosttextBox.BackColor = Color.Pink;
                }
                else
                {
                    CosttextBox.BackColor = Color.White;
                    if (select != -1)
                    {
                        _items[select].Cost = cost;
                        UpdateSelectItemListBox();
                    }
                }
            }
        }

        private void IdtextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }
        }

        private void ItemsTab_Load(object sender, EventArgs e)
        {

        }
    }
}
