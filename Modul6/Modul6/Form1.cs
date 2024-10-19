using Firebase.Database;
using Firebase.Database.Query;
using System;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Modul6
{
    public partial class Form1 : Form
    {
        private readonly FirebaseClient firebaseClient;

        public Form1()
        {
            InitializeComponent();
            firebaseClient = new FirebaseClient("https://modul6-85410-default-rtdb.firebaseio.com/");
            LoadTasks();
        }

        // Загрузка задач из Firebase в DataGridView
        private async void LoadTasks()
        {
            // Очистка текущих столбцов и строк
            dataGridViewTasks.Columns.Clear();
            dataGridViewTasks.Rows.Clear();

            // Добавление столбцов в DataGridView
            dataGridViewTasks.Columns.Add("Id", "ID");
            dataGridViewTasks.Columns.Add("Title", "Title");
            dataGridViewTasks.Columns.Add("Description", "Description");
            dataGridViewTasks.Columns.Add("IsCompleted", "Completed");

            // Получение данных из Firebase
            var tasks = await firebaseClient
                .Child("Tasks")
                .OnceAsync<TaskModel>();

            // Добавление строк в DataGridView
            foreach (var task in tasks)
            {
                dataGridViewTasks.Rows.Add(task.Key, task.Object.Title, task.Object.Description, task.Object.IsCompleted);
            }
        }


        // Добавление новой задачи
        private async void btnAdd_Click(object sender, EventArgs e)
        {
            var task = new TaskModel
            {
                Title = txtTitle.Text,
                Description = txtDescription.Text,
                IsCompleted = false,
                CreatedAt = DateTime.Now
            };

            await firebaseClient
                .Child("Tasks")
                .PostAsync(task);

            LoadTasks();
            ClearFields();
        }

        // Удаление задачи
        private async void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridViewTasks.SelectedRows.Count > 0)
            {
                var taskId = dataGridViewTasks.SelectedRows[0].Cells[0].Value.ToString();
                await firebaseClient.Child("Tasks").Child(taskId).DeleteAsync();
                LoadTasks();
            }
        }

        // Обновление задачи
        private async void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dataGridViewTasks.SelectedRows.Count > 0)
            {
                var taskId = dataGridViewTasks.SelectedRows[0].Cells[0].Value.ToString();
                var updatedTask = new TaskModel
                {
                    Title = txtTitle.Text,
                    Description = txtDescription.Text,
                    IsCompleted = checkBoxCompleted.Checked,
                    CreatedAt = DateTime.Now
                };

                await firebaseClient.Child("Tasks").Child(taskId).PutAsync(updatedTask);
                LoadTasks();
                ClearFields();
            }
        }

        // Очистка полей ввода
        private void ClearFields()
        {
            txtTitle.Text = string.Empty;
            txtDescription.Text = string.Empty;
            checkBoxCompleted.Checked = false;
        }

        // Выбор задачи из DataGridView
        private void dataGridViewTasks_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridViewTasks.SelectedRows.Count > 0)
            {
                txtTitle.Text = dataGridViewTasks.SelectedRows[0].Cells[1].Value.ToString();
                txtDescription.Text = dataGridViewTasks.SelectedRows[0].Cells[2].Value.ToString();
                checkBoxCompleted.Checked = (bool)dataGridViewTasks.SelectedRows[0].Cells[3].Value;
            }
        }
    }
}
