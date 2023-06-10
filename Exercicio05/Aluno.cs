class Aluno
{
    public Aluno(string? nome, int idade, string? sexo)
    {
        Nome = nome;
        Idade = idade;
        Sexo = sexo;
    }

    public string? Nome { get; set; }
    public int Idade { get; set;}
    public string? Sexo { get; set; }
}