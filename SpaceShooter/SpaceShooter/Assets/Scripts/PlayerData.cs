using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerData : MonoBehaviour
{
    public int health;
    public int startingHealth = 100;
    public int lives = 5;
    public int Ammo = 25;
    public static int enemyDead = 0;
    public int enemyCount = 0;
   
    


    // Start is called before the first frame update
    void Start()
    {
        health = startingHealth;
    }

    private void Update()
    {
        enemyCount = enemyDead;
    }


    // Update is called once per frame
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Asteroid")
        {
            EnemyData enemyData = collision.gameObject.GetComponent<EnemyData>();
            health = health - enemyData.damage;
            Destroy(collision.gameObject);
            
        }
        else if(collision.gameObject.tag == "Ammo")
        {
            PickupController pickup = collision.gameObject.GetComponent<PickupController>();

            Ammo += pickup.amount;
            Destroy(collision.gameObject);
        }
        else if(collision.gameObject.tag == "Health")
        {
            PickupController pickup = collision.gameObject.GetComponent<PickupController>();
            health += pickup.amount;
            Destroy(collision.gameObject);
        }
        if(health <= 0)
        {
            lives--;
            health = startingHealth;

        }
        if(lives <= 0)
        {
            SceneManager.LoadScene("SampleScene");
        }
        if(health > 100)
        {
            health = 10;
            lives += 1;
        }
        
    }
}
