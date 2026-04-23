namespace Programming.View
{
    partial class SeasonsHandleControl
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
            this.SeasonLabel = new System.Windows.Forms.Label();
            this.SeasonGoButton = new System.Windows.Forms.Button();
            this.SeasonComboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // SeasonLabel
            // 
            this.SeasonLabel.AutoSize = true;
            this.SeasonLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SeasonLabel.Location = new System.Drawing.Point(690, 495);
            this.SeasonLabel.Name = "SeasonLabel";
            this.SeasonLabel.Size = new System.Drawing.Size(130, 20);
            this.SeasonLabel.TabIndex = 5;
            this.SeasonLabel.Text = "Choose season:";
            this.SeasonLabel.Click += new System.EventHandler(this.SeasonGoButton_Click);
            // 
            // SeasonGoButton
            // 
            this.SeasonGoButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SeasonGoButton.Location = new System.Drawing.Point(990, 515);
            this.SeasonGoButton.Name = "SeasonGoButton";
            this.SeasonGoButton.Size = new System.Drawing.Size(90, 30);
            this.SeasonGoButton.TabIndex = 4;
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
            this.SeasonComboBox.Location = new System.Drawing.Point(694, 520);
            this.SeasonComboBox.Name = "SeasonComboBox";
            this.SeasonComboBox.Size = new System.Drawing.Size(274, 24);
            this.SeasonComboBox.TabIndex = 3;
            this.SeasonComboBox.Click += new System.EventHandler(this.SeasonGoButton_Click);
            // 
            // SeasonsHandleControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.SeasonLabel);
            this.Controls.Add(this.SeasonGoButton);
            this.Controls.Add(this.SeasonComboBox);
            this.Name = "SeasonsHandleControl";
            this.Size = new System.Drawing.Size(1200, 670);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label SeasonLabel;
        private System.Windows.Forms.Button SeasonGoButton;
        private System.Windows.Forms.ComboBox SeasonComboBox;
    }
}
