using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class telaVida : MonoBehaviour {

    public Main pacMan;
    public Text pontoVida;
	
	// Update is called once per frame
	void Update () {

        pontoVida.text = Main.vidaAtual.ToString("0");

	}
}
