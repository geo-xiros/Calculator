using System;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator<int> calcInt = Calculator<int>.CreateIntCalculator();

            Calculator<float> calcFloat = Calculator<float>.CreateFloatCalculator();

            Console.WriteLine(calcInt.Calculate("mul", 4, 2));
            Console.WriteLine(calcInt.Calculate("div", 4, 2));
            Console.WriteLine(calcFloat.Calculate("Add", 1, 2.2f));
            Console.ReadKey();
        }
    }

}
