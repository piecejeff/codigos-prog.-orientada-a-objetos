using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemigoB : MonoBehaviour
{
    public List<Enemigo> enemigo;
    // Start is called before the first frame update
    void Awake()
    {
        enemigo.Add(new Enemigo(100, 50, "Bolita asesina"));
        enemigo.Add(new Enemigo(200, 500, "slime de marihuana"));
        enemigo.Add(new Enemigo(300, 50, "Muerto de hambre"));
    }
    // Update is called once per frame
    void Update()
    {

    }
}
