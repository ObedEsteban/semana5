using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Ingrese el radio del círculo:");
        string inputRadio = Console.ReadLine();
        double radio = Convert.ToDouble(inputRadio);

        double area = Math.PI * Math.Pow(radio, 2);
        Console.WriteLine("El área del círculo es: " + area);
    }
}





//using System;

//public class Program
//{
//    public static void Main()
//    {
//        Console.Write("Ingresa el ancho del rectángulo: ");
//        double ancho = double.Parse(Console.ReadLine());

//        Console.Write("Ingresa la altura del rectángulo: ");
//        double altura = double.Parse(Console.ReadLine());

//        double perimetro = CalcularPerimetroRectangulo(ancho, altura);

//        Console.WriteLine($"El perimetro es : {perimetro}");
//    }

//    public static double CalcularPerimetroRectangulo(double ancho, double altura)
//    {
//        double perimetro = 2 * (ancho + altura);
//        return perimetro;
//    }
//}




//using System;

//public class Program


//{
//    static void Main()
//    {

//        Console.Write("Ingrese la cantidad de números que desea promediar: ");
//        int cantidadNumeros = int.Parse(Console.ReadLine());


//        double[] numeros = new double[cantidadNumeros];


//        for (int i = 0; i < cantidadNumeros; i++)
//        {
//            Console.Write($"Ingrese el número {i + 1}: ");
//            numeros[i] = double.Parse(Console.ReadLine());
//        }


//        double promedio = 0;
//        foreach (double numero in numeros)
//        {
//            promedio += numero;
//        }
//        promedio /= cantidadNumeros;

//        Console.WriteLine($"El promedio de los números ingresados es igual a : {promedio}");
//    }
//}





//using System;

//public class Program
//{
//    public static void Main()
//    {

//        Console.Write("Ingrese un número entero: ");
//        int numero = int.Parse(Console.ReadLine());


//        if (numero % 2 == 0)
//        {
//            Console.WriteLine($"{numero} es un número par.");
//        }
//        else
//        {
//            Console.WriteLine($"{numero} es un número impar.");
//        }
//    }
//}






//using System;

//class Program
//{
//    static void Main()
//    {
//        Console.WriteLine("Ingrese una cadena de texto:");
//        string cadena = Console.ReadLine();

//        string mayusculas = cadena.ToUpper();
//        Console.WriteLine("En mayusculas es : " + mayusculas);
//        Console.ReadLine();
//    }
//}






//using System;

//class Program
//{
//    static void Main(string[] args)
//    {
//        double x1, y1, x2, y2;

//        Console.Write("Ingrese la coordenada x del primer punto: ");
//        x1 = double.Parse(Console.ReadLine());
//        Console.Write("Ingrese la coordenada y del primer punto: ");
//        y1 = double.Parse(Console.ReadLine());
//        Console.Write("Ingrese la coordenada x del segundo punto: ");
//        x2 = double.Parse(Console.ReadLine());
//        Console.Write("Ingrese la coordenada y del segundo punto: ");
//        y2 = double.Parse(Console.ReadLine());

//        double distancia = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
//        Console.WriteLine("La distancia entre los dos puntos es: " + distancia);
//    }
//}



//using System;

//class Program
//{
//    static void Main(string[] args)
//    {
//        int sum = 0;
//        string userInput;

//        Console.WriteLine("Ingrese los numero que desea sumar (presione enter para terminar).");

//        while (!string.IsNullOrEmpty(userInput = Console.ReadLine()))
//        {
//            if (int.TryParse(userInput, out int num))
//            {
//                sum += num;
//            }
//            else
//            {
//                Console.WriteLine("El valor ingresado no es un número entero válido. Inténtelo de nuevo.");
//            }
//        }

//        Console.WriteLine($"La suma de los números ingresados es: {sum}");
//        Console.ReadKey();
//    }
//}




//using System;

//class Program
//{
//    static void Main(string[] args)
//    {

//        Console.WriteLine("Por favor, ingrese un número entero para calcular su factorial.");
//        Console.Write("Número: ");
//        int num = int.Parse(Console.ReadLine());
//        int fact = 1;
//        for (int i = 2; i <= num; i++)
//        {
//            fact *= i;
//        }
//        Console.WriteLine($"El factorial de {num} es {fact}");
//        Console.ReadKey();
//    }
//}