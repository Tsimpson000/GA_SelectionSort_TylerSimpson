namespace GA_SelectionSort_TylerSimpson
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //SelectionSort algorithm repeatedly selects the minimum element from the unsorted portion of the array and moves it to the beginning
            //of the sorted portion. This process continues until the entire array is sorted.

            int[] arr = { 64, 25, 12, 22, 11, 36, 8, 42, 5, 38 };

            //display arrays through out sorting steps
            Console.WriteLine("Original Array:");
            PrintArray(arr);

            SelectionSortArray(arr);

            Console.WriteLine("\nSorted Array:");
            PrintArray(arr);

        }
        static void PrintArray(int[] arr)
        {
            foreach (var item in arr)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }
        static void SelectionSortArray(int[] arr)
        {
            // Step 1 - Initialization we obtain the length of the input array arr, which helps us determine the number of elements in the array.
            int arrayLength = arr.Length;

            // Step 2 - Outer Loop iterates through the array from the first element (index 0) to the second-to-last element (index arrayLength - 2).
            // This loop will help us select each element one by one for proper placement.

            for (int currentIndex = 0; currentIndex < arrayLength - 1; currentIndex++)
            {
                //Step 3 - Assumption of Minimum assume that the current element is the minimum within the unsorted portion of the array.
                //Temporary minimum value until we find a smaller value
                int minIndex = currentIndex;

                // Step 4 - Inner Loop iterates through the remaining unsorted portion of the array. Starting from the element following our current element.
                //It then continues to the last index of the array. This loop helps us find the minimum element within the unsorted part.
                for (int unsortedIndex = currentIndex + 1; unsortedIndex < arrayLength; unsortedIndex++)
                {
                    // Step 5 - Comparison of unsortedIndex with the element at the minIndex (the assumed minimum).
                    //If unsortedIndex is smaller than the assumed min, we update minIndex to point to the unsortedIndex
                    //This helps us find the smallest element within the unused portion of the array
                    if (arr[unsortedIndex] < arr[minIndex])
                    {
                        minIndex = unsortedIndex;
                    }
                }
                //Step 6 -we have now found the actual minimum element, we then swap this element with the currentIndex to ensure the smallest element
                //is properly placed at the beginning of the array
                int temp = arr[minIndex];
                arr[minIndex] = arr[currentIndex];
                arr[currentIndex] = temp;

                // Step 7 - display the current state of the array to visualize how the elements are being sorted.
                Console.Write($"Iteration {currentIndex + 1}: ");
                PrintArray(arr);
            }
        }
    }
}
