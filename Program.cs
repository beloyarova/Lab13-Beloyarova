// // Шаг 1

// using System.ComponentModel.DataAnnotations;
// using System.Security.AccessControl;

// PrintHeader();
// PrintHeader();
// Console.WriteLine("Основная часть программы");
// PrintFooter();

// void PrintHeader()
// {
//     Console.WriteLine("^_^");
//     Console.WriteLine("Лабораторная работа #13");
//     Console.WriteLine("Дата формирования отчёта: 16.10.2026");
//     Console.WriteLine("0_0");
// }

// void PrintFooter()
// {
//     Console.WriteLine(">_<");
//     Console.WriteLine("   Конец программы");
//     Console.WriteLine("Х_Х");
// }

// // Шаг 2

// void PrintStudentCard(string name, int age, string groop)
// {
//     Console.WriteLine($"Студент: {name}, возраст: {age}, группа {groop}");
// }

// PrintStudentCard("Егор", 18, "Исп-251");
// PrintStudentCard("Валерия", 17, "Исп-251");

// // Шаг 3

// double CalculateScholarship(double baseAmount, double bonusPercent)
// {
//     return baseAmount + baseAmount * bonusPercent / 100;
// }

// bool IsEligibleForBonus(double averageGrade)
// {
//     return averageGrade >= 4.5;
// }

// double baseAmount = 2000;
// double averageGrade = 3;

// if (IsEligibleForBonus(averageGrade))
// {
//     Console.WriteLine($"Стипендия с надбавкой: {CalculateScholarship(baseAmount, 15)}");
// }else
// {
//     Console.WriteLine($"Стипендия без надбавки: {baseAmount}");
// }

// // Шаг 4

// double CalculateAverageGrade(int[] grades)
// {
//     int sum = 0;
//     foreach (int grade in grades)
//     {
//         sum += grade;
//     }
//     return (double)sum / grades.Length;
// }

// int CountFives(int[] grades)
// {
//     int count = 0;
//     foreach (int grade in grades)
//     {
//         if (grade == 5)
//         {
//             count++;
//         }
//     }
//     return count;
// }

// int[] grades = { 4, 5, 3, 5, 4 };
// double average = CalculateAverageGrade(grades);
// int count1 = CountFives(grades);
// Console.WriteLine(average);
// Console.WriteLine($"Количество пятерок: {count1}");

// class Program {
//     static void Main() {
//         Console.WriteLine(Add(2, 3)); // вызовет первый вариант: int Add(int, int) → 5
//         Console.WriteLine(Add(2.5, 3.5)); // вызовет второй вариант: double Add(double, double) → 6.0
//         Console.WriteLine(Add(2, 3, 4)); // вызовет третий вариант: int Add(int, int, int) → 9
//     }
//     static int Add(int a, int b) {
//         return a + b;
//     }
//     static double Add(double a, double b) {
//         return a + b;
//     }
//     static int Add(int a, int b, int c) {
//         return a + b + c;
//     }
// }

// // Самостоятельные задания

// // Задание Б

// void PrintPerson(string name, int age)
// {
//     Console.WriteLine($"Имя {name}, возраст {age}");
// }

// PrintPerson("Иван", 16);
// PrintPerson("Саша", 17);
// PrintPerson("Илья", 18);

// // Задание В

// bool IsEven(int number)
// {
//     return number % 2 == 0;
// }

// int number = 10;

// if (IsEven(number))
// {
//     Console.WriteLine("Число четное");
// }else
// {
//     Console.WriteLine("Число не четное");
// }

// Console.Write("Введите свою фамилию: ");
// string surname = Console.ReadLine()!.Trim();
// if (string.IsNullOrEmpty(surname)) {
// Console.WriteLine("Фамилия не введена. Завершение работы.");
// return;
// }
// Random rnd = new(surname.GetHashCode() + DateTime.Now.DayOfYear);
// var assigned = Enumerable.Range(1, 10)
// .OrderBy(_ => rnd.Next())
// .Take(2)
// .OrderBy(x => x)
// .ToList();
// Console.WriteLine($"Задачи: №{assigned[0]} и №{assigned[1]}");

// Вариант 1

void PrintSeparator()
{
    Console.WriteLine("____________________");
}

Console.WriteLine("Начало программы");
PrintSeparator();
Console.WriteLine("Основная программа");
PrintSeparator();
Console.WriteLine("Конец программы");

Console.WriteLine();
// Вариант 3

bool IsPositive(int number)
{
    return number > 0;
}

int number = -1;

if(IsPositive(number))
{
    Console.WriteLine("Число положительное");
}else
{
    Console.WriteLine("Число отрицательное");
}