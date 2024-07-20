namespace Algoritmos;
public class BuscaBinaria : IAlgoritmo
{
    public void Run()
    {
        var myList = new List<int> { 1, 3, 5, 7, 9 };
        Console.WriteLine(BinarySearch(myList, 3)); // => 1
        Console.WriteLine(BinarySearch(myList, -1)); // => null gets printed as an empty string
    }

    /// <summary>
    /// O(log n)
    /// </summary>
    /// <param name="list"></param>
    /// <param name="item"></param>
    /// <returns></returns>
    private static int? BinarySearch(IList<int> list, int item)
    {
        var low = 0;
        var high = list.Count() - 1;

        while (low <= high)
        {
            var mid = (low + high) / 2;
            var guess = list[mid];
            if (guess == item) return mid;
            if (guess > item)
            {
                high = mid - 1;
            }
            else
            {
                low = mid + 1;
            }
        }

        return null;
    }
}
