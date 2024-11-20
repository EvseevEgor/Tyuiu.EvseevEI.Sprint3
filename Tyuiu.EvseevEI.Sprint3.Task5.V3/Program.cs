using Tyuiu.EvseevEI.Sprint3.Task5.V3.Lib;
namespace Tyuiu.EvseevEI.Sprint3.Task5.V3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new();
            Console.Title = "Спринт #3 | Выполнил: Евсеев Е.И | ИИПб 24-2";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #3                                                                ");
            Console.WriteLine("* Тема: Вложенные циклы                                                    ");
            Console.WriteLine("* Задание #5                                                               ");
            Console.WriteLine("* Вариант #3                                                               ");
            Console.WriteLine("* Выполнил: Евсеев Егор Игоревич | ИИПб 24-2                            ");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                 ");
            Console.WriteLine("* y = (sin(k) + x) / x при х = 5                                           ");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                         ");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Введите значние х:                                                       ");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("* Введите значние y:                                                       ");
            int y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("* Введите значние w:                                                       ");
            int w = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("* Введите значние z:                                                       ");
            int z = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("* Введите значние i:                                                       ");
            int i = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("*                                                                          ");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                               ");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine(ds.GetSumSumSeries(x, y, w, z, i));
            Console.ReadKey();
        }
    }
}
 
