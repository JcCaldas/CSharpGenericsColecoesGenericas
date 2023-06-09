Console.WriteLine("Exercício 03 - Queue - Simulando loja virtual\n");

//criandoa fila de pedidos
var filaPedidos = new Queue<Pedido>();

//adicionando pedidos na fila
filaPedidos.Enqueue(new Pedido(101, 10.0));
filaPedidos.Enqueue(new Pedido(201, 20.0));
filaPedidos.Enqueue(new Pedido(301, 30.0));

//exibir o número de pedidos na fila
Console.WriteLine($"Número de pedidos na fila: {filaPedidos.Count}\n");

//processar os pedidos da fila
while (filaPedidos.Count > 0)
{
    //retirar o próximo pedido da fila
    Pedido proximoPedido = filaPedidos.Dequeue();

    Console.WriteLine($"Processando pedido {proximoPedido.Numero}, " +
        $"Valor {proximoPedido.Valor.ToString("c")}");
}

//adicionando mais pedidos na fila
filaPedidos.Enqueue(new Pedido(401, 40.0));
filaPedidos.Enqueue(new Pedido(501, 50.0));
filaPedidos.Enqueue(new Pedido(601, 60.0));

//localizar um pedido na fila
int numeroPedido = 501;
Pedido? pedidoLocalizado = filaPedidos.FirstOrDefault(p => p.Numero == numeroPedido);//LINQ

if (pedidoLocalizado != null)
    Console.WriteLine($"Pedido {numeroPedido} localizdo na fila, " +
        $"Valor: {pedidoLocalizado.Valor.ToString("c")}");
else
    Console.WriteLine($"Pedido {numeroPedido} não encontrado na fila");

class Pedido
{
    public Pedido(int numero, double valor)
    {
        Numero = numero;
        Valor = valor;
    }

    public int Numero { get; set; }
    public double Valor { get; set; }
}