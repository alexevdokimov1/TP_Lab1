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
                Task5Solution.solve();
                Task6Solution.solve();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
