﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Cronometro : MonoBehaviour
{
    public string leveltoload;
    private float timer = 10f;
    private Text timerSeconds;
    // Start is called before the first frame update
    void Start()
    
    {
        timerSeconds = GetComponent <Text>();
    }

    // Update is called once per frame
    void Update()
    {
    timer -= Time.deltaTime;
    timerSeconds.text = timer.ToString("f2");
    if (timer<= 0)
    {
            //Application.LoadLevel(leveltoload);
            SceneManager.LoadScene("Perdiste!");
    }
    }
}
