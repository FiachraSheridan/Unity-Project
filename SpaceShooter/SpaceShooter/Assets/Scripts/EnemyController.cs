using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{

    public float speed = 5;
    

    Rigidbody2D body;
    // Start is called before the first frame update
    void Start()
    {
        body = GetComponent<Rigidbody2D>();
        body.velocity = new Vector2(0, speed * -1);
    }

    // Update is called once per frame
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Kill")
        {

            

            Destroy(gameObject);
        }
        else if(collision.gameObject.tag == "Bullet")
        {
            PlayerData.enemyDead++;
        }
        else if(collision.gameObject.tag == "Player")
        {
            Destroy(gameObject);
        }
        
        
    }
}
