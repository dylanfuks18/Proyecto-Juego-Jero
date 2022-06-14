using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Perdiste_btn : MonoBehaviour
{

    // Start is called before the first frame update
    void Update()
    {
        if (Input.GetKey(KeyCode.Y)) ;
        
    }
    
    // Update is called once per frame
    public void OnClick()
    {
        SceneManager.LoadScene("SampleScene");
    }
}
