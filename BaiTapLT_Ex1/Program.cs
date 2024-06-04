using System.Text;

namespace BaiTapLT_Ex1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Nhập vào một số nguyên: ");
            float number = float.Parse(Console.ReadLine());
            if (number == 0)
            {
                Console.WriteLine("số bạn nhập là số 0");
            }else if (number < 0)
            {
                Console.WriteLine("Số bạn nhập là số âm");
            }else
            {
                Console.WriteLine("Số bạn nhập là số dương");
            }
        }
    }
}
