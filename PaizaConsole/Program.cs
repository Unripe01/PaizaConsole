using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
namespace PaizaConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Console.ReadLine());
            Console.WriteLine(Console.ReadLine());
        }
    }

    class Console
    {
        public static string m_text =
@"
500
490
";
        private static int m_index = 0;
        /// <summary>
        /// paiza用ダミーコンソール
        /// </summary>
        /// <returns></returns>
        public static string ReadLine()
        {
            var lines = m_text.Split(new string[] { "\r\n" }, StringSplitOptions.RemoveEmptyEntries);
            string line;
            try
            {
                line = lines[m_index];
            }
            catch
            {
                line = "";
            }
            m_index++;
            return line;
        }

        /// <summary>
        /// paiza用ダミーコンソール
        /// </summary>
        /// <returns></returns>
        public static void WriteLine(string line)
        {
            System.Console.WriteLine(line);
        }
    }
}

