using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class music_switcher : MonoBehaviour
{
    public AudioClip bossBGM;

    public Music_guy oldBGM; 
    // Start is called before the first frame update
    void Start()
    {
        oldBGM = FindObjectOfType<Music_guy>();

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "Boss")
        {
                //oldBGM.Stop();
                oldBGM.BGMchange(bossBGM);
        }
    }
}
