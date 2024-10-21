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

        public double Sphere()
        {
            double spherevolume = (4.0 / 3.0) * _pi * Math.Pow(_Radius, 3);
                return spherevolume;
        }
        public double Circumference()
        {
            double circumference = _Radius * 2 * _pi;
            return circumference;
        }
        public double Diameter()
        {
            double diameter = _Radius * 2;
            return diameter;
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
