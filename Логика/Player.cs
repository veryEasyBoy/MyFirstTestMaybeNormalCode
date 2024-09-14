using System.Collections;
using System.Collections.Generic;
using UnityEngine;

internal class Player : MonoBehaviour
{
   
   protected Rigidbody rb;
   
  
   protected void InitPlayer()
    {
       rb = GetComponent<Rigidbody>(); 
    }

}
internal interface IMove
{
    //float moveX;
}




