using Programming.Model.Classes;
using Programming.Model.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Programming
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            LoadEnums();
            InitializeData();
        }

        private void LoadEnums()
        {
            var enumTypes = new Type[]
            {
                typeof(Weekday),
                typeof(Genre),
                typeof(Model.Enums.Color),
                typeof(EducationForm),
                typeof(Manufactures),
                typeof(Season)
            };
            EnumsListBox.DataSource = enumTypes;

            EnumsListBox.DisplayMember = "Name";

            if (EnumsListBox.Items.Count > 0)
                EnumsListBox.SelectedIndex = 0;
        }

        private void EnumsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedEnumType = EnumsListBox.SelectedItem as Type;

            if (selectedEnumType != null)
            {
                Array enumValues = Enum.GetValues(selectedEnumType);
                ValuesListBox.DataSource = enumValues;
            }
        }

        private void ValuesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ValuesListBox.SelectedItem == null) return;

            int intValue = (int)ValuesListBox.SelectedItem;
            ValueTextBox.Text = intValue.ToString();
        }

        private void ParsButton_Click(object sender, EventArgs e)
        {
            string userInput = parsingTextBox.Text;
            if (Enum.TryParse(userInput, true, out Weekday result))
            {
                parseResultTextBox.Text = $"Это день недели ({result} = {(int)result})";
            }
            else
            {
                parseResultTextBox.Text = "Нет такого дня недели";
            }
        }

        private void SeasonGoButton_Click(object sender, EventArgs e)
        {
            if (SeasonComboBox.SelectedItem == null) return;
            string selectedText = SeasonComboBox.SelectedItem.ToString();
            Season selectSeason = (Season)Enum.Parse(typeof(Season), selectedText);
            switch (selectSeason)
            {
                case Season.Winter:
                    MessageBox.Show("Бррр! Холодно!");
                    break;
                case Season.Spring:
                    this.BackColor = System.Drawing.Color.Green;
                    break;
                case Season.Summer:
                    MessageBox.Show("Ура! Солнце!");
                    break;
                case Season.Autumn:
                    this.BackColor = System.Drawing.Color.Orange;
                    break;
            }
        }
        /// <summary>
        /// Lab 3
        /// </summary>

        private Model.Classes.Rectangle[] _rectangles;
        private Model.Classes.Rectangle _currentRectangle;
        private void InitializeData()
        {
            Random rand = new Random();
            string[] colors = { "Red", "Blue", "Green", "Yellow", "Orange", "Pink" };
            _rectangles = new Model.Classes.Rectangle[5];
            for (int i = 0; i < _rectangles.Length; i++)
            {
                _rectangles[i] = new Model.Classes.Rectangle(rand.Next(1, 101), rand.Next(1, 101), colors[rand.Next(colors.Length)]);
            }
            for (int i = 0; i < _rectangles.Length; i++)
            {
                RectangleListBox.Items.Add($"Rectangle {i + 1}");
            }
        }
        private void RectangleListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = RectangleListBox.SelectedIndex;
            if (index == -1) return;
            _currentRectangle = _rectangles[index];
            UpdateRectangleFields();
        }
        private bool _isUpdating = false;

        private void UpdateRectangleFields()
        {
            if (_currentRectangle == null) return;
            _isUpdating = true;
            LenghtTextBox.Text = _currentRectangle.Length.ToString();
            WidthTextBox.Text = _currentRectangle.Width.ToString();
            ColorTextBox.Text = _currentRectangle.Color;
            _isUpdating = false;
        }
        private void LenghtTextBox_TextChanged(object sender, EventArgs e)
        {
            if ( _isUpdating || _currentRectangle == null) return;
            try
            {
                double value = double.Parse(LenghtTextBox.Text);
                _currentRectangle.Length = value;
                LenghtTextBox.BackColor = System.Drawing.Color.White;
            }
            catch (Exception)
            {
                LenghtTextBox.BackColor = System.Drawing.Color.LightPink;
            }
        }

        private void WidthTextBox_TextChanged(object sender, EventArgs e)
        {
            if (_isUpdating || _currentRectangle == null) return;
            try
            {
                double value = double.Parse(WidthTextBox.Text);
                _currentRectangle.Width = value;
                WidthTextBox.BackColor = System.Drawing.Color.White;
            }
            catch (Exception)
            {
                WidthTextBox.BackColor = System.Drawing.Color.LightPink;
            }
        }

        private void ColorTextBox_TextChanged(object sender, EventArgs e)
        {
            if (_isUpdating || _currentRectangle == null) return;
            {
                _currentRectangle.Color = ColorTextBox.Text;
                ColorTextBox.BackColor = System.Drawing.Color.White;
            }
        }
        private void FindRectangleButton_Click(object sender, EventArgs e)
        {

        }
    }
}
