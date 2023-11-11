using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chest : MonoBehaviour
{
      bool activated = false;
   private void OnCollisionEnter(Collision other)
   {
    if(other.gameObject.CompareTag("Player") && activated == false )
    {
        GetComponent<Animator>().Play("Activate");


    }


}
}