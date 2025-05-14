LinkedList<string> frutas = new LinkedList<string>();

//Agregar nodos 

frutas.AddFirst("Platano");
frutas.AddLast("Mango");
frutas.AddFirst("Pera");

//Insertar elementos en medio 

LinkedListNode<string> nodoPlatano = frutas.Find("Platano");

frutas.AddBefore(nodoPlatano, "Sandia");

//Eliminar nodos 

frutas.Remove("Mango");

LinkedListNode<string> actual = frutas.First;

while (actual != null)
{
    string anterior = actual.Previous?.Value ?? "null";
    string siguiente = actual.Next?.Value ?? "null";
    Console.WriteLine($"{anterior} <- {actual.Value} -> {siguiente}");
    actual = actual.Next;

}

