using System;

public class Solution {
    public string solution(string my_string, int[,] queries) {
            string answer = "";
            char[] chars = my_string.ToCharArray();
            for (int i = 0; i < queries.GetLength(0); i++)
            {
                int start = queries[i, 0];
                int end = queries[i, 1];
                Array.Reverse(chars, start, end - start + 1);
                my_string = new string(chars);
            }
            answer = my_string;
            return answer;
    }
}