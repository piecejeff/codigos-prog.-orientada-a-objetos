using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class diamante : MonoBehaviour
{
    public float puntos;

    //public float cubos

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Player")
        {
            //el debug .log sirve para que nos muestre
            //un comentario en la consola
            Debug.Log("Colision hecha");

        }
    }
}
