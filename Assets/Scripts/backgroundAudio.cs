using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class backgroundAudio : MonoBehaviour
{
    public AudioSource backgroundStart;
    public AudioSource backgroundMusic;
    // Start is called before the first frame update
    void Start()
    {
        backgroundMusic.loop = true;
        StartCoroutine(playBackgroundAudio());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator playBackgroundAudio()
    {
        backgroundStart.Play();
        yield return new WaitForSeconds(backgroundStart.clip.length);
        backgroundMusic.Play();
    }
}
