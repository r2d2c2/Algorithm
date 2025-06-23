using System;
using System.Linq;
public class Solution {
            private int GCD(int a, int b)
        {
            while (b != 0)
            {
                int temp = b;
                b = a % b;
                a = temp;
            }
            return a;
        }
    public int[] solution(int numer1, int denom1, int numer2, int denom2) {
            int[] answer = new int[] { };
            int copy1 = numer1, copy2 = numer2, copy3 = denom1, copy4 = denom2;
            while (true)
            {
                if (copy3 == copy4)
                {
                    answer = answer.Append(copy1 + copy2).ToArray();
                    answer = answer.Append(copy3).ToArray();
                    break;
                }
                else if (copy3 < copy4)
                {
                    copy1 += numer1;
                    copy3 += denom1;
                }
                else if (copy3 > copy4)
                {
                    copy2 += numer2;
                    copy4 += denom2;
                }
            }
            while (answer[0] % 2 == 0&& answer[1]%2==0)
            {
                answer[0] /= 2;
                answer[1] /= 2;
            }
                   //최대공약수로 나누기
           int gcd = GCD(answer[0], answer[1]);
           answer[0] /= gcd;
           answer[1] /= gcd;
            return answer;
    }
}