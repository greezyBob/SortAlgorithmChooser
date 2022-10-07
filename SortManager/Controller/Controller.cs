using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace Controller
{
    public class Controller
    {
        public int[] GenerateArray(int x)
        {
            int[] arr = new int[x];
            for (int i = 0; i < arr.Length; i++)
            {
                Random rnd = new Random();
                int rndNumber = rnd.Next(1, 100);
                arr[i] = x;
            }
            return arr;
        }
    }
}