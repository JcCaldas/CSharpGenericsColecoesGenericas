Console.WriteLine("Queue<T>\n");

//Inicializando um Queue
Queue<string> diaSemana =  new Queue<string>();//{"segunda"} -> não suporta inicializador

//Adicionando elemento
diaSemana.Enqueue("segunda");
diaSemana.Enqueue("terça");
diaSemana.Enqueue("quarta");

//inicializando através de IEnumerable
int[] array1 = new int[] { 1, 2, 3, 4, 5 };
var numeros = new Queue<int>(array1);

var impares = new Queue<int>(3);//indica a capacidade inicial
impares.Enqueue(1);

//Métodos do Queue
string[] cursos = { "C#", "Phyton", "Java", "SQL", "ASP.NET"};
var fila1 = new Queue<string>(cursos);

Console.WriteLine($"Número de elementos na fila1: {fila1.Count}");

Exibir(fila1);

Console.WriteLine("Adicionando item na fila Enqueue (última posição)");
fila1.Enqueue(".NET MAUI");
Exibir(fila1);

Console.WriteLine("Obtem o primeiro elemento da fila com Peek (não remove)");
var elemento = fila1.Peek();
Console.WriteLine(elemento);

Console.WriteLine("Removendo item da fila Dequeue (primeira posição)");
fila1.Dequeue();
Exibir(fila1);

if (fila1.Contains("C#"))
    Console.WriteLine("C# está na fila\n");
else
    Console.WriteLine("C# não está na fila\n");

Console.WriteLine("Limpar fila com Clear");
fila1.Clear();
Console.WriteLine($"Número de elementos na fila1: {fila1.Count}");



static void Exibir<T>(IEnumerable<T> fila)
{
    Console.WriteLine("\n-------------\n");
    foreach (var item in fila)
    {
        Console.WriteLine(item);
    }
    Console.WriteLine("\n-------------\n");
}
