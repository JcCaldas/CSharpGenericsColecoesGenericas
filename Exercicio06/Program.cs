Console.WriteLine("Exercício 06\n");

Console.WriteLine("Minha resolução");
Console.WriteLine("Expressão matemática balanceada ou não.");

//Minha resolução
string expressao = "(1 + 2) * 3) - 4";
Console.WriteLine($"{expressao}\n");

var listaParenteses = new Stack<char>();

foreach (var item in expressao)
{
    if (item == '(' || item == '{' ||  item == '[')
    {
        listaParenteses.Push(item);
    }

    if (item == ')' || item == '}' || item == ']')
    {
        if (listaParenteses.Count == 0)
        {
            listaParenteses.Push(item);
        }

        if (listaParenteses.Count > 0)
        {
            if (listaParenteses.Peek() == '(' || listaParenteses.Peek() == '{' || listaParenteses.Peek() == '[')
            {
                listaParenteses.Pop();
            }
        }
    }
}

if (listaParenteses.Count > 0)
    Console.WriteLine("A expressão matemática NÃO contém parenteses balanceados\n");
else
    Console.WriteLine("A expressão matemática contém parenteses balanceados\n");

//Resolução do instrutor
Console.WriteLine("Resolução do instrutor");
string expression = "(1 + 2) * 3) - 4";
bool balenceada = EstaBalanceada(expression);
Console.WriteLine($"A expressão matemática {expression} {(balenceada ?
 "esta balanceada" : "não esta balanceada")}.");
Console.ReadKey();
static bool EstaBalanceada(string expression)
{
    Stack<char> stack = new Stack<char>();
    foreach (char c in expression)
    {
        if (c == '(' || c == '{' || c == '[')
        {
            stack.Push(c);
        }
        else if (c == ')' || c == '}' || c == ']')
        {
            if (stack.Count == 0)
            {
                return false;
            }
            char lastParentheses = stack.Pop();
            if ((c == ')' && lastParentheses != '(') ||
            (c == '}' && lastParentheses != '{') ||
            (c == ']' && lastParentheses != '['))
            {
                return false;
            }
        }
    }
    return stack.Count == 0;
}