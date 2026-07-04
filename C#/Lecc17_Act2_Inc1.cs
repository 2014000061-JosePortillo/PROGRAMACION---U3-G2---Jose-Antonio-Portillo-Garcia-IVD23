internal class Lecc17_Act2_Inc1
{
    private static void Main(string[] args)
    {
        int numeroFila, numeroColumnas = 0;
        int[,] matrizIdentidad = new int[4, 4];

        for (numeroFila = 0; numeroFila < 4; numeroFila++)
        {
            for (numeroColumnas = 0; numeroColumnas < 4; numeroColumnas++)
            {
                if (numeroFila == numeroColumnas)
                {
                    matrizIdentidad[numeroFila, numeroColumnas] = 1;
                }
                else {
                    matrizIdentidad[numeroFila, numeroColumnas] = 0;
                }
            }
        }
        Console.WriteLine("Matriz Identidad");

        for (numeroFila = 0; numeroFila < 4; numeroFila++)
        {
            for (numeroColumnas = 0; numeroColumnas < 4; numeroColumnas++)
            {
                Console.Write(matrizIdentidad[numeroFila, numeroColumnas]+"");
            }
            Console.WriteLine("");
        }
    }
}
