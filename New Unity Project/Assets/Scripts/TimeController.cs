using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeController : MonoBehaviour
{
    public AudioSource AudioSource;
    public float elapsedTime, eventTime;
    // Start is called before the first frame update
    void Start()
    {
        AudioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        elapsedTime += Time.deltaTime;

        if(elapsedTime >= eventTime)
        {
            AudioSource.Play();
            elapsedTime = 0;
        }
    }
}
