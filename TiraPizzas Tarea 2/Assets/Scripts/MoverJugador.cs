using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoverJugador : MonoBehaviour
{
    // Start is called before the first frame update
    public float desplazamientoHorizontal;
    public GameObject ProyectilPrefab;
    public GameObject ProyectilPrefab2;
    public float velocidad = 10f;
    
    void Start()
    {
        Debug.Log("estas comenzado el juego");
    }

    // Update is called once per frame
    void Update()
    {
        //GetKeyDown al pulsar la tecla con Keycode
        //decimos que teclas usamos
        if(Input.GetKeyDown(KeyCode.Space)){
            //realizamos instancias del prefab
            //transform position para acceder a la misma
            //posicion del jugador. con proyectilprefb.transfor.rotation le decimos que no queremos ninguna rotacion
            Instantiate(ProyectilPrefab, transform.position,
                ProyectilPrefab.transform.rotation);
        }
        if(Input.GetKeyDown(KeyCode.Return)){
            //realizamos instancias del prefab
            //transform position para acceder a la misma
            //posicion del jugador. con proyectilprefb.transfor.rotation le decimos que no queremos ninguna rotacion
            Instantiate(ProyectilPrefab2, transform.position,
                ProyectilPrefab2.transform.rotation);
        }

        if(transform.position.x < -20){
            transform.position = new Vector3(-20,transform.position.y, transform.position.z);

        }
        if(transform.position.x > 20){
            transform.position = new Vector3(20, transform.position.y, transform.position.z);
        }

        desplazamientoHorizontal = Input.GetAxis("Horizontal");
        //Mueve Jugador Horizontalmente
        transform.Translate(Vector3.right * desplazamientoHorizontal * Time.deltaTime * velocidad);
    }
}
