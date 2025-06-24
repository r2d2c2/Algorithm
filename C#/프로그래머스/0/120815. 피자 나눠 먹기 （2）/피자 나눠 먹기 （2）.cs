using System;

public class Solution {
    public int solution(int n) {
            int answer = 0;
            int count = 1;
            for (int i = 6; i < 1000; i+=6)
            {

                if (i % n == 0)
                {
                    answer = count;
                    break;
                }
                count++;
            }
            return answer;
    }
}