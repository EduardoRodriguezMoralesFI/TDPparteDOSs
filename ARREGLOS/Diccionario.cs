//Diccionario lista enlazada

Dictionary<string, int> edades = new Dictionary<string, int>();

//Agregar elementos

edades.Add("Ana", 25);
edades.Add("Juan", 30);

edades["Maria"] = 28;

//Acceso

int edadAna = edades["Ana"];

//Modificar

edades["Juan"] = 31;

if (edades.ContainsKey("Ana"))
{
    Console.WriteLine("Ana existe ene este diccionario");
}

if (edades.TryGetValue("Pedro", out int edadPedro))
{
    Console.WriteLine($"Si existe pedro con la edad: {edadPedro}");
}
else
{
    Console.WriteLine("Pedro no esta registrado");
}

//Recorrer la memoria no es contigua, ocpan difrente espacio de memoria 

foreach (KeyValuePair<string, int> parDiccionario in edades)
{
    Console.WriteLine($"{parDiccionario.Key} : {parDiccionario.Value}");
}

