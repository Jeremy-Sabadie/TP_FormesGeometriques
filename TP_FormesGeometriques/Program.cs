
using TP_FormesGeometriques;
Console.WriteLine("*********************SEGMENT****************");
Point A = new Point(1, 3);
Point B = new Point(2, 3);
Segment S1 = new Segment(A, B);
Segment S2 = new Segment(B, A);
Console.WriteLine($"Longueur du segment S1= {S1.Length()}mm.");
Console.WriteLine($"Longueur du du segment S2= {S2.Length()}mm.");
Console.WriteLine("*********************CERCLE****************");
Cercle c1 = new Cercle(5, A);
Console.WriteLine($"Périmètre du cercle C1 = {c1.CalculPerimeter()}mm.");
Console.WriteLine($"Aire du cercle c1 = {c1.CalculArea()}mm");
Console.WriteLine("*********************RECTANGLE****************");
Rectangle R1 = new Rectangle(13.5f, 12.5f);
Console.WriteLine($"Périmètre du rectangle R1 = {R1.CalculPerimeter()}mm.");
Console.WriteLine($"Aire du rectangle R1 = {R1.CalculArea()}");