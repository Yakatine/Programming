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
    public partial class EnumerationsControl : UserControl
    {
        public EnumerationsControl()
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
    }
}
