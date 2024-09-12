//basicamente as pilhas trabalham com uma estrutura LIFO -> Last In First Out
//três métodos importantes:
// Push() -> insere um elemento no topo da pilha
// Pop() -> remove um elemento do topo e o retorna
// Peek() -> retorna um elemento do topo sem removê-lo

// Invertendo as bolas
Stack<char> caracteres = new Stack<char> ();
foreach(char c in "DARCY DA MONTANHA")
{
    caracteres.Push (c);
}

//desempilhando
string invertido = string.Empty;
while (caracteres.Count > 0) 
{
    invertido += caracteres.Pop ();
}

Console.WriteLine (invertido);