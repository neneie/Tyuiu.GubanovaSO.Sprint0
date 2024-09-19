using System;
using System.Reflection;

namespace Tyuiu.GubanovaSO.Sprint0.Task6.V0.Lib
{
    public class DataService
    {
        public static object AdditionArray(int[] numbers)
        {
            var totale = 0;
            for (var i = 0; i < numbers.Length; i++)
            {
                totale = totale + numbers[i];
            }
            return totale;
        }
        public static object SubtractionArray(int[] numbers)
        {
            var total = 0;
            int index = 0;

            while (index < numbers.Length)
            {
                total = total - numbers[index];
                index++;

            }
            return total;
        }
        public static object MultiplicationArray(int[] numbers)
        {
            var total = 1;
            int index = 0;
            do
            {
                total = total * numbers[index];
                index++;
            }
            while (index < numbers.Length);

            return total;

        }
    }
}
