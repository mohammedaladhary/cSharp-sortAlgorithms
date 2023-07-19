namespace sortAlgorithms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            List<int> list = new List<int> { 64, 25, 12, 22, 11 };

            selectionSort.Sort(list);

            foreach (int i in list)
            {
                Console.Write(i+ " ");
            }
        }
    }
}