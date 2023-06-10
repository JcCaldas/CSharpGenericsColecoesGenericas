Console.WriteLine("Exercício 05");
/*Escreva um programa que crie uma lista de objetos Aluno que contém as propriedades : Nome,
Idade e Sexo. A seguir defina 5 objetos do tipo Aluno e exiba uma lista de objetos alunos no console.*/

var listaAlunos = new SortedDictionary<int, Aluno>();
listaAlunos.Add(1, new Aluno("Alice", 7, "Feminino"));
listaAlunos.Add(2, new Aluno("Jessé", 39, "Masculino"));
listaAlunos.Add(3, new Aluno("Renata", 36, "Feminino"));
listaAlunos.Add(4, new Aluno("Leticia", 40, "Feminino"));
listaAlunos.Add(5, new Aluno("Anderson", 30, "Masculino"));

foreach (var item in listaAlunos)
{
    Console.WriteLine($"Nº do aluno: {item.Key}\tNome: {item.Value.Nome}\tIdade: {item.Value.Idade}\tSexo: {item.Value.Sexo}");
}