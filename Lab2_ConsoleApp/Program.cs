using System.Numerics;


List<Shape> listOfShapes = new List<Shape>();
List<Shape3D> listOfShapes3D = new List<Shape3D>();
List<int> listOfCounters = new List<int>();
float areaOfShapes = 0;
float triangleCircum = 0;
float biggestVolume = 0;
string shapeString = "";


for (int i = 0; i < 20; i++)
{

    listOfShapes.Add(Shape.GenerateShape());

}


WriteOutShapes(listOfShapes);
ShapeCounterAndMisc(listOfShapes);
Shape3DVolume(listOfShapes);
Console.WriteLine();
Console.WriteLine();
Console.WriteLine($"Avarege area of all shapes (rounded to two decimal places) is: {areaOfShapes / listOfShapes.Count:f2}");
Console.WriteLine($"The total perimeter, (circumference, rounded to two decimal places), of all triangles in the list is: {triangleCircum:f2}");
Console.WriteLine($"The 3D shape with the most volume has a volume of {biggestVolume}");
Console.WriteLine(MostAppearedShape());



string MostAppearedShape()
{
    int mostShapes = listOfCounters.Max();
    int positionMax = listOfCounters.IndexOf(mostShapes);

    if (positionMax == 0)
    {
        shapeString = "Rectangle";
    }
    else if (positionMax == 1)
    {
        shapeString = "Square";
    }
    else if (positionMax == 2)
    {
        shapeString = "Circle";
    }
    else if (positionMax == 3)
    {
        shapeString = "Sphere";
    }
    else if (positionMax == 4)
    {
        shapeString = "Triangle";
    }
    else if (positionMax == 5)
    {
        shapeString = "Cuboid";
    }
    else if (positionMax == 6)
    {
        shapeString = "Cube";
    }
    return $"The shape that appears the most in our list is the {shapeString}, it appeared {mostShapes} times!";



}

void WriteOutShapes(List<Shape> aListOfShapes)
{
  

    foreach (Shape shape in listOfShapes)
    {
        Console.WriteLine(shape);
        
        areaOfShapes += shape.Area;

    }


}

void Shape3DVolume (List<Shape> listOfshapes)
{
    var filteredArray = listOfshapes.OfType<Shape3D>().ToArray();
    
    foreach (Shape3D shape3D in filteredArray)
    {
        if (shape3D.Volume > biggestVolume)
        biggestVolume = shape3D.Volume;
       
    }
    
}

void ShapeCounterAndMisc(List<Shape> aListOfShapes)
{
    int rectangleCounter = 0;
    int squareCounter = 0;
    int circleleCounter = 0;
    int sphereleCounter = 0;
    int triangleleCounter = 0;
    int cuboidCounter = 0;
    int cubeCounter = 0;

    foreach (Shape shape in listOfShapes)
    {
       

        if (shape is Circle)
        {

            circleleCounter++;
        }
        else if (shape is Triangle triangle)
        {
            triangleCircum += triangle.Circumference;
            triangleleCounter++;
        }
        else if (shape is Sphere)
        {

            sphereleCounter++;
        }
        else if (shape is Rectangle rectangle)
        {
            if (rectangle.Square)
            {
                squareCounter++;
            }
            else
            {
                rectangleCounter ++;
            }

        }
        else if (shape is Cuboid cuboid)
        {
            if (cuboid.Cube)
            {
                cubeCounter++;
            }
            else
            {
                cuboidCounter++;

            }

        }


    }
    listOfCounters.Add(rectangleCounter);
    listOfCounters.Add(squareCounter);
    listOfCounters.Add(circleleCounter);
    listOfCounters.Add(sphereleCounter);
    listOfCounters.Add(triangleleCounter);
    listOfCounters.Add(cuboidCounter);
    listOfCounters.Add(cubeCounter);
}

