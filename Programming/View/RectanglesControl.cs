using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Programming.View
{
    public partial class RectanglesControl : UserControl
    {
        public RectanglesControl()
        {
            InitializeComponent();
            InitializeData();
        }
        private Model.Geometry.Rectangle[] _rectangles;
        private Model.Geometry.Rectangle _currentRectangle;
        private void InitializeData()
        {
            Random rand = new Random();
            string[] colors = { "Red", "Blue", "Green", "Yellow", "Orange", "Pink" };
            _rectangles = new Model.Geometry.Rectangle[5];
            for (int i = 0; i < _rectangles.Length; i++)
            {
                _rectangles[i] = new Model.Geometry.Rectangle(rand.Next(1, 101), rand.Next(1, 101), colors[rand.Next(colors.Length)],
                    rand.Next(0, 100), rand.Next(0, 100));
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
            CenterXTextBox.Text = _currentRectangle.Center.X.ToString();
            CenterYTextBox.Text = _currentRectangle.Center.Y.ToString();
            RectangleIdTextBox.Text = _currentRectangle.Id.ToString();
        }
        private bool _isUpdating = false;

        private void UpdateRectangleFields()
        {
            if (_currentRectangle == null) return;
            _isUpdating = true;
            LenghtTextBox.Text = _currentRectangle.Length.ToString();
            WidthTextBox.Text = _currentRectangle.Width.ToString();
            ColorTextBox.Text = _currentRectangle.Color;

            LenghtTextBox.BackColor = System.Drawing.Color.White;
            WidthTextBox.BackColor = System.Drawing.Color.White;
            ColorTextBox.BackColor = System.Drawing.Color.White;
            _isUpdating = false;
        }
        private void LenghtTextBox_TextChanged(object sender, EventArgs e)
        {
            if (_isUpdating || _currentRectangle == null) return;
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
            int index = FindRectangleWithMaxWidth(_rectangles);
            RectangleListBox.SelectedIndex = index;
        }
        private int FindRectangleWithMaxWidth(Model.Geometry.Rectangle[] rectangles)
        {
            if (rectangles == null || rectangles.Length == 0) return -1;
            int maxIndex = 0;
            double maxWidth = rectangles[0].Width;
            for (int i = 1; i < rectangles.Length; i++)
            {
                if (rectangles[i].Width > maxWidth)
                {
                    maxWidth = rectangles[i].Width;
                    maxIndex = i;
                }
            }
            return maxIndex;
        }
    }
}
