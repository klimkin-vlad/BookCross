namespace BookCross
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.showReaderButton = new System.Windows.Forms.Button();
            this.showBookButton = new System.Windows.Forms.Button();
            this.showPlaceButton = new System.Windows.Forms.Button();
            this.mainTable = new System.Windows.Forms.DataGridView();
            this.addButton = new System.Windows.Forms.Button();
            this.takeButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.mainTable)).BeginInit();
            this.SuspendLayout();
            // 
            // showReaderButton
            // 
            this.showReaderButton.Location = new System.Drawing.Point(12, 13);
            this.showReaderButton.Name = "showReaderButton";
            this.showReaderButton.Size = new System.Drawing.Size(90, 23);
            this.showReaderButton.TabIndex = 0;
            this.showReaderButton.Text = "Читатели";
            this.showReaderButton.UseVisualStyleBackColor = true;
            this.showReaderButton.Click += new System.EventHandler(this.ShowReaderButton_Click);
            // 
            // showBookButton
            // 
            this.showBookButton.Location = new System.Drawing.Point(13, 43);
            this.showBookButton.Name = "showBookButton";
            this.showBookButton.Size = new System.Drawing.Size(89, 23);
            this.showBookButton.TabIndex = 1;
            this.showBookButton.Text = "Книги";
            this.showBookButton.UseVisualStyleBackColor = true;
            this.showBookButton.Click += new System.EventHandler(this.ShowBookButton_Click);
            // 
            // showPlaceButton
            // 
            this.showPlaceButton.Location = new System.Drawing.Point(13, 73);
            this.showPlaceButton.Name = "showPlaceButton";
            this.showPlaceButton.Size = new System.Drawing.Size(89, 23);
            this.showPlaceButton.TabIndex = 2;
            this.showPlaceButton.Text = "Места";
            this.showPlaceButton.UseVisualStyleBackColor = true;
            this.showPlaceButton.Click += new System.EventHandler(this.ShowPlaceButton_Click);
            // 
            // mainTable
            // 
            this.mainTable.AllowUserToAddRows = false;
            this.mainTable.AllowUserToDeleteRows = false;
            this.mainTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.mainTable.Location = new System.Drawing.Point(108, 13);
            this.mainTable.MultiSelect = false;
            this.mainTable.Name = "mainTable";
            this.mainTable.ReadOnly = true;
            this.mainTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.mainTable.Size = new System.Drawing.Size(482, 172);
            this.mainTable.TabIndex = 3;
            this.mainTable.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.MainTable_RowEnter);
            // 
            // addButton
            // 
            this.addButton.Enabled = false;
            this.addButton.Location = new System.Drawing.Point(12, 114);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(90, 23);
            this.addButton.TabIndex = 4;
            this.addButton.Text = "Добавить";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // takeButton
            // 
            this.takeButton.Enabled = false;
            this.takeButton.Location = new System.Drawing.Point(12, 143);
            this.takeButton.Name = "takeButton";
            this.takeButton.Size = new System.Drawing.Size(90, 23);
            this.takeButton.TabIndex = 5;
            this.takeButton.Text = "Бронировать";
            this.takeButton.UseVisualStyleBackColor = true;
            this.takeButton.Click += new System.EventHandler(this.TakeButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(622, 197);
            this.Controls.Add(this.takeButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.mainTable);
            this.Controls.Add(this.showPlaceButton);
            this.Controls.Add(this.showBookButton);
            this.Controls.Add(this.showReaderButton);
            this.Name = "MainForm";
            this.Text = "Книжная биржа";
            ((System.ComponentModel.ISupportInitialize)(this.mainTable)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button showReaderButton;
        private System.Windows.Forms.Button showBookButton;
        private System.Windows.Forms.Button showPlaceButton;
        private System.Windows.Forms.DataGridView mainTable;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button takeButton;
    }
}

