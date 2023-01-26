namespace TP_FormesGeometriques
{
    internal class Point
    {
        public int Abcisse { get; private set; }
        public int Ordonnee { get; private set; }

        public Point(int abcisse, int ordonnee)
        {
            Abcisse = abcisse;
            Ordonnee = ordonnee;

        }
        public void pointPrint()
        {
            Console.WriteLine($"coordonnées:{Abcisse};{Ordonnee}");
        }
        /// <summary>
        /// Calcul de la distance entre deux points.
        /// </summary>
        /// <param name="objt"></param>
        /// <returns></returns>
        public virtual double Distance(Point p2)
        {
            return Math.Sqrt(Math.Pow(Abcisse - p2.Abcisse, 2) + Math.Pow(Ordonnee - p2.Ordonnee, 2));

        }

        public override string? ToString()
        {
            return $"abcisse du point:{Abcisse};ordonnée:{Ordonnee}";
        }
    }
}
