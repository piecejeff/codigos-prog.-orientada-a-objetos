using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class persecusion : MonoBehaviour
{
    public Transform playerPosition;
    public float velocidadEnemigo;

    // Start is called before the first frame update
    void Start()
    {
        playerPosition=GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        Perseguir(playerPosition, this.gameObject.transform);
        
    }
    void Perseguir(Transform player, Transform enemigo)
    {
        Vector3 distancia = player.position - enemigo.position;


        transform.LookAt(distancia);
        transform.Translate(distancia.normalized * velocidadEnemigo * Time.deltaTime);
    }
}
