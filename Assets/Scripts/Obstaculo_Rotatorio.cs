using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstaculo_Rotatorio : MonoBehaviour
{
    GameObject mygameObject;
    int rotar = 2;
    Vector3 MyVector3;

    // Start is called before the first frame update
    void Start()
    {
       

    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(new Vector3(0, rotar, 0));
    }
}
