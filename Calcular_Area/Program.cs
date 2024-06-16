// See https://aka.ms/new-console-template for more information

static double CalcularArea(double Base, double Altura, string figura)
{
    double area = 0;

    switch (figura.ToLower())
    {
        case "triangulo":
        return area = (Base * Altura) / 2;

        case "rectangulo":
        return area = Base * Altura;

        case "circulo":
        return area = Math.PI * Math.Pow(Base / 2, 2);

        default:
        Console.WriteLine("Figura no válida. Inténtalo nuevamente.");
        return area;
    }

    
}

Console.WriteLine("Calculadora de areas de figuras, elije una opcion");
Console.WriteLine("1. Triangulo");
Console.WriteLine("2. Rectangulo");
Console.WriteLine("3. Circulo");

int opcion = int.Parse(Console.ReadLine());

Console.Write("Ingresa la base: ");
double Base = double.Parse(Console.ReadLine());

Console.Write("Ingresa la altura: ");
double Altura = double.Parse(Console.ReadLine());

string figura = Console.ReadLine();
double area = 0;

switch (opcion)
{
    case 1:
        CalcularArea(Base, Altura, figura);
        Console.WriteLine($"El área del {figura} es: {area}");
        break;
    case 2:
        CalcularArea(Base, Altura, figura);
        Console.WriteLine($"El área del {figura} es: {area}");
        break;
    case 3:
        CalcularArea(Base, Altura, figura);
        Console.WriteLine($"El área del {figura} es: {area}");
        break;
    default:
        Console.WriteLine("Opción inválida. Inténtalo nuevamente.");
        break;
}


