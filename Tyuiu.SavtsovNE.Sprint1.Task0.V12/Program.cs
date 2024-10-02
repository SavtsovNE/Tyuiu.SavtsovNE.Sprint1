using tyuiu.SavtsovNE.Sprint1.Task0.V12.Lib;

DataService dataService = new DataService();

Console.Title = "Спринт #1 | Выполнил: Савцов Никита Евгеньевич | ИБКСб-24-1";
Console.WriteLine("************************************************************************");
Console.WriteLine("* Спринт #1                                                            *");
Console.WriteLine("* Тема: Базовые навыки работы в C#                                    *");
Console.WriteLine("* Задание #0                                                           *");
Console.WriteLine("* Вариант #12                                                          *");
Console.WriteLine("* Выполнил: Савцов Никита Евгеньевич | ИБКСб-24-1                      *");
Console.WriteLine("************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                             *");
Console.WriteLine("* Написать программу, которая вычисляет выражение (5*2 - 2) / 4 * 3    *");
Console.WriteLine("* и печатает результат на экране.                                      *");
Console.WriteLine("*                                                                      *");
Console.WriteLine("************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                     *");
Console.WriteLine("************************************************************************");
Console.WriteLine("* (5*2 - 2) / 4 * 3                                                    *");
Console.WriteLine("************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                           *");
Console.WriteLine("************************************************************************");

double result = dataService.Calculate();
Console.WriteLine(result);
Console.ReadKey();