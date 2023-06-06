Console.WriteLine("HashSet\n");

//criação coleção hashset com itens
var numeros = new HashSet<int>() { 1,2,3,4,5 }; //cria um hashset de int

var frutas = new HashSet<string>() { "uva", "banana", "pera" }; //cria um hashset de strings

HashSet<int> pares = new HashSet<int>(); //cria um hashset vazio para ser preenchido

//preenchimento do hashset pares
for (int i = 0; i < 6; i++)
{
    pares.Add(i * 2);
}

//contrutor usando IEnumerable - qualquer coleção que exista e implementa IEnumerable pode ser utilizada no construtor
var lista1 = new List<int>() { 1, 2, 3, 4, 5, 6, 7};
var conjunto = new HashSet<int>(lista1);

var lista2 = new List<string>() { "uva", "banana", "pera" };
HashSet<string> minhasFrutas = new HashSet<string>(lista2);

var impares = new int[] { 1, 3, 5, 7, 9, 11, 13 };
HashSet<int> meuHashset = new HashSet<int>(impares);