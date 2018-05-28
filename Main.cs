using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Main : MonoBehaviour {

    public float mostra;

    public static int capPilula = 0;
    public static float cronometro = 0;
    public static float ponto = 0;
    public static int vidaAtual = 3;

    public float tempoCap = 5;
    

    void Update()
    {
        mostra = ponto;

        cronometro += Time.deltaTime;
        if (cronometro >= tempoCap)
        {
            capPilula = 0;
        }
    }
}
