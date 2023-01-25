namespace TP_FormesGeometriques;

internal abstract class Formes
{
    public float OriginAbssice { get; protected set; }
    public float OriginOrdonnee { get; protected set; }

    public abstract double CalculPerimeter();
    public abstract double CalculArea();
}
