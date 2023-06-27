using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField]
    public float veloc ;
    [SerializeField]
    public float entradaHorizontal;
    [SerializeField]
    public GameObject pfLaser;

    public float tempoDeDisparo = 0.3f;

    public float podeDisparar = 0.0f;

    // Start is called before the first frame update
    void Start()
    {
        veloc = 3.0f ;
        transform.position = new Vector3(0,0,0); 
    }

    // Update is called once per frame
    void Update()
    {
       this.Movimento();
       if ( Input.GetKeyDown(KeyCode.Space) || Input.GetMouseButtonDown(0)){
            Disparo();
          }

    }

    
    void Movimento(){
      float entradaHorizontal = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * entradaHorizontal * Time.deltaTime*veloc);
      if ( transform.position.y > -0.99f){
          transform.position = new Vector3(transform.position.x,-0.99f,0);
      } else if ( transform.position.y < -2.76f){
          transform.position = new Vector3(transform.position.x,-2.76f,0);
      }
        float entradaVertical = Input.GetAxis("Vertical");
        transform.Translate(Vector3.up * entradaVertical * Time.deltaTime*veloc);
      if ( transform.position.x < -8.26f){
          transform.position = new Vector3( -8.26f,transform.position.y,0);    
      } else if ( transform.position.x > 5.85f ){
         transform.position = new Vector3( 5.85f,transform.position.y,0.0f);
      }     
    }

    void Disparo(){
       if ( Time.time > podeDisparar ){
            Instantiate(pfLaser,transform.position + new Vector3(0,1.1f,0),Quaternion.identity);
            podeDisparar = Time.time + tempoDeDisparo ;
            }
    }
}