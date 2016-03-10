using MetaWpf.Domain.Abstracts;

namespace MetaWpf.Domain.Concretes
{
    public class MathTools : IMathTools
    {
        public int Add(int num1, int num2)
        {
            return num1 + num2;
        }

        public int Substract(int num1, int num2)
        {
            return num1 - num2;
        }
    }
}