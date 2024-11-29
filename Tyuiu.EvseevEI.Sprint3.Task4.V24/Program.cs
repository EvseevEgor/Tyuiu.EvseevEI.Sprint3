using Tyuiu.EvseevEI.Sprint3.Task4.V24.Lib;
namespace Tyuiu.EvseevEI.Sprint3.Task4.V24
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new();
            Console.Title = "Спринт #3 | Выполнил: Евсеев Е.И | ИИПб 24-2";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #3                                                                ");
            Console.WriteLine("* Тема: Использование операторов continue и break в циклах                 ");
            Console.WriteLine("* Задание #4                                                               ");
            Console.WriteLine("* Вариант #14                                                              ");
            Console.WriteLine("* Выполнил: Евсеев Егор Игоревич | ИИПб 24-2                            ");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                 ");
            Console.WriteLine("* На отрезке, где x принимает значения от -5 до 5, вычислить значение      ");
            Console.WriteLine("* функции y=cos(x)/sin(x) При х = 0 прервать цикл. Полученные значения     ");
            Console.WriteLine("* суммировать.                                                             ");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                         ");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Введите значние х:                                                       ");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("* Введите значние y:                                                       ");
            int y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("*                                                                          ");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                               ");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine(ds.Calculate(x, y));
            Console.ReadKey();
        }
    }
 }
