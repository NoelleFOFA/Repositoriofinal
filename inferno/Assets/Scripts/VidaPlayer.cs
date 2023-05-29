using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VidaPlayer : MonoBehaviour
{
    public Slider barradevidaplayer;
    public int vidamaxP;
    public int vidaatualP;


    void Start()
    {
        vidaatualP = vidamaxP;
        barradevidaplayer.maxValue = vidamaxP;
        barradevidaplayer.value = vidaatualP;
    }

    void Update()
    {
        
    }
    public void DanoPlayer(int danoParaReceber)
    {
        barradevidaplayer.value = vidaatualP;
        vidaatualP -= danoParaReceber;
        if(vidaatualP <= 0)
        {
            Debug.Log("Game Over");
        }
    }
     private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.CompareTag("Inimigos"))
        {
            barradevidaplayer.value = vidaatualP;
            vidaatualP -= 3;
            Destroy(collision.gameObject);
        }
    }
    public void GanharVida(int vidaRecuperar)
    {
        if(vidaatualP + vidaRecuperar <= vidamaxP)
        {
            vidaatualP += vidaRecuperar;
        }
        else
        {
            vidaatualP = vidamaxP;
        }
        barradevidaplayer.value = vidaatualP;
    }
}
