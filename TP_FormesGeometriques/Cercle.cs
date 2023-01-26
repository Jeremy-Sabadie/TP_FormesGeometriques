namespace TP_FormesGeometriques;

internal class Cercle : Formes
{
    public float Rayon { get; private set; }


    public Cercle(float rayon, Point origin) : base(origin)
    {
        Rayon = rayon;

    }



    public override double CalculArea()
    {
        return Math.PI * Rayon * Rayon;
    }

    public override double CalculPerimeter()
    {
        return 2 * Rayon * Math.PI;
    }
    public override string? ToString()
    {
        return $"Abcisse de l'origine: {Origin.Abcisse} ordonnée du point d'origine: {Origin.Ordonnee}";
    }
}

