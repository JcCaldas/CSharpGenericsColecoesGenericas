Console.WriteLine("Exemplo de GetHashCode e Equals\n");
/*Como utilizar os métodos para verificação, sobrescrevendo
 os métodos nas classes.*/

var pessoa1 = new Pessoa(123456, "Erica");
var pessoa2 = new Pessoa(123456, "Erica");
var pessoa3 = new Pessoa(987654, "Erica");

Console.WriteLine("pessoa1 -> CPF = 123456 Nome = Erica");
Console.WriteLine("pessoa2 -> CPF = 123456 Nome = Erica");
Console.WriteLine("pessoa3 -> CPF = 987654 Nome = Erica");

Console.WriteLine("\nComparando objetos Pessoa - GetHashCode");
Console.WriteLine("pessoa1 = " + pessoa1.GetHashCode());
Console.WriteLine("pessoa2 = " + pessoa2.GetHashCode());
Console.WriteLine("pessoa3 = " + pessoa3.GetHashCode());

Console.WriteLine("\nComparando objetos Pessoa - Equals");
Console.WriteLine("pessoa1.Equals(pessoa2) = " + pessoa1.Equals(pessoa2));//False por padrão, mas retorna True quando Equals é sobrescrito
Console.WriteLine("pessoa2.Equals(pessoa3) = " + pessoa2.Equals(pessoa3));//False

public class Pessoa
{
    public int CPF { get; set; }
    public string Nome { get; set; }

    public Pessoa(int cpf, string? nome)
    {
        CPF = cpf;
        Nome = nome;
    }

    /*Ao sobrescrever o método Equals ou GetHashCode, é
     obrigatório sobrescrever o outro método.*/
    public override bool Equals(object? obj)
    {

        if (obj == null) 
            return false;

        if ((obj is not Pessoa))
            return false;

        /*Fazer um downcast, caso não retorne false.
         * Isso transforma o obj no tipo definido no cast.
         O nome da variavel "other" é um nome padrão
        utilizado*/
        
        var other  = (Pessoa)obj;
        return CPF.Equals(other.CPF);//Compara o CPF com o CPF do objeto
    }

    public override int GetHashCode()
    {
        /*Retorna o CPF como HashCode*/
        return CPF.GetHashCode();
    }
}