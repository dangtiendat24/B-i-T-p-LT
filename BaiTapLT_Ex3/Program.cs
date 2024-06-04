using System.Text;

namespace BaiTapLT_Ex3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.Write("Nhập một số nguyên dương: ");
            int number = int.Parse(Console.ReadLine());
            int factorial = 1;
            for (int i = 1;  i <= number; i++)
            {
                factorial *= i;
            }
            Console.WriteLine($"Giai thừa của {number} là: " +  factorial);
        }
    }
}
