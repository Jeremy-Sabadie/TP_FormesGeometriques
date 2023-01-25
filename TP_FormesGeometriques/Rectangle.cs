namespace TP_FormesGeometriques;

internal class Rectangle : Formes
{
    public float Longueur { get; set; }
    public float Largeur { get; set; }



    public override double CalculArea()
    {
        return Longueur * Largeur;
    }
    public override double CalculPerimeter()
    {
        return (2 * Longueur) + (2 * Largeur);

    }
}
