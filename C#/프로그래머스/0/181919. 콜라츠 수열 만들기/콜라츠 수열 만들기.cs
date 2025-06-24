using System;
using System.Linq;
public class Solution {
    public int[] solution(int n) {
        int[] answer = new int[] {};
        answer=answer.Append(n).ToArray();
        while (true)
        {
            if(n == 1)
            {
                //answer = answer.Append(1).ToArray();
                break;
            }
            else if (n % 2 == 0)
            {
                answer = answer.Append(n/2).ToArray();
                n/=2;
            }else if( n % 2 != 0)
            {
                int i = n * 3 + 1;
                answer = answer.Append(i).ToArray();
                n=i;
            }
        }
        return answer;
    }
}