namespace Programming.View
{
    partial class EnumerationsControl
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
            this.ValuesTextBoxLabel = new System.Windows.Forms.Label();
            this.ValuesListBoxLabel = new System.Windows.Forms.Label();
            this.EnumsListBoxLabel = new System.Windows.Forms.Label();
            this.ValueTextBox = new System.Windows.Forms.TextBox();
            this.ValuesListBox = new System.Windows.Forms.ListBox();
            this.EnumsListBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // ValuesTextBoxLabel
            // 
            this.ValuesTextBoxLabel.AutoSize = true;
            this.ValuesTextBoxLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ValuesTextBoxLabel.Location = new System.Drawing.Point(649, 33);
            this.ValuesTextBoxLabel.Name = "ValuesTextBoxLabel";
            this.ValuesTextBoxLabel.Size = new System.Drawing.Size(76, 20);
            this.ValuesTextBoxLabel.TabIndex = 11;
            this.ValuesTextBoxLabel.Text = "Int value:";
            // 
            // ValuesListBoxLabel
            // 
            this.ValuesListBoxLabel.AutoSize = true;
            this.ValuesListBoxLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ValuesListBoxLabel.Location = new System.Drawing.Point(343, 33);
            this.ValuesListBoxLabel.Name = "ValuesListBoxLabel";
            this.ValuesListBoxLabel.Size = new System.Drawing.Size(115, 20);
            this.ValuesListBoxLabel.TabIndex = 10;
            this.ValuesListBoxLabel.Text = "Choose value:";
            // 
            // EnumsListBoxLabel
            // 
            this.EnumsListBoxLabel.AutoSize = true;
            this.EnumsListBoxLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EnumsListBoxLabel.Location = new System.Drawing.Point(38, 33);
            this.EnumsListBoxLabel.Name = "EnumsListBoxLabel";
            this.EnumsListBoxLabel.Size = new System.Drawing.Size(168, 20);
            this.EnumsListBoxLabel.TabIndex = 9;
            this.EnumsListBoxLabel.Text = "Choose enumaration:";
            // 
            // ValueTextBox
            // 
            this.ValueTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ValueTextBox.Location = new System.Drawing.Point(653, 60);
            this.ValueTextBox.Name = "ValueTextBox";
            this.ValueTextBox.Size = new System.Drawing.Size(200, 27);
            this.ValueTextBox.TabIndex = 8;
            // 
            // ValuesListBox
            // 
            this.ValuesListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ValuesListBox.FormattingEnabled = true;
            this.ValuesListBox.ItemHeight = 20;
            this.ValuesListBox.Location = new System.Drawing.Point(347, 60);
            this.ValuesListBox.Name = "ValuesListBox";
            this.ValuesListBox.Size = new System.Drawing.Size(232, 284);
            this.ValuesListBox.TabIndex = 7;
            this.ValuesListBox.SelectedIndexChanged += new System.EventHandler(this.ValuesListBox_SelectedIndexChanged);
            // 
            // EnumsListBox
            // 
            this.EnumsListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EnumsListBox.FormattingEnabled = true;
            this.EnumsListBox.ItemHeight = 20;
            this.EnumsListBox.Location = new System.Drawing.Point(42, 60);
            this.EnumsListBox.Name = "EnumsListBox";
            this.EnumsListBox.Size = new System.Drawing.Size(232, 284);
            this.EnumsListBox.TabIndex = 6;
            this.EnumsListBox.SelectedIndexChanged += new System.EventHandler(this.EnumsListBox_SelectedIndexChanged);
            // 
            // EnumerationsControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ValuesTextBoxLabel);
            this.Controls.Add(this.ValuesListBoxLabel);
            this.Controls.Add(this.EnumsListBoxLabel);
            this.Controls.Add(this.ValueTextBox);
            this.Controls.Add(this.ValuesListBox);
            this.Controls.Add(this.EnumsListBox);
            this.Name = "EnumerationsControl";
            this.Size = new System.Drawing.Size(1200, 670);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ValuesTextBoxLabel;
        private System.Windows.Forms.Label ValuesListBoxLabel;
        private System.Windows.Forms.Label EnumsListBoxLabel;
        private System.Windows.Forms.TextBox ValueTextBox;
        private System.Windows.Forms.ListBox ValuesListBox;
        private System.Windows.Forms.ListBox EnumsListBox;
    }
}
