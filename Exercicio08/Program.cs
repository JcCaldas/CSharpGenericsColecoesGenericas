Console.WriteLine("Exercício 08\n");
int[] intArray = { 1, 2, 3, 4, 5 };
string[] stringArray = { "Lucas", "Rafael", "Larissa", "João" };
double[] doubleArray = { 1.5, 2.5, 3.5, 4.5, 5.5 };

Console.WriteLine("Array Int");
Exemplo.ReverterEImprimir(intArray);
Exemplo.ReverterEImprimir<int>(intArray);

Console.WriteLine("\nArray string");
Exemplo.ReverterEImprimir(stringArray);
Exemplo.ReverterEImprimir<string>(stringArray);

Console.WriteLine("\nArray Double");
Exemplo.ReverterEImprimir(doubleArray);
Exemplo.ReverterEImprimir<double>(doubleArray);



class Exemplo
{
    public static void ReverterEImprimir<T>(T[] array)
    {
        var novoArray = array.Reverse();
        foreach (var item in novoArray)
        {
            Console.Write($"{item} ");
        }
        Console.WriteLine();
    }
}