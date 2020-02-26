using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{

    public GameObject objectToBeSpawned;
    BoxCollider2D spawnArea;
    float elapsedTime = 0;
    public float spawnTime = 2;
    Vector3 PickPos1;
    // Start is called before the first frame update
    void Start()
    {
        spawnArea = GetComponent<BoxCollider2D>();
    }

    // Update is called once per frame
    void Update()
    {
        elapsedTime += Time.deltaTime;
        if (elapsedTime > spawnTime)
        {
            
            SpawnObject();
            elapsedTime = 0;
        }
    }

    Vector3 PickPosition()
    {
        //bounds.min is the leftmost position of the box
        //bounds.max is the rightmost position of the box
        float x = Random.Range(spawnArea.bounds.min.x, spawnArea.bounds.max.x);
        float y = transform.position.y;

        return new Vector3(x, y, 0);
    }

    void SpawnObject()
    {
        PickPos1 = PickPosition();
        Instantiate(objectToBeSpawned, PickPos1, Quaternion.identity);
    }
}
