using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyChallenges
{
    class Program
    {
        static void Main(string[] args)
        {
            string instructions = "255";
            Console.WriteLine(bitWork(instructions));
            Console.ReadKey();

        }

        static int bitWork(string i)
        {
            string[] q = {"&","|","^","<<",">>","SB","CB",""};
            int x, l = i.Length;
            x = i.Select(c =>0+c).Sum();
            while (i != "")
                for (var b = 0;;b++)
                    if (i.StartsWith(q[b]))
                    {
                        i = i.Substring(q[b].Length);
                        var d = new string(i.TakeWhile(Char.IsDigit).ToArray());
                        i = i.Substring(d.Length);
                        int z = int.Parse(d);
                        if (b<1) x = x & z;
                        if (b==1) x = x | z;
                        if (b==2) x = x ^ z;
                        if (b == 3) x = x << z;
                        if (b == 4) x = x >> z;
                        if (b == 5) x = x | (1 << z);
                        if (b>5) x = x & ~(1 << z);
                        break;
                    }
            x = x ^ (1 << l);
            return x;
        }
    }
}
//Original implementation
//string[] st = { "&", "|", "^", "<<", ">>", "SB", "CB" };
//var l = i.Length;
//var x = i.Select(c => (int)c).Sum();
//            while (i != "")
//                foreach (var v in st)
//                    if (i.StartsWith(v))
//                    {
//                        i = i.Substring(v.Length);
//                        var digits = i.TakeWhile(Char.IsDigit).ToArray();
//var str = new string(digits);
//i = i.Substring(str.Length);
//                        int z = int.Parse(str);
//                        if (v == "&") x = x & z;
//                        if (v == "|") x = x | z;
//                        if (v == "^") x = x ^ z;
//                        if (v == "<<") x = x << z;
//                        if (v == ">>") x = x >> z;
//                        if (v == "SB") x = x | (1 << z);
//                        if (v == "CB") x = x & ~(1 << z);
//                        break;
//                    }
//            x = x ^ (1 << l);
//            return x;
