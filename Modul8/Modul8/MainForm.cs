using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Modul8
{
    public partial class MainForm : Form
    {
        // Список задач
        private List<TaskEvent> tasks = new List<TaskEvent>();
        // Путь к файлу JSON
        private string filePath = "tasks.json";

        public MainForm()
        {
            InitializeComponent();
            LoadTasks();     // Загружаем задачи при старте программы
            UpdateTaskList(); // Обновляем список задач на экране
        }

        // Загрузка задач из JSON-файла
        private void LoadTasks()
        {
            if (File.Exists(filePath))
            {
                string json = File.ReadAllText(filePath);
                tasks = JsonConvert.DeserializeObject<List<TaskEvent>>(json) ?? new List<TaskEvent>();
            }
        }

        // Сохранение задач в JSON-файл
        private void SaveTasks()
        {
            string json = JsonConvert.SerializeObject(tasks, Formatting.Indented);
            File.WriteAllText(filePath, json);
        }

        // Обновление списка задач в DataGridView
        private void UpdateTaskList()
        {
            dataGridViewTasks.DataSource = null;
            dataGridViewTasks.DataSource = tasks;
            dataGridViewTasks.Refresh();
        }

        // Добавление новой задачи
        private void btnAddTask_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTitle.Text) || comboBoxCategory.SelectedIndex == -1)
            {
                MessageBox.Show("Заполните все поля перед добавлением задачи.", "Ошибка");
                return;
            }

            TaskEvent newTask = new TaskEvent
            {
                Title = txtTitle.Text,
                DueDate = dateTimePickerDueDate.Value,
                Category = comboBoxCategory.SelectedItem.ToString(),
                Description = txtDescription.Text,
                IsCompleted = false
            };

            tasks.Add(newTask);
            SaveTasks();
            UpdateTaskList();
            ClearInputFields();
        }

        // Очистка полей ввода
        private void ClearInputFields()
        {
            txtTitle.Clear();
            comboBoxCategory.SelectedIndex = -1;
            txtDescription.Clear();
            dateTimePickerDueDate.Value = DateTime.Now;
        }

        // Удаление выбранной задачи
        private void btnDeleteTask_Click(object sender, EventArgs e)
        {
            if (dataGridViewTasks.SelectedRows.Count > 0)
            {
                TaskEvent task = (TaskEvent)dataGridViewTasks.SelectedRows[0].DataBoundItem;
                tasks.Remove(task);
                SaveTasks();
                UpdateTaskList();
            }
        }

        // Напоминание о приближающихся задачах
        private void timerReminder_Tick(object sender, EventArgs e)
        {
            var upcomingTasks = tasks.Where(t => !t.IsCompleted && (t.DueDate - DateTime.Now).TotalMinutes <= 10 && (t.DueDate - DateTime.Now).TotalMinutes > 0).ToList();
            foreach (var task in upcomingTasks)
            {
                MessageBox.Show($"Напоминание: задача '{task.Title}' должна быть выполнена через {Math.Round((task.DueDate - DateTime.Now).TotalMinutes)} минут!", "Напоминание");
            }
        }
    }

    // Модель данных задачи/события
    public class TaskEvent
    {
        public string Title { get; set; }
        public DateTime DueDate { get; set; }
        public string Category { get; set; }
        public string Description { get; set; }
        public bool IsCompleted { get; set; }
    }
}
