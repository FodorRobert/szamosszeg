using System;

class Program
{
    static void szamok()
    {
        int pozitiv = 0;
        int negativ = 0;
        for (int i = 0; i < 10; i++)
        {
            Console.Write($"Kérlek, írd be a(z) {i + 1}. számot: ");
            string input = Console.ReadLine();

            if (int.TryParse(input, out int szam))
            {
                if (szam > 0)
                {
                    pozitiv += szam;
                }
                else if (szam < 0)
                {
                    negativ += szam;
                }
            }
        }
        Console.WriteLine($"A pozitív számok összege: {pozitiv}");
        Console.WriteLine($"A negatív számok összege: {negativ}");
    }
    static void Main(string[] args)
    {
        szamok();
    }
}