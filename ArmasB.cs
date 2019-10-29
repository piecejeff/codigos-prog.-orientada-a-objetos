using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArmasB : MonoBehaviour
{
    public List<Armas> armasPunzocortantes;
    public List<Armas> armasDeFuego;

    // Start is called before the first frame update
    void Awake()
    {
        armasPunzocortantes.Add(new Armas("Cuchillo", 10));
        armasDeFuego.Add(new Armas("Magnum", 50, 6));
    }
    //ESTE CODIGO ES PARA ARMAS MAS DISCRETAS EN EL VIDEOJUEGO
    // Update is called once per frame
    void Update()
    {
        
    }
}
