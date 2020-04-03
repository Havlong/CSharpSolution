using System.ComponentModel;

namespace SecondLab
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
            System.ComponentModel.ComponentResourceManager resources =
                new System.ComponentModel.ComponentResourceManager(typeof(AddStudent));
            this.countStudentsLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
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
            // countStudentsLabel
            // 
            this.countStudentsLabel.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.countStudentsLabel.Location = new System.Drawing.Point(485, 342);
            this.countStudentsLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.countStudentsLabel.Name = "countStudentsLabel";
            this.countStudentsLabel.Size = new System.Drawing.Size(57, 31);
            this.countStudentsLabel.TabIndex = 46;
            this.countStudentsLabel.Text = "0";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.label1.Location = new System.Drawing.Point(227, 340);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(242, 31);
            this.label1.TabIndex = 45;
            this.label1.Text = "Количество студентов:";
            // 
            // sendButton
            // 
            this.sendButton.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.sendButton.Location = new System.Drawing.Point(227, 400);
            this.sendButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.sendButton.Name = "sendButton";
            this.sendButton.Size = new System.Drawing.Size(114, 66);
            this.sendButton.TabIndex = 44;
            this.sendButton.Text = "Добавить";
            this.sendButton.UseVisualStyleBackColor = true;
            this.sendButton.Click += new System.EventHandler(this.sendButton_Click);
            // 
            // idLabel
            // 
            this.idLabel.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.idLabel.Location = new System.Drawing.Point(11, 280);
            this.idLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(160, 31);
            this.idLabel.TabIndex = 43;
            this.idLabel.Text = "Id:";
            // 
            // averageMarkLabel
            // 
            this.averageMarkLabel.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.averageMarkLabel.Location = new System.Drawing.Point(11, 226);
            this.averageMarkLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.averageMarkLabel.Name = "averageMarkLabel";
            this.averageMarkLabel.Size = new System.Drawing.Size(165, 31);
            this.averageMarkLabel.TabIndex = 42;
            this.averageMarkLabel.Text = "Средняя оценка:";
            // 
            // FormLabel
            // 
            this.FormLabel.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.FormLabel.Location = new System.Drawing.Point(11, 174);
            this.FormLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.FormLabel.Name = "FormLabel";
            this.FormLabel.Size = new System.Drawing.Size(160, 31);
            this.FormLabel.TabIndex = 41;
            this.FormLabel.Text = "Курс:";
            // 
            // isFullTimeCheckBox
            // 
            this.isFullTimeCheckBox.Checked = true;
            this.isFullTimeCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.isFullTimeCheckBox.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.isFullTimeCheckBox.Location = new System.Drawing.Point(11, 334);
            this.isFullTimeCheckBox.Margin = new System.Windows.Forms.Padding(2);
            this.isFullTimeCheckBox.Name = "isFullTimeCheckBox";
            this.isFullTimeCheckBox.Size = new System.Drawing.Size(165, 39);
            this.isFullTimeCheckBox.TabIndex = 40;
            this.isFullTimeCheckBox.Text = "Очная форма";
            this.isFullTimeCheckBox.UseVisualStyleBackColor = true;
            // 
            // departmentLabel
            // 
            this.departmentLabel.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.departmentLabel.Location = new System.Drawing.Point(11, 120);
            this.departmentLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.departmentLabel.Name = "departmentLabel";
            this.departmentLabel.Size = new System.Drawing.Size(160, 31);
            this.departmentLabel.TabIndex = 39;
            this.departmentLabel.Text = "Кафедра:";
            // 
            // facultyLabel
            // 
            this.facultyLabel.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.facultyLabel.Location = new System.Drawing.Point(11, 66);
            this.facultyLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.facultyLabel.Name = "facultyLabel";
            this.facultyLabel.Size = new System.Drawing.Size(160, 31);
            this.facultyLabel.TabIndex = 38;
            this.facultyLabel.Text = "Факультет:";
            // 
            // universityLabel
            // 
            this.universityLabel.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.universityLabel.Location = new System.Drawing.Point(11, 14);
            this.universityLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.universityLabel.Name = "universityLabel";
            this.universityLabel.Size = new System.Drawing.Size(160, 31);
            this.universityLabel.TabIndex = 37;
            this.universityLabel.Text = "Университет:";
            // 
            // averageMarkBox
            // 
            this.averageMarkBox.Location = new System.Drawing.Point(241, 226);
            this.averageMarkBox.Margin = new System.Windows.Forms.Padding(2);
            this.averageMarkBox.Name = "averageMarkBox";
            this.averageMarkBox.Size = new System.Drawing.Size(100, 27);
            this.averageMarkBox.TabIndex = 36;
            this.averageMarkBox.Text = "4";
            this.averageMarkBox.TextChanged += new System.EventHandler(this.averageMarkBox_TextChanged);
            // 
            // idBox
            // 
            this.idBox.Location = new System.Drawing.Point(241, 280);
            this.idBox.Margin = new System.Windows.Forms.Padding(2);
            this.idBox.Name = "idBox";
            this.idBox.Size = new System.Drawing.Size(100, 27);
            this.idBox.TabIndex = 35;
            this.idBox.Text = "1";
            this.idBox.TextChanged += new System.EventHandler(this.idBox_TextChanged);
            // 
            // courseBox
            // 
            this.courseBox.Location = new System.Drawing.Point(241, 174);
            this.courseBox.Margin = new System.Windows.Forms.Padding(2);
            this.courseBox.Name = "courseBox";
            this.courseBox.Size = new System.Drawing.Size(100, 27);
            this.courseBox.TabIndex = 34;
            this.courseBox.Text = "2";
            this.courseBox.TextChanged += new System.EventHandler(this.courseBox_TextChanged);
            // 
            // departmentBox
            // 
            this.departmentBox.Location = new System.Drawing.Point(175, 120);
            this.departmentBox.Margin = new System.Windows.Forms.Padding(2);
            this.departmentBox.Name = "departmentBox";
            this.departmentBox.Size = new System.Drawing.Size(166, 27);
            this.departmentBox.TabIndex = 33;
            this.departmentBox.Text = "МОиПЭВМ";
            // 
            // facultyBox
            // 
            this.facultyBox.Location = new System.Drawing.Point(175, 66);
            this.facultyBox.Margin = new System.Windows.Forms.Padding(2);
            this.facultyBox.Name = "facultyBox";
            this.facultyBox.Size = new System.Drawing.Size(166, 27);
            this.facultyBox.TabIndex = 32;
            this.facultyBox.Text = "ФВТ";
            // 
            // universityBox
            // 
            this.universityBox.Location = new System.Drawing.Point(175, 14);
            this.universityBox.Margin = new System.Windows.Forms.Padding(2);
            this.universityBox.Name = "universityBox";
            this.universityBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.universityBox.Size = new System.Drawing.Size(166, 27);
            this.universityBox.TabIndex = 31;
            this.universityBox.Text = "ПГУ";
            // 
            // AddStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(553, 508);
            this.Controls.Add(this.countStudentsLabel);
            this.Controls.Add(this.label1);
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
            this.Icon = ((System.Drawing.Icon) (resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "AddStudent";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Добавить студента";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AddStudent_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label universityLabel;
        private System.Windows.Forms.Label facultyLabel;
        private System.Windows.Forms.Label departmentLabel;
        private System.Windows.Forms.Label FormLabel;
        private System.Windows.Forms.Label averageMarkLabel;
        private System.Windows.Forms.Label idLabel;
        private System.Windows.Forms.Button sendButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label countStudentsLabel;
        private System.Windows.Forms.TextBox averageMarkBox;
        private System.Windows.Forms.TextBox idBox;
        private System.Windows.Forms.TextBox departmentBox;
        private System.Windows.Forms.TextBox facultyBox;
        private System.Windows.Forms.TextBox universityBox;
        private System.Windows.Forms.TextBox courseBox;
        private System.Windows.Forms.CheckBox isFullTimeCheckBox;
    }
}