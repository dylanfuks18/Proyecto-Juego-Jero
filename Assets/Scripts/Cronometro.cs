using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Cronometro : MonoBehaviour
{
    public string leveltoload;
    private float timer = 25f;
    public Text timerSeconds;
    void Start()
    {
        
    }
    // Update is called once per frame
    void Update()
    {
        
            timer -= Time.deltaTime;
            timerSeconds.text =  timer.ToString("f2");
            if (timer <= 0)
        {
            //Application.LoadLevel(leveltoload);
            SceneManager.LoadScene("Perdiste!");
        }
    } 
}
