using System;
using System.Linq;
public class Solution {
    public int[] solution(int[] arr) {
        int[] stk = new int[] {};
        int i = 0;
        while(i < arr.Length)
        {
            int stkCount = stk.Length;
            if(stkCount == 0)
            {
                Array.Resize<int>(ref stk, stkCount + 1);
                stk[0] = arr[i];
                i++;
            }
            else if(stk[stkCount - 1] < arr[i])
            {
                Array.Resize<int>(ref stk, stkCount + 1);
                stk[stkCount] = arr[i];
                i++;
            }
            else if(stk[stkCount - 1] >= arr[i])
            {
                Array.Resize<int>(ref stk, stkCount - 1);
            }
        }
        return stk;
    }
}