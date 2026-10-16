// Шаг 1

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

