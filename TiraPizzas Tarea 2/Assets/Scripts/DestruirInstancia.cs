using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestruirInstancia : MonoBehaviour
{
    // Start is called before the first frame update
    float limiteSuperior = 25;
    float limiteInferior = -10;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.z>limiteSuperior)
         {
            Destroy(gameObject);
            
         }
            else if(transform.position.z < limiteInferior)
            {
                Destroy(gameObject);
                Debug.Log("El juego ha terminado");
            }
    }
        
}
