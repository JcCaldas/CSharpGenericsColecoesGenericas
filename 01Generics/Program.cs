Console.WriteLine("## Generics - Exemplo de uso##\n");

int i1 = 10;
int i2 = 10;

float f1 = 10;
float f2 = 10;

string s1 = "10";
string s2 = "10";

Console.WriteLine("Sem Generics");
Teste teste = new Teste();

teste.Comparar(i1, i2);
teste.Comparar(f1, f2);
teste.Comparar(s1, s2);

Console.WriteLine("\nCom Generics");
Teste2 teste2 = new Teste2();

teste2.Comparar(i1, i2);
teste2.Comparar(f1, f2);
teste2.Comparar(s1, s2);

//Inclusive pode-se comparar tpos diferentes.
Console.WriteLine("\nCom Generics e tipos diferentes");
teste2.CompararTiposDiferentes(i1, s2);
teste2.CompararTiposDiferentes(f1, s1);
teste2.CompararTiposDiferentes(i1, f2);

Console.WriteLine("\nClasse Genérica\n");

Teste3<int, int> teste3 = new Teste3<int, int>();
teste3.Comparar(i1, i2);//Só pode ser comparado int, pois foi o tipo definido na classe

Teste3<float, float> teste4 = new Teste3<float, float>();
teste4.Comparar(f1, f2);

Teste3<string, string> teste5 = new Teste3<string, string>();
teste5.Comparar(s1, s2);

public class Teste
{
    /*Sem usar generics, toda vez que fosse comparar um tipo diferente teria que repetir o código*/
    public void Comparar( int p1,  int p2 )
    {
        var resultado = p1.Equals(p2);
        /*Equals é similar ao "==", porém no Equals é comparado o conteúdo eo tipo de dados,
         * enquanto no "==" é comparado as referências do objeto.*/
        Console.WriteLine($"{p1} e {p2} são iguais? {resultado}");
    }
    public void Comparar(float p1, float p2)
    {
        var resultado = p1.Equals(p2);
        Console.WriteLine($"{p1} e {p2} são iguais? {resultado}");
    }

    public void Comparar(string p1, string p2)
    {
        var resultado = p1.Equals(p2);
        Console.WriteLine($"{p1} e {p2} são iguais? {resultado}");
    }
}

public class Teste2
{
    /*Utilizando o generics, é definido um nome para o tipo e ele poderá ser utilizado por qualquer tipo*/
    public void Comparar <T> (T p1, T p2) //Pode ser utilizado qualquer nome no tipo, não somente a letra "T".
    {
        Console.WriteLine($"Os tipos: {p1.GetType()} e {p2.GetType()}\n");
        var resultado = p1.Equals(p2);
        Console.WriteLine($"{p1} e {p2} são iguais? {resultado}");
    }

    public void CompararTiposDiferentes<T1, T2>(T1 p1, T2 p2)
    {
        Console.WriteLine($"Os tipos: {p1.GetType()} e {p2.GetType()}\n");
        var resultado = p1.Equals(p2);
        Console.WriteLine($"{p1} e {p2} são iguais? {resultado}");
    }
}

/*Ao definir a classe como genérica, na criação do objeto da classe deve-se informar o tipo que o objeto da classe pode receber*/
public class Teste3 <T1, T2>
{
    public void Comparar(T1 p1, T2 p2)
    {
        Console.WriteLine($"Os tipos: {p1.GetType()} e {p2.GetType()}\n");
        var resultado = p1.Equals(p2);
        Console.WriteLine($"{p1} e {p2} são iguais? {resultado}");
    }
}

public class Teste4<T1, T2> where T1 : struct where T2 : struct //com esse excessão, só aceita tipos por valor, por referência é negado. Se tentar uma comparação de string não funcionará
{
    public void Comparar(T1 p1, T2 p2)
    {
        Console.WriteLine($"Os tipos: {p1.GetType()} e {p2.GetType()}\n");
        var resultado = p1.Equals(p2);
        Console.WriteLine($"{p1} e {p2} são iguais? {resultado}");
    }
}