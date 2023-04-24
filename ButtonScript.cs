using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonScript : MonoBehaviour
{

    public bool ButtonSignal = false;

  void OnCollisionEnter2D(Collision2D collision)
    {
     if (collision.gameObject.tag == "Player")
     {
       ButtonSignal = true;
     }
   }

}
