using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zd4_Lezhen_Andrey_Igorevich
{
    static public class NaturalNumbers
    {
        public static bool IsEven(int Number) => Number % 2 == 0;
        public static int GCD(int A, int B)
        {
            while (B != 0)
            {
                int С = B;
                B = A % B;
                A = С;
            }
            return A;
        }
        public static int LCM(int A, int B)
        {
            return Math.Abs(A * B) / GCD(A, B);
        }
        public static bool IsPrime(int Number)
        {
            if (Number == 0) return false;  
            else if (Number == 1) return true;
            else
            {
                for (int i = 2; i < Number; i++) 
                {
                    if (Number%i==0 && i!=Number)
                    {
                        return false;
                    }
                }
            }    
            return true;
        }
    }
}
