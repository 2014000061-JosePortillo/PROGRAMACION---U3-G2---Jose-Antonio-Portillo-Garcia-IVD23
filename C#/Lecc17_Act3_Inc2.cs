internal class Lecc17_Act3_Inc2
{
    private static void Main(string[] args)
    {
        int fila, columna, x, y, mayor= 0;
        int[,] tabla = new int[4, 4];
        
        Console.WriteLine("Ingrese los numeros: ");
        for (fila = 0; fila < 4; fila++)
        {
            for (columna = 0; columna < 4; columna++)
            {
                tabla[fila, columna] = int.Parse(Console.ReadLine());
            }
        }
        mayor = tabla[1, 1];
        x = 1;
        y = 1;

        for (fila = 0; fila < 4; fila++)
        {
            for (columna = 0; columna < 4; columna++)
            {
                if (tabla[fila, columna]> mayor ){
                    mayor = tabla[fila, columna];
                    x = fila;
                    y = columna;
                }
            }
        }
        Console.WriteLine("El numero mayor es: "+mayor);
        Console.WriteLine("Esta en la fila: " + x);
        Console.WriteLine("Y en la columna: " + y);
    }
}