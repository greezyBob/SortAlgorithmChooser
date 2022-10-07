using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SortManagerControllers
{
    public class Controller
    {
        public int[] UnsortedArray { get; private set; }

        public void GenerateUnsortedArray(int x)
        {
            if (x < 1 || x > 100) throw new ArgumentException();



            int[] arr = new int[x];
            for (int i = 0; i < arr.Length; i++)
            {
                Random rnd = new Random();
                int rndNumber = rnd.Next(1, 100);
                arr[i] = x;
            }
            UnsortedArray = arr;
        }



        public (int[], int[]) ParseInput(string input)
        {
            int number;
            SortFactory sortFactory = new SortFactory();
            bool success = int.TryParse(input, out number);
            if (success)
            {
                if (number > 0 && number < 4)
                {
                    int x;
                    bool succes2 = int.TryParse(View.View.DisplayArrayLengthScreen(), out x);
                    if (succes2)
                    {
                        if (x > 0 && x <= 100)
                        {
                            var z = sortFactory.ChooseSorter(number);
                            GenerateUnsortedArray(x);
                            var i = z.Sort(UnsortedArray);
                            View.View.DisplayHappyOutputScreen(UnsortedArray, i, 1.00);
                        }
                        else
                        {

                        }
                    }
                    

                }
                
            }
            else
            {
                 
            }
        }

    }
}