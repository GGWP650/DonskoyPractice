namespace Modul8
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освобождает все ресурсы, которые использует форма.
        /// </summary>
        /// <param name="disposing">true, если управляемый ресурс должен быть удален; иначе false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataGridViewTasks = new System.Windows.Forms.DataGridView();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.dateTimePickerDueDate = new System.Windows.Forms.DateTimePicker();
            this.comboBoxCategory = new System.Windows.Forms.ComboBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.btnAddTask = new System.Windows.Forms.Button();
            this.btnDeleteTask = new System.Windows.Forms.Button();
            this.timerReminder = new System.Windows.Forms.Timer(this.components);
            this.labelTitle = new System.Windows.Forms.Label();
            this.labelDueDate = new System.Windows.Forms.Label();
            this.labelCategory = new System.Windows.Forms.Label();
            this.labelDescription = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTasks)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewTasks
            // 
            this.dataGridViewTasks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTasks.Location = new System.Drawing.Point(12, 12);
            this.dataGridViewTasks.Name = "dataGridViewTasks";
            this.dataGridViewTasks.Size = new System.Drawing.Size(460, 200);
            this.dataGridViewTasks.TabIndex = 0;
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(100, 230);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(200, 20);
            this.txtTitle.TabIndex = 1;
            // 
            // dateTimePickerDueDate
            // 
            this.dateTimePickerDueDate.Location = new System.Drawing.Point(100, 260);
            this.dateTimePickerDueDate.Name = "dateTimePickerDueDate";
            this.dateTimePickerDueDate.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerDueDate.TabIndex = 2;
            // 
            // comboBoxCategory
            // 
            this.comboBoxCategory.FormattingEnabled = true;
            this.comboBoxCategory.Items.AddRange(new object[] {
            "Работа",
            "Личное",
            "Другое"});
            this.comboBoxCategory.Location = new System.Drawing.Point(100, 290);
            this.comboBoxCategory.Name = "comboBoxCategory";
            this.comboBoxCategory.Size = new System.Drawing.Size(200, 21);
            this.comboBoxCategory.TabIndex = 3;
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(100, 320);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(200, 60);
            this.txtDescription.TabIndex = 4;
            // 
            // btnAddTask
            // 
            this.btnAddTask.Location = new System.Drawing.Point(320, 230);
            this.btnAddTask.Name = "btnAddTask";
            this.btnAddTask.Size = new System.Drawing.Size(75, 23);
            this.btnAddTask.TabIndex = 5;
            this.btnAddTask.Text = "Добавить";
            this.btnAddTask.UseVisualStyleBackColor = true;
            this.btnAddTask.Click += new System.EventHandler(this.btnAddTask_Click);
            // 
            // btnDeleteTask
            // 
            this.btnDeleteTask.Location = new System.Drawing.Point(320, 260);
            this.btnDeleteTask.Name = "btnDeleteTask";
            this.btnDeleteTask.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteTask.TabIndex = 6;
            this.btnDeleteTask.Text = "Удалить";
            this.btnDeleteTask.UseVisualStyleBackColor = true;
            this.btnDeleteTask.Click += new System.EventHandler(this.btnDeleteTask_Click);
            // 
            // timerReminder
            // 
            this.timerReminder.Enabled = true;
            this.timerReminder.Interval = 60000;
            this.timerReminder.Tick += new System.EventHandler(this.timerReminder_Tick);
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Location = new System.Drawing.Point(12, 233);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(57, 13);
            this.labelTitle.TabIndex = 7;
            this.labelTitle.Text = "Название:";
            // 
            // labelDueDate
            // 
            this.labelDueDate.AutoSize = true;
            this.labelDueDate.Location = new System.Drawing.Point(12, 266);
            this.labelDueDate.Name = "labelDueDate";
            this.labelDueDate.Size = new System.Drawing.Size(33, 13);
            this.labelDueDate.TabIndex = 8;
            this.labelDueDate.Text = "Дата:";
            // 
            // labelCategory
            // 
            this.labelCategory.AutoSize = true;
            this.labelCategory.Location = new System.Drawing.Point(12, 293);
            this.labelCategory.Name = "labelCategory";
            this.labelCategory.Size = new System.Drawing.Size(60, 13);
            this.labelCategory.TabIndex = 9;
            this.labelCategory.Text = "Категория:";
            // 
            // labelDescription
            // 
            this.labelDescription.AutoSize = true;
            this.labelDescription.Location = new System.Drawing.Point(12, 320);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Size = new System.Drawing.Size(57, 13);
            this.labelDescription.TabIndex = 10;
            this.labelDescription.Text = "Описание:";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 411);
            this.Controls.Add(this.labelDescription);
            this.Controls.Add(this.labelCategory);
            this.Controls.Add(this.labelDueDate);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.btnDeleteTask);
            this.Controls.Add(this.btnAddTask);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.comboBoxCategory);
            this.Controls.Add(this.dateTimePickerDueDate);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.dataGridViewTasks);
            this.Name = "MainForm";
            this.Text = "Учет задач и событий";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTasks)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewTasks;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.DateTimePicker dateTimePickerDueDate;
        private System.Windows.Forms.ComboBox comboBoxCategory;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Button btnAddTask;
        private System.Windows.Forms.Button btnDeleteTask;
        private System.Windows.Forms.Timer timerReminder;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label labelDueDate;
        private System.Windows.Forms.Label labelCategory;
        private System.Windows.Forms.Label labelDescription;
    }
}
