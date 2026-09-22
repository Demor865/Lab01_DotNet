// string FirstName = "Владислав";
// string lastName = "Колесников";
// string group = "ИСП-241";
// int birthYear = 2008;
// double gpa = 4.43;
// bool HasScholarship = false;

// int CurrentYear = 2026;
// int age = CurrentYear - birthYear;

// Console.WriteLine("Студенческое удостоверение");
// Console.WriteLine($"Имя: {FirstName} {lastName}");
// Console.WriteLine($"Группа: {group}");
// Console.WriteLine($"Возраст: {age} лет");
// Console.WriteLine($"Средний бал: {gpa}");
// Console.WriteLine($"Стипендия: {HasScholarship}");

// Console.Write("Введите ваш любимый предмет: ");
// string subject = Console.ReadLine();
// Console.WriteLine($"Отлично, {FirstName} любит {subject}");

Console.WriteLine("Калькулятор");
Console.Write("Введите первое число: ");
double num1 = double.Parse(Console.ReadLine());
Console.Write("Введите второе число: ");
double num2 = double.Parse(Console.ReadLine());

Console.WriteLine($"Сумма: {num1 + num2}");
Console.WriteLine($"Разность: {num1 - num2}");
Console.WriteLine($"Произведение: {num1 * num2}");
if (num2 != 0)
{
    Console.WriteLine($"частное: {num1 / num2}");
}
else
{
    Console.WriteLine("Деление на ноль невозможно");
}