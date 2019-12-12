using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Armas
{
    public string nombre;
    public int daño;
    public int municion;
    public int ExtraPorExplosion;

    //Armas punzocortantes.
    public Armas(string n, int d)
    {
        this.nombre = n;
        this.daño = d;
    }

    //Armas de fuego.
    public Armas(string n, int d, int m)
    {
        this.nombre = n;
        this.daño = d;
        this.municion = m;
    }
}
