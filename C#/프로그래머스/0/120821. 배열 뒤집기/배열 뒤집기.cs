using System;
using System.Collections.Generic;
using System.Linq;
public class Solution {
    public int[] solution(int[] num_list) {
        int[] answer = new int[] {};
        answer = num_list.Reverse().ToArray();
        return answer;
    }
}