using System;
using System.Linq;
public class Solution {
    public int[] solution(int money) {
            int[] answer = new int[] { };
            int count = 0;
            while (true)
            {
                if (money >= 5500)
                {
                    money -= 5500;
                    count++;
                }
                else
                {
                    answer=answer.Append(count).ToArray();
                    answer=answer.Append(money).ToArray();
                    break;
                }
            }
            return answer;
    }
}