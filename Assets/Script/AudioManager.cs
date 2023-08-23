using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    // Start is called before the first frame update

    public AudioSource bgmAudioSource;
    public GameObject sfxAudioSource;


    void Start()
    {
        PlayBGM();
    }

    // Update is called once per frame

    private void PlayBGM() 
    {
        bgmAudioSource.Play();
    }

    public void PlaySFX(Vector3 spawnPosition)
    {
        GameObject.Instantiate(sfxAudioSource, spawnPosition, Quaternion.identity);
    }

    void Update()
    {
        
    }
}
