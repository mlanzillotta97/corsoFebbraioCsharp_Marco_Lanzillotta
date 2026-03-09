using System;

public class ConcreteShapeCreator : ShapeCreator
{
    public override IShape CreateShape(string type)
    {
        if (type.ToLower() == "circle")
            return new Circle();

        if (type.ToLower() == "square")
            return new Square();

        Console.WriteLine("Tipo di forma non valido");
        return null;
    }
}