using tyuiu.SavtsovNE.Sprint1.Task2.V30.Lib;
namespace tyuiu.SavtsovNE.Sprint1.Task2.V30
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #1 | Выполнил: Савцов Никита Евгеньевич | ИБКСб-24-1";
            Console.WriteLine("************************************************************************");
            Console.WriteLine("* Спринт #1                                                            *");
            Console.WriteLine("* Тема: Базовые навыки работы в C#                                     *");
            Console.WriteLine("* Задание #2                                                           *");
            Console.WriteLine("* Вариант #30                                                          *");
            Console.WriteLine("* Выполнил: Савцов Никита Евгеньевич | ИБКСб-24-1                      *");
            Console.WriteLine("************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                             *");
            Console.WriteLine("* Написать программу, которая запрашивает у пользователя исходные данные, выполняет указанные расчёты.*");
            Console.WriteLine("*  и печатает его на экране.                                           *");
            Console.WriteLine("*                                                                      *");
            Console.WriteLine("************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ: Расстояние в километрах (вещественное число)        *");
            Console.WriteLine("************************************************************************");
            Console.WriteLine("*                                                                       *");
            Console.WriteLine("************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                           *");
            Console.WriteLine("************************************************************************");

            DataService dataService = new DataService();
            double polo = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(Convert.ToDouble(dataService.ConvertKmToMetre(polo)));

        }
    }
}
