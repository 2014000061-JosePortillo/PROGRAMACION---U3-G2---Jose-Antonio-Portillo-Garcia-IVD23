internal class Lecc17_Act2_Inc2
{
    private static void Main(string[] args)
    {
        int numeroFila;
        int numeroColumna;
        int[,] matrizColumnas = new int[4,4];

        for (numeroFila = 0; numeroFila < 4; numeroFila++)
        {
            for (numeroColumna = 0; numeroColumna < 4; numeroColumna++)
            {
                matrizColumnas[numeroFila, numeroColumna] = numeroColumna + 1;
            }
        }

        Console.WriteLine("Matriz de Columnas");
        for(numeroFila = 0; numeroFila < 4; numeroFila++)
        {
            for (numeroColumna = 0; numeroColumna < 4; numeroColumna++)
            {
                Console.Write(matrizColumnas[numeroFila, numeroColumna] + " ");
            }
            Console.WriteLine();
        }
        Console.ReadKey();
    }
}