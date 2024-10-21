namespace Labb1
{
    internal class Circle
    {
        public double _Radius;
        float _pi = 3.14f;

        public Circle(double radius)
        {
            _Radius = radius;
        }


        public double ShowRadius()
        {
            return _Radius;
        }

        public double GetArea()
        {
            double area = _Radius * _Radius * _pi;
            return area;
        }
    }
}
