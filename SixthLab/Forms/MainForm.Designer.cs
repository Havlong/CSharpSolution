namespace SixthLab.Forms
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
            this.CallInt = new System.Windows.Forms.Button();
            this.CallString = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CallInt
            // 
            this.CallInt.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.CallInt.Location = new System.Drawing.Point(40, 98);
            this.CallInt.Name = "CallInt";
            this.CallInt.Size = new System.Drawing.Size(200, 100);
            this.CallInt.TabIndex = 0;
            this.CallInt.Text = "Отправить число";
            this.CallInt.UseVisualStyleBackColor = true;
            this.CallInt.Click += new System.EventHandler(this.CallInt_Click);
            // 
            // CallString
            // 
            this.CallString.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.CallString.Location = new System.Drawing.Point(40, 204);
            this.CallString.Name = "CallString";
            this.CallString.Size = new System.Drawing.Size(200, 100);
            this.CallString.TabIndex = 1;
            this.CallString.Text = "Отправить строку";
            this.CallString.UseVisualStyleBackColor = true;
            this.CallString.Click += new System.EventHandler(this.CallString_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(266, 86);
            this.label1.TabIndex = 4;
            this.label1.Text = "Лабораторная работа по C# №6.\r\n12 Вариант.\r\nКостерев Григорий\r\nЕвгений Гришин\r\n";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 341);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CallString);
            this.Controls.Add(this.CallInt);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Приложение";
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button CallInt;
        private System.Windows.Forms.Button CallString;
        private System.Windows.Forms.Label label1;

        #endregion
    }
}