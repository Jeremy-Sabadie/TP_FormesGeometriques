namespace TP_FormesGeometriques
{
    internal class Point
    {
        private int Abcisse { get; set; }
        private int Ordonnee { get; set; }

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

    }
}
