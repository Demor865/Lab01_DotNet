string FirstName = "Владислав";
string lastName = "Колесников";
string group = "ИСП-241";
int birthYear = 2008;
double gpa = 4.43;
bool HasScholarship = false;

int CurrentYear = 2026;
int age = CurrentYear - birthYear;

Console.WriteLine("Студенческое удостоверение");
Console.WriteLine($"Имя: {FirstName} {lastName}");
Console.WriteLine($"Группа: {group}");
Console.WriteLine($"Возраст: {age} лет");
Console.WriteLine($"Средний бал: {gpa}");
Console.WriteLine($"Стипендия: {HasScholarship}");

Console.Write("Введите ваш любимый предмет: ");
string subject = Console.ReadLine();
Console.WriteLine($"Отлично, {FirstName} любит {subject}");