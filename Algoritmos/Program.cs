using Algoritmos;

namespace Algoritmo;

public class Program
{
    private static Dictionary<string, Action> Algoritmos = new Dictionary<string, Action>
    {
        //{ "1", () =>  },
        { "2", () => OrdenecaoPorSelecao.Run() }
    };

    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine(
                "Lista de Algoritmos\n" +
                "1 - .\n" +
                "2 - Ordenação por Seleção (Selection Sort).\n" +
                "3 - Ordenação por Seleção Dupla (Double Selection Sort).\n" +
                "X - Sair"
            );
            Console.Write("Selecione um algoritmo para executar: ");
            var choice = Console.ReadLine();

            if (choice.Equals("X", StringComparison.OrdinalIgnoreCase))
                break;

            if (Algoritmos.TryGetValue(choice, out Action task))
            {
                task();
            }
            else
            {
                Console.WriteLine("Invalid choice.");
            }

            Console.WriteLine();
        }
    }
}
