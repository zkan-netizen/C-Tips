using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class c2 : c1
{
   public bool deneme;
   private void Start()
   {
      c1deneme = 1;
      c1fireRate = 2;
      // c1rigid = GetComponent<Rigidbody2D>();
      Debug.Log(c1deneme);
   }
   private void Update()
   {
      for (int c1deneme = 1; c1deneme < 45; c1deneme++)
      {
         Debug.Log(c1deneme);
         if (deneme == false && c1deneme == 10)
         {
            return;
         }
      }

   }
}

