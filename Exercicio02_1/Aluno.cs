//Classe para receber os alunos com notas

public class Aluno
{
    public string? Nome { get; set; }
    public int Nota { get; set; }

    public Aluno( string nome, int nota)
    {
        Nome = nome;
        Nota = nota;
    }
}
