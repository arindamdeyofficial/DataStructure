using System;

namespace MathHelpers
{
    public class Numbers
    {
        public UInt64 PowerWholeNumber(int baseNum, int power)
        {
            UInt64 num = 0;
            for (int i = 0; i < power; i++)
            {
                num *= (UInt64)baseNum;
            }
            return num;
        }
        public int NumberOfDigits(UInt64 digits)
        {
            int num = 1;
            while (num > 10)
            {
                digits %= 10;
                num++;
            }
            return num;
        }
    }
}
