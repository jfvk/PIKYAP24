using System;
using System.Collections.Generic;
namespace GEOMSH
{
 
  abstract class GS
  {
    public abstract double Area();

    public override string ToString()
    {
      return $"Area: {Area()}";
    }

    
    public virtual void Print()
    {
      Console.WriteLine(ToString());
    }
  }

    
  class Rectangle : GS
  {
    private double w;
    private double h;

    public double Width
    {
      get { return w; }
      set { w = value; }
    }

    public double Height
    {
      get { return h; }
      set { h = value; }
    }

    public Rectangle(double wid, double hei)
    {
      Width = wid;
      Height = hei;
    }

   
    public override double Area()
    {
      return Width * Height;
    }

    public override string ToString()
    {
      return $"Derzhi resultat: V shirinu = {Width}, V visotu = {Height}, {base.ToString()}";
    }
  }

  class Square : Rectangle
  {
    public Square(double side) : base(side, side)
    {
    }

    public override string ToString()
    {
      return $"Квадрат: Storona = {Width}, {base.ToString()}";
    }
  }
  class Circle : GS
  {
    private double _radius;

    public double Radius
    {
      get { return _radius; }
      set { _radius = value; }
    }

    public Circle(double radius)
    {
      Radius = radius;
    }

    public override double Area()
    {
      return Math.PI * Math.Pow(Radius, 2);
    }

    public override string ToString()
    {
      return $"Kruzhok: radius = {Radius}, {base.ToString()}";
    }
  }


  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Viberi boitsa:");
      Console.WriteLine("1. Pryamougolnik");
      Console.WriteLine("2. Quadratik");
      Console.WriteLine("3. Kruzhochek");

      int choice = int.Parse(Console.ReadLine());

      GS shape = null;

      switch (choice)
      {
        case 1:
          Console.WriteLine("vvodi shirinu:");
          double width = double.Parse(Console.ReadLine());
          Console.WriteLine("vvodi visotu ");
          double height = double.Parse(Console.ReadLine());
          shape = new Rectangle(width, height);
          break;
        case 2:
          Console.WriteLine("bahni storonu:");
          double side = double.Parse(Console.ReadLine());
          shape = new Square(side);
          break;
        case 3:
          Console.WriteLine("radius please:");
          double radius = double.Parse(Console.ReadLine());
          shape = new Circle(radius);
          break;
        default:
          Console.WriteLine("Ya ne budu schitat. Vvedi normalno");
          break;
      }

      if (shape != null)
      {
        shape.Print();
      }

      Console.ReadKey();
    }
  }
}
