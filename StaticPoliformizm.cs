using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using UnityEngine;

public class StaticPoliformizm : MonoBehaviour
{

    public void Press()
    {
        Math calculate = new Math();

        if (Input.GetKeyDown(KeyCode.P))
        {
            Debug.Log("Pressed");
            calculate.Addition(25, 35, 45, 65);
        }
    }
    public void Update()
    {
        Press();

    }
    #region Static Poliformizm
    public class Math
    {
        public long Addition(int n1, int n2)
        => n1 + n2;
        public long Addition(int n1, int n2, int n3)
       => n1 + n2 + n3;
        public long Addition(int n1, int n2, int n3, int n4)
       => n1 + n2 + n3 + n4;
    }

    #endregion
}
