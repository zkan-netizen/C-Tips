using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
public class Record : MonoBehaviour
{
    private void Start()
    {
        MyClass m = new MyClass
        {
            MyProperty = 5
        };


    }
    #region Inıt-Only Property
    //We were using getter-only properties before c# 9.0 but we cant assign value after init.Now we can do it with init-only properties through c# 9.0.
    class MyClass
    {
        public int MyProperty { get; init; }
    }

    #endregion

    //-------------------------
    #region  Record
    record Car
    {
        public int Speed { get; init; }
        public string SpeedType { get; init; }
        public string GearType { get; init; }
        public GameObject Type { get; init; }

    }

    void Launch()
    {
        Car ToyotaGT86 = new Car
        {
            Speed = 200,
            SpeedType = "KMH",
            GearType = "Auto",

        };
        Car SubaruBRZ = ToyotaGT86 with { Speed = 220, };
      
        // Car SubaruBRZ = new();
        // Car ToyotaGT86 = new();
        // ToyotaGT86.Type.GetComponent<Renderer>().material.color = Color.blue;
        // Debug.Log(SubaruBRZ.Equals(ToyotaGT86));
    }
    #endregion
    private void Update()
    {
        Launch();
    }
}
