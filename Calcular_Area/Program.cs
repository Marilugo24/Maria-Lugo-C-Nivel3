// See https://aka.ms/new-console-template for more information

 static double CalcularArea(double Base, double Altura, string figura)
{
double area = 0;

switch (figura.ToLower())
{
    case "triangulo":
    area = (Base * Altura) / 2;
    break;

    case "rectangulo":
    area = Base * Altura;
    break;
    
    case "circulo":
    area = Math.PI * Math.Pow(Base / 2, 2);
    break;
    
    default:
    Console.WriteLine("Figura no válida. Inténtalo nuevamente.");
    break;
}
    
    return area;
}

Console.WriteLine("Calculadora de areas de figuras, elije una opcion");
Console.WriteLine("1. Triangulo");
Console.WriteLine("2. Rectangulo");
Console.WriteLine("3. Circulo");

int opcion = Convert.ToInt32(Console.ReadLine());

switch (opcion)
{
    case 1:

        Console.WriteLine("Ingrese la base y la altura del triangulo:");
        double BaseTriangulo = Convert.ToDouble(Console.ReadLine());
        double AlturaTriangulo = Convert.ToDouble(Console.ReadLine());
        break;
    case 2:
        Console.WriteLine("Ingresa la base y la altura del rectángulo:");
        double BaseRectangulo = Convert.ToDouble(Console.ReadLine());
        double AlturaRectangulo = Convert.ToDouble(Console.ReadLine());
        break;
    case 3:
        Console.WriteLine("Ingresa el radio del círculo:");
        double RadioCirculo = Convert.ToDouble(Console.ReadLine());
        break;
    default:
        Console.WriteLine("Opción no válida.");
        break;
}

double Base = double.Parse(Console.ReadLine());
double Altura = double.Parse(Console.ReadLine());
string figura = Console.ReadLine();



double areaCalculada = CalcularArea(Base, Altura, figura);
Console.WriteLine($"El área del {figura} es: {areaCalculada}");


