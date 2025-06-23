using System;
using System.Collections.Generic;
using System.Linq;
public class Solution {
    public int solution(int[] array) {
        int answer = 0;
        Dictionary<int, int> frequency = new Dictionary<int, int>();
        foreach (int num in array)
        {
            if (frequency.ContainsKey(num))
            {
                frequency[num]++;
            }
            else
            {
                frequency[num] = 1;
            }
        }
        int count=0;
        foreach(var i in array)
        {
            if (array[0] == i)
                count++;
        }
        if (count == array.Length)
        {
            return array[0];
        }
        
        int a= frequency.OrderByDescending(x => x.Value)
            .ThenBy(x => x.Key)
            .First().Key;
                    // 2번 값 출력
         int b=9999;
         b = frequency.OrderByDescending(x => x.Value)
            .ThenBy(x => x.Key)
            .Skip(1)
            .FirstOrDefault().Key;
        if(array.Length>1){
            if (frequency[a] == frequency[b])
            {
                answer = -1;
            }
            else
            {
                answer = a;
            }
        }else{
            answer=array[0];
        }
        return answer;
    }
}