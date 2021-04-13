using System;

namespace SpecFlowCalculator
{
    public class Calculator
    {
        public int FirstNumber { get; set; }
        public int SecondNumber { get; set; }

        public int Add()
        {
            return FirstNumber + SecondNumber;
        }

        public int Multi()
        {
            return FirstNumber * SecondNumber;
        }

        public int Split()
        {
            return FirstNumber / SecondNumber;
        }
    }
}
