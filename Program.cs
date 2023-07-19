namespace sortAlgorithms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            List<int> list = new List<int> { 64, 25, 12, 22, 11 };

            Console.WriteLine("\nSelectionSort: ");
            List<int> list1=selectionSort.SortList(list);

            foreach (int i in list1)
            {
                Console.Write(i + " ");
            }

            List<int> list2 = new List<int> { 64, 25, 12, 22, 11 };

            Console.WriteLine("\nMergeSort: ");
            mergeSort.SortList(list2);

            foreach (int i in list2)
            {
                Console.Write(i + " ");
            }

            int[] arr = { 64, 25, 12, 22, 11 };

            Console.WriteLine("\nBubbleSort: ");
            bubbleSort.SortArray(arr);

            foreach (int i in arr)
            {
                Console.Write(i + " ");
            }
        }
    }
}