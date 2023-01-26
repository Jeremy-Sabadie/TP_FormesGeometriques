namespace TP_FormesGeometriques
{
    internal class Segment
    {
        Point Debut;
        Point Fin;
        public Segment(Point debut, Point fin)
        {
            Debut = debut;
            Fin = fin;
        }
        public double Length()
        {
            return Debut.Distance(Fin);
        }

        public void PrintInfo()
        {
            Console.WriteLine($"le segment commence:{Debut}et se termine à:{Fin}, il mesure donc:{Length()}");
        }
    }
}



