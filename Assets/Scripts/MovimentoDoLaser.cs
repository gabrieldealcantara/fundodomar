using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimentoDoLaser : MonoBehaviour
{
    public float veloc ;

    public float entradaHorizontal;
    
    public GameObject pfLaser;

    public float tempoDeDisparo = 0.3f;

    public float podeDisparar = 0.0f;

    public float velocLaser = 12.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.up * velocLaser * Time.deltaTime);

        if ( transform.position.y > 5.5f ){
         Destroy(this.gameObject);
        }
        
    }
}
