namespace Task5
{
    public static class Task5Solution
    {
        public static double GetDifferenceBetweenMaxAndMin(double[] array)
        {
            if(array is null || array.Length == 0) throw new ArgumentException("Массив пуст или не объявлен");
            return array.Max()-array.Min();
        }
    }
}