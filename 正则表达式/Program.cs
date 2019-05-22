using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace 正则表达式
{
    class Program
    {
        static void Main(string[] args)
        {
            //string s = "I am a blue cat.";

            //string res = Regex.Replace(s, "^", "开始:");

            //Console.WriteLine(res);

            //Console.ReadKey();

            //string s = "lalallala";

            //string res = Regex.Replace(s, "$", "结尾");

            //Console.WriteLine(res);

            //Console.ReadKey();

            //string s = Console.ReadLine();

            //bool isMatch = true;

            //for (int i = 0; i < s.Length; i++)
            //{
            //    if (s[i] < '0' || s[i] > '9')
            //    {
            //        isMatch = false;
            //        break;
            //    }
            //}

            //if (isMatch)
            //{
            //    Console.WriteLine("是一个合法的密码");
            //}
            //else
            //{
            //    Console.WriteLine("不是一个合法的密码");
            //}

            //Console.ReadKey();

            //string s = Console.ReadLine();

            //string pattern = @"\d";

            //string pattern = @"^\d*$";

            //bool isMatch = Regex.IsMatch(s, pattern);

            //Console.WriteLine(isMatch);

            //Console.ReadKey();

            //string pattern = @"[^iw]";

            //string s2 = Regex.Replace(s, pattern, "*");

            //Console.WriteLine(s2);

            //Console.ReadKey();

            //string qq1 = "123456";

            //string qq2 = "1313sa111";

            //string qq3 = "114";

            //string pattern = @"^\d{5,12}$";

            //Console.WriteLine(Regex.IsMatch(qq1, pattern));

            //Console.WriteLine(Regex.IsMatch(qq2, pattern));

            //Console.WriteLine(Regex.IsMatch(qq3, pattern));

            //Console.ReadKey();

            //string s = "56sasdasda123（sasaas沙发）";

            //string pattern = @"\d|[a-z]";

            //MatchCollection col = Regex.Matches(s, pattern);

            //foreach (Match match in col)
            //{
            //    Console.WriteLine(match);
            //}

            //Console.ReadKey();

            //string s = "www.isscuss.com;lallala";

            ////string pattern = @"[;.:]";

            //string pattern = @"[;]|[.]|[:]";

            //string[] array = Regex.Split(s, pattern);

            //foreach (var n in array)
            //{
            //    Console.WriteLine(n);
            //}

            //Console.ReadKey();

            string input = Console.ReadLine();

            string strGroup = @"(ab\w{2}){2}";

            Console.WriteLine(Regex.Replace(input, strGroup, "tihuan"));

            Console.ReadKey();

        }
    }
}
