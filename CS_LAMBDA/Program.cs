using System;

namespace CS_LAMBDA
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Action<string> thongbao;
            thongbao = (string s) => Console.WriteLine(s); // delegate void kiểu (string s)

            thongbao?.Invoke("Xin chòa");

            for (int i = 0; i < 10; i++)
            {
                Console.Write((i + 1) + " ");
                thongbao?.Invoke("Xin chòa");
            };

            Action thongbao1;
            thongbao1 = () => Console.WriteLine("Xin chào đây là delegate ko tham số");
            thongbao1?.Invoke();

            Action<string, string> welcome;
            welcome = (msg, name) =>
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine(msg + " " + name);
                Console.ResetColor();
            };

            welcome?.Invoke("Xin chào", "Bảo");

            Func<int, int, int> tinhtoan; //Thế đêó nào delegate có 3 int mà chạy lambda 2 int được, ảo vl

            tinhtoan = (a, b) =>
            {
                int kq = a + b;
                return kq;
            };

            Console.WriteLine(tinhtoan.Invoke(5, 6));

            int[] mang = { 2, 4, 64, 5, 7, 8, 9, 33, 55 };

            //Select duyệt qua từng phẩn tử của mảng
            var kq = mang.Select((int x) =>
            {
                return Math.Sqrt(x); //Căn bật 2
            }
            );

            foreach (var result in kq) // Cách dùng foreach =))
            {
                Console.WriteLine(result);
            }

            mang.ToList().ForEach(
                (x) =>
                {
                    if (x % 2 == 0)
                    {
                        Console.WriteLine(x + " ");
                    }
                }
            );

            var kq_mang = mang.Where(
                 (x) =>
                 {
                     return x % 4 == 0;
                 }
             );

            foreach (var n in kq_mang) // Cách dùng foreach =))
            {
                Console.WriteLine(n);
            }
        }
    }
}