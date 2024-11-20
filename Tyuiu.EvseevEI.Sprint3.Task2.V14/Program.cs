using Tyuiu.EvseevEI.Sprint3.Task2.V14.Lib;
namespace Tyuiu.EvseevEI.Sprint3.Task2.V14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService dataService = new DataService();

            Console.Title = "Спринт #3 | Выполнил: Евсеев Е.И | ИИПб-24-2";
            Console.WriteLine("************************************************************************");
            Console.WriteLine("* Спринт #3                                                            *");
            Console.WriteLine("* Тема: Операторы составного присваивания                              *");
            Console.WriteLine("* Задание #0                                                           *");
            Console.WriteLine("* Вариант #24                                                          *");
            Console.WriteLine("* Выполнил Евсеев Егор Игоревич | ИИПб-24-1                      *");
            Console.WriteLine("************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                             *");
            Console.WriteLine("* Написать программу используя цикл for, которая вычисляет             *");
            Console.WriteLine("* произведение ряда по формуле, при X=5                                *");
            Console.WriteLine("*                                                                      *");
            Console.WriteLine("************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                     *");
            Console.WriteLine("* Формула                                                              *");
            Console.WriteLine("*                                                                      *");
            Console.WriteLine("************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                           *");

            int x = 5;
            int startValue = 1;
            int stopValue = 7;
            double result = dataService.GetMultiplySeries(x, startValue, stopValue);


            Console.WriteLine($"Произведение ряда для X={x}, от {startValue} до {stopValue} равно: {result}");
            Console.WriteLine("************************************************************************");
            Console.ReadLine();
            DataService ds = new DataService();
            int a = Convert.ToInt32(Console.ReadLine());
            int s = Convert.ToInt32(Console.ReadLine());
            int d = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(ds.GetMultiplySeries(a, s, d));
            Console.ReadKey();
        }
    }
}
