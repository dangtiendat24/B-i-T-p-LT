using System.Text;

namespace BaiTapLT_Ex2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Nhập số tương ứng với ngày trong tuần (1 cho thứ hai, 2 cho thứ ba, v.v)");
            int number = int.Parse(Console.ReadLine());
            switch (number)
            {
                case 1:
                    Console.WriteLine("Đây là thứ 2");
                    break;
                case 2:
                    Console.WriteLine("Đây là thứ 3");
                    break;
                case 3:
                    Console.WriteLine("Đây là thứ 4");
                    break;
                case 4:
                    Console.WriteLine("Đây là thứ 5");
                    break;
                case 5:
                    Console.WriteLine("Đây là thứ 6");
                    break;
                case 6:
                    Console.WriteLine("Đây là thứ 7");
                    break;
                case 7:
                    Console.WriteLine("Đây là chủ nhật");
                    break;

            }
        }
    }
}
