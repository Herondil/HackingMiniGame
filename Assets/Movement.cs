using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Movement : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        //les inputs se font toujours les v�rifier dans update
        if (Input.GetButtonDown("Fire1"))
        {
            Debug.Log("Bouton appuy�");

            transform.Translate(Vector3.forward);
          
        }
    }
}
