using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss : MonoBehaviour
{
    public int vida;
    public Transform lDD1;
    public Transform lDD2;
    public Transform lDD3;
    public Transform lDD4;
    public Transform lDD5;
    public Transform lDD6;
    public Transform lDD7;
    public Transform lDD8;
    public Transform lDSD;
    public GameObject tiroBoss;
    public GameObject megaL;
    public float tAB;
    public float tMB;
    public float tML;
    public float tMML;
    public Transform barravidaB;
    public GameObject barravidaBL;
    private Vector3 barrascale;
    private float percentualvida;
    void Start()
    {
        barrascale = barravidaB.localScale;
        percentualvida = barrascale.x / vida;
    }

    void UpdateHealthbar()
    {
        barrascale.x = percentualvida * vida;
        barravidaB.localScale = barrascale;
    }

    void Update()
    {
        TirosBoss();
        MegaLaser();
    }
    private void TirosBoss()
    {
        tAB -= Time.deltaTime;
        if(tAB <= 0)
        {
            Instantiate(tiroBoss, lDD1.position, lDD1.rotation);
            Instantiate(tiroBoss, lDD2.position, lDD2.rotation);
            Instantiate(tiroBoss, lDD3.position, lDD3.rotation);
            Instantiate(tiroBoss, lDD4.position, lDD4.rotation);
            Instantiate(tiroBoss, lDD5.position, lDD5.rotation);
            Instantiate(tiroBoss, lDD6.position, lDD6.rotation);
            Instantiate(tiroBoss, lDD7.position, lDD7.rotation);
            Instantiate(tiroBoss, lDD8.position, lDD8.rotation);
            tAB = tMB;
        }
    }
    private void MegaLaser()
    {
        tML -= Time.deltaTime;
        if(tML <= 0)
        {
            Instantiate(megaL, lDSD.position, lDSD.rotation);
            tML = tMML;
        }
    }
    public void TomarDano(int danoptomar)
    {
        vida -= danoptomar;
        UpdateHealthbar();
        if(vida <= 0)
        {
            Destroy(this.gameObject);
        }
    }
    
}
