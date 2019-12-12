using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class crear_enem : agente
{
    public string Id;
    public string nombre;
    public int vida;
    public int magia;

    /* lugar de donde se van a sacar los datos*/
    EnemigoB enemigoB;

    // Start is called before the first frame update
    void Start()
    {
        enemigoB = FindObjectOfType<EnemigoB>();
        BusquedaEnemigo(Id);
    }

    private void BusquedaEnemigo(string id)
    {
        /*Identificar BusquedaEnemigo que no existia antes */
        for (int i = 0; i < enemigoB.enemigo.Count; i++)
        {/*si el id que esta dentro del parametro, busca el dato y que haga una igualdad
dentro del nombre, se regresan datos especificos*/
            if (id == enemigoB.enemigo[i].nombre)
            {
                /* algoritmo de busqueda dentro de i*/
                nombre = enemigoB.enemigo[i].nombre;
                vida = enemigoB.enemigo[i].vida;
                magia = enemigoB.enemigo[i].magia;
            }
        }
    }

    private void Update()
    {
        ConfigurarDestino(destino);
    }



}
