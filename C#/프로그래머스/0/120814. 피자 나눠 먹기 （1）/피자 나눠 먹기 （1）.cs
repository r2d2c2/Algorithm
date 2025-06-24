using System;

public class Solution {
    public int solution(int n) {
            int answer = 0;
            for (int i = 0; i < n; i++)
            {
                if (i % 7 == 0)
                {
                    answer += 1;
                }
            }
            return answer;
    }
}