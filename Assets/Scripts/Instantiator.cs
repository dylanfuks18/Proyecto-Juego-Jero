using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Instantiator : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject ObjectToClone, clone;
    int canti = 4;
    void Update()
    {
        int i = 0;
        if (Input.GetKeyDown(KeyCode.Y)) {
            Debug.Log("hola");
            while (i < canti)
            {
                Debug.Log("WHILE");
                clone = Instantiate(ObjectToClone);
                Destroy(clone, 3);
                i++;
            }
        }
    }
}

    
