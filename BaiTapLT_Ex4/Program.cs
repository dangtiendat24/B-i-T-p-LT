using System.Text;

namespace BaiTapLT_Ex4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.Write("Nhập số hàng: ");
            int rows = int.Parse(Console.ReadLine());
            Console.Write("Nhập số cột: ");
            int cols = int.Parse(Console.ReadLine());

            // Hiển thị mẫu dấu sao
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
        }
    }
}
