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
    public partial class SeasonsHandleControl : UserControl
    {
        public SeasonsHandleControl()
        {
            InitializeComponent();
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
                    MessageBox.Show("Еее, цветочки");
                    break;
                case Season.Summer:
                    MessageBox.Show("Ура! Солнце!");
                    break;
                case Season.Autumn:
                    MessageBox.Show("Брр, дождь");
                    break;
            }
        }
    }
}
