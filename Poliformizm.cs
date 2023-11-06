using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Poliformizm : MonoBehaviour
{

    #region Poliformizm (Çok Biçimlilik)
    void Manage()
    {

        Plane _airship = new Plane();
        Car _car = new Plane();
        Vehicle _vehicle = new Plane();

        _airship.Wheel = null;
        _airship.AirplaneWing = null;
        _airship.Engine = null;
        //-------------------------
        _car.Engine = null;
        _car.Wheel = null;
        _car.StopLight = null;
        //-------------------------
        _vehicle.Engine = null;
        _vehicle.Wheel = null;
    }
    public class Vehicle
    {
        public object Engine { get; set; }
        public object Wheel { get; set; }


    }
    class Car : Vehicle
    {
        public object StopLight { get; set; }
    }

    class Plane : Car
    {
        public object AirplaneWing { get; set; }
    }

    #endregion

    #region Example
    class A
    {
        public string X { get; set; }

    }
    class B : A
    {
        public string Y { get; set; }
    }
    class C : B
    {
        public string Z { get; set; }
    }
    class D : C { }
    #endregion
    private void Start()
    {
        // A a = new C();
        // C c = (C)a;
        //---------
        // C c = new C();
        // A a = c; // same with A a=(A)c; ------Implicit-------(Bilinçsiz Tür Dönüşümü)
        // B b = (B)a;
        // D d = (D)a; Run time error
        #region Cast Operator
        // // ------Explicit----------(Bilinçli Tür Dönüşümü)
        // // A a = new C(); 
        // // C c = (C)a; // It means give object in a from "A" object as a C object;
        //----
        // // Reverse Explicit
        // C c = new C();//boxing
        // A a = (A)c;//unboxing
        //----
        // object n = 123; //boxing
        // int i = (int)n; //unboxing
        //------
        // object w = "ASD"; //boxing
        // string s = (string)w;//unboxing
        // Debug.Log(n + "ve" + w);
        #endregion

        #region  As Operator
        A a = new C();
        // C c = a as C; // C c = (C)a; same with this cast operator
        #endregion
        #region is Operator
        if (a is D)
        {
            D d = (D)a;
            Debug.Log("D true");
        }
        else if (a is C)
        {
            C c = (C)a;
            Debug.Log("C true");
        }
        #endregion


    }
}
