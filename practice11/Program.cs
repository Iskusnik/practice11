using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice11
{
    /// <summary>
    /// Цезарь 
    /// Шифрование, расшифрование
    /// На вход:
    /// 1. Cтрока с русскими строчными буквами (33 штуки от 'а' до 'я')
    /// 2. Натуральное число - сдвиг строки (от 0 до бесконечности, с период = 33)
    /// 3. А - шифровать, Б - расшифровать
    /// 
    /// На выходе:
    /// Строка, в которой символы сдвинуты.
    /// 
    /// 1.По идее
    /// шифрование на N символов = расшифрованию на 33-N символов
    ///
    /// 
    /// </summary>
    class Program
    {
        static public string CaesarCode(string input, int n)
        {
            char temp;
            string result = "";
            for (int i = 0; i < input.Length; i++)
            {
                temp = input[i];
                if (temp < 'а' || temp > 'я' )
                    result = result + temp;
                else
                {
                    int code = temp - 'а' + 1 + n;

                    if (code > 33)
                        code = code % 33 + 1;
                    
                    result = result + char.ConvertFromUtf32(code + 'а' - 1);
                }
            }

            return result;
        }
        static void Main(string[] args)
        {
            string temp = Console.ReadLine();
            int n = int.Parse(Console.ReadLine());
            temp = CaesarCode(temp, n);
            Console.WriteLine(temp);
            temp = CaesarCode(temp, 33 - n);
            Console.WriteLine(temp);
        }
    }
}
