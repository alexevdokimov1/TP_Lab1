namespace Task6
{
    public class Task6Solution
    {
        public static int GetCountOfNumbersWithingRange(double[] array, double more = 0, double less = 125)
        {
            int inRangeCount = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > more && array[i] < less)
                    inRangeCount++;
            }
            return inRangeCount;
        }
    }
}
