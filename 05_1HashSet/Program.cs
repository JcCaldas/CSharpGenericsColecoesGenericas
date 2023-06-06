Console.WriteLine("HashSet\n");

var timesSP = new HashSet<string>() { "Santos", "Palmeiras", "São Paulo" };

var timesRJ = new HashSet<string>() { "Vasco", "Flamengo", "Fluminense" };

var timesBA = new HashSet<string>() { "Bahia", "Vitória", "Juazeiro" };

var timesMundiais = new HashSet<string>() { "Santos", "Palmeiras", "São Paulo", "Flamengo" };

//Adicionando elementos. Obs: O método Add não adiciona elementos repetidos.
if (!timesSP.Contains("Corinthians"))
{
    timesSP.Add("Corinthians");
    timesSP.Add("Santos"); //Esse elemento não será adicionado pois já existe na coleção
}

foreach (var times in timesSP)
{
    Console.WriteLine(times);
}