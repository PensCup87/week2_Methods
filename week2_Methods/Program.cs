using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week2_Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            //using new method
            int answer = Add(5, 7);
            Console.WriteLine(answer);
            //or Console.WriteLine(Add(5, 7));
        }

        //Methods Should not be in the Main Method
        public static int Add(int firstNumber, int secondNumber)
        {
            int sum = firstNumber + secondNumber;
            return sum;
        }

    }
}
