using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject
{
    public class Addition
    {
        public void AddTwoNumbers()
        {
            Console.WriteLine("Enter first num");
            int firstNum = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter second num");
            int secondNum = Convert.ToInt32(Console.ReadLine());
            int finalNum = firstNum + secondNum;
            Console.WriteLine("Addition of two number is:-m" + " " + finalNum);
        }
    }
}
