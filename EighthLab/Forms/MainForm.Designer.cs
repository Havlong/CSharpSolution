namespace EighthLab.Forms
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
            this.collectionsList = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.CountCollectionsButton = new System.Windows.Forms.Button();
            this.AddCollectionButton = new System.Windows.Forms.Button();
            this.MaxCollectionButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.idBox = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize) (this.idBox)).BeginInit();
            this.SuspendLayout();
            // 
            // collectionsList
            // 
            this.collectionsList.FormattingEnabled = true;
            this.collectionsList.Location = new System.Drawing.Point(282, 12);
            this.collectionsList.Name = "collectionsList";
            this.collectionsList.Size = new System.Drawing.Size(281, 433);
            this.collectionsList.TabIndex = 67;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.label1.Location = new System.Drawing.Point(11, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(266, 86);
            this.label1.TabIndex = 66;
            this.label1.Text = "Лабораторная работа по C# №8.\r\n12 Вариант.\r\nКостерев Григорий\r\nЕвгений Гришин\r\n";
            // 
            // CountCollectionsButton
            // 
            this.CountCollectionsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.CountCollectionsButton.Location = new System.Drawing.Point(39, 204);
            this.CountCollectionsButton.Name = "CountCollectionsButton";
            this.CountCollectionsButton.Size = new System.Drawing.Size(200, 100);
            this.CountCollectionsButton.TabIndex = 65;
            this.CountCollectionsButton.Text = "Количество студентов с данным id";
            this.CountCollectionsButton.UseVisualStyleBackColor = true;
            this.CountCollectionsButton.Click += new System.EventHandler(this.CountCollectionsButton_Click);
            // 
            // AddCollectionButton
            // 
            this.AddCollectionButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.AddCollectionButton.Location = new System.Drawing.Point(39, 98);
            this.AddCollectionButton.Name = "AddCollectionButton";
            this.AddCollectionButton.Size = new System.Drawing.Size(200, 100);
            this.AddCollectionButton.TabIndex = 64;
            this.AddCollectionButton.Text = "Добавить коллекцию";
            this.AddCollectionButton.UseVisualStyleBackColor = true;
            this.AddCollectionButton.Click += new System.EventHandler(this.AddCollectionButton_Click);
            // 
            // MaxCollectionButton
            // 
            this.MaxCollectionButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.MaxCollectionButton.Location = new System.Drawing.Point(39, 310);
            this.MaxCollectionButton.Name = "MaxCollectionButton";
            this.MaxCollectionButton.Size = new System.Drawing.Size(200, 100);
            this.MaxCollectionButton.TabIndex = 68;
            this.MaxCollectionButton.Text = "Максимальная коллекция содержащая id";
            this.MaxCollectionButton.UseVisualStyleBackColor = true;
            this.MaxCollectionButton.Click += new System.EventHandler(this.MaxCollectionButton_Click);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.label2.Location = new System.Drawing.Point(39, 417);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 23);
            this.label2.TabIndex = 70;
            this.label2.Text = "ID:";
            // 
            // idBox
            // 
            this.idBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.idBox.Location = new System.Drawing.Point(139, 415);
            this.idBox.Name = "idBox";
            this.idBox.Size = new System.Drawing.Size(100, 24);
            this.idBox.TabIndex = 71;
            this.idBox.Value = new decimal(new int[] {1, 0, 0, 0});
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 461);
            this.Controls.Add(this.idBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.MaxCollectionButton);
            this.Controls.Add(this.collectionsList);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CountCollectionsButton);
            this.Controls.Add(this.AddCollectionButton);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Программа!";
            ((System.ComponentModel.ISupportInitialize) (this.idBox)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button AddCollectionButton;
        private System.Windows.Forms.ListBox collectionsList;
        private System.Windows.Forms.Button CountCollectionsButton;
        private System.Windows.Forms.NumericUpDown idBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button MaxCollectionButton;

        #endregion
    }
}