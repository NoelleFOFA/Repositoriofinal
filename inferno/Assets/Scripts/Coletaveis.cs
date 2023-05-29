using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coletaveis : MonoBehaviour
{
    public bool colvida;
    public bool coltiroD;
    public int vidapDar;
    public bool coltiroS;
    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.CompareTag("Player"))
        {
            if(colvida == true)
            {
                other.gameObject.GetComponent<VidaPlayer>().GanharVida(vidapDar);
            }
            if(coltiroD == true)
            {
                if(other.gameObject.GetComponent<MovimentoP>().verificadorDeTiroS == true)
                {
                    other.gameObject.GetComponent<MovimentoP>().verificadorDeTiroS = false;
                }
                other.gameObject.GetComponent<MovimentoP>().verificadorDeTiroD = false;
                other.gameObject.GetComponent<MovimentoP>().tAtualTiroD = other.gameObject.GetComponent<MovimentoP>().tMaxTiroD;
                other.gameObject.GetComponent<MovimentoP>().verificadorDeTiroD = true;
            }
            if(coltiroS == true)
            {
                if(other.gameObject.GetComponent<MovimentoP>().verificadorDeTiroD == true)
                {
                    other.gameObject.GetComponent<MovimentoP>().verificadorDeTiroD = false;
                }
                other.gameObject.GetComponent<MovimentoP>().verificadorDeTiroS = false;
                other.gameObject.GetComponent<MovimentoP>().tAtualTiroS = other.gameObject.GetComponent<MovimentoP>().tMaxTiroS;
                other.gameObject.GetComponent<MovimentoP>().verificadorDeTiroS = true;
            }
            Destroy(this.gameObject);
        }
    }
}
