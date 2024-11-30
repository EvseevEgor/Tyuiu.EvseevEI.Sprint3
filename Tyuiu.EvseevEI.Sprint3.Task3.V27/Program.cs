using Tyuiu.EvseevEI.Sprint3.Task3.V27.Lib;
namespace Tyuiu.EvseevEI.Sprint3.Task3.V27
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new();
            Console.Title = "Спринт #3 | Выполнил: Евсеев Е.И | ИИПб 24-2";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #3                                                                ");
            Console.WriteLine("* Тема: Оператор цикла foreach                                                ");
            Console.WriteLine("* Задание #3                                                               ");
            Console.WriteLine("* Вариант #25                                                               ");
            Console.WriteLine("* Выполнил: Евсеев Егор Игоревич | ИИПб 24-2                            ");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                 ");
            Console.WriteLine("* Используя цикл foreach подсчитать минимальное количество букв u,         ");
            Console.WriteLine("* находящихся на соседних позициях в строке: kjhgfuu gujut dtuu            ");
            Console.WriteLine("*                                                                          ");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                         ");
            Console.WriteLine("***************************************************************************");
            string str;
            char c;
            Console.WriteLine("* Введите значние х:                                                       ");
            str = Convert.ToString(Console.ReadLine());
            Console.WriteLine("* Введите значние y:                                                       ");
            c = Convert.ToChar(Console.ReadLine());
            Console.WriteLine("*                                                                          ");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                               ");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine(ds.ConvertStringToInt(str, c));
            Console.ReadKey();
        }
    }
}
