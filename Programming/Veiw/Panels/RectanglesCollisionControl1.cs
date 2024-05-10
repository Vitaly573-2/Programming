using Programming.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Programming.Veiw.Panels
{
    public partial class RectanglesCollisionControl1 : UserControl
    {
        private List<Rectangle> _rectangle = new List<Rectangle>();
        private Rectangle _currentRectangles = new Rectangle();

        private List<Panel> _rectanglePanels = new List<Panel>();

        public RectanglesCollisionControl1()
        {
            InitializeComponent();
        }

        private void PaneltextBox5_TextChanged(object sender, EventArgs e)
        {
            if (_currentRectangles != null)
            {
                try
                {
                    if (int.TryParse(PaneltextBox5.Text, out int newLength))
                    {
                        _currentRectangles.Length = newLength;
                        PaneltextBox5.BackColor = ColorTranslator.FromHtml("White");
                        UpdateListBox();
                        UpdateCanvasPanel(_currentRectangles);
                        FindCollisions();
                    }
                    else
                    {
                        PaneltextBox5.BackColor = ColorTranslator.FromHtml("#FFB6C1");
                    }
                }
                catch (Exception)
                {
                    PaneltextBox5.BackColor = ColorTranslator.FromHtml("#FFB6C1");
                }
            }
        }

        private void PaneltextBox4_TextChanged(object sender, EventArgs e)
        {
            if (_currentRectangles != null)
            {
                try
                {
                    if (int.TryParse(PaneltextBox4.Text, out int newWidth))
                    {
                        _currentRectangles.Width = newWidth;
                        PaneltextBox4.BackColor = ColorTranslator.FromHtml("White");
                        UpdateListBox();
                        UpdateCanvasPanel(_currentRectangles);
                        FindCollisions();
                    }
                    else
                    {
                        PaneltextBox4.BackColor = ColorTranslator.FromHtml("#FFB6C1");
                    }
                }
                catch (Exception)
                {
                    PaneltextBox4.BackColor = ColorTranslator.FromHtml("#FFB6C1");
                }
            }
        }

        private void PaneltextBox3_TextChanged(object sender, EventArgs e)
        {
            if (_currentRectangles != null)
            {
                try
                {
                    if (int.TryParse(PaneltextBox3.Text, out int newY))
                    {
                        _currentRectangles.Y = newY;
                        PaneltextBox3.BackColor = ColorTranslator.FromHtml("White");
                        UpdateListBox();
                        UpdateCanvasPanel(_currentRectangles);
                        FindCollisions();
                    }
                    else
                    {
                        PaneltextBox3.BackColor = ColorTranslator.FromHtml("#FFB6C1");
                    }
                }
                catch (Exception)
                {
                    PaneltextBox3.BackColor = ColorTranslator.FromHtml("#FFB6C1");
                }
            }
        }

        private void PaneltextBox2_TextChanged(object sender, EventArgs e)
        {
            if (_currentRectangles != null)
            {
                try
                {
                    if (int.TryParse(PaneltextBox2.Text, out int newX))
                    {
                        _currentRectangles.X = newX;
                        PaneltextBox2.BackColor = ColorTranslator.FromHtml("White");
                        UpdateListBox();
                        UpdateCanvasPanel(_currentRectangles);
                        FindCollisions();

                    }
                    else
                    {
                        PaneltextBox2.BackColor = ColorTranslator.FromHtml("#FFB6C1");
                    }
                }
                catch (Exception)
                {
                    PaneltextBox2.BackColor = ColorTranslator.FromHtml("#FFB6C1");
                }
            }
        }

        private void UpdateCanvasPanel(Rectangle rectangle)
        {
            int index = _rectangle.IndexOf(rectangle);
            if (index >= 0 && index < _rectanglePanels.Count)
            {
                Panel panel = _rectanglePanels[index];
                panel.Location = new Point(rectangle.X, rectangle.Y);
                panel.Size = new Size((int)rectangle.Width, (int)rectangle.Length);
            }
        }

        private void UpdateListBox()
        {

            if (PanellistBox1 != null)
            {
                PanellistBox1.Items.Clear();
                foreach (Rectangle rectangle in _rectangle)
                {
                    PanellistBox1.Items.Add($"Id: {rectangle.Id}, X: {rectangle.X}, Y: {rectangle.Y}, Width: {rectangle.Width}, Length: {rectangle.Length}");
                }
            }
        }

        private void PaneltextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void PanellistBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (PanellistBox1.SelectedIndex != -1)
            {
                int SelectIndex = PanellistBox1.SelectedIndex;
                _currentRectangles = _rectangle[SelectIndex];
                UpdateRectangleInfo(_currentRectangles);

            }
            else
            {
                ClearRectangleInfo();
            }
        }

        private void UpdateRectangleInfo(Rectangle rectangle)
        {
            if (rectangle != null)
            {
                PaneltextBox1.Text = rectangle.Id.ToString();
                PaneltextBox2.Text = rectangle.X.ToString();
                PaneltextBox3.Text = rectangle.Y.ToString();
                PaneltextBox4.Text = rectangle.Width.ToString();
                PaneltextBox5.Text = rectangle.Length.ToString();
            }
        }

        private void ClearRectangleInfo()
        {
            PaneltextBox1.Text = "";
            PaneltextBox2.Text = "";
            PaneltextBox3.Text = "";
            PaneltextBox4.Text = "";
            PaneltextBox5.Text = "";

            PaneltextBox1.BackColor = ColorTranslator.FromHtml("White");
            PaneltextBox2.BackColor = ColorTranslator.FromHtml("White");
            PaneltextBox3.BackColor = ColorTranslator.FromHtml("White");
            PaneltextBox4.BackColor = ColorTranslator.FromHtml("White");
            PaneltextBox5.BackColor = ColorTranslator.FromHtml("White");
        }

        private void CanvasPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Panelbutton6_Click(object sender, EventArgs e)
        {
            if (PanellistBox1.SelectedIndex != -1)
            {
                int SelectIndex = PanellistBox1.SelectedIndex;
                _rectangle.RemoveAt(SelectIndex);
                PanellistBox1.Items.RemoveAt(SelectIndex);
                CanvasPanel1.Controls.RemoveAt(SelectIndex);
                _rectanglePanels.RemoveAt(SelectIndex);
                FindCollisions();
            }
        }

        private void Panelbutton5_Click(object sender, EventArgs e)
        {
            Rectangle newRectangle = new Rectangle();
            _rectangle.Add(newRectangle);

            Panel panel = new Panel();
            panel.Location = new Point(newRectangle.X, newRectangle.Y);
            panel.Size = new Size((int)newRectangle.Width, (int)newRectangle.Length);
            panel.BackColor = System.Drawing.Color.LightGreen;
            _rectanglePanels.Add(panel);

            CanvasPanel1.Controls.Add(panel);
            FindCollisions();
            PanellistBox1.Items.Clear();


            foreach (Rectangle rectangle in _rectangle)
            {
                PanellistBox1.Items.Add($"Id: {rectangle.Id}, X: {rectangle.X}, Y: {rectangle.Y}, Width: {rectangle.Width}, Length: {rectangle.Length}");
            }
        }

        private void FindCollisions()
        {
            foreach (Panel panel in _rectanglePanels)
            {
                panel.BackColor = System.Drawing.Color.LightGreen;
            }

            // Перебор всех прямоугольников
            for (int i = 0; i < _rectangle.Count; i++)
            {

                for (int j = i + 1; j < _rectangle.Count; j++)
                {

                    if (CollisionManager.IsCollision(_rectangle[i], _rectangle[j]))
                    {

                        _rectanglePanels[i].BackColor = System.Drawing.Color.Red;
                        _rectanglePanels[j].BackColor = System.Drawing.Color.Red;
                    }
                    else
                    {
                        _rectanglePanels[i].BackColor = System.Drawing.Color.LightGreen;
                        _rectanglePanels[j].BackColor = System.Drawing.Color.LightGreen;
                    }
                }
            }
        }

        private void RectanglesCollisionControl1_Load(object sender, EventArgs e)
        {

        }
    }
}
