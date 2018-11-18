using System;
using System.Collections.Generic;
using System.Linq;

namespace Calculator
{
    public class Calculator<T>
    {
        private Dictionary<string, Func<T, T, T>> _OperatorsMethods;
        private Calculator()
        {
            _OperatorsMethods = new Dictionary<string, Func<T, T, T>>();
        }
        public static Calculator<int> CreateIntCalculator()
        {
            Calculator<int> calcInt = new Calculator<int>();
            calcInt.AddOperator("add", (a, b)=> a + b );
            calcInt.AddOperator("Sub", (a, b) => a - b);
            calcInt.AddOperator("Div", (a, b) => a / b);
            calcInt.AddOperator("Mul", (a, b) => a * b);
            return calcInt;
        }
        public static Calculator<float> CreateFloatCalculator()
        {
            Calculator<float> calcFloat = new Calculator<float>();
            calcFloat.AddOperator("add", (a, b) => a + b);
            calcFloat.AddOperator("Sub", (a, b) => a - b);
            calcFloat.AddOperator("Div", (a, b) => a / b);
            calcFloat.AddOperator("Mul", (a, b) => a * b);
            return calcFloat;
        }
        public T Calculate(string calcMethodName, T number1, T number2)
        {
            Func<T, T, T> calcMethod = _OperatorsMethods[calcMethodName.ToUpper()];
            return calcMethod(number1, number2);
        }
        public void AddOperator(string calcMethodName, Func<T, T, T> calcMethod)
        {
            _OperatorsMethods.Add(calcMethodName.ToUpper(), calcMethod);
        }
        public bool IsValidOperator(string calculateOperator)
        {
            return _OperatorsMethods.ContainsKey(calculateOperator);
        }
        public string Operators()
        {
            return string.Join(", ", _OperatorsMethods.Select(i => i.Key).ToArray());
        }
    }
}
