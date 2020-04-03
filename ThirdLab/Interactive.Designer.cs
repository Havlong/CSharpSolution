using System.ComponentModel;

namespace ThirdLab
{
    partial class Interactive
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
            this.addButton = new System.Windows.Forms.Button();
            this.idLabel = new System.Windows.Forms.Label();
            this.averageMarkLabel = new System.Windows.Forms.Label();
            this.FormLabel = new System.Windows.Forms.Label();
            this.isFullTimeCheckBox = new System.Windows.Forms.CheckBox();
            this.departmentLabel = new System.Windows.Forms.Label();
            this.facultyLabel = new System.Windows.Forms.Label();
            this.universityLabel = new System.Windows.Forms.Label();
            this.averageMarkBox = new System.Windows.Forms.TextBox();
            this.idBox = new System.Windows.Forms.TextBox();
            this.courseBox = new System.Windows.Forms.TextBox();
            this.departmentBox = new System.Windows.Forms.TextBox();
            this.facultyBox = new System.Windows.Forms.TextBox();
            this.universityBox = new System.Windows.Forms.TextBox();
            this.studentsList = new System.Windows.Forms.ListBox();
            this.delButton = new System.Windows.Forms.Button();
            this.showFirstButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.clear = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // addButton
            // 
            this.addButton.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.addButton.Location = new System.Drawing.Point(11, 308);
            this.addButton.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(100, 60);
            this.addButton.TabIndex = 60;
            this.addButton.Text = "Добавить";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // idLabel
            // 
            this.idLabel.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.idLabel.Location = new System.Drawing.Point(11, 209);
            this.idLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(140, 23);
            this.idLabel.TabIndex = 59;
            this.idLabel.Text = "Id:";
            // 
            // averageMarkLabel
            // 
            this.averageMarkLabel.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.averageMarkLabel.Location = new System.Drawing.Point(11, 169);
            this.averageMarkLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.averageMarkLabel.Name = "averageMarkLabel";
            this.averageMarkLabel.Size = new System.Drawing.Size(145, 23);
            this.averageMarkLabel.TabIndex = 58;
            this.averageMarkLabel.Text = "Средняя оценка:";
            // 
            // FormLabel
            // 
            this.FormLabel.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.FormLabel.Location = new System.Drawing.Point(11, 129);
            this.FormLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.FormLabel.Name = "FormLabel";
            this.FormLabel.Size = new System.Drawing.Size(140, 23);
            this.FormLabel.TabIndex = 57;
            this.FormLabel.Text = "Курс:";
            // 
            // isFullTimeCheckBox
            // 
            this.isFullTimeCheckBox.Checked = true;
            this.isFullTimeCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.isFullTimeCheckBox.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.isFullTimeCheckBox.Location = new System.Drawing.Point(11, 249);
            this.isFullTimeCheckBox.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.isFullTimeCheckBox.Name = "isFullTimeCheckBox";
            this.isFullTimeCheckBox.Size = new System.Drawing.Size(145, 29);
            this.isFullTimeCheckBox.TabIndex = 56;
            this.isFullTimeCheckBox.Text = "Очная форма";
            this.isFullTimeCheckBox.UseVisualStyleBackColor = true;
            // 
            // departmentLabel
            // 
            this.departmentLabel.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.departmentLabel.Location = new System.Drawing.Point(11, 89);
            this.departmentLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.departmentLabel.Name = "departmentLabel";
            this.departmentLabel.Size = new System.Drawing.Size(140, 23);
            this.departmentLabel.TabIndex = 55;
            this.departmentLabel.Text = "Кафедра:";
            // 
            // facultyLabel
            // 
            this.facultyLabel.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.facultyLabel.Location = new System.Drawing.Point(11, 49);
            this.facultyLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.facultyLabel.Name = "facultyLabel";
            this.facultyLabel.Size = new System.Drawing.Size(140, 23);
            this.facultyLabel.TabIndex = 54;
            this.facultyLabel.Text = "Факультет:";
            // 
            // universityLabel
            // 
            this.universityLabel.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.universityLabel.Location = new System.Drawing.Point(11, 9);
            this.universityLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.universityLabel.Name = "universityLabel";
            this.universityLabel.Size = new System.Drawing.Size(140, 23);
            this.universityLabel.TabIndex = 53;
            this.universityLabel.Text = "Университет:";
            // 
            // averageMarkBox
            // 
            this.averageMarkBox.Location = new System.Drawing.Point(213, 169);
            this.averageMarkBox.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.averageMarkBox.Name = "averageMarkBox";
            this.averageMarkBox.Size = new System.Drawing.Size(88, 23);
            this.averageMarkBox.TabIndex = 52;
            this.averageMarkBox.Text = "4";
            this.averageMarkBox.TextChanged += new System.EventHandler(this.averageMarkBox_TextChanged);
            // 
            // idBox
            // 
            this.idBox.Location = new System.Drawing.Point(213, 209);
            this.idBox.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.idBox.Name = "idBox";
            this.idBox.Size = new System.Drawing.Size(88, 23);
            this.idBox.TabIndex = 51;
            this.idBox.Text = "1";
            this.idBox.TextChanged += new System.EventHandler(this.idBox_TextChanged);
            // 
            // courseBox
            // 
            this.courseBox.Location = new System.Drawing.Point(213, 129);
            this.courseBox.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.courseBox.Name = "courseBox";
            this.courseBox.Size = new System.Drawing.Size(88, 23);
            this.courseBox.TabIndex = 50;
            this.courseBox.Text = "2";
            this.courseBox.TextChanged += new System.EventHandler(this.courseBox_TextChanged);
            // 
            // departmentBox
            // 
            this.departmentBox.Location = new System.Drawing.Point(155, 89);
            this.departmentBox.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.departmentBox.Name = "departmentBox";
            this.departmentBox.Size = new System.Drawing.Size(146, 23);
            this.departmentBox.TabIndex = 49;
            this.departmentBox.Text = "МОиПЭВМ";
            // 
            // facultyBox
            // 
            this.facultyBox.Location = new System.Drawing.Point(155, 49);
            this.facultyBox.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.facultyBox.Name = "facultyBox";
            this.facultyBox.Size = new System.Drawing.Size(146, 23);
            this.facultyBox.TabIndex = 48;
            this.facultyBox.Text = "ФВТ";
            // 
            // universityBox
            // 
            this.universityBox.Location = new System.Drawing.Point(155, 9);
            this.universityBox.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.universityBox.Name = "universityBox";
            this.universityBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.universityBox.Size = new System.Drawing.Size(146, 23);
            this.universityBox.TabIndex = 47;
            this.universityBox.Text = "ПГУ";
            // 
            // studentsList
            // 
            this.studentsList.FormattingEnabled = true;
            this.studentsList.ItemHeight = 15;
            this.studentsList.Location = new System.Drawing.Point(374, 9);
            this.studentsList.Name = "studentsList";
            this.studentsList.Size = new System.Drawing.Size(144, 289);
            this.studentsList.TabIndex = 61;
            // 
            // delButton
            // 
            this.delButton.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.delButton.Location = new System.Drawing.Point(115, 308);
            this.delButton.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.delButton.Name = "delButton";
            this.delButton.Size = new System.Drawing.Size(100, 60);
            this.delButton.TabIndex = 62;
            this.delButton.Text = "Удалить";
            this.delButton.UseVisualStyleBackColor = true;
            this.delButton.Click += new System.EventHandler(this.delButton_Click);
            // 
            // showFirstButton
            // 
            this.showFirstButton.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.showFirstButton.Location = new System.Drawing.Point(219, 308);
            this.showFirstButton.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.showFirstButton.Name = "showFirstButton";
            this.showFirstButton.Size = new System.Drawing.Size(120, 60);
            this.showFirstButton.TabIndex = 63;
            this.showFirstButton.Text = "Показать первого";
            this.showFirstButton.UseVisualStyleBackColor = true;
            this.showFirstButton.Click += new System.EventHandler(this.showFirstButton_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.label1.Location = new System.Drawing.Point(344, 328);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 23);
            this.label1.TabIndex = 64;
            this.label1.Text = "Время выполнения:";
            // 
            // clear
            // 
            this.clear.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.clear.Location = new System.Drawing.Point(524, 328);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(40, 23);
            this.clear.TabIndex = 68;
            // 
            // Interactive
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 381);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.showFirstButton);
            this.Controls.Add(this.delButton);
            this.Controls.Add(this.studentsList);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.idLabel);
            this.Controls.Add(this.averageMarkLabel);
            this.Controls.Add(this.FormLabel);
            this.Controls.Add(this.isFullTimeCheckBox);
            this.Controls.Add(this.departmentLabel);
            this.Controls.Add(this.facultyLabel);
            this.Controls.Add(this.universityLabel);
            this.Controls.Add(this.averageMarkBox);
            this.Controls.Add(this.idBox);
            this.Controls.Add(this.courseBox);
            this.Controls.Add(this.departmentBox);
            this.Controls.Add(this.facultyBox);
            this.Controls.Add(this.universityBox);
            this.Name = "Interactive";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Interactive";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Interactive_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox universityBox;
        private System.Windows.Forms.TextBox facultyBox;
        private System.Windows.Forms.TextBox departmentBox;
        private System.Windows.Forms.TextBox courseBox;
        private System.Windows.Forms.TextBox idBox;
        private System.Windows.Forms.TextBox averageMarkBox;
        private System.Windows.Forms.Label universityLabel;
        private System.Windows.Forms.Label facultyLabel;
        private System.Windows.Forms.Label departmentLabel;
        private System.Windows.Forms.CheckBox isFullTimeCheckBox;
        private System.Windows.Forms.Label FormLabel;
        private System.Windows.Forms.Label averageMarkLabel;
        private System.Windows.Forms.Label idLabel;
        private System.Windows.Forms.Button delButton;
        private System.Windows.Forms.ListBox studentsList;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button showFirstButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label clear;
    }
}