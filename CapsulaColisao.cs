using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CapsulaColisao : MonoBehaviour
{

    void OnTriggerEnter2D(Collider2D pc)
    {
        if (pc.name == "pacMan")
        {
            Main.ponto = Main.ponto + 1;
            Destroy(gameObject);
        }
    }
}