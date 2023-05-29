using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inimigos : MonoBehaviour
{
    public GameObject oTiroDoInimigo;
    public Transform oLocalDOTiro;
    public GameObject itensD;
    public float velocidadeI;
    public int vidamaxI;
    public int vidaatualI;
    public int pontosI;
    public int porcentagemdrop;
    public float tempomax;
    public float tempoatual;
    public bool inimigoqueatira;

    void Start()
    {
        vidaatualI = vidamaxI;
    }

    void Update()
    {
        MovimentoI();
        if(inimigoqueatira == true)
        {
            TirosDosI();
        }
    }
    private void MovimentoI()
    {
        transform.Translate(Vector3.up * velocidadeI * Time.deltaTime);
    }
    private void TirosDosI()
    {
        tempoatual -= Time.deltaTime;
        if(tempoatual <= 0)
        {
            Instantiate(oTiroDoInimigo, oLocalDOTiro.position, Quaternion.Euler(0f, 0f, 0f));
            tempoatual = tempomax;
        }
    }
    public void DanoInimigo(int DanoParaTomar)
    {
        vidaatualI -= DanoParaTomar;
        if(vidaatualI <= 0)
        {
            GameManager.instance.BotarPontos(pontosI);
            int numaleatorio = Random.Range(0,100);
            if(numaleatorio <= porcentagemdrop)
            {
                Instantiate(itensD, transform.position, Quaternion.Euler(0f, 0f, 0f));
            }
            Destroy(this.gameObject);
        } 
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.CompareTag("Pedra"))
        {
            Destroy(this.gameObject);
        }
    }
}
