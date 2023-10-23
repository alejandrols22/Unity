using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectorColisiones : MonoBehaviour
{
   private void onTriggerEnter (Collider other)
   {
    Destroy (gameObject);
   }
}
