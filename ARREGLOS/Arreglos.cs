//declaracion
//int[] numeros = int[5];

string[] names = { "Hola", "Adios", "Mundo" };

//Matriz arragle de 2D

int[,] matriz2d = new int[2, 2];
int[,] matriz2d2 = new int[3, 2] { { 1, 2 }, { 4, 5 }, { 7, 8 } };

//int[,,] matriz2d3 = { {1, 2, 3}, {4,5,6} {7,8,9} };

//acceso a los elementos
int valor = matriz2d2[2, 1];

Console.WriteLine(valor);//8

//Arreglo de arreglos jagged Array 

int[][] jaggedArray = new int[3][];

//poblando 
jaggedArray[0] = new int[] { 1, 2 };
jaggedArray[1] = new int[] { 3, 4, 5 };
jaggedArray[2] = new int[] { 6 };

//Recorrecorrer el arreglo con doble for
for (int i = 0; i < jaggedArray.Length; i++)
{
    Console.Write("Fila " + i + " : ");
    for (int j = 0; j < jaggedArray[i].Length; j++)
    {
        Console.Write(jaggedArray[i][j] + " ");
    }
    Console.WriteLine();
}
//lista dinamica el aareglo n