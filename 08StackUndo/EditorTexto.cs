namespace _08StackUndo;

internal class EditorTexto
{

    private Stack<char> undoStack = new Stack<char>();
    private string texto = "";

    public void DigitarChar (char c)
    {
        texto += c;
        undoStack.Push (c);
        Console.WriteLine($"Texto: {texto}");
    }

    public void Undo()
    {
        if(undoStack.Count > 0)
        {
            char ultimoChar = undoStack.Pop();
            texto = texto.Substring(0, texto.Length -1);
            /*Substring -> Método utilizado para extrair uma subcadeia de caracteres
            de uma string.Recebe como parâmetros o indice inicial e o tamanho da substring
            que deve extrair. Neste caso o indice inicial é 0, para que inicie no primeiro
            caractere da string, e o final é o tamanho total menos o último caractere*/
            
            Console.WriteLine($"Texto: {texto}");
        }
    }
}
