using IO;
using Arrays;
using Task5;
using Task6;
namespace UserUI
{
    public class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Output.SendMessage("Задание 5:");
                Output.SendMessage("В заданном массиве действительных чисел найдите разность между " +
                    "максимальным и минимальным числом.");
                Output.SendMessage("Введите количество чисел");
                int arrayElementsCount = Input.ReadInt();
                double[] array = ArrayActions.EnterDoubleArray(arrayElementsCount);
                Output.SendMessage("Исходный массив");
                Output.PrintRow(array);
                double differenceBetweenMaxAndMin = Task5Solution.GetDifferenceBetweenMaxAndMin(array);
                Output.SendMessage($"Разность между максимальным и минимальным числом равна {differenceBetweenMaxAndMin}");

                Output.SendMessage("Задание 6:");
                Output.SendMessage("В одномерном массиве из 100 чисел M[] подсчитайте " +
                    "количество элементов, удовлетворяющих условию 0 < M[i] <125.");
                array = ArrayActions.EnterDoubleArray(10);
                Output.SendMessage("Исходный массив");
                Output.PrintRow(array);
                int countOfNumbers = Task6Solution.GetCountOfNumbersWithingRange(array);
                Output.SendMessage($"Количество элементов, удовлетворяющих условию 0 < M[i] <125 равно {countOfNumbers}.");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}