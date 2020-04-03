using System.ComponentModel;

namespace ThirdLab
{
    partial class Comparison
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
            this.nBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.sendButton = new System.Windows.Forms.Button();
            this.leadTimeList = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // nBox
            // 
            this.nBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.nBox.Location = new System.Drawing.Point(272, 9);
            this.nBox.Name = "nBox";
            this.nBox.Size = new System.Drawing.Size(100, 23);
            this.nBox.TabIndex = 6;
            this.nBox.Text = "100000";
            this.nBox.TextChanged += new System.EventHandler(this.nBox_TextChanged);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(235, 23);
            this.label1.TabIndex = 5;
            this.label1.Text = "Количество студентов:\r\n";
            // 
            // sendButton
            // 
            this.sendButton.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.sendButton.Location = new System.Drawing.Point(113, 35);
            this.sendButton.Name = "sendButton";
            this.sendButton.Size = new System.Drawing.Size(154, 53);
            this.sendButton.TabIndex = 7;
            this.sendButton.Text = "Сгенерировать";
            this.sendButton.UseVisualStyleBackColor = true;
            this.sendButton.Click += new System.EventHandler(this.sendButton_Click);
            // 
            // leadTimeList
            // 
            this.leadTimeList.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.leadTimeList.FormattingEnabled = true;
            this.leadTimeList.ItemHeight = 15;
            this.leadTimeList.Location = new System.Drawing.Point(12, 118);
            this.leadTimeList.Name = "leadTimeList";
            this.leadTimeList.Size = new System.Drawing.Size(360, 94);
            this.leadTimeList.TabIndex = 8;
            // 
            // Comparison
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 231);
            this.Controls.Add(this.leadTimeList);
            this.Controls.Add(this.sendButton);
            this.Controls.Add(this.nBox);
            this.Controls.Add(this.label1);
            this.Name = "Comparison";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Comparison";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Comparison_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nBox;
        private System.Windows.Forms.ListBox leadTimeList;
        private System.Windows.Forms.Button sendButton;
    }
}