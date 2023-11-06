using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Form1 : Singleton
{
    public Form1()
    {

    }
    private void Start()
    {
        Singleton Instance = Singleton.GetInstance();
    }
    void Deneme()
    {
        if (Input.GetKey(KeyCode.V))
        {
            Singleton.GetInstance();
        }
    }
    private void Update()
    {
        Deneme();
    }
}
