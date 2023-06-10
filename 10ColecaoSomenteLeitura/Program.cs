using System.Collections.ObjectModel;

Console.WriteLine("ReadOnlyCollection<T>\n");

//Deve-se lembrar de protejer a coleção original, pois ela altera a somente leitura

var planetas = new List<string>()
{
    "Mercúrio", "Vênus", "Terra", "Marte"
};

//Criando uma coleção somente leitura
var listaplanetas = new ReadOnlyCollection<string>(planetas);

//ou
var novaListaPlanetas = planetas.AsReadOnly();

//Propriedades
Console.WriteLine("Planetas não gasos do sistema solar:\n");

Exibir(novaListaPlanetas);

//Quantidade de itens na lista -> Count
Console.WriteLine($"\nPlanetas na coleção: {novaListaPlanetas.Count}");

//verifica se tem um item específico na coleção -> Contains
Console.WriteLine("\nJúpiter está na coleção?");
Console.WriteLine(novaListaPlanetas.Contains("Jupiter") ? "Sim\n" : "Não\n");//Operador ternário.

//Obtendo item a partir do índice
Console.WriteLine($"Planeta de índice 3: {novaListaPlanetas[3]}\n");

//Obtendo o índice de um item ->IndexOf
Console.WriteLine($"Índice do planeta Terra: {novaListaPlanetas.IndexOf("Terra")}");

//Se alterar a lista original, vai se refletir na coleção somente leitura
Console.WriteLine("Inserindo um novo elemento na Lista original (índice 4 - Plutão)\n");
planetas.Insert(4, "Plutão");

Exibir(novaListaPlanetas);


//Copiando os elemento de uma coleção somente leitura para um Array unidimensional
Console.WriteLine("\nCopiando os elemento de uma coleção somente leitura para um Array unidimensional");
string[] planetasArray = new string[listaplanetas.Count + 2];
novaListaPlanetas.CopyTo(planetasArray, 1);

Console.WriteLine($"O Array copiado possui {planetasArray.Length} elementos\n");
Exibir(planetasArray);



static void Exibir<T>(IEnumerable<T> ListaSomenteLeitura)
{
    foreach (var item in ListaSomenteLeitura)
    {
        Console.Write($"\"{item}\", ");
    }
    Console.WriteLine();
}

