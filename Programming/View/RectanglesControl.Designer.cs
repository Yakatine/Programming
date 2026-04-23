namespace Programming.View
{
    partial class RectanglesControl
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
            this.RectangleIdLabel = new System.Windows.Forms.Label();
            this.RectangleIdTextBox = new System.Windows.Forms.TextBox();
            this.CenterYLabel = new System.Windows.Forms.Label();
            this.CenterXLabel = new System.Windows.Forms.Label();
            this.CenterYTextBox = new System.Windows.Forms.TextBox();
            this.CenterXTextBox = new System.Windows.Forms.TextBox();
            this.FindRectangleButton = new System.Windows.Forms.Button();
            this.ColorLabel = new System.Windows.Forms.Label();
            this.WidthLabel = new System.Windows.Forms.Label();
            this.LenghtLabel = new System.Windows.Forms.Label();
            this.ColorTextBox = new System.Windows.Forms.TextBox();
            this.WidthTextBox = new System.Windows.Forms.TextBox();
            this.LenghtTextBox = new System.Windows.Forms.TextBox();
            this.RectangleListBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // RectangleIdLabel
            // 
            this.RectangleIdLabel.AutoSize = true;
            this.RectangleIdLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RectangleIdLabel.Location = new System.Drawing.Point(366, 139);
            this.RectangleIdLabel.Name = "RectangleIdLabel";
            this.RectangleIdLabel.Size = new System.Drawing.Size(23, 18);
            this.RectangleIdLabel.TabIndex = 27;
            this.RectangleIdLabel.Text = "Id:";
            // 
            // RectangleIdTextBox
            // 
            this.RectangleIdTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RectangleIdTextBox.Location = new System.Drawing.Point(369, 160);
            this.RectangleIdTextBox.Name = "RectangleIdTextBox";
            this.RectangleIdTextBox.ReadOnly = true;
            this.RectangleIdTextBox.Size = new System.Drawing.Size(120, 27);
            this.RectangleIdTextBox.TabIndex = 26;
            // 
            // CenterYLabel
            // 
            this.CenterYLabel.AutoSize = true;
            this.CenterYLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CenterYLabel.Location = new System.Drawing.Point(366, 81);
            this.CenterYLabel.Name = "CenterYLabel";
            this.CenterYLabel.Size = new System.Drawing.Size(69, 18);
            this.CenterYLabel.TabIndex = 25;
            this.CenterYLabel.Text = "Center Y:";
            // 
            // CenterXLabel
            // 
            this.CenterXLabel.AutoSize = true;
            this.CenterXLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CenterXLabel.Location = new System.Drawing.Point(366, 18);
            this.CenterXLabel.Name = "CenterXLabel";
            this.CenterXLabel.Size = new System.Drawing.Size(70, 18);
            this.CenterXLabel.TabIndex = 24;
            this.CenterXLabel.Text = "Center X:";
            // 
            // CenterYTextBox
            // 
            this.CenterYTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CenterYTextBox.Location = new System.Drawing.Point(369, 100);
            this.CenterYTextBox.Name = "CenterYTextBox";
            this.CenterYTextBox.ReadOnly = true;
            this.CenterYTextBox.Size = new System.Drawing.Size(120, 27);
            this.CenterYTextBox.TabIndex = 23;
            // 
            // CenterXTextBox
            // 
            this.CenterXTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CenterXTextBox.Location = new System.Drawing.Point(369, 39);
            this.CenterXTextBox.Name = "CenterXTextBox";
            this.CenterXTextBox.ReadOnly = true;
            this.CenterXTextBox.Size = new System.Drawing.Size(120, 27);
            this.CenterXTextBox.TabIndex = 22;
            // 
            // FindRectangleButton
            // 
            this.FindRectangleButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FindRectangleButton.Location = new System.Drawing.Point(299, 230);
            this.FindRectangleButton.Name = "FindRectangleButton";
            this.FindRectangleButton.Size = new System.Drawing.Size(120, 36);
            this.FindRectangleButton.TabIndex = 21;
            this.FindRectangleButton.Text = "Find";
            this.FindRectangleButton.UseVisualStyleBackColor = true;
            this.FindRectangleButton.Click += new System.EventHandler(this.FindRectangleButton_Click);
            // 
            // ColorLabel
            // 
            this.ColorLabel.AutoSize = true;
            this.ColorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ColorLabel.Location = new System.Drawing.Point(230, 139);
            this.ColorLabel.Name = "ColorLabel";
            this.ColorLabel.Size = new System.Drawing.Size(49, 18);
            this.ColorLabel.TabIndex = 20;
            this.ColorLabel.Text = "Color:";
            // 
            // WidthLabel
            // 
            this.WidthLabel.AutoSize = true;
            this.WidthLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.WidthLabel.Location = new System.Drawing.Point(230, 81);
            this.WidthLabel.Name = "WidthLabel";
            this.WidthLabel.Size = new System.Drawing.Size(50, 18);
            this.WidthLabel.TabIndex = 19;
            this.WidthLabel.Text = "Width:";
            // 
            // LenghtLabel
            // 
            this.LenghtLabel.AutoSize = true;
            this.LenghtLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LenghtLabel.Location = new System.Drawing.Point(230, 18);
            this.LenghtLabel.Name = "LenghtLabel";
            this.LenghtLabel.Size = new System.Drawing.Size(56, 18);
            this.LenghtLabel.TabIndex = 18;
            this.LenghtLabel.Text = "Lenght:";
            // 
            // ColorTextBox
            // 
            this.ColorTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ColorTextBox.Location = new System.Drawing.Point(233, 160);
            this.ColorTextBox.Name = "ColorTextBox";
            this.ColorTextBox.Size = new System.Drawing.Size(120, 27);
            this.ColorTextBox.TabIndex = 17;
            this.ColorTextBox.TextChanged += new System.EventHandler(this.ColorTextBox_TextChanged);
            // 
            // WidthTextBox
            // 
            this.WidthTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.WidthTextBox.Location = new System.Drawing.Point(233, 100);
            this.WidthTextBox.Name = "WidthTextBox";
            this.WidthTextBox.Size = new System.Drawing.Size(120, 27);
            this.WidthTextBox.TabIndex = 16;
            this.WidthTextBox.TextChanged += new System.EventHandler(this.WidthTextBox_TextChanged);
            // 
            // LenghtTextBox
            // 
            this.LenghtTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LenghtTextBox.Location = new System.Drawing.Point(233, 39);
            this.LenghtTextBox.Name = "LenghtTextBox";
            this.LenghtTextBox.Size = new System.Drawing.Size(120, 27);
            this.LenghtTextBox.TabIndex = 15;
            this.LenghtTextBox.TextChanged += new System.EventHandler(this.LenghtTextBox_TextChanged);
            // 
            // RectangleListBox
            // 
            this.RectangleListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RectangleListBox.FormattingEnabled = true;
            this.RectangleListBox.ItemHeight = 20;
            this.RectangleListBox.Location = new System.Drawing.Point(17, 22);
            this.RectangleListBox.Name = "RectangleListBox";
            this.RectangleListBox.Size = new System.Drawing.Size(197, 244);
            this.RectangleListBox.TabIndex = 14;
            this.RectangleListBox.SelectedIndexChanged += new System.EventHandler(this.RectangleListBox_SelectedIndexChanged);
            // 
            // RectanglesControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.RectangleIdLabel);
            this.Controls.Add(this.RectangleIdTextBox);
            this.Controls.Add(this.CenterYLabel);
            this.Controls.Add(this.CenterXLabel);
            this.Controls.Add(this.CenterYTextBox);
            this.Controls.Add(this.CenterXTextBox);
            this.Controls.Add(this.FindRectangleButton);
            this.Controls.Add(this.ColorLabel);
            this.Controls.Add(this.WidthLabel);
            this.Controls.Add(this.LenghtLabel);
            this.Controls.Add(this.ColorTextBox);
            this.Controls.Add(this.WidthTextBox);
            this.Controls.Add(this.LenghtTextBox);
            this.Controls.Add(this.RectangleListBox);
            this.Name = "RectanglesControl";
            this.Size = new System.Drawing.Size(505, 299);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label RectangleIdLabel;
        private System.Windows.Forms.TextBox RectangleIdTextBox;
        private System.Windows.Forms.Label CenterYLabel;
        private System.Windows.Forms.Label CenterXLabel;
        private System.Windows.Forms.TextBox CenterYTextBox;
        private System.Windows.Forms.TextBox CenterXTextBox;
        private System.Windows.Forms.Button FindRectangleButton;
        private System.Windows.Forms.Label ColorLabel;
        private System.Windows.Forms.Label WidthLabel;
        private System.Windows.Forms.Label LenghtLabel;
        private System.Windows.Forms.TextBox ColorTextBox;
        private System.Windows.Forms.TextBox WidthTextBox;
        private System.Windows.Forms.TextBox LenghtTextBox;
        private System.Windows.Forms.ListBox RectangleListBox;
    }
}
