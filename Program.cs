using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace lesson_regex2
{
        delegate string myDEL(int _num);
    internal class Program
    {
        static string NumName(int _number) {
            string result = string.Empty;
            switch (_number)
            {
                case 0:result = "null";break;
                default:result = "no result";
                    break;
            }
            return result;
        }
        static void Main(string[] args)
        {
            myDEL print = NumName;
            Console.WriteLine( print(0)); 
            string input = "Наташа нАтаШа наташа ашатан";
            if (args.Length > 0) {
                input = args[0];
            }
            Regex reg = new Regex(@"наташа",RegexOptions.RightToLeft);//rigthtoleft ищет перевернутое значение слово 
            MatchCollection matchFind = reg.Matches(input);
            int counter = 0;
            foreach (var item in matchFind)
            {
                Console.WriteLine($"Совпадение номер {++counter} {item}");
                string str = item.ToString();
            }

        }
    }
}
