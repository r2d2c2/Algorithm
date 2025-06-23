using System;

public class Solution {
    public int[] solution(int[] arr, int[,] queries) {
        int[] answer = new int[] {};
            for(int i = 0; i < queries.GetLength(0); i++)
            {
                int copy = arr[queries[i, 0]];
                arr[queries[i, 0]] = arr[queries[i, 1]];
                arr[queries[i, 1]] = copy;


            }
            return arr;
    }
}