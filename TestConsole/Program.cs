using System;

namespace TestConsole
{
    public class Program
    {
        static void Main()
        {
            int[] arr = {1,2,3,4,5,6,7,8,9};
    int sum = 0, count = 0;
    for(int i = 1 ; i < arr.Length ; i += 2){
        sum += arr[i];
        count++;
    }
    Console.WriteLine((double)sum / count);
        }
    }
}
