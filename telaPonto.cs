using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class telaPonto : MonoBehaviour {

    public Main pacMan;
    public Text pontoTela;
	
	// Update is called once per frame
	void Update () {

        pontoTela.text = Main.ponto.ToString("0");

	}
}
