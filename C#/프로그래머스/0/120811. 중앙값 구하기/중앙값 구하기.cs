using System;

public class Solution {
    public int solution(int[] array) {
        int answer = 0;
            Array.Sort(array);
            answer+= array.Length/2;
            answer= array[answer];
        return answer;
    }
}