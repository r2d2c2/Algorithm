using System;

public class Solution {
    public int solution(int n, string control) {
        int answer = 0;
                    char[] chars=control.ToCharArray();
            foreach (char c in chars)
            {
                switch (c)
                {
                    case 'w':
                        n++;
                        break;
                    case 's':
                        n--;
                        break;
                    case 'd':
                        n += 10;
                        break;
                    case 'a':
                        n -= 10;
                        break;
                }
            }
            answer = n;
        return answer;
    }
}