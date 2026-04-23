namespace Programming.View
{
    partial class MoviesControl
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

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.FindFilmButton = new System.Windows.Forms.Button();
            this.RatingLabel = new System.Windows.Forms.Label();
            this.RatingTextBox = new System.Windows.Forms.TextBox();
            this.ReleaseYearLabel = new System.Windows.Forms.Label();
            this.DurationMinutesLabel = new System.Windows.Forms.Label();
            this.GenreLabel = new System.Windows.Forms.Label();
            this.ReleaseYearTextBox = new System.Windows.Forms.TextBox();
            this.DurationTextBox = new System.Windows.Forms.TextBox();
            this.GenreFilmTextBox = new System.Windows.Forms.TextBox();
            this.TitleFilmTextBox = new System.Windows.Forms.TextBox();
            this.labelTitleFilm = new System.Windows.Forms.Label();
            this.FilmsListBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // FindFilmButton
            // 
            this.FindFilmButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FindFilmButton.Location = new System.Drawing.Point(314, 239);
            this.FindFilmButton.Name = "FindFilmButton";
            this.FindFilmButton.Size = new System.Drawing.Size(120, 32);
            this.FindFilmButton.TabIndex = 32;
            this.FindFilmButton.Text = "Find";
            this.FindFilmButton.UseVisualStyleBackColor = true;
            this.FindFilmButton.Click += new System.EventHandler(this.FindFilmButton_Click);
            // 
            // RatingLabel
            // 
            this.RatingLabel.AutoSize = true;
            this.RatingLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RatingLabel.Location = new System.Drawing.Point(463, 91);
            this.RatingLabel.Name = "RatingLabel";
            this.RatingLabel.Size = new System.Drawing.Size(54, 18);
            this.RatingLabel.TabIndex = 31;
            this.RatingLabel.Text = "Rating:";
            // 
            // RatingTextBox
            // 
            this.RatingTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RatingTextBox.Location = new System.Drawing.Point(461, 109);
            this.RatingTextBox.Name = "RatingTextBox";
            this.RatingTextBox.Size = new System.Drawing.Size(113, 27);
            this.RatingTextBox.TabIndex = 30;
            this.RatingTextBox.TextChanged += new System.EventHandler(this.RatingTextBox_TextChanged);
            // 
            // ReleaseYearLabel
            // 
            this.ReleaseYearLabel.AutoSize = true;
            this.ReleaseYearLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ReleaseYearLabel.Location = new System.Drawing.Point(461, 30);
            this.ReleaseYearLabel.Name = "ReleaseYearLabel";
            this.ReleaseYearLabel.Size = new System.Drawing.Size(42, 18);
            this.ReleaseYearLabel.TabIndex = 29;
            this.ReleaseYearLabel.Text = "Year:";
            // 
            // DurationMinutesLabel
            // 
            this.DurationMinutesLabel.AutoSize = true;
            this.DurationMinutesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DurationMinutesLabel.Location = new System.Drawing.Point(311, 148);
            this.DurationMinutesLabel.Name = "DurationMinutesLabel";
            this.DurationMinutesLabel.Size = new System.Drawing.Size(124, 18);
            this.DurationMinutesLabel.TabIndex = 28;
            this.DurationMinutesLabel.Text = "Duration minutes:";
            // 
            // GenreLabel
            // 
            this.GenreLabel.AutoSize = true;
            this.GenreLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GenreLabel.Location = new System.Drawing.Point(311, 90);
            this.GenreLabel.Name = "GenreLabel";
            this.GenreLabel.Size = new System.Drawing.Size(53, 18);
            this.GenreLabel.TabIndex = 27;
            this.GenreLabel.Text = "Genre:";
            // 
            // ReleaseYearTextBox
            // 
            this.ReleaseYearTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ReleaseYearTextBox.Location = new System.Drawing.Point(461, 48);
            this.ReleaseYearTextBox.Name = "ReleaseYearTextBox";
            this.ReleaseYearTextBox.Size = new System.Drawing.Size(113, 27);
            this.ReleaseYearTextBox.TabIndex = 26;
            this.ReleaseYearTextBox.TextChanged += new System.EventHandler(this.ReleaseYearTextBox_TextChanged);
            // 
            // DurationTextBox
            // 
            this.DurationTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DurationTextBox.Location = new System.Drawing.Point(314, 169);
            this.DurationTextBox.Name = "DurationTextBox";
            this.DurationTextBox.Size = new System.Drawing.Size(113, 27);
            this.DurationTextBox.TabIndex = 25;
            this.DurationTextBox.TextChanged += new System.EventHandler(this.DurationTextBox_TextChanged);
            // 
            // GenreFilmTextBox
            // 
            this.GenreFilmTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GenreFilmTextBox.Location = new System.Drawing.Point(314, 109);
            this.GenreFilmTextBox.Name = "GenreFilmTextBox";
            this.GenreFilmTextBox.Size = new System.Drawing.Size(113, 27);
            this.GenreFilmTextBox.TabIndex = 24;
            this.GenreFilmTextBox.TextChanged += new System.EventHandler(this.GenreFilmTextBox_TextChanged);
            // 
            // TitleFilmTextBox
            // 
            this.TitleFilmTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TitleFilmTextBox.Location = new System.Drawing.Point(314, 48);
            this.TitleFilmTextBox.Name = "TitleFilmTextBox";
            this.TitleFilmTextBox.Size = new System.Drawing.Size(113, 27);
            this.TitleFilmTextBox.TabIndex = 23;
            this.TitleFilmTextBox.TextChanged += new System.EventHandler(this.TitleFilmTextBox_TextChanged);
            // 
            // labelTitleFilm
            // 
            this.labelTitleFilm.AutoSize = true;
            this.labelTitleFilm.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTitleFilm.Location = new System.Drawing.Point(311, 27);
            this.labelTitleFilm.Name = "labelTitleFilm";
            this.labelTitleFilm.Size = new System.Drawing.Size(39, 18);
            this.labelTitleFilm.TabIndex = 22;
            this.labelTitleFilm.Text = "Title:";
            // 
            // FilmsListBox
            // 
            this.FilmsListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FilmsListBox.FormattingEnabled = true;
            this.FilmsListBox.ItemHeight = 20;
            this.FilmsListBox.Location = new System.Drawing.Point(26, 27);
            this.FilmsListBox.Name = "FilmsListBox";
            this.FilmsListBox.Size = new System.Drawing.Size(230, 244);
            this.FilmsListBox.TabIndex = 21;
            this.FilmsListBox.SelectedIndexChanged += new System.EventHandler(this.FilmsListBox_SelectedIndexChanged);
            // 
            // MoviesControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.FindFilmButton);
            this.Controls.Add(this.RatingLabel);
            this.Controls.Add(this.RatingTextBox);
            this.Controls.Add(this.ReleaseYearLabel);
            this.Controls.Add(this.DurationMinutesLabel);
            this.Controls.Add(this.GenreLabel);
            this.Controls.Add(this.ReleaseYearTextBox);
            this.Controls.Add(this.DurationTextBox);
            this.Controls.Add(this.GenreFilmTextBox);
            this.Controls.Add(this.TitleFilmTextBox);
            this.Controls.Add(this.labelTitleFilm);
            this.Controls.Add(this.FilmsListBox);
            this.Name = "MoviesControl";
            this.Size = new System.Drawing.Size(600, 299);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button FindFilmButton;
        private System.Windows.Forms.Label RatingLabel;
        private System.Windows.Forms.TextBox RatingTextBox;
        private System.Windows.Forms.Label ReleaseYearLabel;
        private System.Windows.Forms.Label DurationMinutesLabel;
        private System.Windows.Forms.Label GenreLabel;
        private System.Windows.Forms.TextBox ReleaseYearTextBox;
        private System.Windows.Forms.TextBox DurationTextBox;
        private System.Windows.Forms.TextBox GenreFilmTextBox;
        private System.Windows.Forms.TextBox TitleFilmTextBox;
        private System.Windows.Forms.Label labelTitleFilm;
        private System.Windows.Forms.ListBox FilmsListBox;
    }
}
