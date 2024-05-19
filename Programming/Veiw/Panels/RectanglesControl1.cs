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
    public partial class RectanglesControl1 : UserControl
    {
        /// <summary>
        /// Список прямоугольников.
        /// </summary>
        private Rectangle[] _rectangles = new Rectangle[5];

        /// <summary>
        /// Текущий выбранный прямоугольник.
        /// </summary>
        private Rectangle _currentRectangle;

        /// <summary>
        /// Список прямоугольников дял ListBox.
        /// </summary>
        private string[] ListBoxRectangle = new string[5];

        /// <summary>
        /// Список цветов.
        /// </summary>
        private string[] Color = new string[5] { "Pink", "Green", "Black", "Blue", "Red" };
        Random random = new Random();

        /// <summary>
        /// Обработчик события добавления нового прямоугольника..
        /// </summary>
        private void RectangelsInitialize()
        {
            for (int i = 0; i < ListBoxRectangle.Length; i++)
            {
                int length = random.Next(200);
                int width = random.Next(200);
                double x = random.Next(200);
                double y = random.Next(200);
                double centrX = x + width / 2;
                double centrY = y + length / 2;

                Point2D center = new Point2D(centrX, centrY);
                _rectangles[i] = new Rectangle(length, width, Color[i], center);
                ListBoxRectangle[i] = ($"Rectangle {i + 1}");
            }
            EnumslistBox4.Items.AddRange(ListBoxRectangle);
        }

        /// <summary>
        /// Инициализирует новый экземпляр класса.
        /// </summary>
        public RectanglesControl1()
        {
            InitializeComponent();
            RectangelsInitialize();
        }

        private void RectanglesControl1_Load(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void idtextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void CenterYtextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void CenterXtextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Обновление TextBox прямоугольников.
        /// </summary>
        private void button3_Click(object sender, EventArgs e)
        {
            int MaxIndex = FindRectangleWithMaxWidth(_rectangles);
            _currentRectangle = _rectangles[MaxIndex];
            LengthtextBox1.Text = _currentRectangle.Length.ToString();
            WidthtextBox2.Text = _currentRectangle.Width.ToString();
            ColortextBox3.Text = _currentRectangle.Color;
        }

        private void label8_Click(object sender, EventArgs e)   
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Обработчик события изменения текста в текстовом поле для цвета прямоугольника.
        /// </summary>
        private void ColortextBox3_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (_currentRectangle != null)
                {
                    string newColor = ColortextBox3.Text;
                    if (Color.Contains(newColor))
                    {
                        _currentRectangle.Color = newColor;
                        ColortextBox3.BackColor = ColorTranslator.FromHtml("White");
                    }
                    else
                    {
                        ColortextBox3.BackColor = ColorTranslator.FromHtml("#FFB6C1");
                    }
                }
            }
            catch (Exception)
            {
                ColortextBox3.BackColor = ColorTranslator.FromHtml("#FFB6C1");
            }
        }

        /// <summary>
        /// Обработчик события для нахождения прямоугольника с большей шириной.
        /// </summary>
        private int FindRectangleWithMaxWidth(Rectangle[] _rectangles)
        {
            int MaxIndex = 0;
            double MaxWidth = _rectangles[0].Width;
            for (int i = 0; i < _rectangles.Length; i++)
            {
                if (_rectangles[i].Width > MaxWidth)
                {
                    MaxIndex = i;
                    MaxWidth = _rectangles[i].Width;
                }
            }
            return MaxIndex;
        }

        /// <summary>
        /// Обработчик события изменения текста в текстовом поле для ширины прямоугольника.
        /// </summary>
        private void WidthtextBox2_TextChanged(object sender, EventArgs e)
        {
            if (_currentRectangle != null)
            {
                try
                {
                    if (double.TryParse(WidthtextBox2.Text, out double newWidth))
                    {
                        _currentRectangle.Width = newWidth;
                        WidthtextBox2.BackColor = ColorTranslator.FromHtml("White");
                    }
                    else
                    {
                        WidthtextBox2.BackColor = ColorTranslator.FromHtml("#FFB6C1");
                    }
                }
                catch (Exception)
                {
                    WidthtextBox2.BackColor = ColorTranslator.FromHtml("#FFB6C1");
                }
            }
        }

        /// <summary>
        /// Обработчик события изменения текста в текстовом поле для длины прямоугольника.
        /// </summary>
        private void LengthtextBox1_TextChanged(object sender, EventArgs e)
        {
            if (_currentRectangle != null)
            {
                try
                {
                    if (double.TryParse(LengthtextBox1.Text, out double newLength))
                    {
                        _currentRectangle.Length = newLength;
                        LengthtextBox1.BackColor = ColorTranslator.FromHtml("White");
                    }
                    else
                    {
                        LengthtextBox1.BackColor = ColorTranslator.FromHtml("#FFB6C1");
                    }
                }
                catch (Exception)
                {
                    LengthtextBox1.BackColor = ColorTranslator.FromHtml("#FFB6C1");
                }
            }
        }

        /// <summary>
        /// Добавление параметров в TextBox по индексу.
        /// </summary>
        private void EnumslistBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            int SelectIndex = EnumslistBox4.SelectedIndex;
            _currentRectangle = _rectangles[SelectIndex];
            LengthtextBox1.Text = _currentRectangle.Length.ToString();
            WidthtextBox2.Text = _currentRectangle.Width.ToString();
            ColortextBox3.Text = _currentRectangle.Color;
            CenterXtextBox1.Text = _currentRectangle.Center.X.ToString();
            CenterYtextBox1.Text = _currentRectangle.Center.Y.ToString();
            idtextBox1.Text = _currentRectangle.Id.ToString();
        }
    }
}
