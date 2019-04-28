namespace MuranoTest
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
            this.savedDataSearchButton = new System.Windows.Forms.Button();
            this.onlineSearchButton = new System.Windows.Forms.Button();
            this.resultBox = new System.Windows.Forms.ListBox();
            this.searchBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // savedDataSearchButton
            // 
            this.savedDataSearchButton.Location = new System.Drawing.Point(134, 65);
            this.savedDataSearchButton.Name = "savedDataSearchButton";
            this.savedDataSearchButton.Size = new System.Drawing.Size(105, 34);
            this.savedDataSearchButton.TabIndex = 0;
            this.savedDataSearchButton.Text = "SavedData";
            this.savedDataSearchButton.UseVisualStyleBackColor = true;
            this.savedDataSearchButton.Click += new System.EventHandler(this.savedDataSearchButton_Click);
            // 
            // onlineSearchButton
            // 
            this.onlineSearchButton.Location = new System.Drawing.Point(12, 65);
            this.onlineSearchButton.Name = "onlineSearchButton";
            this.onlineSearchButton.Size = new System.Drawing.Size(105, 34);
            this.onlineSearchButton.TabIndex = 1;
            this.onlineSearchButton.Text = "Online";
            this.onlineSearchButton.UseVisualStyleBackColor = true;
            this.onlineSearchButton.Click += new System.EventHandler(this.onlineSearchButton_Click);
            // 
            // resultBox
            // 
            this.resultBox.FormattingEnabled = true;
            this.resultBox.Location = new System.Drawing.Point(256, 12);
            this.resultBox.Name = "resultBox";
            this.resultBox.Size = new System.Drawing.Size(399, 316);
            this.resultBox.TabIndex = 2;
            // 
            // searchBox
            // 
            this.searchBox.Location = new System.Drawing.Point(16, 19);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(222, 20);
            this.searchBox.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(671, 340);
            this.Controls.Add(this.searchBox);
            this.Controls.Add(this.resultBox);
            this.Controls.Add(this.onlineSearchButton);
            this.Controls.Add(this.savedDataSearchButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button savedDataSearchButton;
        private System.Windows.Forms.Button onlineSearchButton;
        private System.Windows.Forms.ListBox resultBox;
        private System.Windows.Forms.TextBox searchBox;
    }
}

