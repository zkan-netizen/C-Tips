using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Singleton : MonoBehaviour
{
    private Singleton() { }
    private static Singleton Instance;
    public static Singleton GetInstance()
    {
        if (Instance == null)
        {
            Instance = new Singleton();
        }
        return Instance;
    }

}
