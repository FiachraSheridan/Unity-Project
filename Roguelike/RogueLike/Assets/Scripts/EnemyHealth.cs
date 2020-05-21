using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    public int Health = 20;
    public int damageMax = 5, damageMin = 2;
    public GameObject PowerUp;
    
    private void OnCollisionEnter2D(Collision2D collision)
    {
        
        

        if (collision.gameObject.tag == "Arrow")
        {
            Health -= Random.Range(2, 5);
        }
    }

    void Update()
    {
        if(Health <= 0)
        {
            Destroy(gameObject);
        }
    }
}
