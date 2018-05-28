﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fantasmaMove : MonoBehaviour {

    public Transform[] waypoints;
    int cur = 0;

    public float speed = 0.3f;

    void FixedUpdate()
    {
        // Waypoint not reached yet? then move closer
        if (transform.position != waypoints[cur].position)
        {
            Vector2 p = Vector2.MoveTowards(transform.position,
                                            waypoints[cur].position,
                                            speed);
            GetComponent<Rigidbody2D>().MovePosition(p);
        }
        // Waypoint reached, select next one
            else
            {
                cur = (cur + 1) % waypoints.Length;
            }
    }
    void OnTriggerEnter2D(Collider2D ft)
    {
        if (ft.gameObject.tag == "Player" && Main.capPilula == 1)
        {
                Main.ponto = Main.ponto + 100;
                Destroy(gameObject);
        }
    }

}