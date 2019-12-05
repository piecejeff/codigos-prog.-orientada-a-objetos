using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// Codigo armas
// DESARROLLADOR: Juan Pablo Tadeo Nava Marquez
//Asignatura:Programacion Orientada  objetos
//profesor josue rivadia
//codigo que muestra algunas especificaciones de las armas en este caso arma principal que tendra el personaje 
// se muestra todo lo que tendra y sus especificaciones
[System.Serializable]
public class Armas 
{
    public string nombre;
    public int daño;
    public int municion;
    public int ExtraPorExplosion;

    public Armas(string n, int d)
    {
        this.nombre = n;
        this.daño = d;
    }
    
    public Armas(string n, int daño, int m)
    {
        this.nombre = n;
        this.daño = daño;
        this.municion = m;
    }
}

