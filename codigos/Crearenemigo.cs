using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// Codigo crear enemigo
// DESARROLLADOR: Juan Pablo Tadeo Nava Marquez
//Asignatura:Programacion Orientada  objetos
//profesor josue rivadia
// codigo que seria reciclable el cual sirve para crear mas enemigos en cuanto uno sea colisionado con
// un arma o objeto que lo dañe
public class Crearenemigo : MonoBehaviour
{
    public string Id;
    public string nombre;
    public int vida;
    public int magia;
    EnemigoB enemigoB;
    Barras b;

    // Start is called before the first frame update
    void Start()
    {
        enemigoB = FindObjectOfType<EnemigoB>();
        b = GetComponentInChildren<Barras>();
        b.vida = vida;
        BusquedaEnemigo(Id);
    }

    private void BusquedaEnemigo(string id)
    {
        for (int i = 0; i < enemigoB.enemigo.Count; i ++)
        {
            if (id==enemigoB.enemigo[i].nombre)
            {
                nombre = enemigoB.enemigo[i].nombre;
                vida = enemigoB.enemigo[i].vida;
                magia = enemigoB.enemigo[i].magia;
            }
        }
    }
}
