﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class CountdownTimer : MonoBehaviour
{

    public float timer = 120f;
    private Text timerSeconds;
    // Start is called before the first frame update
    void Start()
    {
        timerSeconds = GetComponent<Text>();
    }





    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;
        timerSeconds.text = timer.ToString("f2");
        if (timer <= 0)
        {
            SceneManager.LoadScene("Scene_001");
        }

    }
}
