using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoofToggle : MonoBehaviour
{

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("Player") || collision.gameObject.CompareTag("Vehicle"))
        {
            gameObject.GetComponent<SpriteRenderer>().enabled = false;
        }
        
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if(!collision.gameObject.CompareTag("Player") || !collision.gameObject.CompareTag("Vehicle"))
        {
            gameObject.GetComponent<SpriteRenderer>().enabled = true;
        }
    }
}
