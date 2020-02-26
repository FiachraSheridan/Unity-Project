using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletController : MonoBehaviour
{
    public float speed = 10;
    public GameObject AmmoPickup, HealthPickup;
    

    
    Rigidbody2D body;
    
    // Start is called before the first frame update
    void Start()
    {
        //playerData = GetComponent<PlayerData>();
        body = GetComponent<Rigidbody2D>();
        body.velocity = new Vector2(0, 1 * speed);
    }

    // Update is called once per frame
    private void OnTriggerEnter2D(Collider2D collision)
    {
        int chance = Random.Range(1, 10);
        if(collision.gameObject.tag == "Kill")
        {

            Destroy(gameObject);
        }
        else if(collision.gameObject.tag == "Asteroid")
        {
            int rnd = Random.Range(1, 2);
            if (rnd == 3)
           {
                if (chance % 2 == 0)
                {
                    Instantiate(AmmoPickup).transform.position = transform.position;
                    //Destroy(collision.gameObject);


                }
                else
                {
                    Instantiate(HealthPickup).transform.position = transform.position;
                    //Destroy(collision.gameObject);

                }
                
            }
            PlayerData.enemyDead++;
            Destroy(collision.gameObject);
            Destroy(gameObject);

        }
        
        

        
    }
}
