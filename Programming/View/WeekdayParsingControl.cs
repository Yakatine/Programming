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

namespace Programming.View
{
    public partial class WeekdayParsingControl : UserControl
    {
        public WeekdayParsingControl()
        {
            InitializeComponent();
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
    }
}
