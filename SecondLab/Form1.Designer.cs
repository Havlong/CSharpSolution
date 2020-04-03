namespace SecondLab
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources =
                new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.addButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.changeButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // addButton
            // 
            this.addButton.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.addButton.Location = new System.Drawing.Point(103, 186);
            this.addButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(251, 106);
            this.addButton.TabIndex = 0;
            this.addButton.Text = "Добавить студента\r\n";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.label1.Location = new System.Drawing.Point(14, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(411, 160);
            this.label1.TabIndex = 1;
            this.label1.Text =
                "Лабораторная работа по C# №2.\r\n12 Вариант.\r\nКостерев Григорий\r\nЕвгений Гришин\r\n";
            // 
            // changeButton
            // 
            this.changeButton.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.changeButton.Location = new System.Drawing.Point(103, 320);
            this.changeButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.changeButton.Name = "changeButton";
            this.changeButton.Size = new System.Drawing.Size(251, 106);
            this.changeButton.TabIndex = 2;
            this.changeButton.Text = "Изменить студента";
            this.changeButton.UseVisualStyleBackColor = true;
            this.changeButton.Click += new System.EventHandler(this.changeButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(439, 481);
            this.Controls.Add(this.changeButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.addButton);
            this.Icon = ((System.Drawing.Icon) (resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Лабораторная работа №2";
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button changeButton;
        private System.Windows.Forms.Button addButton;
    }
}