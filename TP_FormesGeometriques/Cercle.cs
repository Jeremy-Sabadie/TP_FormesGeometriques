namespace TP_FormesGeometriques;

internal class Cercle : Formes
{
    private float Rayon { get; set; }
    private Point Center { get; set; }


    public Cercle(float rayon, Point center)
    {
        Rayon = rayon;
        Center = center;
    }



    public override double CalculArea()
    {
        return Math.PI * Rayon * Rayon;
    }

    public override double CalculPerimeter()
    {
        return 2 * Rayon * Math.PI;
    }
}

