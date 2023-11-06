using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
public class Deconstruct : MonoBehaviour
{
    private void Start()
    {
        Car car = new Car
        {
            Brand = "Ferrari",
            Model = "FXX EVO",
            MaxSpeed = 400

        };
        var (x, y, z) = car;
        z = z / 5;
        car.MaxSpeed=200;
        Debug.Log(z); 
        
    }
    class Program
    {
        public static void Main(string[] args)
        {
            // Car car = new Car
            // {
            //     Brand = "Ferrari",
            //     Model = "FXX EVO",
            //     MaxSpeed = 400

            // };
            // var (x, y, z) = car;
            // x="Ferro";
        }

    }
    class Car
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public int MaxSpeed { get; set; }
        public void Deconstruct(out string brand, out string model, out int maxspeed)
        {
            brand = Brand;
            model = Model;
            maxspeed = MaxSpeed;
        }

    }
    // Car c1 = new Car()
    // {
    //     Brand = "Ferrari",
    //     Model = "Enzo",
    //     MaxSpeed = 310
    // };

}
