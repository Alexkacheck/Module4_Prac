using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module4_Prac
{

    struct Student
    {
        public string Name;           // Фамилия и инициалы
        public string GroupNumber;    // Номер группы
        public int[] Grades;          // Массив успеваемости

        public Student(string name, string groupNumber, int[] grades)
        {
            Name = name;
            GroupNumber = groupNumber;
            Grades = grades;
        }

        // Метод для вычисления среднего балла студента
        public double CalculateAverageGrade()
        {
            if (Grades.Length == 0)
                return 0;

            double sum = 0;
            foreach (var grade in Grades)
            {
                sum += grade;
            }
            return sum / Grades.Length;
        }

        // Метод для проверки, имеются ли только оценки 4 или 5
        public bool HasOnlyGoodGrades()
        {
            foreach (var grade in Grades)
            {
                if (grade < 4)
                    return false;
            }
            return true;
        }

        // Метод для вывода информации о студенте
        public void PrintStudentInfo()
        {
            Console.WriteLine($"Фамилия и инициалы: {Name}");
            Console.WriteLine($"Номер группы: {GroupNumber}");
            Console.WriteLine($"Успеваемость: {string.Join(", ", Grades)}");
            Console.WriteLine($"Средний балл: {CalculateAverageGrade()}");
        }
    }

    class Program
    {
        static void Main()
        {
            // Создаем массив студентов
            Student[] students = new Student[10];
            students[0] = new Student("Иванов И.И.", "Группа 101", new int[] { 5, 4, 4, 3, 5 });
            students[1] = new Student("Петров П.П.", "Группа 101", new int[] { 4, 4, 4, 4, 4 });
            students[2] = new Student("Сидоров С.С.", "Группа 102", new int[] { 5, 5, 5, 5, 5 });
            students[3] = new Student("Козлов К.К.", "Группа 102", new int[] { 3, 3, 3, 3, 3 });
            students[4] = new Student("Андреев А.А.", "Группа 103", new int[] { 4, 5, 4, 5, 4 });
            students[5] = new Student("Семенов С.С.", "Группа 103", new int[] { 3, 4, 3, 4, 3 });
            students[6] = new Student("Михайлов М.М.", "Группа 104", new int[] { 5, 4, 5, 4, 5 });
            students[7] = new Student("Николаев Н.Н.", "Группа 104", new int[] { 3, 3, 4, 4, 4 });
            students[8] = new Student("Дмитриев Д.Д.", "Группа 105", new int[] { 5, 5, 5, 5, 5 });
            students[9] = new Student("Егоров Е.Е.", "Группа 105", new int[] { 4, 4, 4, 4, 4 });

            // Сортировка студентов по среднему баллу
            students = students.OrderBy(student => student.CalculateAverageGrade()).ToArray();

            Console.WriteLine("Студенты с оценками 4 или 5:");
            foreach (var student in students)
            {
                if (student.HasOnlyGoodGrades())
                {
                    student.PrintStudentInfo();
                    Console.WriteLine();
                }
            }
        }
    }
}
