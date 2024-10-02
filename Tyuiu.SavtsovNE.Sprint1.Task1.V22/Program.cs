using tyuiu.SavtsovNE.Sprint1.Task1.V22.Lib;

Console.Title = "Спринт #1 | Выполнил: Савцов Никита Евгеньевич | ИБКСб-24-1";
Console.WriteLine("************************************************************************");
Console.WriteLine("* Спринт #1                                                            *");
Console.WriteLine("* Тема: Базовые навыки работы в C#                                     *");
Console.WriteLine("* Задание #0                                                           *");
Console.WriteLine("* Вариант #22                                                          *");
Console.WriteLine("* Выполнил: Савцов Никита Евгеньевич | ИБКСб-24-1                      *");
Console.WriteLine("************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                             *");
Console.WriteLine("* Написать программу, которая запрашивает у пользователя исходные данные, вычисляет результат по формуле (5+x)/(y*x) и печатает его на экране.*");
Console.WriteLine("*  и печатает его на экране.                                           *");
Console.WriteLine("*                                                                      *");
Console.WriteLine("************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                     *");
Console.WriteLine("************************************************************************");
Console.WriteLine("* (5 + x) / (y * x)                                                    *");
Console.WriteLine("************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                           *");
Console.WriteLine("************************************************************************");

double x, y;
Console.WriteLine("Введите значение X:");
x = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите значение y:");
y = Convert.ToDouble(Console.ReadLine());

DataService dataService = new DataService();


Console.WriteLine(dataService.Calculate(x, y));
Console.ReadLine();