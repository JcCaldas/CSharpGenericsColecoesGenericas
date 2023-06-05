Console.WriteLine("Sorted Dictionary\n");

//Criando uma coleçaõ SortedDictionary. Independente da ordem que for colocado, ela sempre será ordenada pela chave automaticamente.

Console.WriteLine("Criando SortedDictionary\n");

var brics = new SortedDictionary<int, string>()
{
    {20, "Brasil" },
    {10, "China" },
    {40, "India" },
    {30, "Rússia" }
};

ExibirSortedDictionary(brics);

Console.WriteLine("Incluindo o elemento de chave \"70\" e valor \"África do Sul\" ");

brics.Add(70, "África do Sul");

ExibirSortedDictionary(brics);

//Função para exibição
static void ExibirSortedDictionary(SortedDictionary<int, string> brics)
{
    foreach (var item in brics)
    {
        Console.WriteLine($"Chave: {item.Key}\t Valor: {item.Value}");

    }
    Console.WriteLine("\n-----------------------------------\n");
}

