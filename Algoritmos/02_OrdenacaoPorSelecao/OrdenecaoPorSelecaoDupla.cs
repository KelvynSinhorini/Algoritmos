namespace Algoritmos;

public class OrdenecaoPorSelecaoDupla : IAlgoritmo
{
    public void Run()
    {
        var numbers = new int[] { 4, 5, 1, 3, 10, 9, 6, 8, 7, 2 };
        var sortedArr = SelectionSort(numbers);

        Console.WriteLine(string.Join(", ", numbers));
        Console.WriteLine(string.Join(", ", sortedArr));
    }

    /// <summary>
    /// O(n x n) ou O(n^2)
    /// </summary>
    /// <param name="array"></param>
    /// <returns></returns>
    private int[] SelectionSort(int[] array)
        => SelectionSort(new LinkedList<int>(array)).ToArray();

    private IEnumerable<int> SelectionSort(LinkedList<int> list)
    {
        var minList = new LinkedList<int>();
        var maxList = new LinkedList<int>();

        while (list.Count != 0)
        {
            var min = list.Min();
            list.Remove(min);
            minList.AddLast(min);

            var max = list.Max();
            list.Remove(max);
            maxList.AddFirst(max);
        }

        return minList.Union(maxList);
    }
}
