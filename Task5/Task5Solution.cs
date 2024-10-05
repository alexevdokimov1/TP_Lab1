namespace Task5
{
    public class Task5Solution
    {
        public static void solve()
        {
            try
            {
                Console.WriteLine("Задание 5:");
                Console.WriteLine("В заданном массиве действительных чисел найдите разность между максимальным и минимальным числом.");
                Console.WriteLine("Введите количество чисел");
                int arrayElementsCount = Convert.ToInt32(Console.ReadLine());
                if (arrayElementsCount == 0)
                {
                    Console.WriteLine("Масив размером 0 не может быть создан");
                    return;
                }
                double[] array = new double[arrayElementsCount];
                for (int i = 0; i < arrayElementsCount; i++)
                {
                    Console.WriteLine($"Введите {i + 1}-е число");
                    array[i] = Convert.ToDouble(Console.ReadLine());
                }
                Console.WriteLine("Исходный массив");
                for (int i = 0; i < arrayElementsCount; i++)
                    Console.Write($"{array[i]}\t");
                Console.WriteLine();
                double max = array.Max();
                double min = array.Min();
                Console.WriteLine($"Разность между максимальным и минимальным числом равна {max - min}");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
