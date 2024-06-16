// See https://aka.ms/new-console-template for more information

static double CelsiusAFahrenheit(double celsius)
{
    return (celsius * 9 / 5) + 32;
}
static double FahrenheitACelsius(double fahrenheit)
{
    return (fahrenheit - 32) * 5 / 9;
}
static double CelsiusAKelvin(double celsius)
{
return celsius + 273.15;
}

Console.WriteLine("Convertidor de Temperatura, elije la opcion que deseas convertir:");
Console.WriteLine("1. Celsius a Fahrenheit");
Console.WriteLine("2. Fahrenheit a Celsius");
Console.WriteLine("3. Celsius a Kelvin");

int opcion = int.Parse(Console.ReadLine());

Console.Write("Ingresa la temperatura: ");
double temperatura = double.Parse(Console.ReadLine());

double resultado = 0;

switch (opcion)
{
    case 1:
        resultado = CelsiusAFahrenheit(temperatura);
        Console.WriteLine($"La temperatura en Fahrenheit es: {resultado} °F");
        break;
    case 2:
        resultado = FahrenheitACelsius(temperatura);
        Console.WriteLine($"La temperatura en Celsius es: {resultado} °C");
        break;
    case 3:
        resultado = CelsiusAKelvin(temperatura);
        Console.WriteLine($"La temperatura en Kelvin es: {resultado} K");
        break;
    default:
        Console.WriteLine("Opción inválida. Inténtalo nuevamente.");
        break;
}
