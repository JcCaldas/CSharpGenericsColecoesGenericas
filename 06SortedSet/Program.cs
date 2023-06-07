Console.WriteLine("SortedSet\n");

//Criação de SortedSet é similar a HashSet. SortedSet sempre coloca na ordem

var numeros = new SortedSet<int>() { 1, 5, 3, 4, 2 };
ExibirColecao(numeros);

var frutas = new SortedSet<string> { "uva", "banana", "pera", "kiwi" };
ExibirColecao(frutas);

SortedSet<int> pares = new SortedSet<int>();
for (int i = 6; i > 0; i--)
{
    pares.Add(i*2);
}
ExibirColecao(pares);

//pode-se criar a partir de uma lista.

var numerosLista = new List<int>() { 1, 7, 3, 6, 5, 4, 2 };
var conjunto = new SortedSet<int>(numerosLista);
ExibirColecao(conjunto);

static void ExibirColecao<T>(IEnumerable<T> colecao)
{
    Console.WriteLine("\n---------------------------------\n");
    foreach (var item in colecao)
    {
        Console.WriteLine(item);
    }
    Console.WriteLine("\n---------------------------------\n");
}
