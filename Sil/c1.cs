using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class c1 : MonoBehaviour
{
    protected virtual int c1deneme { get; set; }
    protected virtual float c1fireRate { get; set; }
    protected virtual Rigidbody2D c1rigid { get; set; }
    private void Update() {
        Debug.Log("its monobeh");
    }
}
