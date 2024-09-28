// See https://aka.ms/new-console-template for more information
using System;
namespace CS001_HelloWorld
{
    class Program
    {
        /// <summary>
        /// Đây là Main nơi bắt đầu mọi thứ
        /// </summary>
        /// <param name="args">Khum biết</param> <summary>
        /// 
        /// </summary>
        /// <param name="args">Khum biết nốt</param>
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!, Khà khà khà");
            Tong(4, 5);
        }

        /// <summary>
        /// Tổng 2 số a và b
        /// </summary>
        /// <param name="a">Số nguyên a</param>
        /// <param name="b">Số nguyên b</param>
        /// <returns>a + b</returns>
        static int Tong(int a, int b)
        {
            return a + b;
        }
    }
}

