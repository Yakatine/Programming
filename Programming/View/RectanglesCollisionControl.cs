using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Programming
{
    public partial class RectanglesCollisionControl : UserControl
    {
        public RectanglesCollisionControl()
        {
            InitializeComponent();
            InitializeRectangles();
        }

        private List<Model.Geometry.Rectangle> _rectanglesList;
        private Model.Geometry.Rectangle _selectedRectangle;
        private List<Panel> _rectanglePanels;
        private void InitializeRectangles()
        {
            _rectanglesList = new List<Model.Geometry.Rectangle>();
            _rectanglePanels = new List<Panel>();

            for (int i = 0; i < 6; i++)
            {
                AddRandomRectangle();
            }

            ListBoxRectangles.SelectedIndexChanged += ListBoxRectangles_SelectedIndexChanged;
            AddButton.Click -= AddButton_Click;
            AddButton.Click += AddButton_Click;
            RemoveButton.Click += RemoveButton_Click;
            txtX.TextChanged += CoordinateTextBox_TextChanged;
            txtY.TextChanged += CoordinateTextBox_TextChanged;
            txtWidth.TextChanged += SizeTextBox_TextChanged;
            txtLenght.TextChanged += SizeTextBox_TextChanged;

            ClearRectangleInfo();
        }
        private void AddRandomRectangle()
        {
            Model.Geometry.Rectangle newRect = Model.Geometry.RectangleFactory.Randomize();
            _rectanglesList.Add(newRect);

            ListBoxRectangles.Items.Add(FormatRectangleString(newRect));

            Panel panel = new Panel
            {
                Location = new Point((int)newRect.Center.X - (int)(newRect.Width / 2), (int)newRect.Center.Y - (int)(newRect.Length / 2)),
                Width = (int)newRect.Width,
                Height = (int)newRect.Length,
                BackColor = System.Drawing.Color.FromArgb(127, 127, 255, 127),
                BorderStyle = BorderStyle.FixedSingle
            };
            CanvasPanel.Controls.Add(panel);
            _rectanglePanels.Add(panel);

            FindCollisions();
        }

        private string FormatRectangleString(Model.Geometry.Rectangle rect)
        {
            return $"{rect.Id}. (X = {rect.Center.X}; Y = {rect.Center.Y}; W = {rect.Width}; H = {rect.Length})";
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            AddRandomRectangle();
        }
        private void RemoveButton_Click(object sender, EventArgs e)
        {
            int index = ListBoxRectangles.SelectedIndex;
            if (index == -1 || _rectanglesList.Count == 0) return;

            CanvasPanel.Controls.Remove(_rectanglePanels[index]);
            _rectanglePanels.RemoveAt(index);

            _rectanglesList.RemoveAt(index);
            ListBoxRectangles.Items.RemoveAt(index);

            if (_selectedRectangle != null && _selectedRectangle == _rectanglesList.ElementAtOrDefault(index))
                _selectedRectangle = null;

            ClearRectangleInfo();
            FindCollisions();
        }

        private void ListBoxRectangles_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = ListBoxRectangles.SelectedIndex;
            if (index == -1 || _rectanglesList.Count == 0)
            {
                _selectedRectangle = null;
                ClearRectangleInfo();
                return;
            }

            _selectedRectangle = _rectanglesList[index];
            UpdateRectangleInfo(_selectedRectangle);
        }
        private void UpdateRectangleInfo(Model.Geometry.Rectangle rectangle)
        {
            if (rectangle == null) return;
            txtId.Text = rectangle.Id.ToString();
            txtX.Text = rectangle.Center.X.ToString();
            txtY.Text = rectangle.Center.Y.ToString();
            txtWidth.Text = rectangle.Width.ToString();
            txtLenght.Text = rectangle.Length.ToString();

            txtX.BackColor = SystemColors.Window;
            txtY.BackColor = SystemColors.Window;
            txtWidth.BackColor = SystemColors.Window;
            txtLenght.BackColor = SystemColors.Window;
        }

        private void ClearRectangleInfo()
        {
            txtId.Text = "";
            txtX.Text = "";
            txtY.Text = "";
            txtWidth.Text = "";
            txtLenght.Text = "";
        }
        private void CoordinateTextBox_TextChanged(object sender, EventArgs e)
        {
            if (_selectedRectangle == null) return;
            System.Windows.Forms.TextBox tb = sender as System.Windows.Forms.TextBox;
            try
            {
                double newValue = double.Parse(tb.Text);
                if (tb == txtX)
                {
                    _selectedRectangle.SetCenter(newValue, _selectedRectangle.Center.Y);
                }
                else if (tb == txtY)
                {
                    _selectedRectangle.SetCenter(_selectedRectangle.Center.X, newValue);
                }

                UpdatePanelForRectangle(_selectedRectangle);
                UpdateListBoxItem(_selectedRectangle);
                FindCollisions();
                tb.BackColor = SystemColors.Window;
            }
            catch (Exception)
            {
                tb.BackColor = System.Drawing.Color.LightPink;
            }
        }

        private void SizeTextBox_TextChanged(object sender, EventArgs e)
        {
            if (_selectedRectangle == null) return;
            System.Windows.Forms.TextBox tb = sender as System.Windows.Forms.TextBox;
            try
            {
                double newValue = double.Parse(tb.Text);
                if (tb == txtWidth)
                    _selectedRectangle.Width = newValue;
                else if (tb == txtLenght)
                    _selectedRectangle.Length = newValue;

                UpdatePanelForRectangle(_selectedRectangle);
                UpdateListBoxItem(_selectedRectangle);
                FindCollisions();
                tb.BackColor = SystemColors.Window;
            }
            catch (Exception)
            {
                tb.BackColor = System.Drawing.Color.LightPink;
            }
        }
        private void UpdatePanelForRectangle(Model.Geometry.Rectangle rect)
        {
            int index = _rectanglesList.IndexOf(rect);
            if (index == -1) return;
            Panel panel = _rectanglePanels[index];
            panel.Location = new Point((int)rect.Center.X - (int)(rect.Width / 2), (int)rect.Center.Y - (int)(rect.Length / 2));
            panel.Width = (int)rect.Width;
            panel.Height = (int)rect.Length;
        }

        private void UpdateListBoxItem(Model.Geometry.Rectangle rect)
        {
            int index = _rectanglesList.IndexOf(rect);
            if (index != -1)
                ListBoxRectangles.Items[index] = FormatRectangleString(rect);
        }
        private void FindCollisions()
        {
            for (int i = 0; i < _rectanglePanels.Count; i++)
            {
                _rectanglePanels[i].BackColor = System.Drawing.Color.FromArgb(127, 127, 255, 127);
            }

            for (int i = 0; i < _rectanglesList.Count; i++)
            {
                for (int j = i + 1; j < _rectanglesList.Count; j++)
                {
                    if (Model.CollisionManager.IsCollision(_rectanglesList[i], _rectanglesList[j]))
                    {
                        _rectanglePanels[i].BackColor = System.Drawing.Color.FromArgb(127, 255, 127, 127);
                        _rectanglePanels[j].BackColor = System.Drawing.Color.FromArgb(127, 255, 127, 127);
                    }
                }
            }
        }

    }
}
