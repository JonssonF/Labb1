namespace Labb1
{
    internal class Program
    {
        static void Main(string[] args)
        {


            Circle Circle = new Circle(5);
            Circle Circle1 = new Circle(6);

            Console.WriteLine($"Circle radius: {Circle.ShowRadius}\n" +
                $"Circle area: {Circle.GetArea}");



            Console.ReadLine();
        }
    }
}
