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
using ObjectOrientedPractics.Services;
using static ObjectOrientedPractics.Services.DataTools;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ObjectOrientedPractics.View.Tabs
{
    public partial class ItemsTab : UserControl
    {
        private List<Item> _items = new List<Item>();
        //private Item _currentItem;
        private List<string> ItemsListBoxItems = new List<string>();
        List<Item> _displayItems;   

        int select = -1;

        public List<Item> Items
        {
            get { return _items; }
            set { _items = value; }
        }

        public ItemsTab()
        {
            InitializeComponent();
            InitializeComboBox();
        }

        private void InitializeComboBox()
        {
            Array nums = Enum.GetValues(typeof(Category));
            foreach(Category it in nums)
            {
                CategoryComboBox1.Items.Add(it);
            }
            CategoryComboBox1.SelectedIndex = 0;
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
            CategoryComboBox1.SelectedItem = 0;
        }

        //Обновлениие записей в ListBox
        private void UpdateItemsListBox()
        {
            ItemslistBox.Items.Clear();//очищает ItemsListBox

            foreach (Item it in Items)
            {
                ItemslistBox.Items.Add($"Id:{it.Id} Cost:{it.Cost} Name:{it.Name} Description:{it.Info} Category: {it.Category}");
            }
        }

        private void UpdateSelectItemListBox()
        {
            if (select != -1)
            {
                Item selectItem = Items[select];
                //обновление по выбранному элементу в ItemsListBox
                ItemslistBox.Items[select] = $"Id:{selectItem.Id} Cost:{selectItem.Cost} " +
                    $"Name:{selectItem.Name} Description:{selectItem.Info} Category: {selectItem.Category}";
            }
        }

        private void ItemsTab_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Addbutton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(NametextBox.Text) || string.IsNullOrEmpty(DescriptiontextBox.Text) || string.IsNullOrEmpty(CosttextBox.Text))
            {
                MessageBox.Show("Заполните все поля", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Item item = new Item(NametextBox.Text, DescriptiontextBox.Text, double.Parse(CosttextBox.Text),(Category)CategoryComboBox1.SelectedItem);
            Items.Add(item);
            _displayItems = Items;//////////////////////////////    
            UpdateItemsListBox();//обновляет ItemsListBox
            ClearTextBoxes();
        }

        private void Removebutton_Click(object sender, EventArgs e)
        {
            if (ItemslistBox.SelectedIndex != -1)
            {
                Items.RemoveAt(select);
                UpdateItemsListBox();
                select = -1;
                ClearTextBoxes();
                _displayItems = Items;
            }
        }

        private void ItemslistBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ItemslistBox.SelectedIndex != -1)
            {
                select = ItemslistBox.SelectedIndex;
                Item selectedItem = _displayItems[select];

                IdtextBox.Text = selectedItem.Id.ToString();
                CosttextBox.Text = selectedItem.Cost.ToString();
                NametextBox.Text = selectedItem.Name.ToString();
                DescriptiontextBox.Text = selectedItem.Info.ToString();
                CategoryComboBox1.SelectedItem = selectedItem.Category;
            }
        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

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
                    Items[select].Info = DescriptiontextBox.Text;
                    UpdateSelectItemListBox();
                }
            }
        }

        private void label2_Click_2(object sender, EventArgs e)
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
                        Items[select].Cost = cost;
                        UpdateSelectItemListBox();
                    }
                }
            }
        }

        private void label6_Click_2(object sender, EventArgs e)
        {

        }

        private void IdtextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click_2(object sender, EventArgs e)
        {

        }

        private void label3_Click_2(object sender, EventArgs e)
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
                    Items[select].Name = NametextBox.Text;
                    UpdateSelectItemListBox();
                }
            }
        }

        private void label4_Click_2(object sender, EventArgs e)
        {

        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void CategoryComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (select != -1)
            {
                Items[select].Category = (Category)CategoryComboBox1.SelectedIndex;
                UpdateSelectItemListBox();
            }
        }

        private bool FindSubstringString(Item item)
        {
            if(item.Name.IndexOf(FindSubstringTextBox.Text) != -1)
                return true;
            return false;
        }


        private void FindSubstringTextBox_TextChanged(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(FindSubstringTextBox.Text))
            {
                _displayItems = Items; // Возвращаем все элементы, если текст пуст
                UpdateItemsListBox();
                return;
            }

            List<Item> filteredItems = DataTools.Filter(Items, FindSubstringString);

            ItemslistBox.Items.Clear();
            foreach (var item in _displayItems)
            {
                ItemslistBox.Items.Add($"{item.Id} {item.Name}");
            }
        }


    }
}
