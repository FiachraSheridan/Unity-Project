using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupController : MonoBehaviour
{
    PlayerData playerData;
    public int amount = 10;
    Rigidbody2D body;
    public float speed = 5;
    private void Start()
    {
        playerData = GetComponent<PlayerData>();
        body = GetComponent<Rigidbody2D>();
        body.velocity = new Vector2(0, speed * -1);
    }
    // Start is called before the first frame update
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Health")
        {
            playerData.health += amount;
        }
        if (collision.gameObject.tag == "Ammo")
        {
            playerData.Ammo += amount;
        }
        if (collision.gameObject.tag == "Kill")
        {
            Destroy(gameObject);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
