using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.EvseevEI.Sprint3.Task3.V27.Lib
{
    public class DataService : ISprint3Task3V27
    {
        public static int ConvertStringToInt(string value, char v)
        {
            string input = "!bt, g567kid f!";
            string result = "";

            foreach (char c in input)
            {
                if (char.IsDigit(c))
                {
                    result += c;
                }
            }
            int number = int.Parse(result);
            Console.WriteLine(number);

        }

        public int ConvertStringToInt(string value)
        {
            throw new NotImplementedException();
        }
    }
}
