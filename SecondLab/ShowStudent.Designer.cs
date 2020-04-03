using System.ComponentModel;

namespace SecondLab
{
    partial class ShowStudent
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
            System.ComponentModel.ComponentResourceManager resources =
                new System.ComponentModel.ComponentResourceManager(typeof(ShowStudent));
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
            this.label2 = new System.Windows.Forms.Label();
            this.sendButton = new System.Windows.Forms.Button();
            this.countStudentsLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboIdBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // searchButton
            // 
            this.searchButton.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.searchButton.Location = new System.Drawing.Point(229, 49);
            this.searchButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(114, 40);
            this.searchButton.TabIndex = 60;
            this.searchButton.Text = "Найти";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // idLabel
            // 
            this.idLabel.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.idLabel.Location = new System.Drawing.Point(11, 54);
            this.idLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(51, 31);
            this.idLabel.TabIndex = 59;
            this.idLabel.Text = "ID:";
            // 
            // averageMarkLabel
            // 
            this.averageMarkLabel.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.averageMarkLabel.Location = new System.Drawing.Point(11, 334);
            this.averageMarkLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.averageMarkLabel.Name = "averageMarkLabel";
            this.averageMarkLabel.Size = new System.Drawing.Size(181, 31);
            this.averageMarkLabel.TabIndex = 58;
            this.averageMarkLabel.Text = "Средняя оценка:";
            // 
            // FormLabel
            // 
            this.FormLabel.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.FormLabel.Location = new System.Drawing.Point(11, 280);
            this.FormLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.FormLabel.Name = "FormLabel";
            this.FormLabel.Size = new System.Drawing.Size(131, 31);
            this.FormLabel.TabIndex = 57;
            this.FormLabel.Text = "Курс:";
            // 
            // isFullTimeCheckBox
            // 
            this.isFullTimeCheckBox.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.isFullTimeCheckBox.Location = new System.Drawing.Point(11, 386);
            this.isFullTimeCheckBox.Margin = new System.Windows.Forms.Padding(2);
            this.isFullTimeCheckBox.Name = "isFullTimeCheckBox";
            this.isFullTimeCheckBox.Size = new System.Drawing.Size(181, 39);
            this.isFullTimeCheckBox.TabIndex = 56;
            this.isFullTimeCheckBox.Text = "Очная форма";
            this.isFullTimeCheckBox.UseVisualStyleBackColor = true;
            // 
            // departmentLabel
            // 
            this.departmentLabel.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.departmentLabel.Location = new System.Drawing.Point(11, 226);
            this.departmentLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.departmentLabel.Name = "departmentLabel";
            this.departmentLabel.Size = new System.Drawing.Size(131, 31);
            this.departmentLabel.TabIndex = 55;
            this.departmentLabel.Text = "Кафедра:";
            // 
            // facultyLabel
            // 
            this.facultyLabel.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.facultyLabel.Location = new System.Drawing.Point(11, 174);
            this.facultyLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.facultyLabel.Name = "facultyLabel";
            this.facultyLabel.Size = new System.Drawing.Size(131, 31);
            this.facultyLabel.TabIndex = 54;
            this.facultyLabel.Text = "Факультет:";
            // 
            // universityLabel
            // 
            this.universityLabel.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.universityLabel.Location = new System.Drawing.Point(11, 120);
            this.universityLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.universityLabel.Name = "universityLabel";
            this.universityLabel.Size = new System.Drawing.Size(131, 31);
            this.universityLabel.TabIndex = 53;
            this.universityLabel.Text = "Университет:";
            // 
            // averageMarkBox
            // 
            this.averageMarkBox.Location = new System.Drawing.Point(243, 334);
            this.averageMarkBox.Margin = new System.Windows.Forms.Padding(2);
            this.averageMarkBox.Name = "averageMarkBox";
            this.averageMarkBox.Size = new System.Drawing.Size(100, 27);
            this.averageMarkBox.TabIndex = 52;
            this.averageMarkBox.TextChanged += new System.EventHandler(this.averageMarkBox_TextChanged);
            // 
            // courseBox
            // 
            this.courseBox.Location = new System.Drawing.Point(243, 280);
            this.courseBox.Margin = new System.Windows.Forms.Padding(2);
            this.courseBox.Name = "courseBox";
            this.courseBox.Size = new System.Drawing.Size(100, 27);
            this.courseBox.TabIndex = 50;
            this.courseBox.TextChanged += new System.EventHandler(this.courseBox_TextChanged);
            // 
            // departmentBox
            // 
            this.departmentBox.Location = new System.Drawing.Point(177, 226);
            this.departmentBox.Margin = new System.Windows.Forms.Padding(2);
            this.departmentBox.Name = "departmentBox";
            this.departmentBox.Size = new System.Drawing.Size(166, 27);
            this.departmentBox.TabIndex = 49;
            // 
            // facultyBox
            // 
            this.facultyBox.Location = new System.Drawing.Point(177, 174);
            this.facultyBox.Margin = new System.Windows.Forms.Padding(2);
            this.facultyBox.Name = "facultyBox";
            this.facultyBox.Size = new System.Drawing.Size(166, 27);
            this.facultyBox.TabIndex = 48;
            // 
            // universityBox
            // 
            this.universityBox.Location = new System.Drawing.Point(177, 120);
            this.universityBox.Margin = new System.Windows.Forms.Padding(2);
            this.universityBox.Name = "universityBox";
            this.universityBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.universityBox.Size = new System.Drawing.Size(166, 27);
            this.universityBox.TabIndex = 47;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.label2.Location = new System.Drawing.Point(11, 14);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(230, 31);
            this.label2.TabIndex = 63;
            this.label2.Text = "Найти студента по ID:";
            // 
            // sendButton
            // 
            this.sendButton.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.sendButton.Location = new System.Drawing.Point(229, 440);
            this.sendButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.sendButton.Name = "sendButton";
            this.sendButton.Size = new System.Drawing.Size(114, 66);
            this.sendButton.TabIndex = 64;
            this.sendButton.Text = "Изменить";
            this.sendButton.UseVisualStyleBackColor = true;
            this.sendButton.Click += new System.EventHandler(this.sendButton_Click);
            // 
            // countStudentsLabel
            // 
            this.countStudentsLabel.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.countStudentsLabel.Location = new System.Drawing.Point(471, 16);
            this.countStudentsLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.countStudentsLabel.Name = "countStudentsLabel";
            this.countStudentsLabel.Size = new System.Drawing.Size(69, 31);
            this.countStudentsLabel.TabIndex = 66;
            this.countStudentsLabel.Text = "0";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.label1.Location = new System.Drawing.Point(245, 14);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(222, 31);
            this.label1.TabIndex = 65;
            this.label1.Text = "Количество студентов";
            // 
            // comboIdBox
            // 
            this.comboIdBox.FormattingEnabled = true;
            this.comboIdBox.Location = new System.Drawing.Point(67, 58);
            this.comboIdBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboIdBox.Name = "comboIdBox";
            this.comboIdBox.Size = new System.Drawing.Size(121, 28);
            this.comboIdBox.TabIndex = 67;
            // 
            // ShowStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(553, 548);
            this.Controls.Add(this.comboIdBox);
            this.Controls.Add(this.countStudentsLabel);
            this.Controls.Add(this.label1);
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
            this.Icon = ((System.Drawing.Icon) (resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "ShowStudent";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Изменить студента";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ShowStudent_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button sendButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label universityLabel;
        private System.Windows.Forms.Label facultyLabel;
        private System.Windows.Forms.Label departmentLabel;
        private System.Windows.Forms.Label FormLabel;
        private System.Windows.Forms.Label averageMarkLabel;
        private System.Windows.Forms.Label idLabel;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.TextBox averageMarkBox;
        private System.Windows.Forms.TextBox courseBox;
        private System.Windows.Forms.TextBox departmentBox;
        private System.Windows.Forms.TextBox facultyBox;
        private System.Windows.Forms.TextBox universityBox;
        private System.Windows.Forms.CheckBox isFullTimeCheckBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label countStudentsLabel;
        private System.Windows.Forms.ComboBox comboIdBox;
    }
}