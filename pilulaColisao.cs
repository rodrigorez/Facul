using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pilulaColisao : MonoBehaviour {

    void OnTriggerEnter2D(Collider2D co)
    {
        if (co.name == "pacMan")
        {
            Destroy(gameObject);
            Main.capPilula = 1;
            Main.cronometro = 0;
        }
    }
}
