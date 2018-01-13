using System;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            // Single Dimensional Array
            int[] array = new int[5];
            int[] array1 = new int[] { 1, 3, 5, 7, 9 };
            int[] array2 = { 1, 3, 5, 7, 9 };
            string[] days = { "Sun", "Mon", "Tue", "Wed", "Thr", "Fri", "Sat" };
            Console.WriteLine(days[0]); // Outputs "Sun"

            // Multi Dimensional Array
            int[,] array2D = new int[2, 3];
            // declare and initialize multidimension array
            int[,] array2D2 = { { 1, 2, 3 }, { 4, 5, 6 } };

            // Jagged Array
            int[][] jaggedArray = new int[3][];
            jaggedArray[0] = new int[5];
            jaggedArray[1] = new int[4];
            jaggedArray[2] = new int[2];

            // Create the array to store the CDs.
            CD[] cdLibrary = new CD[20];

            // Populate the CD library with CD objects
            for (int i = 0; i < 20; i++)
            {
                cdLibrary[i] = new CD();
            }

            // Assign details to the first album.
            cdLibrary[0].Album = "See";
            cdLibrary[0].Artist = "The Sharp Band";
            //cdLibrary[0].Album = 10;
        }
    }

    class CD
    {
        public string Album;
        public string Artist;
    }
}
