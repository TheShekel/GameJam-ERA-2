using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Music_guy : MonoBehaviour
{
    public AudioClip BGM;
    private AudioSource audioSource;

    

    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        if (BGM != null )
        {
            audioSource.clip = BGM;
            audioSource.loop = false;
            audioSource.Play();
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void BGMchange(AudioClip music )
    {
        BGM = music;
        audioSource.clip = BGM;
    }
    
}
