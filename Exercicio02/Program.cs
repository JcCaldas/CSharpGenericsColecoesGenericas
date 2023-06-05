Console.WriteLine("Exercício 02 - Dictionary\n");
/*Se fosse para criar uma lista limitada, poderia utilizar um dictionary onde a chave é o nome do aluno e o valor é a nota,
 porém isso só funcionaria se fosse uma lista com nomes que não fossem repetidos. Para que possa ter uma solução mais robusta
é melhor crar uma classe que receberá o nome e a nota do aluno, e o dictionary será de <int, TipoClasse>, onde int pode ser
o número da matricula, por exemplo.
Essa resolução está no arquivo de exercício 02_1*/

var alunos = new Dictionary<string, int>()
{
    {"Maria", 7 },
    {"Eric", 8 },
    {"Ana", 9 },
    {"Alex", 6 },
    {"Diná", 5 }
};

//acessando e exibindo nomes com notas
ExibirDictionary(alunos);

//localizar e atualizar a nota de Alex
Console.WriteLine("\nAtualizando a nota do Alex para 9");

if (alunos.ContainsKey("Alex")) 
{
    alunos["Alex"] = 9;
    Console.WriteLine("Nota atualizada com sucesso...\n");
}
else
{
    Console.WriteLine("Não foi encontrado o aluno \"Alex\"\n");
}

ExibirDictionary(alunos);

//Removendo Ana da coleção
Console.WriteLine("\nRemover Ana da coleção");

if (alunos.ContainsKey("Ana"))
{
    alunos.Remove("Ana");
    Console.WriteLine("Ana foi removida da coleção de alunos...\n");
}
else
{
    Console.WriteLine("Não foi encontrado a aluna \"Ana\"\n");
}

ExibirDictionary(alunos);

//Incluir nova Aluna - Vilma com nota 7
Console.WriteLine("\nIncluindo a aluna \"Vilma\" na coleção de alunos, com a nota \"7\"\n");

if (alunos.ContainsKey("Vilma"))
{
    Console.WriteLine("Já existe uma aluna chamada \"Vilma\" na coleção de alunos\n");
}
else
{
    alunos.Add("Vilma", 7);
    Console.WriteLine("\"Vilma\" foi adicionada a coleção com a nota \"7\"\n");
}

ExibirDictionary(alunos);

//Ordenar a coleção por nome
Console.WriteLine("\nOrdenando a coleção por nome,");

var alunosOrdenadosNome = new SortedDictionary<string, int>(alunos);

foreach (var aluno in alunosOrdenadosNome)
{
    Console.WriteLine($"Nome: {aluno.Key}\tNota: {aluno.Value}");
}


static void ExibirDictionary(Dictionary<string, int> alunos)
{
    foreach (var aluno in alunos)
    {
        Console.WriteLine($"Nome: {aluno.Key}\tNota: {aluno.Value}");
    }
}