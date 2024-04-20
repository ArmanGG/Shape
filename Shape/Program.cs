using static System.Console;

var triangle = new Triangle(7, 4, 9);
var circle = new Circle(4);
var square = new Square(6);

WriteLine("Area of Triangle: " + triangle.Area);
WriteLine("Area of Circle: " + circle.Area);
WriteLine("Area of Square: " + square.Area);

Start();

void Start()
{
    while (true)
    {
        WriteLine("Insert Side");
        string a = Console.ReadLine();
        WriteLine("Insert Count");
        string b = Console.ReadLine();
        if (double.TryParse(a, out double a1) && double.TryParse(b, out double b1))
        {

            var polygon = new RegularPolygon(a1, b1);
            WriteLine("Area of Polygon: " + polygon.Area);
            WriteLine("Perimeter of Polygon: " + polygon.Perimeter);
            break;

        }
        else WriteLine("Wrong Side or Count");

    }
}
public class Shape
{


}

public class Triangle : Shape
{
    private double Side1 { get; set; }
    private double Side2 { get; set; }
    private double Side3 { get; set; }

    public Triangle(double side1, double side2, double side3)
    {
        if (side1 + side2 > side3 && side1 + side3 > side2 && side2 + side3 > side1)
        {
            Side1 = side1;
            Side2 = side2;
            Side3 = side3;
        }
        else WriteLine("Wrong sides");
    }

    public double Area
    {
        get
        {
            double p = (Side1 + Side2 + Side3) / 2;//kisaparagic 
            return Math.Sqrt(p * (p - Side1) * (p - Side2) * (p - Side3));//Heroni banadzev
        }
    }
}

public class Circle : Shape
{
    private double Radius { get; set; }

    public Circle(double radius)
    {
        Radius = radius;
    }

    public double Area
    {
        get { return Math.PI * Radius * Radius; }
    }
}

public class Square : Shape
{
    private double SideLength { get; set; }

    public Square(double sideLength)
    {
        SideLength = sideLength;
    }

    public double Area
    {
        get { return SideLength * SideLength; }
    }
}
public class RegularPolygon : Shape
{
    private double Side { get; set; }
    private double Count { get; set; }

    public RegularPolygon(double side, double count)
    {
        Side = side;
        Count = count;
    }
    public double Area
    {

        get
        {
            double x = Math.PI / Count;
            double ctg = 1 / Math.Tan(x);
            return Count / 4 * Side * Side * ctg;

        }
    }
    public double Perimeter
    {
        get
        {
            return Count * Side;
        }
    }

}

