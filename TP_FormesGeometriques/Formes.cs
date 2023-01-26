namespace TP_FormesGeometriques;

internal abstract class Formes : IComparable
{

    public Point Origin { get; set; }

    protected Formes(Point origin)
    {
        Origin = origin;
    }

    public abstract double CalculPerimeter();
    public abstract double CalculArea();
    /// <summary>
    /// Méthode CompareTo qui convertit le paramètre de type objet passé en type forme
    /// </summary>
    /// <param name="obj"></param>
    /// <returns></returns>
    public int CompareTo(object? obj)
    {
        Formes formes = obj as Formes;
        if (formes is not null)//vérification de la conversion.Si l'itance formes n'est pas nul: conversion du type réussie.
        {
            return (formes.CalculArea() < CalculArea()) ? 1 : -1;
        }
        return 0;//Si le retour vaut 0 : la conversion n'est pas effectuée.
    }

}
