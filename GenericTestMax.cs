using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericPracticeProblems
{
    public class GenericTestMax<T> where T : IComparable
    {
        public T firstNum, secondNum, thirdNum;

        public GenericTestMax(T firstNum, T secondNum, T thirdNum)
        {
            this.firstNum = firstNum;
            this.secondNum = secondNum;
            this.thirdNum = thirdNum;
        }

        public static T MaxIntegerNumber(T firstNum, T secondNum, T thirdNum)
        {
            if (firstNum.CompareTo(secondNum) > 0 && firstNum.CompareTo(thirdNum) > 0 || firstNum.CompareTo(secondNum) >= 0 && firstNum.CompareTo(thirdNum) > 0 || firstNum.CompareTo(secondNum) > 0 && firstNum.CompareTo(thirdNum) >= 0)
            {
                return firstNum;
            }
            if (secondNum.CompareTo(firstNum) > 0 && secondNum.CompareTo(thirdNum) > 0 || secondNum.CompareTo(firstNum) >= 0 && secondNum.CompareTo(thirdNum) > 0 || secondNum.CompareTo(firstNum) > 0 && secondNum.CompareTo(thirdNum) >= 0)
            {
                return secondNum;
            }

            if (thirdNum.CompareTo(firstNum) > 0 && thirdNum.CompareTo(firstNum) > 0 || thirdNum.CompareTo(firstNum) >= 0 && thirdNum.CompareTo(firstNum) > 0 || thirdNum.CompareTo(firstNum) > 0 && thirdNum.CompareTo(firstNum) >= 0)
            {
                return thirdNum;
            }
            return firstNum;
        }

    }
}
