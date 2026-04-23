namespace Programming
{
    partial class RectanglesCollisionControl
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
            this.txtWigthLabel = new System.Windows.Forms.Label();
            this.txtLengthLabel = new System.Windows.Forms.Label();
            this.txtYLabel = new System.Windows.Forms.Label();
            this.txtXLabel = new System.Windows.Forms.Label();
            this.txtIdLabel = new System.Windows.Forms.Label();
            this.txtWidth = new System.Windows.Forms.TextBox();
            this.txtLenght = new System.Windows.Forms.TextBox();
            this.txtY = new System.Windows.Forms.TextBox();
            this.txtX = new System.Windows.Forms.TextBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.RemoveButton = new System.Windows.Forms.Button();
            this.AddButton = new System.Windows.Forms.Button();
            this.ListBoxRectangles = new System.Windows.Forms.ListBox();
            this.CanvasPanel = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // txtWigthLabel
            // 
            this.txtWigthLabel.AutoSize = true;
            this.txtWigthLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtWigthLabel.Location = new System.Drawing.Point(37, 522);
            this.txtWigthLabel.Name = "txtWigthLabel";
            this.txtWigthLabel.Size = new System.Drawing.Size(50, 18);
            this.txtWigthLabel.TabIndex = 27;
            this.txtWigthLabel.Text = "Wigth:";
            // 
            // txtLengthLabel
            // 
            this.txtLengthLabel.AutoSize = true;
            this.txtLengthLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtLengthLabel.Location = new System.Drawing.Point(31, 480);
            this.txtLengthLabel.Name = "txtLengthLabel";
            this.txtLengthLabel.Size = new System.Drawing.Size(56, 18);
            this.txtLengthLabel.TabIndex = 26;
            this.txtLengthLabel.Text = "Length:";
            // 
            // txtYLabel
            // 
            this.txtYLabel.AutoSize = true;
            this.txtYLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtYLabel.Location = new System.Drawing.Point(63, 439);
            this.txtYLabel.Name = "txtYLabel";
            this.txtYLabel.Size = new System.Drawing.Size(24, 20);
            this.txtYLabel.TabIndex = 25;
            this.txtYLabel.Text = "Y:";
            // 
            // txtXLabel
            // 
            this.txtXLabel.AutoSize = true;
            this.txtXLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtXLabel.Location = new System.Drawing.Point(63, 397);
            this.txtXLabel.Name = "txtXLabel";
            this.txtXLabel.Size = new System.Drawing.Size(25, 20);
            this.txtXLabel.TabIndex = 24;
            this.txtXLabel.Text = "X:";
            // 
            // txtIdLabel
            // 
            this.txtIdLabel.AutoSize = true;
            this.txtIdLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtIdLabel.Location = new System.Drawing.Point(63, 357);
            this.txtIdLabel.Name = "txtIdLabel";
            this.txtIdLabel.Size = new System.Drawing.Size(27, 20);
            this.txtIdLabel.TabIndex = 23;
            this.txtIdLabel.Text = "Id:";
            // 
            // txtWidth
            // 
            this.txtWidth.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtWidth.Location = new System.Drawing.Point(93, 519);
            this.txtWidth.Name = "txtWidth";
            this.txtWidth.Size = new System.Drawing.Size(140, 24);
            this.txtWidth.TabIndex = 22;
            this.txtWidth.TextChanged += new System.EventHandler(this.SizeTextBox_TextChanged);
            // 
            // txtLenght
            // 
            this.txtLenght.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtLenght.Location = new System.Drawing.Point(93, 477);
            this.txtLenght.Name = "txtLenght";
            this.txtLenght.Size = new System.Drawing.Size(140, 24);
            this.txtLenght.TabIndex = 21;
            this.txtLenght.TextChanged += new System.EventHandler(this.SizeTextBox_TextChanged);
            // 
            // txtY
            // 
            this.txtY.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtY.Location = new System.Drawing.Point(93, 437);
            this.txtY.Name = "txtY";
            this.txtY.Size = new System.Drawing.Size(140, 24);
            this.txtY.TabIndex = 20;
            this.txtY.TextChanged += new System.EventHandler(this.CoordinateTextBox_TextChanged);
            // 
            // txtX
            // 
            this.txtX.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtX.Location = new System.Drawing.Point(93, 395);
            this.txtX.Name = "txtX";
            this.txtX.Size = new System.Drawing.Size(140, 24);
            this.txtX.TabIndex = 19;
            this.txtX.TextChanged += new System.EventHandler(this.CoordinateTextBox_TextChanged);
            // 
            // txtId
            // 
            this.txtId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtId.Location = new System.Drawing.Point(93, 355);
            this.txtId.Name = "txtId";
            this.txtId.ReadOnly = true;
            this.txtId.Size = new System.Drawing.Size(140, 24);
            this.txtId.TabIndex = 18;
            // 
            // RemoveButton
            // 
            this.RemoveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RemoveButton.Location = new System.Drawing.Point(236, 243);
            this.RemoveButton.Name = "RemoveButton";
            this.RemoveButton.Size = new System.Drawing.Size(102, 26);
            this.RemoveButton.TabIndex = 17;
            this.RemoveButton.Text = "-";
            this.RemoveButton.UseVisualStyleBackColor = true;
            this.RemoveButton.Click += new System.EventHandler(this.RemoveButton_Click);
            // 
            // AddButton
            // 
            this.AddButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddButton.Location = new System.Drawing.Point(67, 243);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(102, 26);
            this.AddButton.TabIndex = 16;
            this.AddButton.Text = "+";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // ListBoxRectangles
            // 
            this.ListBoxRectangles.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ListBoxRectangles.FormattingEnabled = true;
            this.ListBoxRectangles.ItemHeight = 18;
            this.ListBoxRectangles.Location = new System.Drawing.Point(28, 56);
            this.ListBoxRectangles.Name = "ListBoxRectangles";
            this.ListBoxRectangles.Size = new System.Drawing.Size(359, 166);
            this.ListBoxRectangles.TabIndex = 15;
            this.ListBoxRectangles.SelectedIndexChanged += new System.EventHandler(this.ListBoxRectangles_SelectedIndexChanged);
            // 
            // CanvasPanel
            // 
            this.CanvasPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CanvasPanel.Location = new System.Drawing.Point(456, 45);
            this.CanvasPanel.Name = "CanvasPanel";
            this.CanvasPanel.Size = new System.Drawing.Size(717, 580);
            this.CanvasPanel.TabIndex = 14;
            // 
            // RectanglesCollisionControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtWigthLabel);
            this.Controls.Add(this.txtLengthLabel);
            this.Controls.Add(this.txtYLabel);
            this.Controls.Add(this.txtXLabel);
            this.Controls.Add(this.txtIdLabel);
            this.Controls.Add(this.txtWidth);
            this.Controls.Add(this.txtLenght);
            this.Controls.Add(this.txtY);
            this.Controls.Add(this.txtX);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.RemoveButton);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.ListBoxRectangles);
            this.Controls.Add(this.CanvasPanel);
            this.Name = "RectanglesCollisionControl";
            this.Size = new System.Drawing.Size(1200, 670);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txtWigthLabel;
        private System.Windows.Forms.Label txtLengthLabel;
        private System.Windows.Forms.Label txtYLabel;
        private System.Windows.Forms.Label txtXLabel;
        private System.Windows.Forms.Label txtIdLabel;
        private System.Windows.Forms.TextBox txtWidth;
        private System.Windows.Forms.TextBox txtLenght;
        private System.Windows.Forms.TextBox txtY;
        private System.Windows.Forms.TextBox txtX;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Button RemoveButton;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.ListBox ListBoxRectangles;
        private System.Windows.Forms.Panel CanvasPanel;
    }
}
