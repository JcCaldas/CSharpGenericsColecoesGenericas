Console.WriteLine("Exercício 04\n");

Console.WriteLine("Insira o primeiro número:");
int n1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Insira o segundo número:");
int n2 = Convert.ToInt32(Console.ReadLine());

var numeros = new Numero<int>();
var resultado = numeros.Adiciona(n1, n2);

Console.WriteLine($"{n1} + {n2} = {resultado}");

class Numero<T> where T : struct, IComparable, IConvertible,
IFormattable
{
    public T Adiciona(T num1, T num2)
    {
        dynamic dynamicNum1 = num1;
        dynamic dynamicNum2 = num2;
        return dynamicNum1 + dynamicNum2;
    }

}