using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TitleBGM : MonoBehaviour
{
    [Header("背景音樂")]
    public AudioSource bgmSource;
    // public AudioClip audioClip;

    // Start is called before the first frame update
    void Start()
    {
        bgmSource = GetComponent<AudioSource>();
        bgmSource.loop = true;
        bgmSource.Play();
    }
}
