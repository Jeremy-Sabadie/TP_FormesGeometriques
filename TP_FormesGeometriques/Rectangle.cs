namespace TP_FormesGeometriques;

internal class Rectangle : Formes
{
    public Rectangle(float longueur, float largeur, Point origin) : base(origin)
    {
        Longueur = longueur;
        Largeur = largeur;
    }

    float Longueur { get; set; }
    public float Largeur { get; set; }



    public override double CalculArea()
    {
        return Longueur * Largeur;
    }
    public override double CalculPerimeter()
    {
        return (2 * Longueur) + (2 * Largeur);

    }

    public override string? ToString()
    {
        return $"{Origin.Abcisse} {Origin.Ordonnee} largeur : {Largeur} longueur{Longueur}";
    }
}
