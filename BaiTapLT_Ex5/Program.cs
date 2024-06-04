using System.Text;

namespace BaiTapLT_Ex5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Random random = new Random();
            int secretNumber = random.Next(1, 101);

            int guess;
            bool correct = false;

            // Vòng lặp cho đến khi người dùng đoán đúng
            while (!correct)
            {
                Console.Write("Đoán số từ 1 đến 100: ");
                guess = int.Parse(Console.ReadLine());

                if (guess < secretNumber)
                {
                    Console.WriteLine("Số bạn đoán thấp hơn số bí mật.");
                }
                else if (guess > secretNumber)
                {
                    Console.WriteLine("Số bạn đoán cao hơn số bí mật.");
                }
                else
                {
                    Console.WriteLine("Chúc mừng! Bạn đã đoán đúng.");
                    correct = true;
                }
            }
        }
    }
}
