using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponChoice : MonoBehaviour
{

    public GameObject Sling;
    public GameObject Wand;
    public Transform AttachPoint;

    public void OnTriggerStay2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "WandWorld")
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                Destroy(Sling);
                Destroy(collision.gameObject);

                Instantiate(Wand, AttachPoint);
                Wand.transform.position = new Vector3(0.038f, 0.03f, 0);
            }
                      
        }
    }


    
    
}
