using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyData : MonoBehaviour
{

    public int minDamage = 1;
    public int maxDamage = 25;
    public int damage;
    // Start is called before the first frame update
    void Start()
    {
        damage = Random.Range(minDamage, maxDamage);
    }

    // Update is called once per frame
    
}
