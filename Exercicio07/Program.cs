Console.WriteLine("Exercício 07\n");

Console.WriteLine("Fila de Impressão:\n");

var filaImpressao = new Queue<string>();
filaImpressao.Enqueue("Arquivo1.txt");
filaImpressao.Enqueue("Arquivo2.doc");
filaImpressao.Enqueue("Arquivo3.pdf");
filaImpressao.Enqueue("Arquivo4.png");
filaImpressao.Enqueue("Arquivo5.jpeg");

while (filaImpressao.Count > 0)
{    
        Console.WriteLine($"O arquivo {filaImpressao.Peek()} está sendo impresso...");
        
        Thread.Sleep(new Random().Next(1000, 5000));
        
        Console.WriteLine($"O arquivo {filaImpressao.Peek()} foi impresso com sucesso!\n");
        
        filaImpressao.Dequeue();
    
}