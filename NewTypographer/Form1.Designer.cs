namespace NewTypographer
{
    partial class Form1
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
            this.typographyButton = new System.Windows.Forms.Button();
            this.inputRichTextBox = new System.Windows.Forms.RichTextBox();
            this.outputRichTextBox = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // typographyButton
            // 
            this.typographyButton.Location = new System.Drawing.Point(310, 402);
            this.typographyButton.Name = "typographyButton";
            this.typographyButton.Size = new System.Drawing.Size(177, 36);
            this.typographyButton.TabIndex = 0;
            this.typographyButton.Text = "Оттипографировать";
            this.typographyButton.UseVisualStyleBackColor = true;
            this.typographyButton.Click += new System.EventHandler(this.typographyButton_Click);
            // 
            // inputRichTextBox
            // 
            this.inputRichTextBox.Location = new System.Drawing.Point(0, 0);
            this.inputRichTextBox.Name = "inputRichTextBox";
            this.inputRichTextBox.Size = new System.Drawing.Size(390, 396);
            this.inputRichTextBox.TabIndex = 1;
            this.inputRichTextBox.Text = "";
            // 
            // outputRichTextBox
            // 
            this.outputRichTextBox.Location = new System.Drawing.Point(413, 0);
            this.outputRichTextBox.Name = "outputRichTextBox";
            this.outputRichTextBox.Size = new System.Drawing.Size(386, 396);
            this.outputRichTextBox.TabIndex = 2;
            this.outputRichTextBox.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.outputRichTextBox);
            this.Controls.Add(this.inputRichTextBox);
            this.Controls.Add(this.typographyButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button typographyButton;
        private System.Windows.Forms.RichTextBox inputRichTextBox;
        private System.Windows.Forms.RichTextBox outputRichTextBox;
    }
}

