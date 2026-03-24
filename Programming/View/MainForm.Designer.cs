namespace Programming
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabPageEnums = new System.Windows.Forms.TabPage();
            this.SeasonHandleGroupBox = new System.Windows.Forms.GroupBox();
            this.SeasonLabel = new System.Windows.Forms.Label();
            this.SeasonGoButton = new System.Windows.Forms.Button();
            this.SeasonComboBox = new System.Windows.Forms.ComboBox();
            this.WeekdayParsingGroupBox = new System.Windows.Forms.GroupBox();
            this.parseResultTextBox = new System.Windows.Forms.TextBox();
            this.ParseLabel = new System.Windows.Forms.Label();
            this.ParsButton = new System.Windows.Forms.Button();
            this.parsingTextBox = new System.Windows.Forms.TextBox();
            this.EnumarationGroupBox = new System.Windows.Forms.GroupBox();
            this.ValuesTextBoxLabel = new System.Windows.Forms.Label();
            this.ValuesListBoxLabel = new System.Windows.Forms.Label();
            this.EnumsListBoxLabel = new System.Windows.Forms.Label();
            this.ValueTextBox = new System.Windows.Forms.TextBox();
            this.ValuesListBox = new System.Windows.Forms.ListBox();
            this.EnumsListBox = new System.Windows.Forms.ListBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageClasses = new System.Windows.Forms.TabPage();
            this.RectGroupBox = new System.Windows.Forms.GroupBox();
            this.FindRectangleButton = new System.Windows.Forms.Button();
            this.ColorLabel = new System.Windows.Forms.Label();
            this.WidthLabel = new System.Windows.Forms.Label();
            this.LenghtLabel = new System.Windows.Forms.Label();
            this.ColorTextBox = new System.Windows.Forms.TextBox();
            this.WidthTextBox = new System.Windows.Forms.TextBox();
            this.LenghtTextBox = new System.Windows.Forms.TextBox();
            this.RectangleListBox = new System.Windows.Forms.ListBox();
            this.tabPageEnums.SuspendLayout();
            this.SeasonHandleGroupBox.SuspendLayout();
            this.WeekdayParsingGroupBox.SuspendLayout();
            this.EnumarationGroupBox.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPageClasses.SuspendLayout();
            this.RectGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPageEnums
            // 
            this.tabPageEnums.Controls.Add(this.SeasonHandleGroupBox);
            this.tabPageEnums.Controls.Add(this.WeekdayParsingGroupBox);
            this.tabPageEnums.Controls.Add(this.EnumarationGroupBox);
            this.tabPageEnums.Location = new System.Drawing.Point(4, 25);
            this.tabPageEnums.Name = "tabPageEnums";
            this.tabPageEnums.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageEnums.Size = new System.Drawing.Size(1174, 594);
            this.tabPageEnums.TabIndex = 0;
            this.tabPageEnums.Text = "Enums";
            this.tabPageEnums.UseVisualStyleBackColor = true;
            // 
            // SeasonHandleGroupBox
            // 
            this.SeasonHandleGroupBox.Controls.Add(this.SeasonLabel);
            this.SeasonHandleGroupBox.Controls.Add(this.SeasonGoButton);
            this.SeasonHandleGroupBox.Controls.Add(this.SeasonComboBox);
            this.SeasonHandleGroupBox.Location = new System.Drawing.Point(581, 390);
            this.SeasonHandleGroupBox.Name = "SeasonHandleGroupBox";
            this.SeasonHandleGroupBox.Size = new System.Drawing.Size(576, 195);
            this.SeasonHandleGroupBox.TabIndex = 8;
            this.SeasonHandleGroupBox.TabStop = false;
            this.SeasonHandleGroupBox.Text = "Season Handle";
            // 
            // SeasonLabel
            // 
            this.SeasonLabel.AutoSize = true;
            this.SeasonLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SeasonLabel.Location = new System.Drawing.Point(17, 53);
            this.SeasonLabel.Name = "SeasonLabel";
            this.SeasonLabel.Size = new System.Drawing.Size(130, 20);
            this.SeasonLabel.TabIndex = 2;
            this.SeasonLabel.Text = "Choose season:";
            // 
            // SeasonGoButton
            // 
            this.SeasonGoButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SeasonGoButton.Location = new System.Drawing.Point(317, 73);
            this.SeasonGoButton.Name = "SeasonGoButton";
            this.SeasonGoButton.Size = new System.Drawing.Size(90, 30);
            this.SeasonGoButton.TabIndex = 1;
            this.SeasonGoButton.Text = "Go!";
            this.SeasonGoButton.UseVisualStyleBackColor = true;
            this.SeasonGoButton.Click += new System.EventHandler(this.SeasonGoButton_Click);
            // 
            // SeasonComboBox
            // 
            this.SeasonComboBox.FormattingEnabled = true;
            this.SeasonComboBox.Items.AddRange(new object[] {
            "Winter",
            "Spring",
            "Summer",
            "Autumn"});
            this.SeasonComboBox.Location = new System.Drawing.Point(21, 78);
            this.SeasonComboBox.Name = "SeasonComboBox";
            this.SeasonComboBox.Size = new System.Drawing.Size(274, 24);
            this.SeasonComboBox.TabIndex = 0;
            // 
            // WeekdayParsingGroupBox
            // 
            this.WeekdayParsingGroupBox.Controls.Add(this.parseResultTextBox);
            this.WeekdayParsingGroupBox.Controls.Add(this.ParseLabel);
            this.WeekdayParsingGroupBox.Controls.Add(this.ParsButton);
            this.WeekdayParsingGroupBox.Controls.Add(this.parsingTextBox);
            this.WeekdayParsingGroupBox.Location = new System.Drawing.Point(8, 390);
            this.WeekdayParsingGroupBox.Name = "WeekdayParsingGroupBox";
            this.WeekdayParsingGroupBox.Size = new System.Drawing.Size(551, 196);
            this.WeekdayParsingGroupBox.TabIndex = 7;
            this.WeekdayParsingGroupBox.TabStop = false;
            this.WeekdayParsingGroupBox.Text = "Weekday Parsing";
            // 
            // parseResultTextBox
            // 
            this.parseResultTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.parseResultTextBox.Location = new System.Drawing.Point(22, 114);
            this.parseResultTextBox.Name = "parseResultTextBox";
            this.parseResultTextBox.ReadOnly = true;
            this.parseResultTextBox.Size = new System.Drawing.Size(299, 27);
            this.parseResultTextBox.TabIndex = 3;
            // 
            // ParseLabel
            // 
            this.ParseLabel.AutoSize = true;
            this.ParseLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ParseLabel.Location = new System.Drawing.Point(18, 53);
            this.ParseLabel.Name = "ParseLabel";
            this.ParseLabel.Size = new System.Drawing.Size(179, 20);
            this.ParseLabel.TabIndex = 2;
            this.ParseLabel.Text = "Type value for parsing:";
            // 
            // ParsButton
            // 
            this.ParsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ParsButton.Location = new System.Drawing.Point(338, 73);
            this.ParsButton.Name = "ParsButton";
            this.ParsButton.Size = new System.Drawing.Size(117, 29);
            this.ParsButton.TabIndex = 1;
            this.ParsButton.Text = "Parse";
            this.ParsButton.UseVisualStyleBackColor = true;
            this.ParsButton.Click += new System.EventHandler(this.ParsButton_Click);
            // 
            // parsingTextBox
            // 
            this.parsingTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.parsingTextBox.Location = new System.Drawing.Point(22, 76);
            this.parsingTextBox.Name = "parsingTextBox";
            this.parsingTextBox.Size = new System.Drawing.Size(299, 24);
            this.parsingTextBox.TabIndex = 0;
            // 
            // EnumarationGroupBox
            // 
            this.EnumarationGroupBox.Controls.Add(this.ValuesTextBoxLabel);
            this.EnumarationGroupBox.Controls.Add(this.ValuesListBoxLabel);
            this.EnumarationGroupBox.Controls.Add(this.EnumsListBoxLabel);
            this.EnumarationGroupBox.Controls.Add(this.ValueTextBox);
            this.EnumarationGroupBox.Controls.Add(this.ValuesListBox);
            this.EnumarationGroupBox.Controls.Add(this.EnumsListBox);
            this.EnumarationGroupBox.Location = new System.Drawing.Point(8, 6);
            this.EnumarationGroupBox.Name = "EnumarationGroupBox";
            this.EnumarationGroupBox.Size = new System.Drawing.Size(1150, 368);
            this.EnumarationGroupBox.TabIndex = 6;
            this.EnumarationGroupBox.TabStop = false;
            this.EnumarationGroupBox.Text = "Enumaration";
            // 
            // ValuesTextBoxLabel
            // 
            this.ValuesTextBoxLabel.AutoSize = true;
            this.ValuesTextBoxLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ValuesTextBoxLabel.Location = new System.Drawing.Point(623, 33);
            this.ValuesTextBoxLabel.Name = "ValuesTextBoxLabel";
            this.ValuesTextBoxLabel.Size = new System.Drawing.Size(76, 20);
            this.ValuesTextBoxLabel.TabIndex = 5;
            this.ValuesTextBoxLabel.Text = "Int value:";
            // 
            // ValuesListBoxLabel
            // 
            this.ValuesListBoxLabel.AutoSize = true;
            this.ValuesListBoxLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ValuesListBoxLabel.Location = new System.Drawing.Point(317, 33);
            this.ValuesListBoxLabel.Name = "ValuesListBoxLabel";
            this.ValuesListBoxLabel.Size = new System.Drawing.Size(115, 20);
            this.ValuesListBoxLabel.TabIndex = 4;
            this.ValuesListBoxLabel.Text = "Choose value:";
            // 
            // EnumsListBoxLabel
            // 
            this.EnumsListBoxLabel.AutoSize = true;
            this.EnumsListBoxLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EnumsListBoxLabel.Location = new System.Drawing.Point(12, 33);
            this.EnumsListBoxLabel.Name = "EnumsListBoxLabel";
            this.EnumsListBoxLabel.Size = new System.Drawing.Size(168, 20);
            this.EnumsListBoxLabel.TabIndex = 3;
            this.EnumsListBoxLabel.Text = "Choose enumaration:";
            // 
            // ValueTextBox
            // 
            this.ValueTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ValueTextBox.Location = new System.Drawing.Point(627, 60);
            this.ValueTextBox.Name = "ValueTextBox";
            this.ValueTextBox.Size = new System.Drawing.Size(200, 27);
            this.ValueTextBox.TabIndex = 2;
            // 
            // ValuesListBox
            // 
            this.ValuesListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ValuesListBox.FormattingEnabled = true;
            this.ValuesListBox.ItemHeight = 20;
            this.ValuesListBox.Location = new System.Drawing.Point(321, 60);
            this.ValuesListBox.Name = "ValuesListBox";
            this.ValuesListBox.Size = new System.Drawing.Size(232, 284);
            this.ValuesListBox.TabIndex = 1;
            this.ValuesListBox.SelectedIndexChanged += new System.EventHandler(this.ValuesListBox_SelectedIndexChanged);
            // 
            // EnumsListBox
            // 
            this.EnumsListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EnumsListBox.FormattingEnabled = true;
            this.EnumsListBox.ItemHeight = 20;
            this.EnumsListBox.Location = new System.Drawing.Point(16, 60);
            this.EnumsListBox.Name = "EnumsListBox";
            this.EnumsListBox.Size = new System.Drawing.Size(232, 284);
            this.EnumsListBox.TabIndex = 0;
            this.EnumsListBox.SelectedIndexChanged += new System.EventHandler(this.EnumsListBox_SelectedIndexChanged);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageEnums);
            this.tabControl1.Controls.Add(this.tabPageClasses);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1182, 623);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPageClasses
            // 
            this.tabPageClasses.Controls.Add(this.RectGroupBox);
            this.tabPageClasses.Location = new System.Drawing.Point(4, 25);
            this.tabPageClasses.Name = "tabPageClasses";
            this.tabPageClasses.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageClasses.Size = new System.Drawing.Size(1174, 594);
            this.tabPageClasses.TabIndex = 1;
            this.tabPageClasses.Text = "Classes";
            this.tabPageClasses.UseVisualStyleBackColor = true;
            // 
            // RectGroupBox
            // 
            this.RectGroupBox.Controls.Add(this.FindRectangleButton);
            this.RectGroupBox.Controls.Add(this.ColorLabel);
            this.RectGroupBox.Controls.Add(this.WidthLabel);
            this.RectGroupBox.Controls.Add(this.LenghtLabel);
            this.RectGroupBox.Controls.Add(this.ColorTextBox);
            this.RectGroupBox.Controls.Add(this.WidthTextBox);
            this.RectGroupBox.Controls.Add(this.LenghtTextBox);
            this.RectGroupBox.Controls.Add(this.RectangleListBox);
            this.RectGroupBox.Location = new System.Drawing.Point(22, 34);
            this.RectGroupBox.Name = "RectGroupBox";
            this.RectGroupBox.Size = new System.Drawing.Size(451, 299);
            this.RectGroupBox.TabIndex = 8;
            this.RectGroupBox.TabStop = false;
            this.RectGroupBox.Text = "Rectangles";
            // 
            // FindRectangleButton
            // 
            this.FindRectangleButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FindRectangleButton.Location = new System.Drawing.Point(300, 234);
            this.FindRectangleButton.Name = "FindRectangleButton";
            this.FindRectangleButton.Size = new System.Drawing.Size(120, 36);
            this.FindRectangleButton.TabIndex = 7;
            this.FindRectangleButton.Text = "Find";
            this.FindRectangleButton.UseVisualStyleBackColor = true;
            this.FindRectangleButton.Click += new System.EventHandler(this.FindRectangleButton_Click);
            // 
            // ColorLabel
            // 
            this.ColorLabel.AutoSize = true;
            this.ColorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ColorLabel.Location = new System.Drawing.Point(297, 147);
            this.ColorLabel.Name = "ColorLabel";
            this.ColorLabel.Size = new System.Drawing.Size(49, 18);
            this.ColorLabel.TabIndex = 6;
            this.ColorLabel.Text = "Color:";
            // 
            // WidthLabel
            // 
            this.WidthLabel.AutoSize = true;
            this.WidthLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.WidthLabel.Location = new System.Drawing.Point(297, 89);
            this.WidthLabel.Name = "WidthLabel";
            this.WidthLabel.Size = new System.Drawing.Size(50, 18);
            this.WidthLabel.TabIndex = 5;
            this.WidthLabel.Text = "Width:";
            // 
            // LenghtLabel
            // 
            this.LenghtLabel.AutoSize = true;
            this.LenghtLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LenghtLabel.Location = new System.Drawing.Point(297, 26);
            this.LenghtLabel.Name = "LenghtLabel";
            this.LenghtLabel.Size = new System.Drawing.Size(56, 18);
            this.LenghtLabel.TabIndex = 4;
            this.LenghtLabel.Text = "Lenght:";
            // 
            // ColorTextBox
            // 
            this.ColorTextBox.Location = new System.Drawing.Point(300, 168);
            this.ColorTextBox.Name = "ColorTextBox";
            this.ColorTextBox.Size = new System.Drawing.Size(120, 22);
            this.ColorTextBox.TabIndex = 3;
            this.ColorTextBox.TextChanged += new System.EventHandler(this.ColorTextBox_TextChanged);
            // 
            // WidthTextBox
            // 
            this.WidthTextBox.Location = new System.Drawing.Point(300, 108);
            this.WidthTextBox.Name = "WidthTextBox";
            this.WidthTextBox.Size = new System.Drawing.Size(120, 22);
            this.WidthTextBox.TabIndex = 2;
            this.WidthTextBox.TextChanged += new System.EventHandler(this.WidthTextBox_TextChanged);
            // 
            // LenghtTextBox
            // 
            this.LenghtTextBox.Location = new System.Drawing.Point(300, 47);
            this.LenghtTextBox.Name = "LenghtTextBox";
            this.LenghtTextBox.Size = new System.Drawing.Size(120, 22);
            this.LenghtTextBox.TabIndex = 1;
            this.LenghtTextBox.TextChanged += new System.EventHandler(this.LenghtTextBox_TextChanged);
            // 
            // RectangleListBox
            // 
            this.RectangleListBox.FormattingEnabled = true;
            this.RectangleListBox.ItemHeight = 16;
            this.RectangleListBox.Location = new System.Drawing.Point(18, 26);
            this.RectangleListBox.Name = "RectangleListBox";
            this.RectangleListBox.Size = new System.Drawing.Size(230, 244);
            this.RectangleListBox.TabIndex = 0;
            this.RectangleListBox.SelectedIndexChanged += new System.EventHandler(this.RectangleListBox_SelectedIndexChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 623);
            this.Controls.Add(this.tabControl1);
            this.Name = "MainForm";
            this.Text = "Programming Demo";
            this.tabPageEnums.ResumeLayout(false);
            this.SeasonHandleGroupBox.ResumeLayout(false);
            this.SeasonHandleGroupBox.PerformLayout();
            this.WeekdayParsingGroupBox.ResumeLayout(false);
            this.WeekdayParsingGroupBox.PerformLayout();
            this.EnumarationGroupBox.ResumeLayout(false);
            this.EnumarationGroupBox.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPageClasses.ResumeLayout(false);
            this.RectGroupBox.ResumeLayout(false);
            this.RectGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabPage tabPageEnums;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.ListBox EnumsListBox;
        private System.Windows.Forms.TextBox ValueTextBox;
        private System.Windows.Forms.ListBox ValuesListBox;
        private System.Windows.Forms.Label ValuesListBoxLabel;
        private System.Windows.Forms.Label EnumsListBoxLabel;
        private System.Windows.Forms.Label ValuesTextBoxLabel;
        private System.Windows.Forms.GroupBox EnumarationGroupBox;
        private System.Windows.Forms.GroupBox WeekdayParsingGroupBox;
        private System.Windows.Forms.Label ParseLabel;
        private System.Windows.Forms.Button ParsButton;
        private System.Windows.Forms.TextBox parsingTextBox;
        private System.Windows.Forms.TextBox parseResultTextBox;
        private System.Windows.Forms.GroupBox SeasonHandleGroupBox;
        private System.Windows.Forms.Label SeasonLabel;
        private System.Windows.Forms.Button SeasonGoButton;
        private System.Windows.Forms.ComboBox SeasonComboBox;
        private System.Windows.Forms.TabPage tabPageClasses;
        private System.Windows.Forms.TextBox ColorTextBox;
        private System.Windows.Forms.TextBox WidthTextBox;
        private System.Windows.Forms.TextBox LenghtTextBox;
        private System.Windows.Forms.ListBox RectangleListBox;
        private System.Windows.Forms.Label ColorLabel;
        private System.Windows.Forms.Label WidthLabel;
        private System.Windows.Forms.Label LenghtLabel;
        private System.Windows.Forms.GroupBox RectGroupBox;
        private System.Windows.Forms.Button FindRectangleButton;
    }
}

