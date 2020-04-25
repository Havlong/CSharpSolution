using System.ComponentModel;

namespace FourthLab
{
    partial class AddStudent
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
            this.sendButton = new System.Windows.Forms.Button();
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
            this.SuspendLayout();
            // 
            // sendButton
            // 
            this.sendButton.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.sendButton.Location = new System.Drawing.Point(87, 244);
            this.sendButton.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.sendButton.Name = "sendButton";
            this.sendButton.Size = new System.Drawing.Size(86, 43);
            this.sendButton.TabIndex = 60;
            this.sendButton.Text = "Добавить";
            this.sendButton.UseVisualStyleBackColor = true;
            this.sendButton.Click += new System.EventHandler(this.sendButton_Click);
            // 
            // idLabel
            // 
            this.idLabel.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.idLabel.Location = new System.Drawing.Point(9, 181);
            this.idLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(120, 20);
            this.idLabel.TabIndex = 59;
            this.idLabel.Text = "Id:";
            // 
            // averageMarkLabel
            // 
            this.averageMarkLabel.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.averageMarkLabel.Location = new System.Drawing.Point(9, 146);
            this.averageMarkLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.averageMarkLabel.Name = "averageMarkLabel";
            this.averageMarkLabel.Size = new System.Drawing.Size(124, 20);
            this.averageMarkLabel.TabIndex = 58;
            this.averageMarkLabel.Text = "Средняя оценка:";
            // 
            // FormLabel
            // 
            this.FormLabel.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.FormLabel.Location = new System.Drawing.Point(9, 112);
            this.FormLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.FormLabel.Name = "FormLabel";
            this.FormLabel.Size = new System.Drawing.Size(120, 20);
            this.FormLabel.TabIndex = 57;
            this.FormLabel.Text = "Курс:";
            // 
            // isFullTimeCheckBox
            // 
            this.isFullTimeCheckBox.Checked = true;
            this.isFullTimeCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.isFullTimeCheckBox.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.isFullTimeCheckBox.Location = new System.Drawing.Point(9, 216);
            this.isFullTimeCheckBox.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.isFullTimeCheckBox.Name = "isFullTimeCheckBox";
            this.isFullTimeCheckBox.Size = new System.Drawing.Size(124, 25);
            this.isFullTimeCheckBox.TabIndex = 56;
            this.isFullTimeCheckBox.Text = "Очная форма";
            this.isFullTimeCheckBox.UseVisualStyleBackColor = true;
            // 
            // departmentLabel
            // 
            this.departmentLabel.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.departmentLabel.Location = new System.Drawing.Point(9, 77);
            this.departmentLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.departmentLabel.Name = "departmentLabel";
            this.departmentLabel.Size = new System.Drawing.Size(120, 20);
            this.departmentLabel.TabIndex = 55;
            this.departmentLabel.Text = "Кафедра:";
            // 
            // facultyLabel
            // 
            this.facultyLabel.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.facultyLabel.Location = new System.Drawing.Point(9, 42);
            this.facultyLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.facultyLabel.Name = "facultyLabel";
            this.facultyLabel.Size = new System.Drawing.Size(120, 20);
            this.facultyLabel.TabIndex = 54;
            this.facultyLabel.Text = "Факультет:";
            // 
            // universityLabel
            // 
            this.universityLabel.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.universityLabel.Location = new System.Drawing.Point(9, 8);
            this.universityLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.universityLabel.Name = "universityLabel";
            this.universityLabel.Size = new System.Drawing.Size(120, 20);
            this.universityLabel.TabIndex = 53;
            this.universityLabel.Text = "Университет:";
            // 
            // averageMarkBox
            // 
            this.averageMarkBox.Location = new System.Drawing.Point(183, 146);
            this.averageMarkBox.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.averageMarkBox.Name = "averageMarkBox";
            this.averageMarkBox.Size = new System.Drawing.Size(76, 20);
            this.averageMarkBox.TabIndex = 52;
            this.averageMarkBox.Text = "4";
            this.averageMarkBox.TextChanged += new System.EventHandler(this.averageMarkBox_TextChanged);
            // 
            // idBox
            // 
            this.idBox.Location = new System.Drawing.Point(183, 181);
            this.idBox.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.idBox.Name = "idBox";
            this.idBox.Size = new System.Drawing.Size(76, 20);
            this.idBox.TabIndex = 51;
            this.idBox.Text = "1";
            this.idBox.TextChanged += new System.EventHandler(this.idBox_TextChanged);
            // 
            // courseBox
            // 
            this.courseBox.Location = new System.Drawing.Point(183, 112);
            this.courseBox.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.courseBox.Name = "courseBox";
            this.courseBox.Size = new System.Drawing.Size(76, 20);
            this.courseBox.TabIndex = 50;
            this.courseBox.Text = "2";
            this.courseBox.TextChanged += new System.EventHandler(this.courseBox_TextChanged);
            // 
            // departmentBox
            // 
            this.departmentBox.Location = new System.Drawing.Point(133, 77);
            this.departmentBox.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.departmentBox.Name = "departmentBox";
            this.departmentBox.Size = new System.Drawing.Size(126, 20);
            this.departmentBox.TabIndex = 49;
            this.departmentBox.Text = "МОиПЭВМ";
            // 
            // facultyBox
            // 
            this.facultyBox.Location = new System.Drawing.Point(133, 42);
            this.facultyBox.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.facultyBox.Name = "facultyBox";
            this.facultyBox.Size = new System.Drawing.Size(126, 20);
            this.facultyBox.TabIndex = 48;
            this.facultyBox.Text = "ФВТ";
            // 
            // universityBox
            // 
            this.universityBox.Location = new System.Drawing.Point(133, 8);
            this.universityBox.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.universityBox.Name = "universityBox";
            this.universityBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.universityBox.Size = new System.Drawing.Size(126, 20);
            this.universityBox.TabIndex = 47;
            this.universityBox.Text = "ПГУ";
            // 
            // AddStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(286, 313);
            this.Controls.Add(this.sendButton);
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
            this.Name = "AddStudent";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddStudent";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AddStudent_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.TextBox averageMarkBox;
        private System.Windows.Forms.Label averageMarkLabel;
        private System.Windows.Forms.TextBox courseBox;
        private System.Windows.Forms.TextBox departmentBox;
        private System.Windows.Forms.Label departmentLabel;
        private System.Windows.Forms.TextBox facultyBox;
        private System.Windows.Forms.Label facultyLabel;
        private System.Windows.Forms.Label FormLabel;
        private System.Windows.Forms.TextBox idBox;
        private System.Windows.Forms.Label idLabel;
        private System.Windows.Forms.CheckBox isFullTimeCheckBox;
        private System.Windows.Forms.Button sendButton;
        private System.Windows.Forms.TextBox universityBox;
        private System.Windows.Forms.Label universityLabel;

        #endregion
    }
}