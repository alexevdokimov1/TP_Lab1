namespace Task6
{
    public class Task6Solution
    {
        private const int _ELEMENTS_COUNT = 100;
        public static void solve()
        {
            try
            {
                Console.WriteLine("Задание 6");
                Console.WriteLine("В одномерном массиве из 100 чисел M[] подсчитайте количество элементов, удовлетворяющих условию 0 < M[i] <125.");
                int inRangeCount = 0;
                double[] array = new double[_ELEMENTS_COUNT];
                Console.WriteLine($"Введите {_ELEMENTS_COUNT} чисел");
                for (int i = 0; i < _ELEMENTS_COUNT; i++)
                {
                    Console.WriteLine($"Введите {i + 1}-е число");
                    array[i] = Convert.ToDouble(Console.ReadLine());
                }
                Console.WriteLine("Исходный массив");
                for (int i = 0; i < _ELEMENTS_COUNT; i++)
                    Console.Write($"{array[i]}\t");
                Console.WriteLine();
                for (int i = 0; i < _ELEMENTS_COUNT; i++)
                {
                    if (array[i] > 0 && array[i] < 125)
                    {
                        inRangeCount++;
                    }
                }
                Console.WriteLine($"Количество чисел, попавших в диапозон 0 < M[] < 125, равно {inRangeCount}");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
