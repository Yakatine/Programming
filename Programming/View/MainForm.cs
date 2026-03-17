using System.Windows.Forms;
using Programming.Model.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            LoadEnums();
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
    }
}
