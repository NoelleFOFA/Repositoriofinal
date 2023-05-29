using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimentoP : MonoBehaviour
{
    public Rigidbody2D oRigidbody2D;
    public GameObject oTiroDoPlayerS;
    public GameObject oTiroDoPlayer;
    public Transform oLocalDoTiro1;
    public Transform oLocalDOTiro2;
    public Transform oLocalDOTiro3;
    public float tMaxTiroD;
    public float tAtualTiroD;
    public float tMaxTiroS;
    public float tAtualTiroS;

    public float velocidadeDaNave;
    public bool verificadorDeTiroD;
    public bool verificadorDeTiroS;

    private Vector2 teclasApertadas;
    void Start()
    {
        verificadorDeTiroD = false;
        tAtualTiroD = tMaxTiroD;
        verificadorDeTiroS = false;
        tAtualTiroS = tMaxTiroS;
    }

    void Update()
    {
        MovimentarJogador();
        LancarTiro();
        if(verificadorDeTiroD == true)
        {
            tAtualTiroD -= Time.deltaTime;
            if(tAtualTiroD <= 0)
            {
                RemoverTiroD();
            }
        }
        if(verificadorDeTiroS == true)
        {
            tAtualTiroS -= Time.deltaTime;
            if(tAtualTiroS <= 0)
            {
                RemoverTiroS();
            }
        }
    }
    private void MovimentarJogador()
    {
        teclasApertadas = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
        oRigidbody2D.velocity = teclasApertadas.normalized * velocidadeDaNave;
    }
    private void LancarTiro()
    {
        if(Input.GetButtonDown("Fire1"))
        {
            if(verificadorDeTiroD == false && verificadorDeTiroS == false)
            {
                Instantiate(oTiroDoPlayer, oLocalDoTiro1.position, oLocalDoTiro1.rotation);
            }
            if(verificadorDeTiroD == true)
            {
                Instantiate(oTiroDoPlayer, oLocalDOTiro2.position, oLocalDOTiro2.rotation);
                Instantiate(oTiroDoPlayer, oLocalDOTiro3.position, oLocalDOTiro3.rotation);
            }
            if(verificadorDeTiroS == true)
            {
                Instantiate(oTiroDoPlayerS, oLocalDoTiro1.position, oLocalDoTiro1.rotation);
            }
        }
    }
    private void RemoverTiroD()
    {
        verificadorDeTiroD = false;
        tAtualTiroD = tMaxTiroD;
    }
    private void RemoverTiroS()
    {
        verificadorDeTiroS = false;
        tAtualTiroS = tMaxTiroS;
    }
}
