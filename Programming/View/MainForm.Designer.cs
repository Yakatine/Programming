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
            this.FilmsListBox = new System.Windows.Forms.ListBox();
            this.labelTitleFilm = new System.Windows.Forms.Label();
            this.TitleFilmTextBox = new System.Windows.Forms.TextBox();
            this.GenreFilmTextBox = new System.Windows.Forms.TextBox();
            this.DurationTextBox = new System.Windows.Forms.TextBox();
            this.ReleaseYearTextBox = new System.Windows.Forms.TextBox();
            this.GenreLabel = new System.Windows.Forms.Label();
            this.DurationMinutesLabel = new System.Windows.Forms.Label();
            this.ReleaseYearLabel = new System.Windows.Forms.Label();
            this.RatingTextBox = new System.Windows.Forms.TextBox();
            this.RatingLabel = new System.Windows.Forms.Label();
            this.FilmsGroupBox = new System.Windows.Forms.GroupBox();
            this.FindFilmButton = new System.Windows.Forms.Button();
            this.tabPageEnums.SuspendLayout();
            this.SeasonHandleGroupBox.SuspendLayout();
            this.WeekdayParsingGroupBox.SuspendLayout();
            this.EnumarationGroupBox.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPageClasses.SuspendLayout();
            this.RectGroupBox.SuspendLayout();
            this.FilmsGroupBox.SuspendLayout();
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
            this.tabPageClasses.Controls.Add(this.FilmsGroupBox);
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
            this.RectGroupBox.Location = new System.Drawing.Point(29, 34);
            this.RectGroupBox.Name = "RectGroupBox";
            this.RectGroupBox.Size = new System.Drawing.Size(482, 299);
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
            this.ColorTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ColorTextBox.Location = new System.Drawing.Point(300, 168);
            this.ColorTextBox.Name = "ColorTextBox";
            this.ColorTextBox.Size = new System.Drawing.Size(120, 27);
            this.ColorTextBox.TabIndex = 3;
            this.ColorTextBox.TextChanged += new System.EventHandler(this.ColorTextBox_TextChanged);
            // 
            // WidthTextBox
            // 
            this.WidthTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.WidthTextBox.Location = new System.Drawing.Point(300, 108);
            this.WidthTextBox.Name = "WidthTextBox";
            this.WidthTextBox.Size = new System.Drawing.Size(120, 27);
            this.WidthTextBox.TabIndex = 2;
            this.WidthTextBox.TextChanged += new System.EventHandler(this.WidthTextBox_TextChanged);
            // 
            // LenghtTextBox
            // 
            this.LenghtTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LenghtTextBox.Location = new System.Drawing.Point(300, 47);
            this.LenghtTextBox.Name = "LenghtTextBox";
            this.LenghtTextBox.Size = new System.Drawing.Size(120, 27);
            this.LenghtTextBox.TabIndex = 1;
            this.LenghtTextBox.TextChanged += new System.EventHandler(this.LenghtTextBox_TextChanged);
            // 
            // RectangleListBox
            // 
            this.RectangleListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RectangleListBox.FormattingEnabled = true;
            this.RectangleListBox.ItemHeight = 20;
            this.RectangleListBox.Location = new System.Drawing.Point(18, 26);
            this.RectangleListBox.Name = "RectangleListBox";
            this.RectangleListBox.Size = new System.Drawing.Size(230, 244);
            this.RectangleListBox.TabIndex = 0;
            this.RectangleListBox.SelectedIndexChanged += new System.EventHandler(this.RectangleListBox_SelectedIndexChanged);
            // 
            // FilmsListBox
            // 
            this.FilmsListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FilmsListBox.FormattingEnabled = true;
            this.FilmsListBox.ItemHeight = 20;
            this.FilmsListBox.Location = new System.Drawing.Point(29, 22);
            this.FilmsListBox.Name = "FilmsListBox";
            this.FilmsListBox.Size = new System.Drawing.Size(230, 244);
            this.FilmsListBox.TabIndex = 9;
            this.FilmsListBox.SelectedIndexChanged += new System.EventHandler(this.FilmsListBox_SelectedIndexChanged);
            // 
            // labelTitleFilm
            // 
            this.labelTitleFilm.AutoSize = true;
            this.labelTitleFilm.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTitleFilm.Location = new System.Drawing.Point(314, 22);
            this.labelTitleFilm.Name = "labelTitleFilm";
            this.labelTitleFilm.Size = new System.Drawing.Size(39, 18);
            this.labelTitleFilm.TabIndex = 10;
            this.labelTitleFilm.Text = "Title:";
            // 
            // TitleFilmTextBox
            // 
            this.TitleFilmTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TitleFilmTextBox.Location = new System.Drawing.Point(317, 43);
            this.TitleFilmTextBox.Name = "TitleFilmTextBox";
            this.TitleFilmTextBox.Size = new System.Drawing.Size(113, 27);
            this.TitleFilmTextBox.TabIndex = 11;
            this.TitleFilmTextBox.TextChanged += new System.EventHandler(this.TitleFilmTextBox_TextChanged);
            // 
            // GenreFilmTextBox
            // 
            this.GenreFilmTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GenreFilmTextBox.Location = new System.Drawing.Point(317, 104);
            this.GenreFilmTextBox.Name = "GenreFilmTextBox";
            this.GenreFilmTextBox.Size = new System.Drawing.Size(113, 27);
            this.GenreFilmTextBox.TabIndex = 12;
            this.GenreFilmTextBox.TextChanged += new System.EventHandler(this.GenreFilmTextBox_TextChanged);
            // 
            // DurationTextBox
            // 
            this.DurationTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DurationTextBox.Location = new System.Drawing.Point(317, 164);
            this.DurationTextBox.Name = "DurationTextBox";
            this.DurationTextBox.Size = new System.Drawing.Size(113, 27);
            this.DurationTextBox.TabIndex = 13;
            this.DurationTextBox.TextChanged += new System.EventHandler(this.DurationTextBox_TextChanged);
            // 
            // ReleaseYearTextBox
            // 
            this.ReleaseYearTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ReleaseYearTextBox.Location = new System.Drawing.Point(464, 43);
            this.ReleaseYearTextBox.Name = "ReleaseYearTextBox";
            this.ReleaseYearTextBox.Size = new System.Drawing.Size(113, 27);
            this.ReleaseYearTextBox.TabIndex = 14;
            this.ReleaseYearTextBox.TextChanged += new System.EventHandler(this.ReleaseYearTextBox_TextChanged);
            // 
            // GenreLabel
            // 
            this.GenreLabel.AutoSize = true;
            this.GenreLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GenreLabel.Location = new System.Drawing.Point(314, 85);
            this.GenreLabel.Name = "GenreLabel";
            this.GenreLabel.Size = new System.Drawing.Size(53, 18);
            this.GenreLabel.TabIndex = 15;
            this.GenreLabel.Text = "Genre:";
            // 
            // DurationMinutesLabel
            // 
            this.DurationMinutesLabel.AutoSize = true;
            this.DurationMinutesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DurationMinutesLabel.Location = new System.Drawing.Point(314, 143);
            this.DurationMinutesLabel.Name = "DurationMinutesLabel";
            this.DurationMinutesLabel.Size = new System.Drawing.Size(124, 18);
            this.DurationMinutesLabel.TabIndex = 16;
            this.DurationMinutesLabel.Text = "Duration minutes:";
            // 
            // ReleaseYearLabel
            // 
            this.ReleaseYearLabel.AutoSize = true;
            this.ReleaseYearLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ReleaseYearLabel.Location = new System.Drawing.Point(464, 25);
            this.ReleaseYearLabel.Name = "ReleaseYearLabel";
            this.ReleaseYearLabel.Size = new System.Drawing.Size(42, 18);
            this.ReleaseYearLabel.TabIndex = 17;
            this.ReleaseYearLabel.Text = "Year:";
            // 
            // RatingTextBox
            // 
            this.RatingTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RatingTextBox.Location = new System.Drawing.Point(464, 104);
            this.RatingTextBox.Name = "RatingTextBox";
            this.RatingTextBox.Size = new System.Drawing.Size(113, 27);
            this.RatingTextBox.TabIndex = 18;
            this.RatingTextBox.TextChanged += new System.EventHandler(this.RatingTextBox_TextChanged);
            // 
            // RatingLabel
            // 
            this.RatingLabel.AutoSize = true;
            this.RatingLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RatingLabel.Location = new System.Drawing.Point(466, 86);
            this.RatingLabel.Name = "RatingLabel";
            this.RatingLabel.Size = new System.Drawing.Size(54, 18);
            this.RatingLabel.TabIndex = 19;
            this.RatingLabel.Text = "Rating:";
            // 
            // FilmsGroupBox
            // 
            this.FilmsGroupBox.Controls.Add(this.FindFilmButton);
            this.FilmsGroupBox.Controls.Add(this.RatingLabel);
            this.FilmsGroupBox.Controls.Add(this.RatingTextBox);
            this.FilmsGroupBox.Controls.Add(this.ReleaseYearLabel);
            this.FilmsGroupBox.Controls.Add(this.DurationMinutesLabel);
            this.FilmsGroupBox.Controls.Add(this.GenreLabel);
            this.FilmsGroupBox.Controls.Add(this.ReleaseYearTextBox);
            this.FilmsGroupBox.Controls.Add(this.DurationTextBox);
            this.FilmsGroupBox.Controls.Add(this.GenreFilmTextBox);
            this.FilmsGroupBox.Controls.Add(this.TitleFilmTextBox);
            this.FilmsGroupBox.Controls.Add(this.labelTitleFilm);
            this.FilmsGroupBox.Controls.Add(this.FilmsListBox);
            this.FilmsGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FilmsGroupBox.Location = new System.Drawing.Point(540, 34);
            this.FilmsGroupBox.Name = "FilmsGroupBox";
            this.FilmsGroupBox.Size = new System.Drawing.Size(602, 299);
            this.FilmsGroupBox.TabIndex = 20;
            this.FilmsGroupBox.TabStop = false;
            this.FilmsGroupBox.Text = "Films";
            // 
            // FindFilmButton
            // 
            this.FindFilmButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FindFilmButton.Location = new System.Drawing.Point(317, 234);
            this.FindFilmButton.Name = "FindFilmButton";
            this.FindFilmButton.Size = new System.Drawing.Size(120, 32);
            this.FindFilmButton.TabIndex = 20;
            this.FindFilmButton.Text = "Find";
            this.FindFilmButton.UseVisualStyleBackColor = true;
            this.FindFilmButton.Click += new System.EventHandler(this.FindFilmButton_Click);
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
            this.FilmsGroupBox.ResumeLayout(false);
            this.FilmsGroupBox.PerformLayout();
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
        private System.Windows.Forms.ListBox FilmsListBox;
        private System.Windows.Forms.TextBox GenreFilmTextBox;
        private System.Windows.Forms.TextBox TitleFilmTextBox;
        private System.Windows.Forms.Label labelTitleFilm;
        private System.Windows.Forms.TextBox DurationTextBox;
        private System.Windows.Forms.TextBox ReleaseYearTextBox;
        private System.Windows.Forms.Label ReleaseYearLabel;
        private System.Windows.Forms.Label DurationMinutesLabel;
        private System.Windows.Forms.Label GenreLabel;
        private System.Windows.Forms.TextBox RatingTextBox;
        private System.Windows.Forms.GroupBox FilmsGroupBox;
        private System.Windows.Forms.Label RatingLabel;
        private System.Windows.Forms.Button FindFilmButton;
    }
}

