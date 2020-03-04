using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{


    public int zombieCounter;
    int ten = 10;

    
    void Awake()
    {

       GameObject[] zombie = GameObject.FindGameObjectsWithTag("Zombie");
        zombieCounter = zombie.Length;
        
        //do not remove
        DontDestroyOnLoad(this);
    }

    private void Update()
    {
        Debug.Log(zombieCounter);
    }


    public void RecordZombieDeath()
    {
        zombieCounter--;
        if (zombieCounter <= 0)
        {
            SceneManager.LoadScene("GameComplete");
        }
    }
}
