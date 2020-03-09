using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VehicleCollision : HealthComponent
{
    GameManager gameManager;
    public GameObject splatterPrefab, gameController;
 

    private void Start()
    {
        gameController = GameObject.FindGameObjectWithTag("GameController");
        gameManager = gameController.GetComponent<GameManager>();
        
        
    }

    
    private void OnCollisionEnter2D(Collision2D collision)
    {
        
        
            if (collision.gameObject.CompareTag("Zombie"))
            {

                Destroy(collision.gameObject);
                gameManager.RecordZombieDeath();
                Instantiate(splatterPrefab, transform.position, Quaternion.identity);


            }
        
        
    }

}
