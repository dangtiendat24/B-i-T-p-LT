using System.Text;

namespace BaiTapLT_Ex6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            string input;
            int sum = 0;

            Console.WriteLine("Nhập một chuỗi số (cách nhau bằng dấu cách):");
            input = Console.ReadLine();

            string[] numbers = input.Split(' ');

            foreach (string number in numbers)
            {
                if (int.TryParse(number, out int value) && value > 0)
                {
                    sum += value;
                }
                else
                {
                    // Bỏ qua số âm
                    continue;
                }
            }

            Console.WriteLine("Tổng các số dương: " + sum);
        }
    }
}
