using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Boat_Movements_2D_array
{
    public class BoatMovement
    {
        static readonly int b = 6;
        public int CanTravelTo(bool[,] gameMatrix, int fromRow, int fromColumn, int toRow, int toColumn)
        {
            var min = 0; 
            var max = 5;
            var possibleRoute = gameMatrix[toRow,toColumn];

            while (max <= 5)
            {
                var mid = (int)(0 + 5) / 2;
                var temp = compareRow(GetRow(gameMatrix, min), Convert.ToInt32(possibleRoute));

                    // If current row is equal to the given
                    // array then return the row number
                    if (temp == 0)
                        return mid + 1;

                    // If arr[] is greater, ignore left half
                    else if (temp == 1)
                        min = mid + 1;

                    // If arr[] is smaller, ignore right half
                    else
                        max = mid - 1;
            }


            return -1;

        }

        public int compareRow(bool[] a1, int possibleRoute)
        {
            for (int i = 0; i < b; i++)
            {
                // Return 1 if mid row is less than arr[]
                if (Convert.ToInt32(a1[i]) < possibleRoute)
                    return 1;

                // Return 1 if mid row is greater than arr[]
                else if (Convert.ToInt32(a1[i]) > possibleRoute)
                    return -1;
            }
            // Both the arrays are equal
            return -1;
        }

        public bool[] GetRow(bool[,] matrix, int mid)
        {
            var rowLength = matrix.GetLength(1);
            var rowVector = new bool[rowLength];

            for (var i = 0; i < rowLength; i++)
                rowVector[i] = matrix[mid, i];

            return rowVector;
        }
    }
}