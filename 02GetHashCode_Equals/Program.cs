Console.WriteLine("GetHashCode e Equals\n");

Console.WriteLine("Equals\n");
/*Por padrão, Retorna com precisão para tipos primitivos,
 * mas caso seja uma classe, deve ser sobrescrito*/

Console.WriteLine("Tipos primitivos");

string a = "João";
string b = "João";

int x = 10;
int y = 10;

Console.WriteLine("Strings");
Console.WriteLine($"a = b: {a.Equals(b)}");
Console.WriteLine("\nInt");
Console.WriteLine($"x = y: {x.Equals(y)}");

Console.WriteLine("\nClasses");

var pessoa1 = new Pessoa(1, "Ana");
var pessoa2 = new Pessoa(1, "Ana");

Console.WriteLine($"pessoa1 = pessoa2: {pessoa1.Equals(pessoa2)}");
/*Por padrão retorna false, pois pessoa1 e pessoa2 não são
 o mesmo objeto e possuem referências diferentes*/

Console.WriteLine("GetHashCode\n");
/*Vai retornar o HashCode do object
 Somente tipos primitivos com valores iguais tem 
HashCodes iguais.*/

Console.WriteLine("HashCode da String a: " + a.GetHashCode());
Console.WriteLine("HashCode da String b: " + b.GetHashCode());
Console.WriteLine("HashCode da Int x: " + x.GetHashCode());
Console.WriteLine("HashCode da Int y: " + y.GetHashCode());
Console.WriteLine("HashCode da Classe Pessoa pessoa1: " + pessoa1.GetHashCode());
Console.WriteLine("HashCode da Classe Pessoa pessoa2: " + pessoa2.GetHashCode());
public class Pessoa
{
    public int Id { get; set; }
    public string Nome { get; set; }

    public Pessoa (int id, string? nome)
    {
        Id = id;
        Nome = nome;
    }
}