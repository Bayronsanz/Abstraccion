
namespace Abstraccion
{
    public abstract class Figura{
        public abstract double Area();
        public abstract double Perimetro();
        public void Imprimir(){
            Console.WriteLine($"Area: {Area()}");
            Console.WriteLine($"Perimetro: {Perimetro()}");
        }
    }
}
