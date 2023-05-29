using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TiroPlayer : MonoBehaviour
{
    public float velocidadeDoTiro;
    public int danotiro;
    void Start()
    {
        
    }

    void Update()
    {
        MoverTiro();       
    }
    private void MoverTiro()
    {
        transform.Translate(Vector3.left * velocidadeDoTiro * Time.deltaTime);
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.CompareTag("Inimigos"))
        {
            other.gameObject.GetComponent<Inimigos>().DanoInimigo(danotiro);
            Destroy(this.gameObject);
        }
        if(other.gameObject.CompareTag("Pedra"))
        {
            Destroy(this.gameObject);
        }
        if(other.gameObject.CompareTag("Boss"))
        {
            other.gameObject.GetComponent<Boss>().TomarDano(danotiro);
            Destroy(this.gameObject);
        }
    }
}
