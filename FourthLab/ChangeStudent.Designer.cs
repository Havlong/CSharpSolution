using System.ComponentModel;

namespace FourthLab
{
    partial class ChangeStudent
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
            this.comboIdBox = new System.Windows.Forms.ComboBox();
            this.sendButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.searchButton = new System.Windows.Forms.Button();
            this.idLabel = new System.Windows.Forms.Label();
            this.averageMarkLabel = new System.Windows.Forms.Label();
            this.FormLabel = new System.Windows.Forms.Label();
            this.isFullTimeCheckBox = new System.Windows.Forms.CheckBox();
            this.departmentLabel = new System.Windows.Forms.Label();
            this.facultyLabel = new System.Windows.Forms.Label();
            this.universityLabel = new System.Windows.Forms.Label();
            this.averageMarkBox = new System.Windows.Forms.TextBox();
            this.courseBox = new System.Windows.Forms.TextBox();
            this.departmentBox = new System.Windows.Forms.TextBox();
            this.facultyBox = new System.Windows.Forms.TextBox();
            this.universityBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // comboIdBox
            // 
            this.comboIdBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboIdBox.FormattingEnabled = true;
            this.comboIdBox.Location = new System.Drawing.Point(59, 39);
            this.comboIdBox.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.comboIdBox.Name = "comboIdBox";
            this.comboIdBox.Size = new System.Drawing.Size(107, 23);
            this.comboIdBox.TabIndex = 85;
            // 
            // sendButton
            // 
            this.sendButton.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.sendButton.Location = new System.Drawing.Point(101, 332);
            this.sendButton.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.sendButton.Name = "sendButton";
            this.sendButton.Size = new System.Drawing.Size(110, 62);
            this.sendButton.TabIndex = 82;
            this.sendButton.Text = "Изменить";
            this.sendButton.UseVisualStyleBackColor = true;
            this.sendButton.Click += new System.EventHandler(this.sendButton_Click);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.label2.Location = new System.Drawing.Point(10, 9);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(201, 23);
            this.label2.TabIndex = 81;
            this.label2.Text = "Найти студента по ID:";
            // 
            // searchButton
            // 
            this.searchButton.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.searchButton.Location = new System.Drawing.Point(202, 35);
            this.searchButton.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(100, 43);
            this.searchButton.TabIndex = 80;
            this.searchButton.Text = "Найти";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // idLabel
            // 
            this.idLabel.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.idLabel.Location = new System.Drawing.Point(10, 39);
            this.idLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(44, 23);
            this.idLabel.TabIndex = 79;
            this.idLabel.Text = "ID:";
            // 
            // averageMarkLabel
            // 
            this.averageMarkLabel.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.averageMarkLabel.Location = new System.Drawing.Point(10, 249);
            this.averageMarkLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.averageMarkLabel.Name = "averageMarkLabel";
            this.averageMarkLabel.Size = new System.Drawing.Size(159, 23);
            this.averageMarkLabel.TabIndex = 78;
            this.averageMarkLabel.Text = "Средняя оценка:";
            // 
            // FormLabel
            // 
            this.FormLabel.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.FormLabel.Location = new System.Drawing.Point(10, 209);
            this.FormLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.FormLabel.Name = "FormLabel";
            this.FormLabel.Size = new System.Drawing.Size(114, 23);
            this.FormLabel.TabIndex = 77;
            this.FormLabel.Text = "Курс:";
            // 
            // isFullTimeCheckBox
            // 
            this.isFullTimeCheckBox.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.isFullTimeCheckBox.Location = new System.Drawing.Point(10, 288);
            this.isFullTimeCheckBox.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.isFullTimeCheckBox.Name = "isFullTimeCheckBox";
            this.isFullTimeCheckBox.Size = new System.Drawing.Size(159, 29);
            this.isFullTimeCheckBox.TabIndex = 76;
            this.isFullTimeCheckBox.Text = "Очная форма";
            this.isFullTimeCheckBox.UseVisualStyleBackColor = true;
            // 
            // departmentLabel
            // 
            this.departmentLabel.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.departmentLabel.Location = new System.Drawing.Point(10, 168);
            this.departmentLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.departmentLabel.Name = "departmentLabel";
            this.departmentLabel.Size = new System.Drawing.Size(114, 23);
            this.departmentLabel.TabIndex = 75;
            this.departmentLabel.Text = "Кафедра:";
            // 
            // facultyLabel
            // 
            this.facultyLabel.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.facultyLabel.Location = new System.Drawing.Point(10, 129);
            this.facultyLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.facultyLabel.Name = "facultyLabel";
            this.facultyLabel.Size = new System.Drawing.Size(114, 23);
            this.facultyLabel.TabIndex = 74;
            this.facultyLabel.Text = "Факультет:";
            // 
            // universityLabel
            // 
            this.universityLabel.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.universityLabel.Location = new System.Drawing.Point(10, 89);
            this.universityLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.universityLabel.Name = "universityLabel";
            this.universityLabel.Size = new System.Drawing.Size(114, 23);
            this.universityLabel.TabIndex = 73;
            this.universityLabel.Text = "Университет:";
            // 
            // averageMarkBox
            // 
            this.averageMarkBox.Location = new System.Drawing.Point(213, 249);
            this.averageMarkBox.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.averageMarkBox.Name = "averageMarkBox";
            this.averageMarkBox.Size = new System.Drawing.Size(88, 23);
            this.averageMarkBox.TabIndex = 72;
            this.averageMarkBox.TextChanged += new System.EventHandler(this.averageMarkBox_TextChanged);
            // 
            // courseBox
            // 
            this.courseBox.Location = new System.Drawing.Point(213, 209);
            this.courseBox.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.courseBox.Name = "courseBox";
            this.courseBox.Size = new System.Drawing.Size(88, 23);
            this.courseBox.TabIndex = 71;
            this.courseBox.TextChanged += new System.EventHandler(this.courseBox_TextChanged);
            // 
            // departmentBox
            // 
            this.departmentBox.Location = new System.Drawing.Point(157, 168);
            this.departmentBox.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.departmentBox.Name = "departmentBox";
            this.departmentBox.Size = new System.Drawing.Size(146, 23);
            this.departmentBox.TabIndex = 70;
            // 
            // facultyBox
            // 
            this.facultyBox.Location = new System.Drawing.Point(157, 129);
            this.facultyBox.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.facultyBox.Name = "facultyBox";
            this.facultyBox.Size = new System.Drawing.Size(146, 23);
            this.facultyBox.TabIndex = 69;
            // 
            // universityBox
            // 
            this.universityBox.Location = new System.Drawing.Point(157, 89);
            this.universityBox.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.universityBox.Name = "universityBox";
            this.universityBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.universityBox.Size = new System.Drawing.Size(146, 23);
            this.universityBox.TabIndex = 68;
            // 
            // ChangeStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(320, 406);
            this.Controls.Add(this.comboIdBox);
            this.Controls.Add(this.sendButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.idLabel);
            this.Controls.Add(this.averageMarkLabel);
            this.Controls.Add(this.FormLabel);
            this.Controls.Add(this.isFullTimeCheckBox);
            this.Controls.Add(this.departmentLabel);
            this.Controls.Add(this.facultyLabel);
            this.Controls.Add(this.universityLabel);
            this.Controls.Add(this.averageMarkBox);
            this.Controls.Add(this.courseBox);
            this.Controls.Add(this.departmentBox);
            this.Controls.Add(this.facultyBox);
            this.Controls.Add(this.universityBox);
            this.Name = "ChangeStudent";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ChangeStudent";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ChangeStudent_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox universityBox;
        private System.Windows.Forms.TextBox facultyBox;
        private System.Windows.Forms.TextBox departmentBox;
        private System.Windows.Forms.TextBox courseBox;
        private System.Windows.Forms.TextBox averageMarkBox;
        private System.Windows.Forms.Label universityLabel;
        private System.Windows.Forms.Label facultyLabel;
        private System.Windows.Forms.Label departmentLabel;
        private System.Windows.Forms.CheckBox isFullTimeCheckBox;
        private System.Windows.Forms.Label FormLabel;
        private System.Windows.Forms.Label averageMarkLabel;
        private System.Windows.Forms.Label idLabel;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button sendButton;
        private System.Windows.Forms.ComboBox comboIdBox;
    }
}