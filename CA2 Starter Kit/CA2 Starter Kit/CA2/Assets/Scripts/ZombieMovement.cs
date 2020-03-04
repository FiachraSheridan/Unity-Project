using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieMovement : MonoBehaviour
{

    GameObject player;

    public float movementSpeed = 100, trackingRange = 5;

    Rigidbody2D zombie;
    void Start()
    {
        NewMethod();
        zombie = GetComponent<Rigidbody2D>();
    }

    private void NewMethod()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }

    void Update()
    {
        if (player == null)
            NewMethod();

        transform.up = player.transform.position - transform.position;
        if (Vector3.Distance(transform.position, player.transform.position) <= trackingRange)
        {
            zombie.velocity = transform.up * movementSpeed * Time.deltaTime;
        }
    }
}
