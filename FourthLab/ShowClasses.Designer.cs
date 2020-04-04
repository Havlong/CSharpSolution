using System.ComponentModel;

namespace FourthLab
{
    partial class ShowClasses
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
            this.classesTree = new System.Windows.Forms.TreeView();
            this.SuspendLayout();
            // 
            // classesTree
            // 
            this.classesTree.Location = new System.Drawing.Point(12, 12);
            this.classesTree.Name = "classesTree";
            this.classesTree.Size = new System.Drawing.Size(300, 350);
            this.classesTree.TabIndex = 0;
            // 
            // ShowClasses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 381);
            this.Controls.Add(this.classesTree);
            this.Name = "ShowClasses";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ShowClasses";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ShowClasses_FormClosed);
            this.Load += new System.EventHandler(this.ShowClasses_Load);
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.TreeView classesTree;
    }
}