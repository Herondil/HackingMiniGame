using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collisionManager : MonoBehaviour
{
    private int EnnemyHp;

    private void Start()
    {
        Debug.Log(gameObject.name);

        
    }

    private void OnCollisionEnter(Collision collision)
    {
        //Avec quoi on vient de collisioner en fait ?

        Debug.Log("Il y a eu une collision avec "+collision.gameObject.name);
        Destroy(collision.gameObject);  
    }
}
