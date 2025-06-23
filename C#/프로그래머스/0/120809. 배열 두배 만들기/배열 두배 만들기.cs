using System;
using System.Linq;
public class Solution {
    public int[] solution(int[] numbers) {
        int[] answer = new int[] {};
        foreach (int number in numbers)
        {
            answer=answer.Append(number * 2).ToArray();
        }
        return answer;
    }
}