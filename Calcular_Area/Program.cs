// See https://aka.ms/new-console-template for more information

string figura;
double CalcularArea( double Base, double Altura)
{
    switch (figura)
    {
        case "Rectángulo":
            return Base * Altura;
        case "Triángulo":
            return Base * Altura / 2;
        case "Círculo":
            return Math.PI * Base * Base;
        default:
            throw new ArgumentException("Figura no válida.");
    }

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

double AreaCalculada = CalcularArea(Base, Altura);
Console.WriteLine($"El área del {figura} es: {AreaCalculada}");


