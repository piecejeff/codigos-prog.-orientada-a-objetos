using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// Codigo Enemigo
// DESARROLLADOR: Juan Pablo Tadeo Nava Marquez
//Asignatura:Programacion Orientada  objetos
//profesor josue rivadia
//en este se agregan propiedades que llevara el enemigo y son sus stats las cuales llevaran dentro del juego
// con opcion personalizable para el jugador
[System.Serializable]
public class Enemigo 
{
    public string nombre; 
    public int vida;
    public int magia;
    
    public Enemigo(int v, int m, string n)
    {
        this.nombre = n;
        this.vida = v;
        this.magia = m;

    }
    
    
}


