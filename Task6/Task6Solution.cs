namespace Task6
{
    public class Task6Solution
    {
        public static int GetCountOfNumbersWithingRange(double[] array, double more = 0, double less = 125)
        {
            int inRangeCount = 0;
            foreach (var single in array)
            {
                if (single > more && single < less)
                    inRangeCount++;
            }
            return inRangeCount;
        }
    }
}