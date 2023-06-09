Console.WriteLine("Stack<T> \n");

//inicializando coleção Stack:

int[] array1 = new int[] {1, 2, 3 };
Stack<int> pilha1 = new Stack<int>(array1);//criação a partir de um IEnumerable

var impares = new Stack<int>(3); //inicializa com 3 posições
impares.Push(5);

Stack<int> numeros = new Stack<int>(); //{1, 2, 3} -> não suporta inicializador
numeros.Push(10);
numeros.Push(20);
numeros.Push(30);
numeros.Push(10);//Pode ter elementos duplicados
//numeros[1]; -> não suporta indexadores, para acessar é via foreach
Exibir(numeros);

//Count ->exibe a quantidade de itens da pilha
Console.WriteLine($"A pilha numeros comtém, inicialmente, {numeros.Count} itens\n");

//Peek -> retorna sem remover
Console.WriteLine($"Item obtido da pilha (Peek): {numeros.Peek()}\n");

//Pop -> remove item da pilha
Console.WriteLine($"Item removido da pilha (Pop): {numeros.Pop()}\n");

Console.WriteLine($"A pilha numeros comtém, agora, {numeros.Count} itens\n");
Exibir(numeros);

if(numeros.Contains(20))//Retorna true ou false
    Console.WriteLine("O número 20 está na pilha!\n");
else
    Console.WriteLine("O número 20 nãoe stá na pilha!\n");

Console.WriteLine("Copia da pilha usando ToArray");
var copia = new Stack<int>(numeros.ToArray());
Exibir(copia);

Console.WriteLine("Removendo todos os itens da pilha\n");
numeros.Clear();
Console.WriteLine($"{numeros.Count} itens na pilha numeros");

static void Exibir<T>(IEnumerable<T> colecao)
{
    Console.WriteLine("\n---------------\n");
    Console.WriteLine("Exibindo coleção");
    foreach (var item in colecao)
    {
        if (item == null)
            Console.WriteLine("Null");
        else
            Console.WriteLine(item);
    }
    Console.WriteLine("\n---------------\n");
}