namespace homework1.oop2and3;

public interface IShape
{
    public double Perimeter();
    public double Area();
}
// in case of interface everything would be the same we would just have written class : IShape
// and methods Perimeter and Area doesn't need keyword override anymore.
// and we would create Array of IShapes[] shapes = {shape1,shape2,shape3}