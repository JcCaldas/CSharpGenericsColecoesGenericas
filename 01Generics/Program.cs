Console.WriteLine("## Generics ##\n");

Teste teste = new Teste();

int i1 = 10;
int i2 = 10;

teste.Comparar(i1, i2);


public class Teste
{
    public void Comparar( int p1,  int p2 )
    {
        var resultado = p1.Equals(p2);
        /*Equals é similar ao "==", porém no Equals é comparado o conteúdo eo tipo de dados, enquanto no "==" é comparado as referências do objeto.*/
        Console.WriteLine($"{p1} e {p2} são iguais? {resultado}");
    }
}