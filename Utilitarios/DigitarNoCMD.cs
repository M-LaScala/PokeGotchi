namespace PokéGotchi.Utilitarios;

internal class DigitarNoCMD
{
    public static void EscreverLetraPorLetra(string texto, int delay)
    {
        foreach (char letra in texto)
        {
            Console.Write(letra);
            Thread.Sleep(delay);
        }
        Console.WriteLine(); // Pular uma linha após escrever todo o texto
    }

}
