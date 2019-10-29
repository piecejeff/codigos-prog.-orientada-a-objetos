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
    //ESTAS SON NUESTRAS CLASES QUE SE NECESITAN PARA QUE EL CODIGO FUNCIONE
    //Armas punzocortantes.
    public Armas(string n, int d)
    {
        this.nombre = n;
        this.daño = d;
    }//esta parte del codigo solo sirve para armas punzocortantes

    //Armas de fuego.
    public Armas(string n, int d, int m)
    {
        this.nombre = n;
        this.daño = d;
        this.municion = m;
    }//esta parte del codigo sirve para armas de fuego pero solopara armaA
}
