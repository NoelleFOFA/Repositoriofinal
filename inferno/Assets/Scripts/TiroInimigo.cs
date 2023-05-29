using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TiroInimigo : MonoBehaviour
{
    public float itVelocidade;
    public int danoparadar;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        MovimentarTiroI();   
    }
    private void MovimentarTiroI()
    {
        transform.Translate(Vector3.left * itVelocidade * Time.deltaTime);
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.CompareTag("Player"))
        {
            other.gameObject.GetComponent<VidaPlayer>().DanoPlayer(danoparadar);
            Destroy(this.gameObject);
        }
        if(other.gameObject.CompareTag("Pedra"))
        {
            Destroy(this.gameObject);
        }
    }
}
