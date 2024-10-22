using IO;
namespace Arrays
{
    public class ArrayActions
    {
        public static double[] EnterDoubleArray(int count) {
            double[] array = new double[count];
            for (int i = 0; i < count; i++)
            {
                Output.SendMessage($"Введите {i + 1}-е число");
                array[i] = Input.ReadDouble();
            }
            return array;
        }
    }
}
