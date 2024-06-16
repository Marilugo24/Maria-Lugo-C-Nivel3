// See https://aka.ms/new-console-template for more information

static int ContarPalabras(string texto)
{
    string[] palabras = texto.Split();
    return palabras.Length;
}

static int ContarVocales(string texto)
{
    int contadorVocales = 0;
    foreach (char caracter in texto.ToLower())
    {
        if ("aeiou".Contains(caracter))
        {
            contadorVocales++;
        }
    }
    return contadorVocales;
}

static string InvertirTexto(string texto)
{
    char[] caracteres = texto.ToCharArray();
    Array.Reverse(caracteres);
    return new string(caracteres);
}

Console.Write("Por favor ingrese un texto: ");
string texto = Console.ReadLine();

int numeroDePalabras = ContarPalabras(texto);
Console.WriteLine($"Número de palabras en el texto: {numeroDePalabras}");

int numeroDeVocales = ContarVocales(texto);
Console.WriteLine($"Número total de vocales en el texto: {numeroDeVocales}");

string textoInvertido = InvertirTexto(texto);
Console.WriteLine($"Texto invertido: {textoInvertido}");
