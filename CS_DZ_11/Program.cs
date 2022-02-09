using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_DZ_11
{
    class Program
    {
        static void Main(string[] args)
        {
            int tryCount = 3;
            string password = "aabb";
            string userInput;

            for (int i = 0; i < tryCount; i++)
            {
                Console.Write("Введите пароль: ");
                userInput = Console.ReadLine();

                if (password == userInput)
                {
                    Console.WriteLine("Это был верный пароль. Позравляю.");
                    break;
                }
                else
                {
                    Console.WriteLine("У вас осталось " + (tryCount - i - 1) + " попыток");
                }
            }
        }
    }
}
