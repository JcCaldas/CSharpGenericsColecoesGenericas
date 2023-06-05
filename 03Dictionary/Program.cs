Console.WriteLine("Dictionary\n");

//Criar um Dictionary<TipoChave, TipoValor>

Dictionary<int, int> dic1 = new Dictionary<int, int>();

//ou
var dic2 = new Dictionary<int, int>();

//Adicionar elementos
//Chaves são exclusivas, mesmo que contenham valores repetidos

//Add
dic2.Add(2, 100);
dic2.Add(4, 100);
dic2.Add(3, 400);

/*Outra forma de incluir valores, é criar um Dictionary
 com os valores. {chave, valor}*/
var dic3 = new Dictionary<int, int>() 
{
    {1, 100 },
    {2, 300 },
    {3, 400 }
};

/*Caso seja inserido um elemento com um valor de chave existente
 é gerado uma excessão: ArgumentException*/
Console.WriteLine("\nInclui um elemento com chave(3) duplicada com \"Add\"");
try
{
    dic3.Add(3, 100);
}
catch (Exception ex)
{
    Console.WriteLine("\n" + ex.Message);
    Console.WriteLine("\n" + ex.ToString());
}

//TryAdd
Console.WriteLine("\nInclui um elemento com chave(3) duplicada com \"TryAdd\"");

var resultado = dic3.TryAdd(3,100);//retorna true ou false - nesse caso é false pois já tem uma chave 3 no Dictionary
Console.WriteLine("Elemento com chave 3 foi incluido? " + resultado);

var resultado2 = dic3.TryAdd(4,100);//retorna true ou false - nesse caso é true pois não tem uma chave 4 no Dictionary
Console.WriteLine("\nElemento com chave 4 foi incluido? " + resultado2);

//ContainsKey - Verifica se a chave existe no Dictionary
Console.WriteLine("\nContainsKey");
Console.WriteLine("Contem a chave 3 no Dictionary? " + dic3.ContainsKey(3));//Retorna True ou False

//Caso não contenha a chave, o elemento naquela chave é adicionado

if (!dic3.ContainsKey(7)) //Not dic3.ContainsKey(7) - Se Dictionary não contiver a chave 7
{
    Console.WriteLine("\nIncluindo o elemento com chave 7 e valor 7000");
    dic3.Add(7, 7000);
}
    Console.WriteLine("Elemento com chave 7 no dictionary: " + dic3[7]);

//ContainsValue - Verifica se um valor existe no Dictionay, retorna True ou False
Console.WriteLine("\nContainsValue");

if (dic3.ContainsValue(7000))
{
    Console.WriteLine("O valor 7000 contém no Dicionário");
}

//Alterando valor de elemento do Dicionário
Console.WriteLine("\nAlterando o valor do elemento com chave 7");
Console.WriteLine("Valor aual do item: " + dic3[7]);

if (dic3.ContainsKey(7))
{
    dic3[7] = 7777; //Dictionary na posição 7 recebe valor
    Console.WriteLine("Valor alterado do item: " + dic3[7]);
}

//Acessando elemento com chave inexistente (KeyNotFoundException)
Console.WriteLine("\nTentando obter elemtno com chave 5 - inexistente");

try
{
    Console.WriteLine(dic3[5]);
}

catch (Exception ex)
{
    Console.WriteLine("\n" + ex.Message);
    Console.WriteLine("\n" + ex.ToString());
}

//TryGetValue - Tenta acessar e retorna true ou false.
//Precisa utilizr out tipo valor - isso gera uma variavel do tipo com o valor
Console.WriteLine("\nUsando TryGetValue() para a chave 5");

//Se a chave existir ele retorna o valor da chave na variavel "valor".
if (dic3.TryGetValue(5, out int valor))
{
    Console.WriteLine("Valor para a chave 5 = " + valor);
}
else
{
    Console.WriteLine("Chave não encontrada");
}

dic3.Add(6, 6666);
dic3.Add(5, 4444);

//Exibindo um dictionary

Console.WriteLine("\nPercorrendo o dicionário e exibindo os itens (foreach)");

foreach (var item in dic3)
{
    Console.WriteLine($"Chave: {item.Key}\nValor: {item.Value}");
}

//Ordenar os elementos do Dictionary
Console.WriteLine("\nOrdenando os elementos do dicionário (SortedDictionary/LINQ - LINQ com mais detalhes a frente do curso)");

//cria um dicionário ordenado a partir de um dicionário existente

Console.WriteLine("\nDic3 Ordenado com SortedDictionary.");

var dic3Ordenado = new SortedDictionary<int, int>(dic3);

foreach (var item in dic3Ordenado)
{
    Console.WriteLine($"Chave: {item.Key}\nValor: {item.Value}");
}


Console.WriteLine("\nDic Ordenado com LINQ pela chave");

var dic3OrdenadoLinqChave = dic3.OrderBy(x => x.Key); //Expressão lâmbida que solicita a ordenação pela chave

foreach (var item in dic3OrdenadoLinqChave)
{
    Console.WriteLine($"Chave: {item.Key}\nValor: {item.Value}");
}

Console.WriteLine("\nDic Ordenado com LINQ pelo valor");

var dic3OrdenadoLinqValor = dic3.OrderBy(x => x.Value); //Expressão lâmbida que solicita a ordenação pelo valor

foreach (var item in dic3OrdenadoLinqValor)
{
    Console.WriteLine($"Chave: {item.Key}\nValor: {item.Value}");
}