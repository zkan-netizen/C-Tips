using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;


public class ExplicityImplement : MonoBehaviour
{


}
class Explictyİmplement
{
    private void Start()
    {
        // additionCalculate.MyProperty();

    }
    class Calculate : IAddition, IMultiplication
    {
        public int MyProperty { get; set; }

        int IMultiplication.Asd()
        {
            throw new System.NotImplementedException();
        }
        int IAddition.Asd()
        {
            throw new System.NotImplementedException();
        }
    }
    interface IAddition
    {
        public int Asd();
        public int MyProperty { get; set; }
    }
    interface IMultiplication
    {
        public int Asd();
        public int MyProperty { get; set; }
    }


}
