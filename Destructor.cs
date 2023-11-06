using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
public class Destructor : MonoBehaviour
{
    public void Start()
    {
        new MyClass();
        GC.Collect();
        // Console.ReadLine();
    }
    class MyClass
    {
        public MyClass()
        {
            Debug.Log("Hey");
        }

        ~MyClass()
        {
            Debug.Log("Gone");
        }
    }
    class MyClass2
    {
        int numb;
        public MyClass2(int numb)
        {
            this.numb = numb;
            Debug.Log($"{numb}. nesne oluşturulmuştur.");

        }
        ~MyClass2()
        {
            Debug.Log($"{numb}. nesne imha ediliyor.");
        }
    }
    void Update()
    {
        // Countdown();
    }
    void Countdown()
    {
        int number = 100;
        while (number >= 1)
        {
            new MyClass2(number--);


        }
    }
}
namespace Lesson
{

}