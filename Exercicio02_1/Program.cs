using System.Collections.Generic;

Console.WriteLine("Exercício 02_1 - Dictionary\n");

//Criação do dicionário de alunos com notas. Sendo o tipo int representação da matricula
var alunos = new Dictionary<int, Aluno>() 
{
    { 1, new Aluno("Maria", 7) },
    { 2, new Aluno("Eric", 8) },
    { 3, new Aluno("Ana", 9) },
    { 4, new Aluno("Alex", 6) },
    { 5, new Aluno("Diná", 5) }
};

//Exibir dicionário de alunos
ExibeDicionario(alunos);

//localizar e atualizar a nota de algum aluno
//Criar um menu do, while para receber via teclado as informações

var nomeBusca = "Alex";
var nota = 9;

Console.WriteLine($"Atualizando a nota do \"{nomeBusca}\" para \"{nota}\".");

foreach (var aluno in alunos)
{

    if (aluno.Value.Nome == nomeBusca)
    {
        aluno.Value.Nota = nota;
        Console.WriteLine("Nota atualizada com sucesso...\n");
        break;
    }
    else if (aluno.Key == alunos.Count())
    {
        Console.WriteLine($"Não foi encontrado o aluno \"{nomeBusca}\"\n");
    }
}

ExibeDicionario(alunos);

//Removendo um aluno do dicionário
//Criar um menu do, while para receber via teclado as informações

var nomeExcluir = "Ana";

Console.WriteLine($"Remover \"{nomeExcluir}\" da coleção");
foreach (var aluno in alunos)
{

    if (aluno.Value.Nome == nomeExcluir)
    {
        alunos.Remove(aluno.Key);
        Console.WriteLine($"O aluno {nomeExcluir} foi removido do dicionário de alunos...\n");
        break;
    }
    else if (aluno.Key == alunos.Count())
    {
        Console.WriteLine($"Não foi encontrado o aluno \"{nomeExcluir}\"\n");
    }

}

ExibeDicionario(alunos);

//Incluir nova Aluna - Vilma com nota 7
//Criar um menu do, while para receber via teclado as informações


var nomeIncluir = "Vilma";
var notaIncluir = 7;
Console.WriteLine($"Incluindo a aluna \"{nomeIncluir}\" na coleção de alunos, com a nota \"{notaIncluir}\"\n");

alunos.Add(6, new Aluno(nomeIncluir, notaIncluir));

ExibeDicionario(alunos);

//Ordenar dicionário por nome
Console.WriteLine("\nOrdenando o dicionário por nome com LINQ:");
var alunosOrdenadosLINQ = alunos.OrderBy(x => x.Value.Nome);

foreach (var aluno in alunosOrdenadosLINQ)
{
    Console.WriteLine($"Matricula: {aluno.Key}\tNome: {aluno.Value.Nome}\t Nota: {aluno.Value.Nota}");
}

//Remover os elementos do dicionário
alunos.Clear();
Console.WriteLine(alunos.GetType());

ExibeDicionario(alunos);


//Função que exibe o dicionário
static void ExibeDicionario(Dictionary<int, Aluno> alunos)
{
    Console.WriteLine("\nExibindo Dicionário de Alunos...");
    foreach (var aluno in alunos)
    {
        Console.WriteLine($"Matricula: {aluno.Key}\tNome: {aluno.Value.Nome}\t Nota: {aluno.Value.Nota}");
    }
    Console.WriteLine();
}

