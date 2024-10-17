using System;
using System.Windows.Forms;

namespace Modul5
{
    public partial class Calculator : Form
    {
        // Переменная для хранения текущего значения
        double value = 0;
        // Переменная для хранения выбранной операции (+, -, *, /)
        string operation = "";
        // Флаг для отслеживания, была ли нажата кнопка операции
        bool operationPressed = false;

        // Конструктор формы калькулятора
        public Calculator()
        {
            InitializeComponent();
        }

        // Метод для обработки нажатия на цифровые кнопки
        private void button_Click(object sender, EventArgs e)
        {
            // Если результат равен "0" или была нажата кнопка операции, очищаем текстовое поле
            if ((textBox_Result.Text == "0") || operationPressed)
                textBox_Result.Clear();

            // Сбрасываем флаг операции, т.к. начинается новый ввод
            operationPressed = false;
            // Приводим отправителя (кнопку) к типу Button
            Button b = (Button)sender;
            // Добавляем нажатую цифру в текстовое поле
            textBox_Result.Text += b.Text;
        }

        // Метод для обработки нажатия на кнопки операций (+, -, *, /)
        private void operator_Click(object sender, EventArgs e)
        {
            // Приводим отправителя (кнопку операции) к типу Button
            Button b = (Button)sender;
            // Сохраняем выбранную операцию
            operation = b.Text;
            // Сохраняем текущее значение из текстового поля
            value = Double.Parse(textBox_Result.Text);
            // Устанавливаем флаг, что операция была нажата
            operationPressed = true;
        }

        // Метод для обработки нажатия на кнопку "=" (равно)
        private void button_Equals_Click(object sender, EventArgs e)
        {
            // В зависимости от выбранной операции, выполняем соответствующее действие
            switch (operation)
            {
                case "+":
                    // Выполняем сложение и выводим результат
                    textBox_Result.Text = (value + Double.Parse(textBox_Result.Text)).ToString();
                    break;
                case "-":
                    // Выполняем вычитание и выводим результат
                    textBox_Result.Text = (value - Double.Parse(textBox_Result.Text)).ToString();
                    break;
                case "*":
                    // Выполняем умножение и выводим результат
                    textBox_Result.Text = (value * Double.Parse(textBox_Result.Text)).ToString();
                    break;
                case "/":
                    // Выполняем деление и выводим результат
                    textBox_Result.Text = (value / Double.Parse(textBox_Result.Text)).ToString();
                    break;
            }
            // Сбрасываем флаг операции
            operationPressed = false;
        }

        // Метод для обработки нажатия на кнопку "C" (очистка)
        private void button_Clear_Click(object sender, EventArgs e)
        {
            // Устанавливаем значение в текстовом поле на "0"
            textBox_Result.Text = "0";
            // Сбрасываем текущее значение
            value = 0;
        }
    }
}
