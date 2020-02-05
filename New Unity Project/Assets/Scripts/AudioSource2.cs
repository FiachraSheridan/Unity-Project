using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioSource2 : MonoBehaviour
{
    // Start is called before the first frame update
    AudioSource AudioSource;
    // Start is called before the first frame update
    void Start()
    {
        AudioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.P) && !AudioSource.isPlaying)
        {
            AudioSource.Play();
        }
        else if (Input.GetKey(KeyCode.P) && AudioSource.isPlaying)
        {
            AudioSource.Pause();
        }
        else if (Input.GetKey(KeyCode.S))
        {
            AudioSource.Pause();
        }
    }
}
