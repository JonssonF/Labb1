namespace Labb1   //Fredrik Jonsson SUT_24
{
    internal class Program
    {
        static void Main(string[] args)
        {

            var Circle = new Circle(5);
            var Circle1 = new Circle(6);



            Console.WriteLine($"Circle radius: {Circle.ShowRadius()}\n" +
                $"Circle area: {Circle.GetArea()}\n");

            Console.WriteLine($"Circle radius: {Circle1.ShowRadius()}\n" +
                $"Circle area: {Circle1.GetArea()}\n");

            

            Console.ReadLine();
        }
    }
}
