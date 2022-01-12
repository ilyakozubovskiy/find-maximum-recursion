using System;

namespace FindMaximumTask
{
    /// <summary>
    /// Class for operations with array.
    /// </summary>
    public static class ArrayExtension
    {
        /// <summary>
        /// Finds the element of the array with the maximum value recursively.
        /// </summary>
        /// <param name="array"> Source array. </param>
        /// <returns>The element of the array with the maximum value.</returns>
        /// <exception cref="ArgumentNullException">Thrown when array is null.</exception>
        /// <exception cref="ArgumentException">Thrown when array is empty.</exception>
        public static int FindMaximum(int[] array)
        {
            if (array == null)
            {
                throw new ArgumentNullException(nameof(array));
            }

            if (array.Length == 0)
            {
                throw new ArgumentException("source cannot be empty.");
            }

            if (array.Length == 1)
            {
                return array[0];
            }

            if (array.Length == 2)
            {
                return Max(array[0], array[1]);
            }

            int midIndex = array.Length / 2;

            return Max(FindMaximum(array[..midIndex]), FindMaximum(array[midIndex..]));
        }

        public static int Max(int a, int b) => a > b ? a : b;
    }
}
