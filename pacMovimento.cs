using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pacMovimento : MonoBehaviour
{

    public float velocidade = 1;
    

    void Update()
    {
        Movimentacao();        
    }

    void Movimentacao()
    {
        if (Input.GetAxisRaw("Horizontal") > 0)
        {
            transform.Translate(Vector2.right * velocidade * Time.deltaTime);
            transform.eulerAngles = new Vector2(0, 0);
        }
        if (Input.GetAxisRaw("Horizontal") < 0)
        {
            transform.Translate(Vector2.right * velocidade * Time.deltaTime);
            transform.eulerAngles = new Vector2(0, 180);
        }
        if (Input.GetAxisRaw("Vertical") < 0)
        {
            transform.Translate(Vector2.down * velocidade * Time.deltaTime);
        }
        if (Input.GetAxisRaw("Vertical") > 0)
        {
            transform.Translate(Vector2.up * velocidade * Time.deltaTime);
        }
    }

    void OnTriggerEnter2D(Collider2D pc)
    {
        if (pc.gameObject.tag == "ghost")
        {
            if (Main.capPilula == 1)
            {
                Main.ponto = +1;
            }
            else {
                Destroy(gameObject);
                Main.vidaAtual = Main.vidaAtual - 1;
            }
            
        }
    }
}