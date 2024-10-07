using System;
using System.Linq;

public struct Student
{
    public string lastName;
    public string initials;
    public int groupNumber;
    public int[] grades;

    // Метод для расчета среднего балла
    public double AverageGrade()
    {
        return grades.Average();
    }

    // Метод для проверки, есть ли только оценки 4 и 5
    public bool HasOnlyHighGrades()
    {
        return grades.All(g => g >= 4);
    }
}

class Students
{
    static void Run(string[] args)
    {
        // Массив студентов
        Student[] students = new Student[3]
        {
            new Student { lastName = "Иванов", initials = "А.И.", groupNumber = 101, grades = new int[] { 4, 5, 4, 4, 5 } },
            new Student { lastName = "Петров", initials = "Б.В.", groupNumber = 102, grades = new int[] { 3, 4, 5, 3, 4 } },
            new Student { lastName = "Сидоров", initials = "В.Г.", groupNumber = 101, grades = new int[] { 5, 5, 5, 5, 5 } },
            
        };

        // Сортировка по возрастанию среднего балла
        var sortedStudents = students.OrderBy(s => s.AverageGrade()).ToArray();

        // Вывод отсортированных студентов
        Console.WriteLine("Студенты, отсортированные по среднему баллу:");
        foreach (var student in sortedStudents)
        {
            Console.WriteLine($"{student.lastName}, Группа: {student.groupNumber}, Средний балл: {student.AverageGrade():F2}");
        }

        // Вывод студентов с оценками 4 и 5
        Console.WriteLine("\nСтуденты с оценками 4 и 5:");
        foreach (var student in students)
        {
            if (student.HasOnlyHighGrades())
            {
                Console.WriteLine($"{student.lastName}, Группа: {student.groupNumber}");
            }
        }
    }
}
