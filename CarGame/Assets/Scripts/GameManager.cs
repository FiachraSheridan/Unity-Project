using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public Sprite selectedCar;
    // Start is called before the first frame update
    void Start()
    {
        DontDestroyOnLoad(this);   
    }


    public void QuitGame()
    {
        Application.Quit();
    }



    public void LoadScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }
    // Update is called once per frame
    
}
