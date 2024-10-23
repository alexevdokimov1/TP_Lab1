namespace IO
{
    public class Output
    {
        public static void SendMessage(string message)
        {
            Console.WriteLine(message);
        }

        public static void Print(string str)
        {
            Console.Write(str);
        }

        public static void PrintRow<T>(IList<T> array)
        {
            foreach (var single in array)
                Output.Print($"{single}\t");
            Output.Print("\n");
        }
    }
}
