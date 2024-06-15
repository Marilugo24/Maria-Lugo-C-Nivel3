// See https://aka.ms/new-console-template for more information

double fahrenheit;
double celsius;
double kelvin;

double CelsiusAFahrenheit(double celsius) 
{
    return fahrenheit = (9.0 / 5.0) * celsius + 32;
}

double FahrenheitACelsius(double fahrenheit) 
{
    return (5.0 / 9.0) * (fahrenheit - 32);
}

double CelsiusAKelvin(double celsius) 
{
    return celsius + 273.15;
}

Console.WriteLine("Convertidor de Temperatura, elije la opcion que deseas convertir");
Console.WriteLine("1. Celsius");
Console.WriteLine("2. Fahrenheit");
Console.WriteLine("3. Kelvin");

int opcion = Convert.ToInt32(Console.ReadLine());

switch (opcion)
{
    case 1:

        Console.WriteLine("Ingrese la temperatura en Celsius:");
        double gradoscelcius = Convert.ToDouble(Console.ReadLine());
       
        break;
    case 2:
        Console.WriteLine("Ingresa la temperatura en Fahrenheit:");
        double gradosfahrenheit = Convert.ToDouble(Console.ReadLine());
        break;
    case 3:
        Console.WriteLine("Ingrese la temperatura en celcius:");
        double gradoskelvin = Convert.ToDouble(Console.ReadLine());
        break;
    default:
        Console.WriteLine("Opción no válida.");
        break;
}

FahrenheitACelsius(fahrenheit);
Console.WriteLine($"{fahrenheit} grados Fahrenheit corresponden a {celsius} grados Celsius.");

CelsiusAKelvin(celsius);
Console.WriteLine($"{celsius} grados Celsius son {kelvin} grados Kelvin.");

CelsiusAFahrenheit(celsius);
Console.WriteLine($"{celsius} grados Celsius son {fahrenheit} grados fahrenheit.");
