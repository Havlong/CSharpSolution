using System.ComponentModel;

namespace ThirdLab
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            this.interactiveButton = new System.Windows.Forms.Button();
            this.comparisonButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // interactiveButton
            // 
            this.interactiveButton.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.interactiveButton.Location = new System.Drawing.Point(12, 93);
            this.interactiveButton.Name = "interactiveButton";
            this.interactiveButton.Size = new System.Drawing.Size(310, 100);
            this.interactiveButton.TabIndex = 0;
            this.interactiveButton.Text = "Интерактивное взаимодейтвие";
            this.interactiveButton.UseVisualStyleBackColor = true;
            this.interactiveButton.Click += new System.EventHandler(this.interactiveButton_Click);
            // 
            // comparisonButton
            // 
            this.comparisonButton.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.comparisonButton.Location = new System.Drawing.Point(12, 198);
            this.comparisonButton.Name = "comparisonButton";
            this.comparisonButton.Size = new System.Drawing.Size(310, 100);
            this.comparisonButton.TabIndex = 1;
            this.comparisonButton.Text = "Сравнение коллекций";
            this.comparisonButton.UseVisualStyleBackColor = true;
            this.comparisonButton.Click += new System.EventHandler(this.comparisonButton_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.label1.Location = new System.Drawing.Point(12, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(310, 90);
            this.label1.TabIndex = 2;
            this.label1.Text =
                "Лабораторная работа по C# №3.\r\n12 Вариант.\r\nКостерев Григорий\r\nЕвгений Гришин\r\n";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 312);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comparisonButton);
            this.Controls.Add(this.interactiveButton);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Button comparisonButton;
        private System.Windows.Forms.Button interactiveButton;
        private System.Windows.Forms.Label label1;
    }
}