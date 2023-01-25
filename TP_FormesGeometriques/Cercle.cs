namespace TP_FormesGeometriques;

internal class Cercle : Formes
{
    public Cercle(int rayon)
    {
        Rayon = rayon;
    }

    public int Rayon { get; protected set; }



    public override double CalculArea()
    {
        return Math.PI * Rayon * Rayon;
    }

    public override double CalculPerimeter()
    {
        return 2 * Rayon * Math.PI;
    }
}

