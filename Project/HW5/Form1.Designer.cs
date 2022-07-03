namespace HW5
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.SecondTaskButton = new System.Windows.Forms.Button();
            this.FirstTaskButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.SecondTaskButton);
            this.panel1.Controls.Add(this.FirstTaskButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(140, 611);
            this.panel1.TabIndex = 0;
            // 
            // SecondTaskButton
            // 
            this.SecondTaskButton.Location = new System.Drawing.Point(12, 227);
            this.SecondTaskButton.Name = "SecondTaskButton";
            this.SecondTaskButton.Size = new System.Drawing.Size(116, 115);
            this.SecondTaskButton.TabIndex = 1;
            this.SecondTaskButton.Text = "Завдання 2";
            this.SecondTaskButton.UseVisualStyleBackColor = true;
            this.SecondTaskButton.Click += new System.EventHandler(this.SecondTaskButton_Click);
            // 
            // FirstTaskButton
            // 
            this.FirstTaskButton.Location = new System.Drawing.Point(12, 70);
            this.FirstTaskButton.Name = "FirstTaskButton";
            this.FirstTaskButton.Size = new System.Drawing.Size(116, 115);
            this.FirstTaskButton.TabIndex = 0;
            this.FirstTaskButton.Text = "Завдання1";
            this.FirstTaskButton.UseVisualStyleBackColor = true;
            this.FirstTaskButton.Click += new System.EventHandler(this.FirstTaskButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(795, 611);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.IsMdiContainer = true;
            this.Name = "Form1";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button SecondTaskButton;
        private System.Windows.Forms.Button FirstTaskButton;
    }
}

