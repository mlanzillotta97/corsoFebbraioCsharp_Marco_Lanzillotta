using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Quale forma vuoi disegnare?");
        Console.WriteLine("circle - square");
        Console.Write("Scelta: ");

        string tipo = Console.ReadLine();

        ShapeCreator creator = new ConcreteShapeCreator();
        IShape shape = creator.CreateShape(tipo);

        if (shape != null)
        {
            shape.Draw();
        }
    }
}