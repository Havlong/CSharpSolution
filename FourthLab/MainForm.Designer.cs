namespace FourthLab
{
    partial class MainForm
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
            this.changeButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.addButton = new System.Windows.Forms.Button();
            this.showClassesButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // changeButton
            // 
            this.changeButton.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.changeButton.Location = new System.Drawing.Point(52, 201);
            this.changeButton.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.changeButton.Name = "changeButton";
            this.changeButton.Size = new System.Drawing.Size(219, 80);
            this.changeButton.TabIndex = 5;
            this.changeButton.Text = "Изменить студента";
            this.changeButton.UseVisualStyleBackColor = true;
            this.changeButton.Click += new System.EventHandler(this.changeButton_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.label1.Location = new System.Drawing.Point(10, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(297, 103);
            this.label1.TabIndex = 4;
            this.label1.Text =
                "Лабораторная работа по C# №4.\r\n12 Вариант.\r\nКостерев Григорий\r\nЕвгений Гришин\r\n";
            // 
            // addButton
            // 
            this.addButton.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.addButton.Location = new System.Drawing.Point(52, 115);
            this.addButton.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(219, 80);
            this.addButton.TabIndex = 3;
            this.addButton.Text = "Добавить студента\r\n";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // showClassesButton
            // 
            this.showClassesButton.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.showClassesButton.Location = new System.Drawing.Point(52, 287);
            this.showClassesButton.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.showClassesButton.Name = "showClassesButton";
            this.showClassesButton.Size = new System.Drawing.Size(219, 80);
            this.showClassesButton.TabIndex = 6;
            this.showClassesButton.Text = "Просмотр классов";
            this.showClassesButton.UseVisualStyleBackColor = true;
            this.showClassesButton.Click += new System.EventHandler(this.showClassesButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 411);
            this.Controls.Add(this.showClassesButton);
            this.Controls.Add(this.changeButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.addButton);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button changeButton;
        private System.Windows.Forms.Button showClassesButton;
    }
}