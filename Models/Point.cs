namespace _024_bb_the_point.Models;

public class Point
{
    public int CoordX { get; } = 0;
    public int CoordY { get; } = 0;

    public Point()
    {
        
    }

    public Point(int coordX, int coordY)
    {
        CoordX = coordX;
        CoordY = coordY;
    }
}