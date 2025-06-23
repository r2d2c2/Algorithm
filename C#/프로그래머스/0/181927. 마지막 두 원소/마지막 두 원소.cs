using System;
using System.Linq;
public class Solution {
    public int[] solution(int[] num_list) {
        int[] answer = new int[] {};
        int a =num_list[num_list.Length-1];
        int b = num_list[num_list.Length - 2];
        if (a > b)
        {
            answer = num_list.Append(a - b).ToArray();
        }
        else
        {
            answer = num_list.Append(a *2).ToArray();
        }
        return answer;
    }
}