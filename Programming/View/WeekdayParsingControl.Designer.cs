namespace Programming.View
{
    partial class WeekdayParsingControl
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
            this.parseResultTextBox = new System.Windows.Forms.TextBox();
            this.ParseLabel = new System.Windows.Forms.Label();
            this.ParsButton = new System.Windows.Forms.Button();
            this.parsingTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // parseResultTextBox
            // 
            this.parseResultTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.parseResultTextBox.Location = new System.Drawing.Point(52, 508);
            this.parseResultTextBox.Name = "parseResultTextBox";
            this.parseResultTextBox.ReadOnly = true;
            this.parseResultTextBox.Size = new System.Drawing.Size(299, 27);
            this.parseResultTextBox.TabIndex = 7;
            // 
            // ParseLabel
            // 
            this.ParseLabel.AutoSize = true;
            this.ParseLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ParseLabel.Location = new System.Drawing.Point(48, 447);
            this.ParseLabel.Name = "ParseLabel";
            this.ParseLabel.Size = new System.Drawing.Size(179, 20);
            this.ParseLabel.TabIndex = 6;
            this.ParseLabel.Text = "Type value for parsing:";
            // 
            // ParsButton
            // 
            this.ParsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ParsButton.Location = new System.Drawing.Point(368, 467);
            this.ParsButton.Name = "ParsButton";
            this.ParsButton.Size = new System.Drawing.Size(117, 29);
            this.ParsButton.TabIndex = 5;
            this.ParsButton.Text = "Parse";
            this.ParsButton.UseVisualStyleBackColor = true;
            this.ParsButton.Click += new System.EventHandler(this.ParsButton_Click);
            // 
            // parsingTextBox
            // 
            this.parsingTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.parsingTextBox.Location = new System.Drawing.Point(52, 470);
            this.parsingTextBox.Name = "parsingTextBox";
            this.parsingTextBox.Size = new System.Drawing.Size(299, 24);
            this.parsingTextBox.TabIndex = 4;
            this.parsingTextBox.TextChanged += new System.EventHandler(this.ValuesListBox_SelectedIndexChanged);
            // 
            // WeekdayParsingControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.parseResultTextBox);
            this.Controls.Add(this.ParseLabel);
            this.Controls.Add(this.ParsButton);
            this.Controls.Add(this.parsingTextBox);
            this.Name = "WeekdayParsingControl";
            this.Size = new System.Drawing.Size(1200, 670);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox parseResultTextBox;
        private System.Windows.Forms.Label ParseLabel;
        private System.Windows.Forms.Button ParsButton;
        private System.Windows.Forms.TextBox parsingTextBox;
    }
}
