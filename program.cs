using System;

class Program
{
    static void Main()
    {
        Console.Write("Digite um número para ver a tabuada: ");
        int numero = int.Parse(Console.ReadLine());

        Console.WriteLine($"\nTabuada do número: {numero}\n");

        for (int i = 0; i <= 10; i++)
        {
            Console.WriteLine($"{numero} x {i} = {numero * i}");
        }
    }
}
