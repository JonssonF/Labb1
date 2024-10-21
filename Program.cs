namespace Labb1   //Fredrik Jonsson SUT_24
{
    internal class Program
    {
        static void Main(string[] args)
        {

            var Circle = new Circle(5);
            var Circle1 = new Circle(6);



            Console.WriteLine($"Circle radius: {Circle.ShowRadius()}\n" +
                $"Circle diameter: {Circle.Diameter()}\n" +
                $"Circle area: {Circle.GetArea()}\n" +
                $"Circle circumference: {Circle.Circumference()}\n" +
                $"Spherical volume: {Circle.Sphere()}\n\n");
            
            Console.WriteLine($"Circle radius: {Circle1.ShowRadius()}\n" +
                $"Circle diameter: {Circle1.Diameter()}\n" +
                $"Circle area: {Circle1.GetArea()}\n" +
                $"Circle circumference: {Circle1.Circumference()}\n" +
                $"Spherical volume: {Circle1.Sphere()}");

            

            




            Console.ReadLine();
        }
    }
}
