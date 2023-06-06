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
//Melhor forma é verificar se a chave já existe para não dar erro
if (brics.ContainsKey(70))
    Console.WriteLine("A chave já existe");
else
    brics.Add(70, "África do Sul");

ExibirSortedDictionary(brics);

//Exibindo a quanditdade de elementos de um dicionário
Console.WriteLine($"Número de pares de chaves(elementos) no dicionário: {brics.Count}\n");

//Acessar o elemento pela chave
Console.WriteLine("Acessando um elemento pela chave -> brics[20]");
Console.WriteLine($"Chave 20 -> {brics[20]}\n");

//Alterar o valor de uma chave
Console.WriteLine("Alterando o valor da chave \"20\" para \"Argentina\" -> brics[20] = \"Argentina\"");
brics[20] = "Argentina";
Console.WriteLine($"Chave 20 -> {brics[20]}\n");

//Removendo elemento
Console.WriteLine("Removendo a chave \"10\" -> brics.Remove(10)");
brics.Remove(10);
Console.WriteLine("\n-----------------------------------\n");
ExibirSortedDictionary(brics);

//Verificando se uma chave existe (retorna true ou false)
Console.WriteLine("Verificando se uma chave existe com ContainsKey");
Console.WriteLine($"Existe a chave \"30\"? -> {brics.ContainsKey(30)}");
Console.WriteLine($"Existe a chave \"10\"? -> {brics.ContainsKey(10)}");
Console.WriteLine("\n-----------------------------------\n");

//Verificando se um valor existe
Console.WriteLine("Verificando se um valor existe com ContainsValue");
Console.WriteLine($"Existe o valor \"Rússia\"? -> {brics.ContainsValue("Rússia")}");
Console.WriteLine($"Existe o valor \"Chile\"? -> {brics.ContainsValue("Chile")}");
Console.WriteLine("\n-----------------------------------\n");

//Obtendo valor usando TryGetValue
Console.WriteLine("Obtendo o valor da chave \"30\" usando TryGetValue");

if (brics.TryGetValue(30, out string? value)) //Se existir a chave 30, o valor é colocado na variavel externa definida
    Console.WriteLine($"Valor da chave 30: {value}");
else
    Console.WriteLine("A chave não existe");
Console.WriteLine("\n-----------------------------------\n");

//Para percorrer o SortedDictionary usa-se foreach
Console.WriteLine("Percorrendo o dicionário usando foreach");
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

