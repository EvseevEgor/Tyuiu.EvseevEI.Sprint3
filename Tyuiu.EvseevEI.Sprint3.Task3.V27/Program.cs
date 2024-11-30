using Tyuiu.EvseevEI.Sprint3.Task3.V27.Lib;
namespace Tyuiu.EvseevEI.Sprint3.Task3.V27
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #3 | Выполнила: Евсеев Е.И | ИИПБ-24-2";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #3                                                               *");
            Console.WriteLine("* Тема: Создания итогового решения по спринту                             *");
            Console.WriteLine("* Задание #3                                                              *");
            Console.WriteLine("* Вариант #27                                                             *");
            Console.WriteLine("* Выполнила: Евсеев Егор Игоревич | ИИПБ-24-2                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Используя цикл foreach удалить все буквы и знаки препинания,            *");
            Console.WriteLine("* оставить цифру затем преобразовать в число в строке: !bt, g567kid f!,         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            DataService ds = new DataService();
            string value = "!bt, g567kid f!";
            int res = ds.ConvertStringToInt(value);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("После удаления всех букв и знаков препинания, осталось только число: " + res);
            Console.ReadKey();
        }
    }
}