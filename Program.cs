// Шаг 1

using System.ComponentModel.DataAnnotations;
using System.Security.AccessControl;

PrintHeader();
PrintHeader();
Console.WriteLine("Основная часть программы");
PrintFooter();

void PrintHeader()
{
    Console.WriteLine("^_^");
    Console.WriteLine("Лабораторная работа #13");
    Console.WriteLine("Дата формирования отчёта: 16.10.2026");
    Console.WriteLine("0_0");
}

void PrintFooter()
{
    Console.WriteLine(">_<");
    Console.WriteLine("   Конец программы");
    Console.WriteLine("Х_Х");
}

// Шаг 2

void PrintStudentCard(string name, int age, string groop)
{
    Console.WriteLine($"Студент: {name}, возраст: {age}, группа {groop}");
}

PrintStudentCard("Егор", 18, "Исп-251");
PrintStudentCard("Валерия", 17, "Исп-251");

// Шаг 3

double CalculateScholarship(double baseAmount, double bonusPercent)
{
    return baseAmount + baseAmount * bonusPercent / 100;
}

bool IsEligibleForBonus(double averageGrade)
{
    return averageGrade >= 4.5;
}

double baseAmount = 2000;
double averageGrade = 3;

if (IsEligibleForBonus(averageGrade))
{
    Console.WriteLine($"Стипендия с надбавкой: {CalculateScholarship(baseAmount, 15)}");
}else
{
    Console.WriteLine($"Стипендия без надбавки: {baseAmount}");
}

// Шаг 4

double CalculateAverageGrade(int[] grades)
{
    int sum = 0;
    foreach (int grade in grades)
    {
        sum += grade;
    }
    return (double)sum / grades.Length;
}

int CountFives(int[] grades)
{
    int count = 0;
    foreach (int grade in grades)
    {
        if (grade == 5)
        {
            count++;
        }
    }
    return count;
}

int[] grades = { 4, 5, 3, 5, 4 };
double average = CalculateAverageGrade(grades);
int count1 = CountFives(grades);
Console.WriteLine(average);
Console.WriteLine($"Количество пятерок: {count1}");