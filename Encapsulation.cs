using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Encapsulation : MonoBehaviour
{
    private void Start()
    {

        EncapsulationWithMethod method = new();
        method.ASet(15);
        Debug.Log(method.AGet());
        Debug.Log(method.MyProperty);
    }


    #region  //Encapsulation with method
    //This method types are using by developers but less than other method types.
    class EncapsulationWithMethod
    {

        int a;
        public int AGet()
        {

            return this.a / 2;

        }
        public void ASet(int value)
        {
            value = 20;
            this.a = value;
        }
        #endregion
        //---------------------------------
        #region Encapsulation with property
        private int myVar;
        public int MyProperty
        {
            get
            {
                
                return myVar+2;

            }
            set
            {
                myVar = value;
            }
        }


    }
    #endregion





}

