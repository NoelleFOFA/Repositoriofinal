using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    public int enemiesdefeated;
    public Text textopontuacaoA;
    void Awake()
    {
        instance = this;
    }
    void Start()
    {
        enemiesdefeated = 0;
        textopontuacaoA.text = "PONTUAÇÂO: " + enemiesdefeated;
    }

    void Update()
    {
        
    }
    public void BotarPontos(int pontos)
    {
        enemiesdefeated += pontos;
        textopontuacaoA.text = "PONTUAÇÃO: " + enemiesdefeated;
    }
}
