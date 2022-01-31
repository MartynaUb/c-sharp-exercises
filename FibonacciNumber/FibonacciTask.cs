using System.Collections.Generic;

namespace csharpExercises.FibonacciNumber
{
    public class FibonacciTask
    {
        private static Dictionary<int, int> memo = new Dictionary<int, int>() { { 0, 0 }, { 1, 1 } };
        
        public static int ReturnFibonacciNumberByPosition(int position)
        {
            int var1 = 1;
            int var2 = 1;
            int result = 1;

            if (position == 0)
            {
                return 0;
            }

            if (position > 2)
            {
                for (int i = 2; i < position; i++)
                {
                    result = var1 + var2;
                    var2 = var1;
                    var1 = result;
                }
            }

            return result;
        }


        public static int RecursivelyReturnFibonacciNumberByPosition(int position)
        {
            return position <= 1
                ? position
                : RecursivelyReturnFibonacciNumberByPosition(position - 2) +
                  RecursivelyReturnFibonacciNumberByPosition(position - 1);
        }
        
        public static int ReturnFibonacciNumberByPositionMemoization(int position)
        {
            if (memo.ContainsKey(position))
            {
                return memo[position];
            }

            int result = position <= 1
                ? position
                : RecursivelyReturnFibonacciNumberByPosition(position - 2) +
                  RecursivelyReturnFibonacciNumberByPosition(position - 1);
            memo[position] = result;
            
            return result;        
        }
        
        
    }
}