using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackGround : MonoBehaviour
{
    // Variavel para controlar a velocidade de objeto BF
    public float velocidade = 1.0f;
    // Variavel para controle do ponto de reposição
    public float reposicao = 18 ;
    // Variavel para quardar a posição inicial do objeto
    public Vector3 posicaoInicial;

    // Start is called before the first frame update
    void Start()
    {
        posicaoInicial = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        float novaPosicao = Mathf.Repeat(Time.time * velocidade,reposicao);
        transform.position = posicaoInicial + Vector3.left * novaPosicao;
    }
}
