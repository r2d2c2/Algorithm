using System;

public class Solution {
    public bool solution(bool x1, bool x2, bool x3, bool x4) {
        bool answer = true;
            if((x1 || x2) && (x3 || x4))
            {
                answer = true;
            }

            else
            {
                answer = false;
            }
        return answer;
    }
}