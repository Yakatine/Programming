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
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.EnumarationGroupBox = new System.Windows.Forms.GroupBox();
            this.ValuesTextBoxLabel = new System.Windows.Forms.Label();
            this.ValuesListBoxLabel = new System.Windows.Forms.Label();
            this.EnumsListBoxLabel = new System.Windows.Forms.Label();
            this.ValueTextBox = new System.Windows.Forms.TextBox();
            this.ValuesListBox = new System.Windows.Forms.ListBox();
            this.EnumsListBox = new System.Windows.Forms.ListBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.WeekdayParsingGroupBox = new System.Windows.Forms.GroupBox();
            this.parsingTextBox = new System.Windows.Forms.TextBox();
            this.ParsButton = new System.Windows.Forms.Button();
            this.ParseLabel = new System.Windows.Forms.Label();
            this.parseResultTextBox = new System.Windows.Forms.TextBox();
            this.SeasonHandleGroupBox = new System.Windows.Forms.GroupBox();
            this.SeasonComboBox = new System.Windows.Forms.ComboBox();
            this.SeasonGoButton = new System.Windows.Forms.Button();
            this.SeasonLabel = new System.Windows.Forms.Label();
            this.tabPage1.SuspendLayout();
            this.EnumarationGroupBox.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.WeekdayParsingGroupBox.SuspendLayout();
            this.SeasonHandleGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.SeasonHandleGroupBox);
            this.tabPage1.Controls.Add(this.WeekdayParsingGroupBox);
            this.tabPage1.Controls.Add(this.EnumarationGroupBox);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1174, 594);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Enums";
            this.tabPage1.UseVisualStyleBackColor = true;
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
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1182, 623);
            this.tabControl1.TabIndex = 0;
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
            // parsingTextBox
            // 
            this.parsingTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.parsingTextBox.Location = new System.Drawing.Point(22, 76);
            this.parsingTextBox.Name = "parsingTextBox";
            this.parsingTextBox.Size = new System.Drawing.Size(299, 24);
            this.parsingTextBox.TabIndex = 0;
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
            // parseResultTextBox
            // 
            this.parseResultTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.parseResultTextBox.Location = new System.Drawing.Point(22, 114);
            this.parseResultTextBox.Name = "parseResultTextBox";
            this.parseResultTextBox.ReadOnly = true;
            this.parseResultTextBox.Size = new System.Drawing.Size(299, 27);
            this.parseResultTextBox.TabIndex = 3;
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
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 623);
            this.Controls.Add(this.tabControl1);
            this.Name = "MainForm";
            this.Text = "Programming Demo";
            this.tabPage1.ResumeLayout(false);
            this.EnumarationGroupBox.ResumeLayout(false);
            this.EnumarationGroupBox.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.WeekdayParsingGroupBox.ResumeLayout(false);
            this.WeekdayParsingGroupBox.PerformLayout();
            this.SeasonHandleGroupBox.ResumeLayout(false);
            this.SeasonHandleGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabPage tabPage1;
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
    }
}

