// The Point
// :: Object Tests ::
// :: Boss Battle 1/5 ::

using _024_bb_the_point.Models;

// Set app title and clear screen
Console.Title = "The Point";
Console.Clear();

// Generate instances of the Point class
Point firstPoint = new Point(2, 3); // Pre-defined values
Point secondPoint = new Point(); // Blank constructor

// Display contents of instanced Point classes
Console.WriteLine($"({firstPoint.CoordX}, {firstPoint.CoordY})");
Console.WriteLine($"({secondPoint.CoordX}, {secondPoint.CoordY})");