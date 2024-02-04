using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UITest : MonoBehaviour
{

    private TextMeshProUGUI r;
    private int i;

    // Start is called before the first frame update
    void Start()
    {
        //Changer le text du TMP du gameobject "Value"

        //Trouver la référence d'un GO via son nom
        GameObject TextMeshProGameObjectRef = GameObject.Find("Value");

        GameObject.FindGameObjectWithTag("Finish");

        r = TextMeshProGameObjectRef.GetComponent<TextMeshProUGUI>();

        i = 0;
    }

    private void Update()
    {
        r.text = i.ToString();
        //i++;
    }
}
