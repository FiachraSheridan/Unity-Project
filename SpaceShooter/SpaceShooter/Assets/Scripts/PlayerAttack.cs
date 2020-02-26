using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttack : MonoBehaviour
{
    public GameObject bulletObject;
    PlayerData data;
    Vector3 Ship;
    // Start is called before the first frame update
    void Start()
    {
        data = GetComponent<PlayerData>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if(data.Ammo >= 1)
            {
                Ship = transform.position;
                Instantiate(bulletObject, Ship, Quaternion.identity);
                data.Ammo--;
            }
        }
    }
}
