﻿namespace IO
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
            for (int i = 0; i < array.Count; i++)
                Output.Print($"{array[i]}\t");
            Output.Print("\n");
        }
    }
}