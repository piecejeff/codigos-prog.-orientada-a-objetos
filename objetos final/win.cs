using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class win : MonoBehaviour
{
    public int enemigo = 0;

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            Debug.Log("quiero una maruchan");
            SceneManager.LoadScene(1);

        }
    }
    /*void OnCollisionEnter(Collision collision)
    {
        
    }
    public void Update()
    {
        
    }*/
}
