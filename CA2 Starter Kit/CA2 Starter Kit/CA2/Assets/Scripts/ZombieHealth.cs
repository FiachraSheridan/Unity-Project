using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieHealth : HealthComponent
{
    GameManager gameManager;
    public GameObject splatterPrefab, gameController;
    private void Start()
    {
        gameController = GameObject.FindGameObjectWithTag("GameController");
        gameManager =gameController.GetComponent<GameManager>();
    }

    public override void KillCharacter()
    {

        gameManager.RecordZombieDeath();
        Instantiate(splatterPrefab, transform.position, Quaternion.identity);
        base.KillCharacter();
        

        
    }

   
}
