
using DependancyInversionWrong;

Console.WriteLine("Dependancy Inversion Wrong");

Point Pa = new Point() { X_Coord = 2, Y_Coord = 6};
Point Pb = new Point() { X_Coord = 5, Y_Coord = 9};

Vector V = new Vector() { P1 = Pa, P2 =  Pb };

Console.WriteLine(V.Norm());