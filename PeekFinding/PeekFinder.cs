using System;

namespace PeekFinding
{
    internal class PeekFinder
    {
        // Pick middle column O(1)
        // Find peak
        //    Find 1D peak
        //    Find max     O(n)
        // Check neighbors
        //    If peak :)
        //    else recurse T(n/2, m)
        public static int GetPeekIn2D(int[,] array)
        {
            if (array == null)
                throw new ArgumentNullException();

            int totalColumns = array.GetLength(0);
            int middleColumn = totalColumns/2;

            return GetPeek(array, middleColumn);
        }

        public static int GetPeek(int[,] array, int column)
        {
            int rowWithMaxValue = FindRowWithMaxValueByColumn(array, column);

            int leftValue = array[rowWithMaxValue, column - 1];
            int rightValue = array[rowWithMaxValue, column + 1];
            int currentValue = array[rowWithMaxValue, column];

            if (leftValue > currentValue)
            {
                return GetPeek(array, column - 1);
            }
            
            if (rightValue > currentValue)
            {
                return GetPeek(array, column + 1);
            }
            
            return array[rowWithMaxValue, column];
        }

        public static int FindRowWithMaxValueByColumn(int[,] array, int column)
        {
            int totalRows = array.GetLength(1);
            int maxValue = 0;
            int rowWithMaxValue = 0;
            for (int row = 0; row < totalRows; row++)
            {
                int currentValue = array[row, column];
                if (currentValue > maxValue)
                {
                    maxValue = currentValue;
                    rowWithMaxValue = row;
                }
            }
            return rowWithMaxValue;
        }
    }
}