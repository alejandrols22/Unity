using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Generador : MonoBehaviour
{
    public GameObject[] animalesPrefab;

    public float xposicion1 = 20f;
    public float xposicion2 = 20f;
    
    public float inicioGeneracion = 2.0f;
    public float retardoGeneracion = 1.5f;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("GenerarAleatorio", inicioGeneracion, retardoGeneracion);
    }

    void GenerarAleatorio()
    {
        int a = Random.Range(0, animalesPrefab.Length);
        Vector3 PosicionGenerator = new Vector3(Random.Range(-xposicion1, xposicion2), 0, 20);
        Instantiate(animalesPrefab[a], PosicionGenerator, animalesPrefab[a].transform.rotation);


    }

    void AnimalesAleatorios(){
        if (Input.GetKeyDown(KeyCode.P)) {
            int a = Random.Range(0, animalesPrefab.Length);
            // creando una instancia de Vector3
            Vector3 PosicionGenerator = new Vector3(Random.Range(-xposicion1,xposicion2), 0, 20);

            Instantiate(animalesPrefab[a], PosicionGenerator, animalesPrefab[a].transform.rotation);
        
        }

}

}

    
   
    
   