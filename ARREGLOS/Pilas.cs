//Creacion 

Stack<string> pila = new Stack<string>();

//Aplicar push

pila.Push("Primero");
pila.Push("Segundo");
pila.Push("Tercero");

//Desapilar Pop

string ultimo = pila.Pop();
Console.WriteLine(ultimo); //Tercero

//Desapilar peek
ultimo = pila.Pop();
Console.WriteLine(ultimo);
string superior = pila.Peek();
Console.WriteLine(superior); //Segundo
superior = pila.Peek();
Console.WriteLine(superior); //Segundo

//Pop lo saca el elemento y lo elimina de la pila
//el peek muestra el elemento inmediato sin eliminarlo 
//Primero que entra es el primero que sale 