using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeradorDeObjetos : MonoBehaviour
{
    public GameObject[] objetosPSpawn;
    public Transform[] pontosSpawn;
    public float tempomaxSpawn;
    public float tempoatualSpawn;
    void Start()
    {
        tempoatualSpawn = tempomaxSpawn;
    }

    void Update()
    {
        tempoatualSpawn -= Time.deltaTime;
        if(tempoatualSpawn <= 0)
        {
            SpawnarObjeto();
        }
    }
    private void SpawnarObjeto()
    {
        int randomobject = Random.Range(0, objetosPSpawn.Length);
        int pontoaleatorio = Random.Range(0, pontosSpawn.Length);

        Instantiate(objetosPSpawn[randomobject], pontosSpawn[pontoaleatorio].position, Quaternion.Euler(0f,  0f, 90f));
        tempoatualSpawn = tempomaxSpawn;
    }
}
