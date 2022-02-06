using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_overloadHW
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int divider = 0;
            Money cash = new Money(2, 57);
            Money cash1 = new Money(2, 56);
            Console.WriteLine(cash);
            Console.WriteLine(cash1);
            Console.WriteLine($"{cash1} / {divider} = {cash1 / divider}");
            Console.WriteLine($"{cash1} > {cash} - {(cash1>cash?true:false)}");
            Console.WriteLine($"{cash1} < {cash} - {(cash1<cash?true:false)}");
            Console.WriteLine($"{cash1} = {cash} - {(cash1==cash?true:false)}");
            Console.WriteLine($"{cash1} != {cash} - {(cash1!=cash?true:false)}");
            Console.Write($"{cash1}++ - ");
            cash1++;
            Console.WriteLine($"{cash1}");
            Console.Write($"{cash1}-- - ");
            cash1--;
            Console.WriteLine($"{cash1}");
            
            
        }
    }
}
