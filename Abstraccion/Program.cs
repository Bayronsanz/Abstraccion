using Abstraccion;

Circulo circulo = new Circulo();
Rectangulo rectangulo = new Rectangulo();

Console.WriteLine("Ingrese el radio:");
circulo.Radio = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Imgrese la base:");
rectangulo.Base = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Ingrese la altura:");
rectangulo.Altura = Convert.ToDouble(Console.ReadLine());