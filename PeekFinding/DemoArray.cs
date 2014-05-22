﻿namespace PeekFinding
{
    internal class DemoArray
    {
        public static int[,] Create5By5()
        {
            // . . n . . 
            // 0 3 2 0 0 .
            // 0 4 1 0 0 .
            // 0 5 0 0 0 m
            // 0 6 0 0 0 .
            // 0 7 8 0 0 .
            const int SIZE = 5;
            var a = new int[SIZE, SIZE];
            a[0, 0] = 0; a[0, 1] = 3; a[0, 2] = 2; a[0, 3] = 0; a[0, 4] = 0;
            a[1, 0] = 0; a[1, 1] = 4; a[1, 2] = 1; a[1, 3] = 0; a[1, 4] = 0;
            a[2, 0] = 0; a[2, 1] = 5; a[2, 2] = 0; a[2, 3] = 0; a[2, 4] = 0;
            a[3, 0] = 0; a[3, 1] = 6; a[3, 2] = 0; a[3, 3] = 0; a[3, 4] = 0;
            a[4, 0] = 0; a[4, 1] = 7; a[4, 2] = 8; a[4, 3] = 0; a[4, 4] = 0;
            return a;
        }

        public static int[,] Create7By7()
        {
            // 0, 0, 9, 0, 0, 0, 0 
            // 0, 0, 0, 0, 0, 0, 0
            // 0, 1, 0, 0, 0, 0, 0 
            // 0, 2, 0, 0, 0, 0, 0 
            // 0, 3, 0, 0, 0, 0, 0 
            // 0, 5, 0, 0, 0, 0, 0 
            // 0, 4, 7, 0, 0, 0, 0
            const int SIZE = 7;
            var a = new int[SIZE, SIZE];
            a[0, 0] = 0; a[0, 1] = 0; a[0, 2] = 9; a[0, 3] = 0; a[0, 4] = 0; a[0, 5] = 0; a[0, 6] = 0; 
            a[1, 0] = 0; a[1, 1] = 0; a[1, 2] = 0; a[1, 3] = 0; a[1, 4] = 0; a[1, 5] = 0; a[1, 6] = 0; 
            a[2, 0] = 0; a[2, 1] = 1; a[2, 2] = 0; a[2, 3] = 0; a[2, 4] = 0; a[2, 5] = 0; a[2, 6] = 0; 
            a[3, 0] = 0; a[3, 1] = 2; a[3, 2] = 0; a[3, 3] = 0; a[3, 4] = 0; a[3, 5] = 0; a[3, 6] = 0; 
            a[4, 0] = 0; a[4, 1] = 3; a[4, 2] = 0; a[4, 3] = 0; a[4, 4] = 0; a[4, 5] = 0; a[4, 6] = 0; 
            a[5, 0] = 0; a[5, 1] = 5; a[5, 2] = 0; a[5, 3] = 0; a[5, 4] = 0; a[5, 5] = 0; a[5, 6] = 0; 
            a[6, 0] = 0; a[6, 1] = 4; a[6, 2] = 7; a[6, 3] = 0; a[6, 4] = 0; a[6, 5] = 0; a[6, 6] = 0; 
            return a;
        }
    }
}