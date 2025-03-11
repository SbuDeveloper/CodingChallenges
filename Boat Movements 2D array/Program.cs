

using Boat_Movements_2D_array;

internal class Program
{
    private static void Main(string[] args)
    {
        BinarySearch binarySearch = new();
        BoatMovement boatMovement = new();
        int[,] myArray = new int[3,4] {
                                {0, 1, 2, 3},
                                {4, 5, 6, 7},
                                {8, 9, 10, 11}
            };

            // Accessing an element in the 2D array
            int element = myArray[1,2]; // This will return
            Console.WriteLine(element);

            // Iterating over a 2D array using nested loops
            for (int a = 0; a < myArray.GetLength(0); a++) {
                for (int b = 0; b < myArray.GetLength(1); b++) {
                    Console.Write(myArray[a,b] + " ");
                }
                Console.WriteLine();
            }

        //     int[,] mat = {{ 0, 0, 1, 0 },
        //         { 10, 9, 22, 23 },
        //         { 40, 40, 40, 40 },
        //         { 43, 44, 55, 68 },
        //         { 81, 73, 100, 132 },
        //         { 100, 75, 125, 133 }};
        // int[] row = { 10, 9, 22, 23 };
        // Console.WriteLine(binarySearch.binaryCheck(mat, row));

         bool[,] gameMatrix = 
        {
            {false, true,  true,  false, false, false},
            {true,  true,  true,  false, false, false},
            {true,  true,  true,  true,  true,  true},
            {false, true,  true,  false, true,  true},
            {false, true,  true,  true,  false, true},
            {false, false, false, false, false, false},
        };

        Console.WriteLine(boatMovement.CanTravelTo(gameMatrix, 3, 2, 2, 2)); // true, Valid move
        Console.WriteLine(boatMovement.CanTravelTo(gameMatrix, 3, 2, 3, 4)); // false, Can't travel through land
        Console.WriteLine(boatMovement.CanTravelTo(gameMatrix, 3, 2, 6, 2)); // false, Out of bounds


    }
}