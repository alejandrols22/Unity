using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrancarCoche : MonoBehaviour
{
     
    public float velocidad = 15.0f; 
     public float velocidadGiro = 25;
     public float controlHorizontal;

     public float controlAvance;
    


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        controlHorizontal = Input.GetAxis("Horizontal");
        controlAvance = Input.GetAxis("Vertical");
        transform.Translate(Vector3.forward * Time.deltaTime * velocidad * controlAvance);
        transform.Translate(Vector3.right * Time.deltaTime *
            velocidadGiro*controlHorizontal);

        transform.Rotate(Vector3.up, controlHorizontal * Time.deltaTime * velocidadGiro);
    }
}
