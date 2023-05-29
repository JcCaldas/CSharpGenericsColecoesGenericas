Console.WriteLine("Exercício 01");


ClasseGenerica<int> lista= new ClasseGenerica<int>();

lista.Adicionar(10);
lista.Adicionar(20);
lista.Adicionar(30);
lista.Adicionar(40);
lista.Adicionar(50);

Console.WriteLine("Classe ClasseGenerica <T> de objetos\n");

for (int i = 0; i < 5; i++)
{
    Console.WriteLine(lista[i]);
}

public class ClasseGenerica <T>
{
    //definição do array com 5 elementos
    T[] lista = new T[5];
    int contador = 0;
    
    //adiciona elementos
    public void Adicionar(T obj)
    {
        if (contador <5 )
        {
            lista[contador] = obj;
        }
        contador++;
    }

    //indexador
    public T this[int index]
    {
        get { return lista[index]; }
        set { lista[index] = value;}
    }
}