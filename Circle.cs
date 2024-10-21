namespace Labb1
{
    internal class Circle
    {
        double _Radius;


        public Circle(double radius)
        {
            _Radius = radius;
        }


        public double ShowRadius()
        {
            return _Radius;
        }

        public double GetArea(double radius)
        {
            return radius * radius * Math.PI;
        }
    }
}
