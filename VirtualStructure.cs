using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.U2D;
using UnityEngine.UIElements;


public class VirtualStructure : MonoBehaviour
{

    private void Update()
    {

        // MineClass m = new();
        // Debug.Log(m.MineProperty);
        // m.MineMethod();
        // MineClass2 m2 = new();
        // m2.MineMethod();
        // Debug.Log(m2.MineProperty);
        Animals a = new();
        a.Quality();
        // a.Quality();
        Monkey m = new();
        m.Quality();
        Eagle e = new();
        e.Quality();

        // Triangle t = new(10, 4);
        // Debug.Log(t.CalculateArea());
        // Square s = new(4, 4);
        // Debug.Log(s.CalculateArea() + " " + "Square value");
        // Triangle t=new(4,8);
        // Debug.Log(t.CalculateArea()+" "+ "Triangle Value");
    }
    #region //Example 1
    class MyClass
    {
        //Normal Method
        public void MyMethod()
        {

        }
        //Normal Property
        public int MyProperty { get; set; }

    }


    public class MineClass
    {

        //Virtual Method
        virtual public void MineMethod()
        {
            // int gonnaChange = 25;
            // Debug.Log("This method is anyone's");
            // Debug.Log(gonnaChange + " " + "gonnachange");

        }

        //Virtual Property 
        virtual public int MineProperty { get; set; } = 10;

    }

    public class MineClass2 : MineClass
    {

        public override void MineMethod()
        {
            // int gonnaChange = 45;
            // Debug.Log(gonnaChange + " " + "changed");
            // Debug.Log("This method is mine");

        }


        public override int MineProperty { get; set; } = 25;
    }
    #endregion
    #region  Second Example
    public class Animals
    {

        virtual public bool canSwim { get; set; }
        virtual public bool canFly { get; set; }
        virtual public void Quality()
        {

            if (Input.GetKey(KeyCode.B))
            {
                canSwim = true;
                canFly = true;

                if (canSwim == true && canFly == true)
                {
                    Debug.Log("seagull");
                }


            }
            else if (Input.GetKey(KeyCode.B) == false)
            {
                Debug.Log("its not seagull");
            }

        }
    }
    class Monkey : Animals
    {
        override public void Quality()
        {

            if (Input.GetKey(KeyCode.A))
            {
                canSwim = false;
                canFly = false;

                if (canSwim == false && canFly == false)
                {
                    Debug.Log("monkey");
                }


            }
            else if (Input.GetKey(KeyCode.A) == false)
            {


                if (canSwim != false && canFly != false)
                {
                    Debug.Log("it is not monkey");
                }
            }
        }

    }
    class Eagle : Animals
    {

        override public void Quality()
        {

            if (Input.GetKey(KeyCode.C))
            {
                canSwim = false;
                canFly = true;

                if (canSwim == false && canFly == true)
                {
                    Debug.Log("EAGLE");
                }


            }
            else if (Input.GetKey(KeyCode.C) != true)
            {
                canSwim = false;
                canFly = false;

                if (canSwim == false && canFly == false)
                {
                    Debug.Log("it is not eagle");
                }
            }
        }
    }

    #endregion


    #region Third Example
    class Shape
    {
        public int _length;
        public int _width;
        // constructor
        public Shape(int length, int width)
        {

            _length = length;
            _width = width;
        }
        //Method
        virtual public int CalculateArea()
        {
            return 0;
        }

    }

    class Triangle : Shape
    {
        public Triangle(int length, int width) : base(length, width)
        {
          
        }
        public override int CalculateArea()
        {
            return (_length * _width) / 2;
        }
    }
    class Square : Shape
    {
        public Square(int length, int width) : base(length, width)
        {

        }
        public override int CalculateArea()
        {

            return (_length * _width);
        }
    }
    class Rectangle : Shape
    {
        public Rectangle(int length, int width) : base(length, width)
        {

        }
    }
    #endregion
}