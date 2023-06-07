Console.WriteLine("HashSet\n");

var timesSP = new HashSet<string>() { "Santos", "Palmeiras", "São Paulo" };

var timesRJ = new HashSet<string>() { "Vasco", "Flamengo", "Fluminense" };

var timesBA = new HashSet<string>() { "Bahia", "Vitória", "Juazeiro" };

var timesMundiais = new HashSet<string>() { "Santos", "Palmeiras", "São Paulo", "Flamengo" };

Console.WriteLine("Times de São Paulo");
ExibirTimes(timesSP);

Console.WriteLine("Times do RJ");
ExibirTimes(timesRJ);

Console.WriteLine("Times da BA");
ExibirTimes(timesBA);

Console.WriteLine("Times com Mundiais");
ExibirTimes(timesMundiais);



//Adicionando elementos. Obs: O método Add não adiciona elementos repetidos.
if (!timesSP.Contains("Corinthians"))
{
    Console.WriteLine("Adicionando times: \"Corinthians\" e \"Santos\"\n");
    timesSP.Add("Corinthians");
    timesSP.Add("Santos"); //Esse elemento não será adicionado pois já existe na coleção
}

//Console.WriteLine("Times de São Paulo");
//ExibirTimes(timesSP);

////Removendo elementos
//Console.WriteLine("Remover \"Juazeiro\" da coleçãod e Times da BA");
//timesBA.Remove("Juazeiro");
//ExibirTimes(timesBA);

//Subconjunto - Retorna True ou False
if (timesSP.IsSubsetOf(timesMundiais))
{
    Console.WriteLine("TimesSP é um subconjunto de timesMundiais\n");
}

//Superconjunto - Retorna True ou False
if (timesMundiais.IsSupersetOf(timesSP))
{
    Console.WriteLine("timesMundiais é um superconjunto de TimesSP\n");
}

//Elementos comuns entre as coleções - Retorna True ou False
if (timesRJ.Overlaps(timesMundiais))
{
    Console.WriteLine("Pelo menos um time do RJ tem título Mundial\n");
}

//Se contém os mesmos elementos nas coleções
if (!timesSP.SetEquals(timesRJ))
{
    Console.WriteLine("timesSP e times RJ não contém os mesmos elementos\n");
}

//Juntar as coleções em uma só
Console.WriteLine("Juntando os HashSet<T>: SP, RJ e BA\n");
//Pode-se juntar em uma coleção já existente, exemplo: colocar todos na coleção SP.
var times = new HashSet<string>();
times.UnionWith(timesRJ);
times.UnionWith(timesSP);
times.UnionWith(timesBA);

Console.WriteLine("Exibindo times RJ, SP e BA juntos:");
ExibirTimes(times);

Console.WriteLine("Juntando os times de SP, RJ e BA ordenados.\n");
var timesOrdenados = new SortedSet<string>(times);

Console.WriteLine("Exibindo times RJ, SP e BA juntos, ordenados:");
ExibirTimes(timesOrdenados);

//Interseção de duas coleções. Exibe os itens comuns aos dois.
Console.WriteLine("Interseção de dois HashSet<T>: times e timesMundiais\n");
var timesIntersecao = new HashSet<string>(timesSP);
timesIntersecao.IntersectWith(timesMundiais);
ExibirTimes(timesIntersecao);

//Diferença de duas coleções. Remove os itens iguais.
Console.WriteLine("Diferença de dois HashSet<T>: times e timesMundiais\n");
var timesDiferenca = new HashSet<string>(timesMundiais);
timesDiferenca.ExceptWith(timesSP);
ExibirTimes(timesDiferenca);

//Diferença de duas coleções, com SymmetricExceptWith. Remove os itens iguais.
Console.WriteLine("Diferença de dois HashSet<T>: times e timesMundiais com SymmetrickExceptWith\n");
var timesDiferencaSymmetric = new HashSet<string>(timesMundiais);
timesDiferencaSymmetric.SymmetricExceptWith(timesSP);
ExibirTimes(timesDiferencaSymmetric);

//Remover todos os elementos de uma coleção
Console.WriteLine("Removendo elementos de timesMundiais:\n");
var timesRemover = new HashSet<string>(timesMundiais);
timesRemover.Clear();
ExibirTimes(timesRemover);
Console.WriteLine("Fim do processamento...");






static void ExibirTimes<T>(IEnumerable<T> colecao)
{
    Console.WriteLine("\n-----------------------------\n");
    foreach (var item in colecao)
    {
        Console.WriteLine(item);
    }
    Console.WriteLine("\n-----------------------------\n");
}